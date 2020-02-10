<?php
class leerling
{
    protected $naam;
    private $klas;
    public function __construct($n, $k)
    {
        $this->naam = $n;
        $this->klas = $k;
    }
    public function toon()
    {
        echo $this->naam . "<br>";
        echo $this->klas;
    }
}

class aspirantLeerling extends leerling
{
    public function schrijf()
    {

        echo $this->naam;
    }
}

$aspirant = new aspirantLeerling("Beginner", "Ao1");
$aspirant->schrijf();
