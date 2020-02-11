function uitvoer() {
  var invoer = document.testinvoer.invoer.value;
  if (invoer == "") {
    var invoer2 = document.testinvoer.invoer2.value;
    var f = 1.8 * invoer2 + 32;
  } else {
    var f = 1.8 * invoer + 32;
  }

  alert(f);
}
function opdracht3() {
  var invoer = document.forminvoer2.invoer3.value;
  var invoer2 = document.forminvoer2.invoer4.value;
  var invoer3 = document.forminvoer2.invoer5.value;

  var gem = invoer + invoer2 + invoer3 / 3;

  var gemid = gem.toFixed(2);

  document.write(gemid);
}
