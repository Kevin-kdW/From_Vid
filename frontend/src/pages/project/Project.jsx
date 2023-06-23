import { useLoaderData } from "react-router-dom";
import {
  Heading,
  Text,
  VStack,
  Card,
  CardHeader,
  CardFooter,
} from "@chakra-ui/react";

export const Project = () => {
  const project = useLoaderData();

  return (
    <div>
      <Heading textAlign={"center"}>{project.title}</Heading>
      <Text textAlign={"center"}>{project.description}</Text>
      <VStack>
        {project.todos.map((todo) => {
          let color = "red";
          if (todo.status === 1) color = "green";
          if (todo.status === 2) color = "orange";
          return (
            <Card key={todo.id} bgColor={color}>
              <CardHeader>{todo.title}</CardHeader>
              <CardFooter>{todo.description}</CardFooter>
            </Card>
          );
        })}
      </VStack>
    </div>
  );
};
