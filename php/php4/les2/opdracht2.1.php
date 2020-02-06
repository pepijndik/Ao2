<?php

class fiets
{
    public $merk, $voorraad, $prijs;

    function schrijf()
    {
        return $this->merk . "" . $this->voorraad . " " . $this->prijs;
    }

    function null()
    {
        $this->merk = null;
        $this->voorraad = null;
        $this->prijs = null;
    }
}

$fiets1 = new fiets;
$fiets1->merk = "Batavus sport";
$fiets1->voorraad = 60;
$fiets1->prijs = 450;

$fiets2 = new fiets;
$fiets2->merk = "Gazelle design";
$fiets2->voorraad = 30;
$fiets2->prijs = 850;

echo $fiets1->merk . " " . $fiets1->voorraad . " " . $fiets1->prijs;
echo $fiets2->merk . " " . $fiets2->voorraad . " " . $fiets2->prijs;
