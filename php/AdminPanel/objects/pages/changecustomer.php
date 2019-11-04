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
        $_SESSION['klantnummer'] = $klantnummer;
        $adres = $klant['adres'];
        $plaatsnaam = $klant['woonplaats'];
        $postcode = $klant['postcode'];
        $email = $klant['email'];
        $aantalorders = $klant['aantal_orders'];
        $betaald = $klant['betaald'];
    }
}
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
            <h1 class="h2">verander klant: <?php echo $naam ?> </h1>
        </div>
    </div>
    <form name="klanteninvoegen" method="POST" action="">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label for="klantnaam">Klantnaam</label>
                <input type="text" class="form-control" name="klantnaam" placeholder="klant naam" value="<?= $klantnaam ?>" require />
            </div>
            <div class="form-group col-md-3">
                <label for="klantnaam">Klant nummer</label>
                <input type="text" class="form-control" name="klantnummer" placeholder="Klant nummer" value="<?= $klantnummer ?>" disabled />
            </div>
            <div class="form-group col-md-3">
                <label for="email">Email</label>
                <input type="email" class="form-control" name="email" placeholder="Email" value="<?= $email ?>" require />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-4">
                <label for="van">addres</label>
                <input type="text" class="form-control" name="adres" placeholder="Gieterij 53" value="<?= $adres ?>" require />
                <input type="text" class="form-control" name="postcode" placeholder="2211WC" value="<?= $postcode ?>" require />
                <input type="text" class="form-control" name="plaatsnaam" placeholder="Noordwijkerhout" value="<?= $plaatsnaam ?>" require />

            </div>

            <div class="form-group col-md-3">
                <label for="van">Aantal orders</label>
                <input type="text" class="form-control" name="aantal" placeholder="1" value="<?= $aantalorders ?>" disabled />
            </div>
        </div>

        <button type="submit" name="update" class="btn btn-primary">Verander Klant</button>
        </div>

    </form>
</main>
</div>
</div>
</body>
<?php if (isset($_POST['delete'])) {
    echo "deleted";
    $id = $_POST['klantnummer'];
    $sql = "DELETE FROM klant where klantnummer='$id'";
    $result = mysqli_query($con, $sql);
}
if (isset($_POST['update'])) {
    $klantnaam = $_POST['klantnaam'];
    $email = $_POST['email'];
    $klantnummer =  $_SESSION['klantnummer'];
    $adres = $_POST['adres'];
    $plaatsnaam =  $_POST['plaatsnaam'];
    $postcode = $_POST['postcode'];

    $sql2 = "UPDATE `klant` SET `naam`='$klantnaam',`adres`='$adres',`postcode`='$postcode',`woonplaats`='$plaatsnaam',`email`='$email' WHERE `klantnummer`= $klantnummer";
    $updateResult = mysqli_query($con, $sql2);
    if ($updateResult) {
        echo "Klant is geupdate gefeliciteerd";
        header('Location: ../../index.php');
    } else {
        echo "Er is iets fout gegaan.";
    }
}

?>