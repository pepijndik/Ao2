<?php
// SHow errors 
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);

//Load the config File 

require_once('PHPMailer/config.php');
require_once("functions.php");

//Set Required parameters
$smtp = array(
    'debug'    => 4,
    'host'     => 'smtp.office365.com',
    'auth'     => true,
    'username' => SMTP_USER,
    'password' => SMTP_PASS,
    'secure'   => 'tls',
    'port'     => 587
);
$to = array(
    array(
        'name' => 'Pepijn dik',
        'email' => 'pepijn@pdik.nl'
    ),
);
$subject = 'Test';
$html = '<h3>THIS is a title.</h3><p> this is some text.</p>';
$from = array('name' => 'sales Mobox', 'email' => 'sales@mobox.nl'); //make sure this email exists!

//Create a new instace and send the email 

$PDIKmailer = new PDIKMailer(true, $smtp);
$PDIKmailer->mail($to, $subject, $html, $from);
