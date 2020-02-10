<?php
class werknemer
{
    private $naam, $salaris;
    public function __construct($n, $s)
    {
        $this->naam = $n;
        $this->salaris = $s;
    }
    public function toon()
    {
        echo $this->naam . " " . $this->salaris;
    }
}

class stagiar extends werknemer
{
    public function __construct($n, $s)
    {
        $this->naam = $n;
        $this->salaris = $s;
    }
}

$werknemer = new werknemer("P", 450);

$stagiar = new stagiar("a", 250);
$stagiar->toon();
$werknemer->toon();
