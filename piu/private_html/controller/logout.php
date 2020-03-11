<!--PHP login System by Pdik Systems (https://pdik.nl) -->
<?php
session_start();
if(session_destroy())
{    
header("Location: /login.php");
}
?>