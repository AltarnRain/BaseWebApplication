import { Endpoints } from "../../Types/Interfaces/Endpoints";
import { IServer } from "../../Types/Interfaces/IServer";

/**
 * This class abstracts all calls to the backend.
 */
export class Server implements IServer {

    public async callApi(): Promise<string> {
        const response = await this.postData<string>("callApi")
        return response;
    }

    private async postData<T>(url: Endpoints, data = {}): Promise<T> {

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

        return responseModel.model;
    }
}

interface ResponseModel<T> {
    model: T,
}