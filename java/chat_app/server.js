console.log("Hello world");

// gebruik express
var express = require("express");

// create instance of express
var app = express();

// use http with instance of express
var http = require("http").createServer(app);

// Start de server
var port = 3000;
http.listen(port, function() {
  console.log("Chat poort " + port);
});

// create socket instance with http
var io = require("socket.io")(http);
