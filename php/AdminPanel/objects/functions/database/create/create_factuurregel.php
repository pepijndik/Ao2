<?php

// Connect to the MySQL database  
require "../../config.php";

$sqlCommand = "CREATE TABLE facregel (
		 		 ordernummer int(25) NOT NULL,
				 artiekel_id int(50) NOT NULL,
		 		 aantal int(55) NOT NULL,
		 		 PRIMARY KEY (ordernummer),
		 		
		 		 ) ";
if (mysqli_query($sqlCommand, $con)) {
    echo "klanten tabel aangemaakt!";
} else {
    echo "CRITICAL ERROR: klanten table has not been created.";
}
