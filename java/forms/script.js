function uitvoer() {
  var invoer = document.testinvoer.invoer.value;
  var f = 1.8 * invoer + 32;
  alert(f);
}
function opdracht3() {
  var invoer = document.forminvoer2.invoer.value;
  var invoer2 = document.forminvoer2.invoer2.value;
  var invoer3 = document.forminvoer2.invoer3.value;

  var gem = invoer + invoer2 + invoer3 / 3;
  gem.toFixed(1);
  alert(gem);
}
