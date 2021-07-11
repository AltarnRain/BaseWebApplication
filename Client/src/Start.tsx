import React from "react";
import ReactDom from "react-dom";
import { App } from "./App/App";

export function start(): void {
   const rootElement = document.getElementById("root");

   ReactDom.render(<App/>, rootElement);
}