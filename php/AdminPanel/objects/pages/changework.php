<?php
include('header.php');

if (isset($_POST['delete'])) {
    echo "deleted";
    $id = $_POST['id'];
    $sql = "DELETE FROM werknemers where id='$id'";
    $result = mysqli_query($con, $sql);
}

$result = mysqli_query($con, $sql);
if (isset($_POST['change'])) {
    $naam = $_POST['naam'];
    $id = $_POST['id'];
    $sql = "SELECT * FROM werknemers WHERE id=$id";
    $result = mysqli_query($con, $sql);
    while ($werknemer = mysqli_fetch_array($result)) {
        $id = $werknemer['id'];
        $naam = $werknemer['roepnaam'];
        $tussenvoegsel = $werknemer['tussenvoegsel'];
        $achternaam = $werknemer['achternaam'];
        $indienst = $werknemer['indienst'];
        $plaatsnaam = $werknemer['plaatsnaam'];
        $iban = $werknemer['bankrekening'];
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
            <h1 class="h2">verander Werknemer: <?php echo $naam ?> </h1>
        </div>
    </div>
    <form name="klanteninvoegen" method="POST" action="">
        <div class="form-row">


            <input type="hidden" class="form-control" name="id" placeholder="Klant nummer" value="<?= $id ?>" />

            <div class="form-group col-md-3">
                <label for="klantnaam">Werknemer</label>
                <input type="text" class="form-control" name="naam" placeholder="klant naam" value="<?= $naam ?>" require />
            </div>

            <div class="form-group col-md-3">
                <label for="tussenvoegsel">Tussenvoegsel</label>
                <input type="text" class="form-control" name="tussenvoegsel" placeholder="Van der" value="<?= $tussenvoegsel ?>" require />

            </div>
            <div class="form-group col-md-3">
                <label for="achternaam">Achternaam</label>
                <input type="text" class="form-control" name="achternaam" placeholder="DIk" value="<?= $achternaam ?>" require />
            </div>
            <div class="form-group col-md-3">
                <label for="achternaam">Plaatsnaam</label>
                <input type="text" class="form-control" name="plaatsnaam" placeholder="DIk" value="<?= $plaatsnaam ?>" require />
            </div>
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="van">BankRekening</label>
                <input type="text" class="form-control" name="iban" placeholder="NL16Rabo019998876" value="<?= $iban ?>" />
            </div>
            <div class="form-group col-md-3">
                <label for="van">Indienst</label>
                <input type="text" class="form-control" name="indienst" placeholder="2019-01-20" value="<?= $indienst ?>" />
            </div>
        </div>
        <div class="form-group col-md-3">
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
    $sql = "DELETE FROM werknemer where id='$id'";
    $result = mysqli_query($con, $sql);
}
if (isset($_POST['update'])) {
    $id = $_POST['id'];
    $naam = $_POST['naam'];
    $tussenvoegsel = $_POST['tussenvoegsel'];
    $achternaam = $_POST['achternaam'];
    $indienst = $_POST['indienst'];
    $plaatsnaam = $_POST['plaatsnaam'];
    $iban = $_POST['iban'];

    $sql2 = "UPDATE `werknemers` SET `roepnaam`='$naam',`tussenvoegsel`='$tussenvoegsel',`achternaam`='$achternaam',`indienst`='$indienst',`plaatsnaam`='$plaatsnaam',`bankrekening`= '$iban' WHERE `id`=$id";
    $updateResult = mysqli_query($con, $sql2);
    if ($updateResult) {
        echo "Werknemer Geupdate";
        header('Location: ../../index.php');
    } else {
        echo "Er is iets fout gegaan.";
    }
}

?>