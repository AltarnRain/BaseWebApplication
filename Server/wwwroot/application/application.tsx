import React, { useState } from "react";
import { IApplicationContext } from "../Types/Interfaces/IApplicationContext";

export function Application(props: { context: IApplicationContext }): React.ReactElement {

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
    )
}