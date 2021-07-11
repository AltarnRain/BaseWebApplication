requirejs.config({
    baseUrl: "",
    paths: {
        "react": "./node_modules/react/umd/react.development",
        "react-dom": "./node_modules/react-dom/umd/react-dom.development",
    }
});

requirejs(["launchApplication"], (module: typeof import ("./launchApplication")) => {
    module.launchApplication();
});