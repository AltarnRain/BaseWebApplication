import React from "react";
import ReactDom from "react-dom";
import { Application } from "./application/application";
import { ApplicationContext } from "./application/Context/ApplicationContext";

export function launchApplication(): void {
   const rootElement = document.getElementById("root");

   const context = new ApplicationContext();

   ReactDom.render(<Application context={context} />, rootElement);
}