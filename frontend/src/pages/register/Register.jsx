import { Heading, Input, Button, Text } from "@chakra-ui/react";
import { useRef, useState } from "react";
import { useNavigate } from "react-router-dom";

export const Register = () => {
  const userName = useRef();
  const userPassword = useRef();

  const [errorMessage, setErrorMessage] = useState('');

  const navigate = useNavigate();

  const HandleLogin = () => {
    const username = userName.current.value;
    const password = userPassword.current.value;

    const request = {
      username: username,
      password: password,
    };

    fetch(`${import.meta.env.VITE_APP_BACKEND_URL}/auth/register`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(request),
    })
      .then((response) => {
        console.log(response)
        if (response.ok) return response.json();
      })
      .then((body) => {
        console.log(body);
        if (body.errorMessage) 
        {
          console.log(body);
          setErrorMessage(body.errorMessage)
          return;
        } 
          navigate("/login");
      });
  };

  return (
    <div>
      <Heading mb={10} textAlign={"center"}>
        Register
      </Heading>
      <Text color={'red'}>{errorMessage}</Text>
      <Input ref={userName} mb={10} type="email" placeholder="enter email" />
      <Input
        ref={userPassword}
        mb={10}
        type="password"
        placeholder="enter password"
      />
      <Button onClick={HandleLogin}>Register</Button>
    </div>
  );
};
