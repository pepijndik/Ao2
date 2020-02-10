<?php

class rekendoos
{
    public $getal1, $getal2;

    public function __construct($g1, $g2)
    {
        $this->getal1 = $g1;
        $this->getal2 = $g2;
    }

    public function telOp()
    {
        return $this->getal1 + $this->getal2;
    }
    public function vermenigvuldig()
    {
        return $this->getal1 * $this->getal2;
    }
}

if ($_POST['submit']) {
    $g1 = $_POST['getal1'];
    $g2 = $_POST['getal2'];
    $machine = new rekendoos($g1, $g2);
    echo "De getallen opgeteld geeft:" . $machine->telOp();
    echo   "De getallen vermedigvuldigd:" . $machine->vermenigvuldig();
}
