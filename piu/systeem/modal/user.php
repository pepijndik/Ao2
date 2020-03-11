<?php
require('db.php');


class user
{
    private $gebruiker_id, $email;
    public function login($u, $wachtwoord)
    {
        $db = new db(DB_HOST, DB_user, DB_PASS, DB_base);
        $account = $db->query('SELECT * FROM gebruiker where email = ? and wachtwoord = ?', $u, md5($wachtwoord));
        $rows = $account->numRows();
        if ($rows == 1) {
            $_SESSION['username'] = $u;
            return true;
        } else {
            return false;
        }
    }
}
