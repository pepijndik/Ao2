<?php

use PHPMailer\PHPMailer\PHPMailer;

require_once('PHPMailer/src/Exception.php');
require_once('PHPMailer/src/PHPMailer.php');
require_once('PHPMailer/src/SMTP.php');
if (!class_exists('PDIKMailer')) {
    class PDIKMailer
    {
        public $mail;

        public function __construct($exceptions = false, $smtp = array())
        {
            $this->mail = new PHPMailer($exceptions);

            //SMTP Setup
            if (!empty($smtp)) {
                $this->mail->SMTPDebug = $smtp['debug']; // Enable Verbose Debug output
                $this->mail->isSMTP();  // Set Mailer to use SMTP
                $this->mail->Host = $smtp['host']; // Specify Main and Backup SMTP Servers 
                $this->mail->SMTPAuth = $smtp['auth'];  // Enable SMTP Authentication
                $this->mail->Username = $smtp['username']; // SMTP username
                $this->mail->Password = $smtp['password']; // SMTP password
                $this->mail->SMTPSecure = $smtp['secure']; // Enable TLS Encryption, 'ssl' also accepted 
                $this->mail->Port = $smtp['port']; //TCP Port to connect to
            }
        }
        public function mail($to = array(), $subject, $html, $from = array(), $plaintext = false, $cc = array(), $bcc = array(), $attachments = array())
        {
            //Required Parameters are $to, $from, $subjects and $html 
            if (empty($to) || empty($from) || empty($subject) || empty($html)) {
                die('Missing a Parameter');
            }

            // Sender 
            $this->mail->setFrom($from['email'], $from['name']);
            $this->mail->addReplyTo($from['email'], $from['name']);

            //Recipients
            if (!empty($to)) {
                foreach ($to as $recipient) {
                    $this->mail->addAddress($recipient['email'], $recipient['name']);
                }
            }
            //CC
            if (!empty($cc)) {
                foreach ($cc as $recipient) {
                    $this->mail->addCC($recipient);
                }
            }
            //BCC
            if (!empty($bcc)) {
                foreach ($bcc as $recipient) {
                    $this->mail->addBCC($recipient);
                }
            }
            // Attachments 
            if (!empty($attachments)) {
                foreach ($attachments as $attachment) {
                    $this->mail->addAttachment($attachment);
                }
            }

            //HTML Mail
            $this->mail->isHTML(true);
            $this->mail->Subject = $subject;
            $this->mail->Body = $html;

            //Plain text Version
            if (false !== $plaintext) {
                $this->mail->AltBody = $plaintext;
            }
            //Send the Mail
            try {
                $this->mail->send();
                echo 'Email verstuurd';
            } catch (Exception $e) {
                echo 'Message could not be sent. Mailer Error:', $this->mail->ErrorInfo;
            }
        }
    }
}
