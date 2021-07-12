/*
 * @preserve Copyright 2019-2021 Onno Invernizzi.
 * This source code is subject to terms and conditions.
 * See LICENSE.MD.
 */
import React from "react";
import ReactDom from "react-dom";
import { Application } from "../application/application";

export function launchApplication(): void {
   const rootElement = document.getElementById("root");

   ReactDom.render(<Application/>, rootElement);
}