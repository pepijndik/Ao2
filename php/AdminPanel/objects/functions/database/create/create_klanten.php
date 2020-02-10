<?php

// Connect to the MySQL database  
require "../../config.php";

$sqlCommand = "CREATE TABLE werknemers (
		 		 klantnummer int(25) NOT NULL auto_increment,
				 naam varchar(255) NOT NULL,
		 		 adres varchar(15) NOT NULL,
		 		 postcode varchar(7),
                 woonplaats varchar(25) not null,
                 email varchar(25),
                 aantal_orders int(55),
		 		 PRIMARY KEY (klantnummer),
		 		
		 		 ) ";
if (mysqli_query($sqlCommand, $con)) {
    echo "klanten tabel aangemaakt!";
} else {
    echo "CRITICAL ERROR: klanten table has not been created.";
}
