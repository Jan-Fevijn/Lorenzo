<?php 
session_start();
// DB CONNECTIE
$servername = "127.0.0.1";
$username = "root";
$password = "usbw";
$dbname = "gip";

$foutclass = "";
$foutster = "";
// Maak je connectie
$conn = new mysqli($servername, $username, $password, $dbname);
$debug = false;
// controle van je connectie
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

function checkLogIn() {
    if ($_SESSION["loggedIn"] == TRUE) {
        header("location: Main_Page_beheerder.php");
    } else {
        header("location: index.php");
    }
}
checkLogIn();

if ($_SERVER["REQUEST_METHOD"] == "POST") {

    // Controle op invoer
    
    if (isset($_POST["Gebruikersnaam"]) && isset($_POST["Wachtwoord"]) && !empty($_POST["Gebruikersnaam"]) && 
        !empty($_POST["Wachtwoord"])){
            
            // controle gbr en ww + guery maken
            $gbr = $_POST["Gebruikersnaam"];
            $ww = $_POST["Wachtwoord"];
            $sql_controleBeheerder = "SELECT id, gbr, ww FROM gebruiker WHERE gbr = '" . $gbr . "' and ww = '" . $ww . "'";
            $sql_controleGebruiker = "SELECT id, gbr, ww FROM gebruiker WHERE gbr = '" . $gbr . "' and ww = '" . $ww . "'";
            $resultaat = mysqli_query($conn,$sql_controleGebruiker);
            $result = mysqli_query($conn,$sql_controleBeheerder);
            if ($row = mysqli_fetch_assoc($resultaat)){
                echo $row["id"];
                $_SESSION["loggedIn"] = TRUE;
                $_SESSION["loginID"] = $row["id"];

            

                //check login 
                if ($_SESSION["loggedIn"] == TRUE) {
                    header("location: Main_Page_beheerder.php");
                } else {
                    header("location: index.php");
                }
            }else{
                $_SESSION["loggedIn"] = FALSE;
                checkLogIn();
                //header('location: index.php?fout=gebruiker niet gevonden of foutief wachtwoord.');
            }

}}



?>