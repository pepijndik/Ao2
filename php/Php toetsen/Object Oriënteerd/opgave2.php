<?php

/**
 *Author: Pepijn dik
 *Klas: Ao2b
 */
$knuffel = new knuffel("Pluisje", 20, true);
//Enkel eten geven wanneer iets is ingevuld
if (isset($_POST['UpdateEten'])) {
    //Geef eten aanroepen
    $knuffel->setEten($_POST['UpdateEten']);
}
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
        //Print uit
        echo "Naam: " . $this->naam . "<br> Maaginhoud: " . $this->maaginhoud . "<br>Levend:" . $this->levend;
    }

    //Verwerk het eten
    public function setEten($maaginhoud)
    {
        $this->maaginhoud += $maaginhoud;
        $this->print();
    }
}
