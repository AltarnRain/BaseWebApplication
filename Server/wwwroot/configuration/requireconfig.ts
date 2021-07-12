/*
 * @preserve Copyright 2019-2021 Onno Invernizzi.
 * This source code is subject to terms and conditions.
 * See LICENSE.MD.
 */

requirejs.config({
    baseUrl: "",
    paths: {
        "react": "./node_modules/react/umd/react.development",
        "react-dom": "./node_modules/react-dom/umd/react-dom.development",
    }
});

requirejs(["configuration/launchApplication"], (module: typeof import ("./launchApplication")) => {
    module.launchApplication();
});