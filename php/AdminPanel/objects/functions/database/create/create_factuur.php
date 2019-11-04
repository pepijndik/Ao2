<?php

// Connect to the MySQL database  
require "../../config.php";

$sqlCommand = "CREATE TABLE facturen (
		 		 ordernummer int(25) NOT NULL auto_increment,
				 klantnummer int(255) NOT NULL,
		 		 orderdatum date(15) NOT NULL,
		 		 betaald varchar(7),
		 		 PRIMARY KEY (ordernummer,klantnummer),
		 		
		 		 ) ";
if (mysqli_query($sqlCommand, $con)) {
    echo "klanten tabel aangemaakt!";
} else {
    echo "CRITICAL ERROR: klanten table has not been created.";
}
