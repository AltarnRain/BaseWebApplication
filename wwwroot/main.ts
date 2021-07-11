requirejs.config({
    //By default load any module IDs from js/lib
    baseUrl: "",
    paths: {
        "react": "./node_modules/react/umd/react.development",
        "react-dom": "./node_modules/react-dom/umd/react-dom.development",
    }
});

// Require the start module and execute it.
requirejs(["js/Start"], (module: typeof import ("./Start")) => {
    // Call the start function in Start.ts to get things going.
    module.start();
});