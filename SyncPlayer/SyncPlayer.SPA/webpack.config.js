
var webpack = require('webpack');

module.exports = {

    entry: { 
        app: './wwwroot/app/app.ts',
        about: './wwwroot/app/about.ts'
    },
    output: {
        path: './wwwroot/build',
        filename: '[name].bundle.js'
    },
    module: {
        loaders: [
            { test: /\.ts$/, loader: 'ts' },
            { test: /\.css$/, loader: "style!css" },
            { test: /\.jpe?g$|\.gif$|\.png$|\.svg$|\.woff$|\.ttf$|\.eot$|\.woff2$/, loader: "url" }
        ]
    },
    resolve: {
        extensions: ['', '.js', '.ts']
    }
};