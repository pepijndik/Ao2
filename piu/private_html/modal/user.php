<?php
//Gebruiker class

namespace pdik;

class user
{
 
	/* The ID of the logged in account (or NULL if there is no logged in account) */
	private $id;
	
	/* The name of the logged in account (or NULL if there is no logged in account) */
	private $name;

	/* TRUE if the user is authenticated, FALSE otherwise */
    private $authenticated;
    
    	/* Constructor */
	public function __construct()
	{
		/* Initialize the $id and $name variables to NULL */
		$this->id = NULL;
		$this->name = NULL;
		$this->authenticated = FALSE;
    }

    /* Destructor */
	public function __destruct()
	{
		
	}
    
    //Check if user is logedin
    public function auth(){
        session_start();
        if($this->logedin){

        }else {
              if (!isset($_SESSION["username"])) {
                 header("Location: /login.php");
                 $this->logedin = false;
                exit();
            
        } else {
            $this->logedin = true;
        }
        }
      

    }
    public function login($u, $wachtwoord)
    {
        $db = new db();
        $account = $db->query('SELECT * FROM gebruikers where email = ? and wachtwoord = ? AND actief=1', $u, md5($wachtwoord));
        $rows = $account->numRows();
        if ($rows == 1) {
            $this->email = $u;
            $_SESSION['username'] = $u;
            $this->logedin = true;
            return true;
        } else {
            $this->logedin = false;
            return false;
        }
    } // ENd of login

    public function logout(){
        if(session_destroy())
        {    
            header("Location: /login.php");
        }
    } // End of logout


    //verify account Special key in email
    public function verify($key, $id){
        $db = new db(DB_HOST, DB_user, DB_PASS, DB_base);
        $verify = $db->query("SELECT * FROM `gebruikers` WHERE gebruiker_id=$id AND verification_key='$key' AND active=0");
         $rows = $verify->numRows();
         if($rows == 1){
             $usql = "UPDATE `gebruikers` SET active=1 WHERE gebruiker_id=$id";
             $ures = $db->query($usql);
             if($ures){
                 return true;
                 $smg = "Account Activated Successfully";
                }
                else{
                    return false;
                    $fmsg = "Account Activation failed, contact support";
                }
         }else{
             return false;
             $fmsg = "key not found in db";
            }
        } // End of Verify Function

        public function get_email(){
            return $this->email;
        }
        public function get_id(){
            return $this->gebruiker_id;
        }

        public function get_logedin(){
            return $this->logedin;
        }
} // End of class
