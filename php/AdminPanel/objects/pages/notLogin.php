<?php


require('../config.php');
session_start();
if (isset($_POST['naam'])) {
    $naam = stripslashes($_REQUEST['naam']);
    $naam = mysqli_real_escape_string($con, $naam);
    $password = stripslashes($_REQUEST['wachtwoord']);
    $password = mysqli_real_escape_string($con, $password);
    $query = "SELECT * FROM werknemers WHERE roepnaam='$naam'
AND wachtwoord='" . md5($password) . "'";

    $result = mysqli_query($con, $query) or die(mysqli_error($con));
    $rows = mysqli_num_rows($result);

    if ($rows == 1) {
        $_SESSION['naam'] = $naam;
        header("Location: ../../index.php");
    } else {
        echo "<div class='form'>
<h3>Deze Werknemer bestaat niet. Of het ingevulde Wachtwoord is Fout!</h3>
<br/>Click here to <a href='https://pdik.nl/nova/adminpanel'>Login</a></div>";
    }
}


$query2 = "SELECT * FROM nieuwtjes";
$resultaatNieuw = mysqli_query($con, $query2);
?>
<html>

<head>
    <script type="text/javascript">
        $(window).on('load', function() {
            $('#loginModal').modal('show');
        });
    </script>
    <link href="https://netdna.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Grand+Hotel" rel="stylesheet" type="text/css" />
    <script src="https://kit.fontawesome.com/3434922caa.js"></script>
    <link href="https://pdik.nl/assets/css/login-register.css" rel="stylesheet" />
</head>

<body>
    <div style="overflow:scroll; height:250;">
        <center>
            <table class="">
                <thead>
                    <tr>
                        <th>Nieuwtjes</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                    while ($nieuw = mysqli_fetch_array($resultaatNieuw)) {
                        echo "<tr>";
                        echo "<td>Title: " . $nieuw['title'] . "</td><br>";
                        echo "</tr>";
                        echo "<tr>";
                        echo "<td>Beschrijving: " . $nieuw['beschrijving'] . "</td>";
                        echo "</tr>";
                        echo "<br>";
                    }
                    ?>
                </tbody>
            </table>
        </center>
    </div>
    <br><br>
    <center>
        <form method="post" action="invoice.php" accept-charset="UTF-8">
            <label>Bekijk jouw factuur</label><br>
            <input id="klantnummer" class="form-control" type="text" placeholder="klantnummer" name="klantnummer"><br>
            <input class="btn btn-default btn-login" type="submit" id="login" value="Bekijk">
        </form>

        <div class="modal fade login" id="loginModal">
            <div class="modal-dialog login animated">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h4 class="modal-title">Login met</h4>
                    </div>
                    <div class="modal-body">
                        <div class="box">
                            <div class="content">
                                <div class="social">
                                    <a class="circle github" href="#">
                                        <i class="fab fa-github"></i>
                                    </a>
                                    <a id="google_login" class="circle google" href="#">
                                        <i class="fab fa-github"></i>
                                    </a>
                                    <a id="facebook_login" class="circle facebook" href="#">
                                        <i class="fab fa-facebook"></i>
                                    </a>
                                </div>
                                <div class="division">
                                    <div class="line l"></div>
                                    <span>of</span>
                                    <div class="line r"></div>
                                </div>
                                <div class="error"></div>
                                <div class="form loginBox">
                                    <form method="post" action="" accept-charset="UTF-8">
                                        <input id="naam" class="form-control" type="text" placeholder="Werknemer naam" name="naam">
                                        <input id="wachtwoord" class="form-control" type="password" placeholder="Wachtwoord" name="wachtwoord">
                                        <input class="btn btn-default btn-login" type="submit" id="login" value="Login">
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </center>
</body>

</html>