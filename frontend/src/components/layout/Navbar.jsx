import { HStack,  Button } from "@chakra-ui/react";
import { useNavigate,Link } from "react-router-dom";

const routes = [
  {
    path: "",
    display: "Home",
  },
  {
    path: "projects",
    display: "Projects",
  },
  {
    path: "register",
    display: "Register",
  },
  {
    path: "login",
    display: "Login",
  },
  {
    path: "store",
    display: "Store",
  }
];

export const Navbar = () => {
  const navigate = useNavigate();
  const HandlerLogout = () => {
    sessionStorage.removeItem("token");
    navigate("/login");
  };

  return (
    <div>
      <HStack>
        {routes.map((route) => (
          <Link to={route.path} key={route.display}>
            {route.display}
          </Link>
        ))}
        <Button onClick={HandlerLogout}>Logout</Button>
      </HStack>
    </div>
  );
};
