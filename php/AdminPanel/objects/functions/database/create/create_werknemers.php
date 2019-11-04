<?php
// Connect to the MySQL database  
require "../../config.php";

$sqlCommand = "CREATE TABLE werknemers (
		 		 id int(25) NOT NULL auto_increment,
				 roepnaam varchar(255) NOT NULL,
		 		 tussenvoegsel varchar(15) NOT NULL,
		 		 achternaam varchar(25) NOT NULL,
                 indienst date NOT NULL,
                 plaatsnaam varchar(255) NOT NULL,
                 bankrekening int(255) NULL,
                 wachtwoord varchar(255) NOT NULL,
		 		 PRIMARY KEY (id),
		 		
		 		 ) ";
if (mysqli_query($sqlCommand, $con)) {
    echo "Werknemers tabel aangemaakt!";
} else {
    echo "CRITICAL ERROR: werknemers table has not been created.";
}
