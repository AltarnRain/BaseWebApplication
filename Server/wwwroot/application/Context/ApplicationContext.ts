/**
 * @preserve Copyright 2019-2021 Onno Invernizzi.
 * This source code is subject to terms and conditions.
 * See LICENSE.MD.
 */

import { Interfaces } from "../../typing/interfaces";
import { Server } from "../server/server";

export class ApplicationContext implements Interfaces.ApplicationContext {
 
    constructor() {
        this.server = new Server();
    }

    public readonly server: Server;
}