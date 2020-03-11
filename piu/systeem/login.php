<!DOCTYPE html>
<!--PHP  User system by Pdik Systems (https://pdik.nl) -->
<?php
include('load.php');
session_start();
$error = "";
if ($_POST['username']) {

    $gebruiker = new user;

    $u = $_POST['username'];
    $p = $_POST['user_password'];

    if ($gebruiker->login($u, $p)) {
?>
        <script src="js/detectmobile.js"></script>
<?php
        header("Location: modals/mobile/main.php");
    } else {
        $error = "<div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">
        <strong>Holy guacamole!</strong> Uw wachtwoord of gebruikers naam is incorrect
        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">
          <span aria-hidden=\"true\">&times;</span>
        </button>
      </div>";
    }
}
?>
<html lang="nl">

<head>
    <title>Mijn Mobox</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="/vendor/bootstrap/css/bootstrap.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="/assets/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="/assets/fonts/iconic/css/material-design-iconic-font.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="/vendor/animate/animate.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="/vendor/css-hamburgers/hamburgers.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="/vendor/animsition/css/animsition.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="/vendor/select2/select2.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="/vendor/daterangepicker/daterangepicker.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="/assets/css/login/util.css">
    <link rel="stylesheet" type="text/css" href="/assets/css/login/main.css">
    <!--===============================================================================================-->
    <link href="https://fonts.googleapis.com/css?family=Poppins:400,500,700&display=swap" rel="stylesheet">
    <!--===============================================================================================-->
</head>

<body>
    <div class="container-login100" style="background-image: url('https://www.mobox.nl/wp-content/uploads/2019/11/moboxmobiel.jpg');">

        <div class="wrap-login100 p-l-55 p-r-55 p-t-80 p-b-30">

            <form class="login100-form validate-form" method="POST" action="">
                <?php
                if ($error > "") {
                    echo $error;
                } ?>
                <span class="login100-form-title p-b-37" style="font-family: 'Poppins', sans-serif; font-weight:bold; font-size:35px;">
                    <img src="https://www.mobox.nl/wp-content/uploads/2019/03/logo-mobox.svg"><br>
                    Asset login
                </span>

                <div class="wrap-input100 validate-input m-b-20" style="font-family: 'Poppins', sans-serif;" data-validate="Voer een gebruikers naam in">
                    <input class="input100" type="text" name="username" style="font-family: 'Poppins', sans-serif;" placeholder="Gebruikers naam of email">
                    <span class="focus-input100"></span>
                </div>

                <div class="wrap-input100 validate-input m-b-25" style="font-family: 'Poppins', sans-serif;" data-validate="Voer je wachtwoord in">
                    <input class="input100" type="password" name="user_password" style="font-family: 'Poppins', sans-serif;" placeholder="Wachtwoord">
                    <span class="focus-input100"></span>
                </div>

                <div class="container-login100-form-btn">
                    <button type="submit" value="Login" style="font-family: 'Poppins', sans-serif; font-weight:bold;" name="submit" class="login100-form-btn">
                        Login
                    </button>
                </div>

                <div class="text-center p-t-57 p-b-20">
                    <span class="txt1">
                        Vragen?
                    </span>
                </div>

                <div class="flex-c p-b-112">

                    <a href="mailto:info@mobox.nl?SUBJECT=vraag over mijn mobox" class="login100-social-item">
                        <img src=" assets/img/question.svg" alt="Support Pdik">
                    </a>
                </div>

                <div class="text-center">
                    <a href="https://pdik.nl" class="txt2 hov1">
                        Powerd By Pdik systems
                    </a>
                </div>
            </form>


        </div>
    </div>




    <!--===============================================================================================-->
    <script src="/vendor/jquery/jquery-3.2.1.min.js"></script>
    <!--===============================================================================================-->
    <script src="/vendor/animsition/js/animsition.min.js"></script>
    <!--===============================================================================================-->
    <script src="/vendor/bootstrap/js/popper.js"></script>
    <script src="/vendor/bootstrap/js/bootstrap.min.js"></script>
    <!--===============================================================================================-->
    <script src="/vendor/select2/select2.min.js"></script>
    <!--===============================================================================================-->
    <script src="/vendor/daterangepicker/moment.min.js"></script>
    <script src="/vendor/daterangepicker/daterangepicker.js"></script>
    <!--===============================================================================================-->
    <script src="/vendor/countdowntime/countdowntime.js"></script>
    <!--===============================================================================================-->
    <script src="/assets/js/login/main.js"></script>

</body>

<?php
?>

</html>