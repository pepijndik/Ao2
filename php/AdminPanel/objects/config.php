<!--Pdik Config -->

<?php
//MySQL Database Gegevens
$host = "localhost";
$username = "pdik";
$pass = "Daq1Stappels!";
$db = "simpelshop";


$con = mysqli_connect($host, $username, $pass, $db);
if (mysqli_connect_errno()) {
    echo "Failed to connect to MySQL: " . mysqli_connect_error();
}
?>