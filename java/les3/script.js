function les3() {
  var uitvoer = document.getElementById("uitvoerles3");
  var tekst = "";
  var teller;
  var score;
  tekst = "<table> <tr><th>score</th><th>Cijfer</th>";
  for (teller = 4; teller <= 10; teller++) {
    if (teller == 4) {
      score = "0-40";
    }
    if (teller == 5) {
      score = "41-48";
    }
    if (teller == 6) {
      score = "49-54";
    }
    if (teller == 7) {
      score = "55-60";
    }
    if (teller == 8) {
      score = "61-63";
    }
    if (teller == 9) {
      score = "64-67";
    }
    if (teller == 10) {
      score = "68-70-54";
    }

    tekst += "<tr><th>" + score + "</th><th>" + teller + "</th></tr>";
  }

  tekst += "</table>";
  uitvoer.innerHTML = tekst;
}

function les3opgave3() {
  var totaal;
  for (var i = 0; i < 100; i++) {
    totaal += i;
  }
  alert(i);
}

function les3opgave4() {}
