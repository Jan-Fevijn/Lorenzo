<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    session_unset();
    session_destroy();
    header("location: index.php");
}

?>
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
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<style>
header{
    background-color: rgba;
    text-align: right;
    padding: 15px;
}
header ul{
    display: inline-block;
}
header li{
    display: inline-block;
    margin-right: 70px;

}

header ul li a{
    text-decoration: none;
    color: black;
}




</style>
<body>
<h1>WELKOM</h1>
<header>
    
    <ul>
        <li><a href="index.php">Afmelden</a></li>
    </ul>
</header>

    
</body>
</html>