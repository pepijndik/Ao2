function opdracht1() {
  var woord = "novacollege";
  var lengte = woord.length / 2;
  var x = Math.floor(lengte);
  document.write(woord.substring(0, x));

  document.write(" " + woord.substring(x, woord.length));
}

function opdracht2() {
  var woord = "novacollege";
  var lengte = woord.length / 2;
  var x = Math.floor(lengte);
  document.write(woord.substring(x, woord.length));
  document.write(" " + woord.substring(0, x));
}
function opdracht3() {
  var string = "Novacollege is stom";
  var vervangen = string.replace(/ [^ a, e, i, o, u, A, E, I, O, U] / g, "");
  alert(vervangen);
}

function opdracht4() {
  var getal = 12.0009;
  for (var i = 0; i < 2; i++) {
    if ((i = 1)) {
      Math.ceil(getal);
    } else {
      Math.floor(getal);
    }
  }
}
function opdracht5() {
  var numbers = new array();
  for (var i = 0; i < 5; i++) {
    numbers.push(Math.random() * 20 + 5);
  }
  alert(Math.max(numbers));
}
