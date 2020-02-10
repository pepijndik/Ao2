<?php
require "../../config.php";

$sqlCommand = "CREATE TABLE producten (
                 artiekel_id int(55) not NULL,
		 		 id int(25) NOT NULL auto_increment,
				 title varchar(24) NOT NULL,
		 		 beschrijving varchar(255),
		 		 prijs_incl int(25) NOT NULL,
                 prijs_exl int(25) NOT NULL,
                 type varchar(35) NOT NULL,
                 aantal_verkocht int(25) null,
                 product_image int(25) NOT NULL,
		 		 PRIMARY KEY (artiekel_id),
		 		
		 		 ) ";
if (mysqli_query($sqlCommand, $con)) {
    echo "Producten aangemaakt!";
} else {
    echo "CRITICAL ERROR: admin table has not been created.";
}
