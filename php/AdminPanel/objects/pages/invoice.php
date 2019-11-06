<?php
require('../../objects/config.php');
//require('../../objects/checks/auth.php');

if (isset($_POST['klantnummer'])) {
    $klant_id = $_POST['klantnummer'];
} else {
    $klant_id = $_GET['klantnummer'];
}

if (isset($_GET['klantnummer'])) {
    $klant_id = $_GET['klantnummer'];
} else {
    $klant_id = $_POST['klantnummer'];
}

$sql = "SELECT * FROM facturen RIGHT join klant
ON klant.klantnummer = facturen.klantnummer where klant.klantnummer='$klant_id'";
$result = mysqli_query($con, $sql);

while ($factuur = mysqli_fetch_array($result)) {
    $klant_naam = $factuur['naam'];
    $adres = $factuur['adres'];
    $postcode = $factuur['postcode'];
    $woonplaats = $factuur['woonplaats'];
    $klant_email = $factuur['email'];
    //Factuur gegevens
    $factuur_nummer = $factuur['factuurnummer'];
    $factuur_datum = $factuur['factuurdatum'];
    $factuur_betaald = $factuur['betaald'];
}
?>
<html lang="en" class="gr__getbootstrap_com">

<head>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head>

<body>
    <div id="invoice">

        <div class="toolbar hidden-print">
            <div class="text-right">
                <button id="printInvoice" class="btn btn-info"><i class="fa fa-print"></i> Print</button>
                <button class="btn btn-info"><i class="fa fa-file-pdf-o"></i> Export as PDF</button>
            </div>
            <hr>
        </div>
        <div class="invoice overflow-auto">
            <div style="min-width: 800px">
                <header>
                    <div class="row">
                        <div class="col">
                            <a target="_blank" href="https://pdik.nl">
                                <img src="https://pdik.nl/nova/ao2/adminpanel/assets/image/webshop-logo.jpg" data-holder-rendered="true" />
                            </a>
                        </div>
                        <div class="col company-details">
                            <h2 class="name">
                                <a target="_blank" href="https://pdik.nl">
                                    SimpelShop
                                </a>
                            </h2>
                            <div>26 S'gravendamseweg, 2215ta, NL</div>
                            <div>(06) 1999-0890</div>
                            <div>info@Simpel.nl</div>
                        </div>
                    </div>
                </header>
                <main>
                    <div class="row contacts">
                        <div class="col invoice-to">
                            <div class="text-gray-light">Factuur naar:</div>
                            <h2 class="to"><?php echo $klant_naam ?></h2>
                            <div class="address"><?php echo $adres . " " . $woonplaats . " " . $postcode ?></div>
                            <div class="email"><a href="mailto:mail"><?php echo $klant_email ?></a></div>
                        </div>
                        <div class="col invoice-details">
                            <h1 class="invoice-id">Factuur: <?php echo $factuur_nummer ?></h1>
                            <div class="date">Factuur datum: <?php echo $factuur_datum ?></div>

                        </div>
                    </div>
                    <table border="0" cellspacing="0" cellpadding="0">
                        <thead>
                            <tr>
                                <th># &nbsp;</th>
                                <th class="text-left">Product</th>
                                <th class="text-left">Beschrijving &nbsp;</th>
                                <th class="text-right">Aantal </th>
                                <th class="text-right">Totaal</th>
                            </tr>
                        </thead>
                        <tbody>
                            <?php



                            $factuurregels = "SELECT * FROM facturen RIGHT join factuurregels ON facturen.factuurnummer = factuurregels.factuurnummer where facturen.klantnummer='$klant_id'";
                            $resultaten = mysqli_query($con, $factuurregels);
                            while ($regel = mysqli_fetch_array($resultaten)) {

                                $artiekel_id = $regel['artiekel_id'];
                                $aantal = $regel['aantal'];

                                //Verkrijg Informatie  van prodcut
                                $artiekelInfo = "SELECT * FROM producten where producten.artiekel_id=$artiekel_id";
                                $ArtiekelResultaat = mysqli_query($con, $artiekelInfo);
                                while ($artiekel = mysqli_fetch_array($ArtiekelResultaat)) {
                                    $prijs = $artiekel['prijs_exl'];
                                    $conditie = $artiekel['conditie'];
                                    $title = $artiekel['title'];
                                    $beschrijving = $artiekel['beschrijving'];
                                }
                                //Laat Producten Rijen zien in de factuur
                                echo "  <tr>";
                                echo " <td > $artiekel_id </td>";
                                echo "<td class=\"text-left\">";
                                echo "<p>$title</p> ";
                                echo "<td class=\"text-left\"> <p> &nbsp" . $beschrijving . "</p></td>";
                                echo "</td>";
                                echo " <td class=\"qty\">$aantal</td>";
                                $product_totaal = $prijs * $aantal;
                                echo "<td class=\"total\">€$product_totaal</td>";

                                //Totaal en BTW uitlaten rekenen
                                $sub_totaal += $product_totaal;
                                $btw += $sub_totaal / 100 * 21;
                                $totaal = $sub_totaal + $btw;
                            }

                            ?>
                            <!-- <tr>
                                <td class="no">04</td>
                                <td class="text-left">
                                    <h3>
                                        <a target="_blank" href="https://www.youtube.com/channel/UC_UMEcP_kF0z4E6KbxCpV1w">
                                            Title
                                        </a>
                                    </h3>
                                    <a target="_blank" href="https://www.youtube.com/channel/UC_UMEcP_kF0z4E6KbxCpV1w">
                                        Link
                                    </a>
                                    Beschrijving
                                </td>

                                <td class="qty">1</td>
                                <td class="total">$0.00</td>
                            </tr> -->


                        </tbody>
                        <tfoot>
                            <tr>
                                <td colspan="2"></td>
                                <td colspan="2">SubTotaal</td>
                                <td>€<?php echo $sub_totaal ?></td>
                            </tr>
                            <tr>
                                <td colspan="2"></td>
                                <td colspan="2">BTW 21%</td>
                                <td><?php echo $btw ?></td>
                            </tr>
                            <tr>
                                <td colspan="2"></td>
                                <td colspan="2">Totaal</td>
                                <td>€<?php echo $totaal ?></td>
                            </tr>
                        </tfoot>
                    </table>
                    <div class="thanks">Hartelijk bedankt</div>
                    <div class="notices">
                        <div>Opmerkingen:</div>
                        <div class="notice">een Rente word berekend van 1.5% na 30 dagen niet betalen</div>
                    </div>
                </main>
                <footer>
                    Factuur aangemaakt door: Factuur_pdik
                </footer>
            </div>
            <!--DO NOT DELETE THIS div. IT is responsible for showing footer always at the bottom-->
            <div></div>
        </div>
    </div>
</body>
<script>
    $('#printInvoice').click(function() {
        Popup($('.invoice')[0].outerHTML);

        function Popup(data) {
            window.print();
            return true;
        }
    });
</script>

</html>