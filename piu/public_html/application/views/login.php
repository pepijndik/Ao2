<!DOCTYPE html>
<html>

<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Asset beheer | Login</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">


  <!--=================Login Css=================================-->

  <link rel="stylesheet" type="text/css" href="<?php echo base_url('assets/css/login/util.css') ?>">

  <link rel="stylesheet" type="text/css" href="<?php echo base_url('assets/css/login/main.css') ?>">

  <!--===============================================================================================-->

  <link href="https://fonts.googleapis.com/css?family=Poppins:400,500,700&display=swap" rel="stylesheet">

  <!--===============================================================================================-->


  <link rel="stylesheet" href="<?php echo base_url('assets/bower_components/bootstrap/dist/css/bootstrap.min.css') ?>">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="<?php echo base_url('assets/bower_components/font-awesome/css/font-awesome.min.css') ?>">
  <!-- Ionicons -->
  <link rel="stylesheet" href="<?php echo base_url('assets/bower_components/Ionicons/css/ionicons.min.css') ?>">
  <!-- Theme style -->
  <link rel="stylesheet" href="<?php echo base_url('assets/dist/css/AdminLTE.min.css') ?>">
  <!-- iCheck -->
  <link rel="stylesheet" href="<?php echo base_url('assets/plugins/iCheck/square/blue.css') ?>">

  <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">

</head>

<body class="hold-transition login-page">


  <div class="container-login100" style="background-image: url('');">

    <div class="wrap-login100 p-l-55 p-r-55 p-t-80 p-b-30">



      <form class="login100-form validate-form" method="POST" action="<?php echo base_url('auth/login') ?>">
        <?php echo validation_errors(); ?>
        <?php if (!empty($errors)) {
          echo $errors;
        } ?>
        <!-- <?php if (!empty($login_error['password']) || !empty($login_error['login'])) { ?>

          <br /><br />

          <div class="alert alert-warning alert-dismissible fade show" role="alert"> <strong>Holy guacamole!</strong> Uw wachtwoord of gebruikers naam is incorrect

            <button type="button" class="close" data-dismiss="alert" aria-label="Close">

              <span aria-hidden="true">&times;</span>

            </button>

          </div>

        <?php } ?> -->

        <span class="login100-form-title p-b-37" style="font-family: 'Poppins', sans-serif; font-weight:bold; font-size:35px;">

          <img src="/assets/images/nova-college.png"><br>

          Login

        </span>



        <div class="wrap-input100 validate-input m-b-20" style="font-family: 'Poppins', sans-serif;" data-validate="Voer een Email in">

          <input class="input100" type="text" name="email" style="font-family: 'Poppins', sans-serif;" placeholder="email">

          <span class="focus-input100"></span>



        </div>



        <div class="wrap-input100 validate-input m-b-25" style="font-family: 'Poppins', sans-serif;" data-validate="Voer je wachtwoord in">

          <input class="input100" type="password" name="password" style="font-family: 'Poppins', sans-serif;" placeholder="Wachtwoord">

          <span class="focus-input100"></span>
          <div class="col-xs-8">
            <div class="checkbox icheck">
              <label>
                <input type="checkbox"> Onthoud wachtwoord
              </label>
            </div>
          </div>

        </div>



        <div class="container-login100-form-btn">

          <button type="submit" name="enter" value="Login" style="font-family: 'Poppins', sans-serif; font-weight:bold;" name="submit" class="login100-form-btn">

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


  <!-- jQuery 3 -->

  <script src="<?php echo base_url('assets/bower_components/jquery/dist/jquery.min.js') ?>"></script>
  <!-- Bootstrap 3.3.7 -->
  <script src="<?php echo base_url('assets/bower_components/bootstrap/dist/js/bootstrap.min.js') ?>"></script>
  <!-- iCheck -->
  <script src="<?php echo base_url('assets/plugins/iCheck/icheck.min.js') ?>"></script>
  <script>
    $(function() {
      $('input').iCheck({
        checkboxClass: 'icheckbox_square-blue',
        radioClass: 'iradio_square-blue',
        increaseArea: '20%' // optional
      });
    });
  </script>
</body>

</html>