import { Heading, Input, Button } from "@chakra-ui/react";
import { useRef } from "react";
import { useNavigate } from "react-router-dom";

export const Login = () => {
  const userEmail = useRef();
  const userPassword = useRef();

  const navigate = useNavigate();

  const HandleLogin = () => {
    const email = userEmail.current.value;
    const password = userPassword.current.value;

    //TODO: handle user login. Take values and validate against DB.
    //TODO: return token if valid

    const token = email + password;
    sessionStorage.setItem('token', token);
    navigate('/');
  };

  return (
    <div>
      <Heading mb={10} textAlign={"center"}>
        Login
      </Heading>
      <Input ref={userEmail} mb={10} type="email" placeholder="enter email" />
      <Input
        ref={userPassword}
        mb={10}
        type="password"
        placeholder="enter password"
      />
      <Button onClick={HandleLogin}>Login</Button>
    </div>
  );
};
