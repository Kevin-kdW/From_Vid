import { Heading, Input, Button } from "@chakra-ui/react";
import { useRef } from "react";
import { useNavigate } from "react-router-dom";

export const Register = () => {
  const userEmail = useRef();
  const userPassword = useRef();

  const navigate = useNavigate();

  const HandleLogin = () => {
    const email = userEmail.current.value;
    const password = userPassword.current.value;

    //TODO: handle user registration. Insert into db if valid

    console.log(`Created new user with email '${email}' and password '${password}'`)
    navigate('/login');
  };

  return (
    <div>
      <Heading mb={10} textAlign={"center"}>
        Register
      </Heading>
      <Input ref={userEmail} mb={10} type="email" placeholder="enter email" />
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
