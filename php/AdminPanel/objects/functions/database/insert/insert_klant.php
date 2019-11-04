<?php

// Connect to the MySQL database  
require "../../config.php";

$sqlCommand = 'INSERT INTO klant (klantnummer, naam, adres, postcode, woonplaats, email, aantal_orders, )
VALUES(115,"jaap","paxlaan 23","2215ap","Hoofddorp","jaap01ie@hotmail.com",1),
(116,"BENtest","testlaan 2","9961Aa","TESTERLAAN","BENTESTER@pepi.com",0)
		 		 ) ';
if (mysqli_query($sqlCommand, $con)) {
    echo "klanten tabel aangemaakt!";
} else {
    echo "CRITICAL ERROR: klanten table has not been created.";
}
