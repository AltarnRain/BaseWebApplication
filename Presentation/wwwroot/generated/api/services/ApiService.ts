/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { StringResponseModel } from '../models/StringResponseModel';
import { request as __request } from '../core/request';

export class ApiService {

    /**
     * @param name 
     * @returns StringResponseModel Success
     * @throws ApiError
     */
    public static async sayHello(
name?: string | null,
): Promise<StringResponseModel> {
        const result = await __request({
            method: 'POST',
            path: `/api/SayHello`,
            query: {
                'name': name,
            },
        });
        return result.body;
    }

    /**
     * @param name 
     * @returns StringResponseModel Success
     * @throws ApiError
     */
    public static async sayGoodbye(
name?: string | null,
): Promise<StringResponseModel> {
        const result = await __request({
            method: 'POST',
            path: `/api/SayGoodbye`,
            query: {
                'name': name,
            },
        });
        return result.body;
    }

}