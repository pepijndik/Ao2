<?php
session_start();
require("view/header.php");

use pdik\User as User;
/* user data routine */

$data_error = array();
$data_update = false;
if (isset($_POST['update_data'])) {
	$user['name'] = !empty($_POST['name']) ? $_POST['name'] : '';
	$user['mail'] = !empty($_POST['mail']) ? $_POST['mail'] : '';
	if (User::update($user['id'], $user)) {
		$data_update = true;
	} else {
		$data_error['general'] = implode('<br/>', User::getError());
	}
}

/* login update */
$login_error = array();
$login_update = false;
if (isset($_POST['update_login'])) {
	$login = !empty($_POST['login']) ? $_POST['login'] : '';
	$password = !empty($_POST['password']) ? $_POST['password'] : '';

	$error_flag = false;

	if (empty($login)) {
		/* login is required */
		$login_error['login'] = 'Login is required';
		$error_flag = true;
	}

	if (empty($password)) {
		/* password is required */
		$login_error['password'] = 'Password is required';
		$error_flag = true;
	} else {
		$hash = User::passwordGet($user['id']);
		if (!User::passwordCheck($password, $hash)) {
			$login_error['password'] = 'Wrong password';
			$error_flag = true;
		}
	}

	if (!$error_flag) {
		if (User::loginUpdate($user['id'], $login)) {
			$login_update = true;
			$user['login'] = $login;
		} else {
			$login_error['general'] = implode('<br/>', User::getError());
		}
	}
}

/* password update */
$password_error = array();
$password_update = false;
if (isset($_POST['update_pass'])) {
	$password = !empty($_POST['password']) ? $_POST['password'] : '';
	$password_new = !empty($_POST['password_new']) ? $_POST['password_new'] : '';
	$password_key = !empty($_POST['password_key']) ? $_POST['password_key'] : '';

	$error_flag = false;

	if (empty($password)) {
		/* password is required */
		$password_error['password'] = 'Password is required';
		$error_flag = true;
	} else {
		$hash = User::passwordGet($user['id']);
		if (!User::passwordCheck($password, $hash)) {
			$password_error['password'] = 'Wrong password';
			$error_flag = true;
		}
	}

	if (empty($password_new)) {
		/* password is required */
		$password_error['password_new'] = 'Password is required';
		$error_flag = true;
	} else if ($password_new != $password_key) {
		/* check password key */
		$password_error['password_key'] = 'Passwords do not match';
		$error_flag = true;
	}

	if (!$error_flag) {
		if (User::passwordUpdate($user['id'], $password_new)) {
			$password_update = true;
		} else {
			$password_error['general'] = implode('<br/>', User::getError());
		}
	}
}
?>

<div class="content">
	<div class="container-fluid">
		<div class="row">
			<div class="col-md-8">
				<div class="card">
					<div class="card-header">
						<h4 class="card-title">Uw profiel</h4>
					</div>
					<div class="card-body">
						<form action="" method="post">
							<div class="row">
								<div class="col-md-5 pr-1">
									<div class="form-group">
										<label>Naam</label>
										<input type="text" class="form-control" name="name" placeholder="name" value="<?php echo $user['name']; ?>">
									</div>
									<div class="form-group">
										<label>bedrijf (disabled)</label>
										<input type="text" class="form-control" disabled="" placeholder="Company" value="Novacollege">
									</div>
									<?php if (!empty($data_error['general'])) { ?>
										<br /><br />
										<div class="alert alert-danger" role="alert"><?php echo $data_error['general']; ?></div>
									<?php } ?>
									<?php if (!empty($data_update)) { ?>
										<br /><br />
										<div class="alert alert-success" role="alert">Data saved</div>
									<?php } ?>
								</div>


								<div class="col-md-4 pl-1">
									<div class="form-group">
										<label for="exampleInputEmail1">Email address</label>
										<input type="email" name="mail" class="form-control" value="<?php echo $user['mail']; ?>">
									</div>
								</div>

							</div>
							<button type="submit" name="update_data" class="btn btn-info btn-fill pull-right">Update Profile</button>
						</form>
						<div class="row">

						</div>

						<h2>Update wachtwoord</h2>
						<form action="" method="post">
							<div class="row">
								<div class="col-md-3 pr-1">

									<div class="form-group">
										<label>Oud wachtwoord</label>
										<input type="password" class="form-control" name="password" id="password" placeholder="wachtwoord" value="">
										<?php if (!empty($password_error['password'])) { ?>
											<br />
											<div class="alert alert-danger" role="alert"><?php echo $password_error['password']; ?></div>
										<?php } ?>
									</div>
								</div>
								<div class="col-md-3 pr-1">

									<div class="form-group">
										<label>Wachtwoord</label>
										<input type="password" class="form-control" name="password_new" id="password_new" placeholder="New password" value="">
										<?php if (!empty($password_error['password_new'])) { ?>
											<br />
											<div class="alert alert-danger" role="alert"><?php echo $password_error['password_new']; ?></div>
										<?php } ?>
									</div>
								</div>
								<div class="col-md-3 px-1">
									<div class="form-group">
										<label>Wachtwoord confirm</label>
										<input type="password" class="form-control" name="password_key" placeholder="conirm" value="">
										<?php if (!empty($password_error['password_key'])) { ?>
											<br />
											<div class="alert alert-danger" role="alert"><?php echo $password_error['password_key']; ?></div>
										<?php } ?>
									</div>
								</div>

							</div>
							<?php if (!empty($password_error['general'])) { ?>
								<br /><br />
								<div class="alert alert-danger" role="alert"><?php echo $password_error['general']; ?></div>
							<?php } ?>
							<?php if (!empty($password_update)) { ?>
								<br /><br />
								<div class="alert alert-success" role="alert">Password updated</div>
							<?php } ?>
							<button type="submit" name="update_pass" class="btn btn-info btn-fill pull-right">Update wachtwoord</button>
							<div class="clearfix"></div>
						</form>
					</div>
				</div>
			</div>
			<div class="col-md-4">
				<div class="card card-user">
					<div class="card-image">
						<img src="https://ununsplash.imgix.net/photo-1431578500526-4d9613015464?fit=crop&fm=jpg&h=300&q=75&w=400" alt="...">
					</div>
					<div class="card-body">
						<div class="author">
							<a href="#">
								<img class="avatar border-gray" src="../assets/img/faces/face-3.jpg" alt="...">
								<h5 class="title"><?php echo $user['name'] ?></h5>
							</a>
							<p class="description">
								<?php echo $user['mail']; ?>
							</p>
						</div>

					</div>


				</div>
			</div>
		</div>
	</div>

	<?php
	include("view/footer.php");
	?>