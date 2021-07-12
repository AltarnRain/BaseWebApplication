/*
 * @preserve Copyright 2019-2021 Onno Invernizzi.
 * This source code is subject to terms and conditions.
 * See LICENSE.MD.
 */


import React, { ChangeEvent, useState } from "react";
import { ApiService } from "../generated/index";

export function Application(): React.ReactElement {

    const [apiRespone, setApiResponse] = useState("No call done yet.");
    const [name, setName] = useState("");

    function onInputChange(e: ChangeEvent<HTMLInputElement>) {
        setName(e.target.value);
    }

    async function sayHello(): Promise<void> {
        const response = await ApiService.sayHello(name);

        if (response.value != null && response.value !== undefined) {
            setApiResponse(response.value);
        }
    }

    async function sayGoodbye(): Promise<void> {
        const response = await ApiService.sayGoodbye(name);

        if (response.value != null && response.value !== undefined) {
            setApiResponse(response.value);
        }
    }

    return (
        <>
            <div>Say hello</div>
            <p>Enter your name</p>
            <input  type="text" placeholder={"Enter your name here"}  value={name} onChange={onInputChange} ></input><br/>
            <button onClick={sayHello}>Say hello</button><br/>
            <button onClick={sayGoodbye}>Say good bye</button><br/>
            <input readOnly={true} value={apiRespone}></input>
        </>
    );
}