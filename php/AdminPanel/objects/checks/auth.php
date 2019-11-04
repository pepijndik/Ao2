<?php
session_start();
if (!isset($_SESSION["naam"])) {
    header("Location: objects/pages/notLogin.php");
    exit();
}
