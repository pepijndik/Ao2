<?php
class bankrekning
{
    private $nummer, $naam, $saldo;

    public function setNaam($n)
    {
        $this->naam = $n;
    }
    public function setNum($n)
    {
        $this->nummer = $n;
    }
    public function setSaldo($n)
    {
        $this->saldo = $n;
    }

    public function getNaam()
    {
        return $this->naam;
    }
    public function getNum()
    {
        return $this->nummer;
    }
    public function getSaldo()
    {
        return $this->saldo;
    }

    public function changeSaldo($h, $k)
    {
        if ($k == "+") {
            $this->saldo = $this->saldo  + $h;
        } else if ($k == "-") {
            $this->saldo = $this->saldo - $h;
        }
    }
}

$rekening1 = new bankrekning;
$rekening1->setNum(12345);
$rekening1->setSaldo(4500);
$rekening1->setNaam("Jan de Wit");

echo $rekening1->getNaam() . " " . $rekening1->getNum() . " " . $rekening1->getSaldo();
$rekening1->changeSaldo(25, "+");
echo $rekening1->getNaam() . " " . $rekening1->getNum() . " " . $rekening1->getSaldo();
