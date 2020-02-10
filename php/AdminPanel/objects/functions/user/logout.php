<!--PHP login System by Pdik Systems (www.pdik.nl) -->
<?php
session_start();
if (session_destroy($_SESSION['naam'])) {
    header("Location: ../../../index.php");
}

session_unset();
session_destroy();
ob_start();
header("Location: ../../../index.php");
ob_end_flush();

exit();
?>