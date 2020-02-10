<?php
include('header.php');
$id = $_POST['id'];
$_SESSION['id'] = $id;
$queryGetProduct = "SELECT * FROM producten where artiekel_id='$id'";
$resultaat = mysqli_query($con, $queryGetProduct);
while ($producten = mysqli_fetch_array($resultaat)) {
    $prodcut_id = $producten['artiekel_id'];
    $_SESSION['artiekel_id'] = $prodcut_id;
    $productnaam = $producten['title'];
    $type = $producten['type'];
    $beschrijving = $producten['beschrijving'];
    $prijs_in = $producten['prijs_incl'];
    $prijs_ex = $producten['prijs_exl'];
    $leverancier = $producten['leverancier'];
    $conditie = $producten['conditie'];
}


?>
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
            <h1 class="h2">Producten Simpel Shop</h1>

        </div>
    </div>
    <form action="" method="POST">

        <div class="form-group">
            <label for="exampleFormControlInput1">Product naam</label>
            <input type="text" class="form-control" name="productnaam" id="productnaam" placeholder="Acer moederbord" value="<?php echo $productnaam ?>">
        </div>
        <div class="form-group">
            <label for="exampleFormControlSelect1">Type Hardware</label>
            <select class="form-control" name="type" id="type">
                <option <?= $type == 'Videokaart' ? ' selected="selected"' : ''; ?>>Videokaart</option>
                <option <?= $type == 'Moederbord' ? ' selected="selected"' : ''; ?>>Moederbord</option>
                <option <?= $type == 'Ram' ? ' selected="selected"' : ''; ?>>Ram</option>
                <option <?= $type == 'Cpu' ? ' selected="selected"' : ''; ?>>Cpu</option>
                <option <?= $type == 'Voeding' ? ' selected="selected"' : ''; ?>>Voeding</option>
                <option <?= $type == 'Case' ? ' selected="selected"' : ''; ?>>Case</option>
                <option <?= $type == 'Kabels' ? ' selected="selected"' : ''; ?>>Kabels</option>
                <option <?= $type == 'Monitor' ? ' selected="selected"' : ''; ?>>Monitor</option>

            </select>
        </div>
        <div class="form-group">
            <label for="exampleFormControlSelect1">Niew/Tweedehands</label>
            <select class="form-control" name="conditie" id="conditie">
                <option <?= $conditie == 'Nieuw' ? ' selected="selected"' : ''; ?>>Nieuw</option>
                <option <?= $conditie == 'Tweedehands' ? ' selected="selected"' : ''; ?>>Tweedehands</option>


            </select>
        </div>
        <div class="form-group">
            <label for="exampleFormControlTextarea1">Beschrijving</label>
            <textarea class="form-control" id="beschrijving" name="beschrijving" rows="3" value=""><?php echo $beschrijving ?> </textarea>
        </div>
        <div class="form-row">
            <div class="form-row">
                <div class="form-group col-md-4">
                    <label for="inputCity">Inkoop prijs</label>
                    <input type="text" class="form-control" name="inkoop" id="inkoop" value="<?php echo $prijs_in ?>">
                </div>

                <div class=" form-group col-md-4">
                    <label for="inputZip">Verkoop prijs</label>
                    <input type="text" class="form-control" name="verkoop" id="verkoop" value="<?php echo $prijs_ex ?>">
                </div>
            </div>

        </div>
        <button type="submit" name="update" class="btn btn-primary">Verander</button>
    </form>

</main>
</div>
</div>
<?php

if (isset($_POST['update'])) {
    //verkrijg data die ingevoerd is
    if (isset($id)) {
        echo "ID=";
    } else {
        $id = $_SESSION['id'];
        echo $id;
    }
    $id = $_SESSION['artiekel_id'];
    $productnaam = $_POST['productnaam'];
    $inkoop = $_POST['inkoop'];
    $verkoop = $_POST['verkoop'];
    $type = $_POST['type'];
    $beschrijving = $_POST['beschrijving'];
    $conditie = $_POST['conditie'];

    //Stuur naar database
    $queryUpdateProduct = "UPDATE `producten` SET `title`='$productnaam',`beschrijving`='$beschrijving',`prijs_incl`=$inkoop,`prijs_exl`=$verkoop,`type`='$type',`conditie`='$conditie' WHERE artiekel_id=$id";
    $testen = mysqli_query($con, $queryUpdateProduct);
    if ($testen) {
        echo "Veranderd";
        header("Location: ../../index.php");
    } else {
        echo $id;
        echo "Error";
    }
}

include('footer.php');
?>