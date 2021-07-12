/**
 * @preserve Copyright 2019-2021 Onno Invernizzi.
 * This source code is subject to terms and conditions.
 * See LICENSE.MD.
 */

export namespace Interfaces {
    /**
     * This interface defines the application context. The application context is injected via a property into the main application.
     */
    export interface ApplicationContext {
        server: Server;
    }

    export interface Server {
        callApi(): Promise<string>;
    }
}

