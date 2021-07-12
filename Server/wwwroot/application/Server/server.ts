/*
 * @preserve Copyright 2019-2021 Onno Invernizzi.
 * This source code is subject to terms and conditions.
 * See LICENSE.MD.
 */

import { Interfaces } from "../../typing/interfaces";
import { Types } from "../../typing/types";

/**
 * This class abstracts all calls to the backend.
 */
export class Server implements Interfaces.Server {

    public async callApi(): Promise<string> {
        const response = await this.postData<string>("callApi");
        return response;
    }

    private async postData<T>(url: Types.Endpoints, data = {}): Promise<T> {

        const apiCall = `api/${url}`;

        const response = await fetch(apiCall, {
            method: "POST",
            mode: "cors",
            cache: "no-cache",
            credentials: "same-origin",
            headers: {
                "Content-Type": "application/json"
            },
            redirect: "follow",
            referrerPolicy: "no-referrer",
            body: JSON.stringify(data)
        });

        const responseModel = await response.json() as ResponseModel<T>;

        return responseModel.value;
    }
}

interface ResponseModel<T> {
    value: T,
}