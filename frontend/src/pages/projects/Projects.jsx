import { CardHeader, Heading, VStack, Card, CardBody } from "@chakra-ui/react";
import { useLoaderData, useNavigate } from "react-router-dom";

export const Projects = () => {
  const projects = useLoaderData();
  const navigate = useNavigate();

  const HandleSelectProject = projectId => {
    navigate(`/projects/${projectId}`)
  };

  return (
    <div>
      <Heading textAlign={"center"}>Projects</Heading>
      <VStack>
        {projects.map((project) => (
          <Card
            key={project.id}
            onClick={() => HandleSelectProject(project.id)}
            _hover={{cursor: 'pointer'}}
          >
            <CardHeader>{project.title}</CardHeader>
            <CardBody>{project.description}</CardBody>
          </Card>
        ))}
      </VStack>
    </div>
  );
};
