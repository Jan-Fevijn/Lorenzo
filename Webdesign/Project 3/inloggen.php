<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<h1>Inloggen</h1>



<?php 
session_start();
// DB CONNECTIE
$servername = "127.0.0.1";
$username = "root";
$password = "usbw";
$dbname = "project3";

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
        header("location: ingelogd.php");
    } else {
        header("location: index.php");
    }
}
checkLogIn();

if ($_SERVER["REQUEST_METHOD"] == "POST") {

    // Controle op invoer
    
    if (isset($_POST["Klantencode"]) && !empty($_POST["Klantencode"])){
            
            // controle op klantencode maken
            $code = $_POST["Klantencode"];
            $sql_controleklant = "SELECT idklant, code FROM klant WHERE Klantencode = '" . $code . "' ";
           //echo $sql_controleklant;
           // if ($debug) echo $sql_controleklant;
            $resultaat = mysqli_query($conn,$sql_controleklant);
            if ($row = mysqli_fetch_assoc($resultaat)){
                echo $row["idklant"];
                $_SESSION["loggedIn"] = TRUE;
                $_SESSION["loginID"] = $row["idklant"];
                checkLogIn();

            }else{
                $_SESSION["loggedIn"] = FALSE;
                checkLogIn();
                //header('location: index.php?fout=gebruiker niet gevonden of foutief wachtwoord.');
            }

}}



?>

    
</body>
</html>