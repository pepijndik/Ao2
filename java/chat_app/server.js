//Gebruik express
var express = require("express");

//Applicatie
var app = express();

//Server console
var server = app.listen(3000, () => {
  console.log("Pep chat is gestart op poort: ", server.address().port);
});

app.use(express.static(__dirname));
