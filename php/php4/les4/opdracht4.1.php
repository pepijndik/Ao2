<?php
class klant
{
    private $nummer, $naam, $bedrag;

    public function __construct($num, $naam, $bedrag)
    {
        $this->naam = $naam;
        $this->nummer = $num;
        $this->bedrag = $bedrag;
    }

    public function schrijf()
    {
        return  $this->naam . " " . $this->nummer . "" . $this->bedrag;
    }
}


$klant768 = new klant(768, "P. Verdonk", 550);
$klant768->schrijf();

$klant6789 = new klant(6889, "h. Zomergast", 230);
$klant6789->schrijf();
