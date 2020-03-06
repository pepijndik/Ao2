<?php

/**
 *Author: Pepijn dik
 *Klas: Ao2b
 */
$knuffel = new knuffel("Pluisje", 20, true);

class knuffel
{
    //Prive Variables
    private $naam, $maaginhoud, $levend;

    //Construct
    public function __construct($naam, $maaginhoud, $levend)
    {
        //Set de Class variables naar de ingegeven Values
        $this->naam = $naam;
        $this->maaginhoud = $maaginhoud;
        $this->levend = $levend;
        //Voer de print functie uit
        $this->print();
    }

    //Print functie
    private function print()
    {
        echo "Naam: " . $this->naam . "<br> Maaginhoud: " . $this->maaginhoud . "<br>Levend:" . $this->levend;
    }
}
