<?php
include('header.php');


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
            <h1 class="h2">Maak een nieuwtje aan </h1>
        </div>
    </div>
    <form name="voeg nieuwtje toe" method="POST" action="">
        <div class="form-row">
            <div class="form-group col-md-3">
                <label for="klantnaam">Title</label>
                <input type="text" class="form-control" name="title" placeholder="nieuwtje" value="" require />
            </div>
        </div>
        <div class="form-row">

            <div class="form-group col-md-3">
                <label for="van">Beschrijving</label>
                <input type="text" class="form-control" name="beschrijving" placeholder="Beschrijving" value="" />
            </div>
        </div>
        <div class="form-group col-md-3">

            <button type="submit" name="add" class="btn btn-primary">Maak nieuwtje</button>


    </form>
</main>
</div>
</div>
</body>
<?php
if (isset($_POST['add'])) {
    $title = $_POST['title'];
    $beschrijving = $_POST['beschrijving'];
    $sql2 = "INSERT INTO `nieuwtjes`(`title`, `beschrijving`) VALUES ($title,$beschrijving)";
    $updateResult = mysqli_query($con, $sql2);
    if ($updateResult) {
        echo "Klant Toegevoegd";
    } else {
        echo "Er is iets fout gegaan.";
    }
}

?>