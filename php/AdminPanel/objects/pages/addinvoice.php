<?php
include('header.php');

$result = mysqli_query($con, $sql);
if (isset($_POST['change'])) {
    $naam = $_POST['klantnaam'];
    $id = $_POST['klantnummer'];
    $sql = "SELECT * FROM klant WHERE klantnummer=$id";
    $result = mysqli_query($con, $sql);
    while ($klant = mysqli_fetch_array($result)) {
        $klantnummer = $klant['klantnummer'];
        $klantnaam = $klant['naam'];
        $adres = $klant['adres'];
        $plaatsnaam = $klant['woonplaats'];
        $postcode = $klant['postcode'];
        $email = $klant['email'];
        $aantalorders = $klant['aantal_orders'];
    }
}
$vandaag = date("Y-m-d");

?>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
<main role="main" class="col-md-9 ml-sm-auto col-lg-10 px-4">
    <div class="chartjs-size-monitor" style="position: absolute; left: 0px; top: 0px; right: 0px; bottom: 0px; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -1;">
        <div class="chartjs-size-monitor-expand" style="position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;">
            <div style="position:absolute;width:1000000px;height:1000000px;left:0;top:0"></div>
        </div>
        <div class="chartjs-size-monitor-shrink" style="position:absolute;left:0;top:0;right:0;bottom:0;overflow:hidden;pointer-events:none;visibility:hidden;z-index:-1;">
            <div style="position:absolute;width:200%;height:200%;left:0; top:0"></div>
        </div>
    </div>
    <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
        <div class="btn-toolbar mb-2 mb-md-0">
            <h1 class="h2">Factuur aan maken</h1>
        </div>
    </div>
    <form name="factuuraanmaken" method="POST" action="">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label for="klantnaam">Kies een klant</label>
                <div class="form-group">

                    <select class="form-control" id="kiesklant" name="kiesklant">
                        <?php
                        $queryget = "SELECT * FROM klant";
                        $result = mysqli_query($con, $queryget);
                        while ($klant = mysqli_fetch_array($result)) {
                            $klantnummer = $klant['klantnummer'];
                            $klantnaam = $klant['naam'];
                            echo "<option value=\"$klantnummer\">$klantnaam </option>";
                        }
                        ?>
                    </select>
                </div>
            </div>
            <!-- <div class="form-group col-md-3">
                <label for="klantnaam">Extra Info</label>
                <input type="text" class="form-control" name="klantnummer" placeholder="info" />
            </div> -->
            <div class="form-group col-md-3">
                <label for="van">Factuur datum aangemaakt:</label>
                <input type="text" class="form-control" name="date" value="<?php echo $vandaag; ?>" placeholder="1" disabled />
            </div>
        </div>
        <div class="form-row">
            <h3 class="col-md-12">Factuur Regels</h3><br><br>
            <div class="form-group col-md-4">
                <label for="van">Kies een Product</label>
                <div class="form-group">

                    <select class="form-control" id="product" name="product">
                        <?php
                        $querygetproduct = "SELECT * FROM producten";
                        $getProductResult = mysqli_query($con, $querygetproduct);
                        while ($product = mysqli_fetch_array($getProductResult)) {
                            $product_id = $product['artiekel_id'];
                            $product_naam = $product['title'];
                            echo "<option value=\"$product_id\">$product_naam</option>";
                        }
                        ?>
                    </select>
                </div>
            </div>
            <div class="form-group col-md-3">
                <label for="van">Aantal</label>
                <input type="text" class="form-control" name="aantal" placeholder="1" require />
                <button id="addMore" class="btn btn-secondary">Meerdere Factuur Regels</button>
            </div>

            <div class="form-group col-md-12" id="factuurregels">

            </div>


        </div>
        <div class="form-group col-md-3">

            <label class="btn btn-danger">
                <input type="radio" name="betaald" value="nee" />Niet betaald</button>
            </label>
            <label class="btn btn-success">
                <input type="radio" name="betaald" value="ja" />Betaald</button>
            </label>
        </div>
        <button type="submit" name="add" class="btn btn-primary">Maak Nieuw factuur</button>
        </div>

    </form>
</main>
</div>
</div>
</body>
<?php


include('footer.php'); ?>
<?php
if (isset($_POST['add'])) {
    //Voor factuur
    $klantnummer = $_POST['kiesklant'];
    $betaald = $_POST['betaald'];
    $factuur_date = $vandaag;
    //Voor factuur regels
    $_SESSION['product'] = $_POST['product'];
    $_SESSION['aantal'] = $_POST['aantal'];
    //Maak factuur aan
    $QueryCreateFactuur = "INSERT INTO `facturen`( `klantnummer`, `factuurdatum`, `betaald`) VALUES ($klantnummer,'$factuur_date','$betaald')";
    $CreateFactuurResult = mysqli_query($con, $QueryCreateFactuur);
    if ($CreateFactuurResult) {

        echo "Basis Factuur aangemaakt ";
        //Verkijg laatse ID
        $factuurnummer = mysqli_insert_id($con);

        $product_id = $_SESSION['product'];
        $aantal = $_SESSION['aantal'];
        //Voeg regels toe
        $queryAddRegel = "INSERT INTO `factuurregels`(`factuurnummer`, `artiekel_id`, `aantal`) VALUES ($factuurnummer,$product_id,$aantal)";
        $addRegelResult = mysqli_query($con, $queryAddRegel);
        if ($addRegelResult) {
            echo " Regels toegevoegd ";
        } else {
            echo " Geen factuur regels ";
        }
    } else {
        echo " Er is iets fout gegaan. ";
    }
}

$querygetproduct2 = "SELECT * FROM producten";
$getProductResult2 = mysqli_query($con, $querygetproduct2);
?>
<script>
    $(function() {
        $("#addMore").click(function(e) {
            e.preventDefault();
            $("#factuurregels").append("<div class='form-group col-md-4'>");
            $("#factuurregels").append("<label for='van'>Kies een Product</label><div class='form-group'>");
            $("#factuurregels").append("<select class='form-control' id='product' name='product'><?php while ($product = mysqli_fetch_array($getProductResult2)) {
                                                                                                        $product_id = $product['artiekel_id'];
                                                                                                        $product_naam = $product['title'];
                                                                                                        echo "<option value='$product_id'>$product_naam</option>";
                                                                                                    } ?></select>");
            $("#factuurregels").append("<label for='van'>Aantal</label>");
            $("#factuurregels").append("<input type='text' class='form-control' name='aantal' placeholder='1' />");
            $("#factuurregels").append("</div>");

        });
    });
</script>