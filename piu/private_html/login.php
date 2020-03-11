<!DOCTYPE html>
<!--PHP  User system by Pdik Systems (https://pdik.nl) -->
<?php
session_start();
require('load.php');
use pdik\User as User;
$error = "";

User::init(DB_driver, DB_HOST, DB_base, DB_user,DB_PASS);

/* check current user */
	$user = false;
	if(User::check()) {
		/* redirect to user account */
		header('Location: home.php');
		exit();
    }

    /* default values */
	$login = '';
    
    	/* login routine */
    $login_error = array();
    if(isset($_POST['enter'])) {
		$login = !empty($_POST['username']) ? $_POST['username'] : '';
		$password = !empty($_POST['user_password']) ? $_POST['user_password'] : '';
		$error_flag = false;
		
		if(empty($login)) {
			/* login is required */
			$login_error['login'] = 'Login is required';
			$error_flag = true;
		}
		
		if(empty($password)) {
			/* password is required */
			$login_error['password'] = 'Password is required';
			$error_flag = true;
		}
		
		/* all checks passed */
		if(!$error_flag) {
			if(User::login($login, $password)) {
				/* redirect to user account */
				header('Location: home.php');
				exit();
			}
			else {
				$login_error['general'] = 'Something wrong';
			}
		}
	}

// if ($_POST['username']) {

//     $gebruiker = new user;

//     $u = $_POST['username'];
//     $p = $_POST['user_password'];

//     if ($gebruiker->login($u, $p)) {

//         header("Location: /dashboard.php");
//     } else {
//         $error = "<div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">
//         <strong>Holy guacamole!</strong> Uw wachtwoord of gebruikers naam is incorrect
//         <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">
//           <span aria-hidden=\"true\">&times;</span>
//         </button>
//       </div>";
//     }
// }
?>
<html lang="nl">

<head>
    <title>Beheer</title>
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
    <div class="container-login100" style="background-image: url('');">

        <div class="wrap-login100 p-l-55 p-r-55 p-t-80 p-b-30">

            <form class="login100-form validate-form" method="POST" action="">
              	<?php if(!empty($login_error['password'])|| !empty($login_error['login'])) { ?>
							<br/><br/>
						<div class="alert alert-warning alert-dismissible fade show" role="alert"> <strong>Holy guacamole!</strong> Uw wachtwoord of gebruikers naam is incorrect
        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
           <span aria-hidden="true">&times;</span>
         </button>
       </div>
						<?php } ?>
                <span class="login100-form-title p-b-37" style="font-family: 'Poppins', sans-serif; font-weight:bold; font-size:35px;">
                    <img src="/assets/img/nova-college.png"><br>
                    Login
                </span>

                <div class="wrap-input100 validate-input m-b-20" style="font-family: 'Poppins', sans-serif;" data-validate="Voer een Email in">
                    <input class="input100" type="text" name="username" style="font-family: 'Poppins', sans-serif;" placeholder="email">
                    <span class="focus-input100"></span>
                    
                </div>

                <div class="wrap-input100 validate-input m-b-25" style="font-family: 'Poppins', sans-serif;" data-validate="Voer je wachtwoord in">
                    <input class="input100" type="password" name="user_password" style="font-family: 'Poppins', sans-serif;" placeholder="Wachtwoord">
                    <span class="focus-input100"></span>
                    				
                </div>

                <div class="container-login100-form-btn">
                    <button type="submit" name="enter"value="Login" style="font-family: 'Poppins', sans-serif; font-weight:bold;" name="submit" class="login100-form-btn">
                        Login
                    </button>
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