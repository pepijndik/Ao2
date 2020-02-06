<?php
class db
{
    protected $server, $name, $password, $database;
    public $con;
    public function verbinding()
    {
        $this->con = mysqli_connect($this->server, $this->name, $this->password, $this->database);

        if (!$this->con) {
            echo "Error: Unable to connect to MySQL." . PHP_EOL;
            echo "Debugging errno: " . mysqli_connect_errno() . PHP_EOL;
            echo "Debugging error: " . mysqli_connect_error() . PHP_EOL;
            exit;
        }
    }
}

class leden extends db
{

    public function toonleden()
    {
        $query = "SELECT * FROM geheim";
        $result = $this->verbinding()->query($query);
        while ($leden = mysqli_fetch($result)) {
            echo $leden['nummer'] . " " . $leden['naam'] . " " . $leden['wachtwoord'];
        }
    }
}

/** opgave 6.5 
 *USe While loop and echo the results 
 */
