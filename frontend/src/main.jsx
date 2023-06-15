import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import { createBrowserRouter, RouterProvider, Outlet } from 'react-router-dom';
import Layout from "./components/layout/Layout";
import {ChakraProvider} from '@chakra-ui/react';
import { AuthLoader } from "./components/layout/AuthLoader";
import Home from './pages/home/Home';
import {Projects} from './pages/projects/Projects';
import { Register } from "./pages/register/Register";
import { Login } from "./pages/login/Login";
import { Project } from "./pages/project/Project";
import { ProjectsLoader } from "./pages/projects/ProjectsLoader";

const authenticatedRoutes = [
  {
    path:'',
    element: <Home />
  },
  {
    path: 'projects',
    element: <Projects />,
    loader: ProjectsLoader,
  },
  {
    path: 'projects/:projectId',
    element: <Project />
  }
]

const router = createBrowserRouter([
  {
    path: '',
    element: <Layout />,
    children: [
      {
        path: '',
        element:<Outlet />,
        loader: AuthLoader,
        children: authenticatedRoutes,
      },
      {
        path: 'login',
        element: <Login />
      },
      {
        path: 'register',
        element: <Register />
      }
    ],
  },
]);

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <ChakraProvider>
      <RouterProvider router={router} />
    </ChakraProvider>
  </React.StrictMode>
);
