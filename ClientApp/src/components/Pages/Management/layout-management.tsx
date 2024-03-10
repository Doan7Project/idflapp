import React from "react";
import { Container } from "reactstrap";
import { NavbarManagement } from "./Navbar/navbar-management";
interface LayoutManagementProps {
  children?: React.ReactNode;
}
export const LayoutManagement: React.FC<LayoutManagementProps> = (props) => {
  return (
    <div className="flex">
      <NavbarManagement />
      <div className="border overflow-x-auto w-full">
        {props.children !== undefined && props.children}
      </div>
    </div>
  );
};
