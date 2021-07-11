/**
 * @preserve Copyright 2019-2021 Onno Invernizzi.
 * This source code is subject to terms and conditions.
 * See LICENSE.MD.
 */

import { IServer } from "./IServer";

/**
 * This interface defines the application context. The application context is injected via a property into the main application.
 */
export interface IApplicationContext {
    server: IServer;
}