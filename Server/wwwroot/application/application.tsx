/*
 * @preserve Copyright 2019-2021 Onno Invernizzi.
 * This source code is subject to terms and conditions.
 * See LICENSE.MD.
 */


import React, { useState } from "react";
import { Interfaces } from "../typing/interfaces";

export function Application(props: { context: Interfaces.ApplicationContext }): React.ReactElement {

    const [apiRespone, setApiResponse] = useState("No call done yet.");

    async function callApi() {
        const response = await props.context.server.callApi();
        setApiResponse(response);
    }

    return (
        <>
            <div>Hello world</div>
            <button onClick={callApi}>Click me for api call</button>
            <input readOnly={true} value={apiRespone}></input>
        </>
    );
}