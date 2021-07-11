/**
 * @preserve Copyright 2019-2021 Onno Invernizzi.
 * This source code is subject to terms and conditions.
 * See LICENSE.MD.
 */

import { IApplicationContext } from "../../Types/Interfaces/IApplicationContext";
import { IServer } from "../../Types/Interfaces/IServer";
import { Server } from "../Server/server";

export class ApplicationContext implements IApplicationContext {
 
    constructor() {
        this.server = new Server();
    }

    public readonly server: IServer;
}