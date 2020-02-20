console.log("Hello world");

// use express
var express = require("express");

// create instance of express
var app = express();

// use http with instance of express
var http = require("http").createServer(app);
