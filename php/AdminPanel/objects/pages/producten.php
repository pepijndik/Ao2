<?php
include('header.php');
$sql = "SELECT * FROM producten";
$result = mysqli_query($con, $sql);

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
            <input type="text" class="form-control" id="productnaam" placeholder="Acer moederbord">
        </div>
        <div class="form-group">
            <label for="exampleFormControlSelect1">Type Hardware</label>
            <select class="form-control" id="type">
                <option>Videokaart</option>
                <option>Moederbord</option>
                <option>Ram</option>
                <option>Cpu</option>
                <option>Voeding</option>
                <option>Case</option>
                <option>Netwerk</option>
                <option>Kabels</option>
                <option>Monitor</option>
            </select>
        </div>
        <div class="form-group">
            <label for="exampleFormControlSelect1">Niew/Tweedehands</label>
            <select class="form-control" id="conditie">
                <option>Nieuw</option>
                <option>Tweedehands</option>

            </select>
        </div>
        <div class="form-group">
            <label for="exampleFormControlTextarea1">Beschrijving</label>
            <textarea class="form-control" id="beschrijving" rows="3"></textarea>
        </div>
        <div class="form-row">
            <div class="form-row">
                <div class="form-group col-md-4">
                    <label for="inputCity">Inkoop prijs</label>
                    <input type="text" class="form-control" id="inkoop">
                </div>

                <div class="form-group col-md-4">
                    <label for="inputZip">Verkoop prijs</label>
                    <input type="text" class="form-control" id="verkoop">
                </div>
            </div>

        </div>
        <button type="submit" name="toevoegen" class="btn btn-primary">Voeg toe</button>
    </form>
    <table class="table table-striped table-sm">
        <thead>
            <tr>
                <th>#</th>
                <th>Type</th>
                <th>Product naam</th>
                <th>Inkoop prijs</th>
                <th>Verkoop prijs</th>
                <th>aantal keer verkocht</th>

            </tr>
        </thead>
        <tbody>
            <?php

            while ($prodcut = mysqli_fetch_array($result)) {
                $id = $prodcut['artiekel_id'];
                echo "<form action=\"updateproduct.php\" method=\"POST\">";
                echo "<tr>";
                echo "<td>" . $prodcut['artiekel_id'] . "</td>";
                echo "<td>" . $prodcut['type'] . "</td>";
                echo "<td>" . $prodcut['title'] . "</td>";
                echo "<td>" . $prodcut['prijs_incl'] . "</td>";
                echo "<td>" . $prodcut['prijs_exl'] . "</td>";
                echo "<td>" . $prodcut['aantal_verkocht'] . "</td>";
                echo "<input type=\"hidden\" name=\"id\" value=\"$id\"/>";
                echo "<td><button type=\"submit\" name=\"change\"  id=\"change\" class=\"btn btn-warning\">Verander</button></td>";
                echo "<td><button type=\"submit\" name=\"delete\" id=\"delete\" class=\"btn btn-danger\">Verwijder</button></td>";
                echo "</form>";
                echo "</tr>";
            }
            ?>
        </tbody>
    </table>
</main>
</div>
</div>
<?php

if (isset($_POST['toevoegen'])) {
    //verkrijg data die ingevoerd is
    $productnaam = $_POST['productnaam'];
    $inkoop = $_POST['inkoop'];
    $verkoop = $_POST['verkoop'];
    $type = $_POST['type'];
    $beschrijving = $_POST['beschrijving'];
    $conditie = $_POST['conditie'];

    //Stuur naar database
    $sql = "INSERT into `producten` (title, beschrijving, prijs_incl, prijs_exl, type, conditie) VALUES('$productnaam', '$beschrijving', '$inkoop', '$verkoop', '$type', '$conditie')";
    $result = mysqli_query($con, $sql);
    if ($result) {
        echo "Toegevoegd";
    } else {
        echo "...";
    }
} else { }

include('footer.php');
?>