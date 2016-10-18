
var webpack = require('webpack');
var ExtractTextPlugin = require("extract-text-webpack-plugin");

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
            { test: /\.jpe?g$|\.gif$|\.png$|\.svg$|\.woff$|\.ttf$|\.eot$|\.woff2$/, loader: "url" },
            { test: /\.scss$/, loader: ExtractTextPlugin.extract('css!sass')}
        ]
    },
    plugins: [
         new ExtractTextPlugin("app.css")
    ],
    resolve: {
        extensions: ['', '.js', '.ts']
    }
};