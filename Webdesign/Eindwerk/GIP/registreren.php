<!DOCTYPE html>
<html lang="en">
<head>
<link rel="stylesheet" type="text/css" href="css/stijlregistreren.css">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<?php
$servername = "localhost";
$username = "root";
$password = "usbw";
$dbname = "gip";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
?>




<?php
if (isset($_POST["gbr"]) && isset($_POST["ww"]) && !empty($_POST["gbr"]) && 
!empty($_POST["ww"]) && !empty($_POST["wwconfirm"]) && !empty($_POST["wwconfirm"])){

     $gbr = $_POST['gbr'];
     $ww = $_POST['ww'];
     $wwconfirm = $_POST['wwconfirm'];

     if ($ww !== $wwconfirm) {
        die('password and Confirm password should match!');   
     }
    
     $sql = "INSERT INTO gebruiker (gbr,ww,wwconfirm)
     VALUES ('$gbr','$ww','$wwconfirm')";
 
     if (mysqli_query($conn, $sql)) {
        echo "Nieuwe gebruiker aangemaakt!";
     } else {
        echo "Error: " . $sql . ":-" . mysqli_error($conn);
     }
     mysqli_close($conn);
}



if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (empty($_POST["gbr"])) {
      $nameErr = "Name is required";
    } else {
      $name = test_input($_POST["gbr"]);
    }}


?>
<body>
    <h1>Registreren</h1>

<form action="registreren.php" method="post">
Gebruikersnaam: <input type="text" name="gbr"><br>
Wachtwoord: <input type="password" name="ww"><br>
Wachtwoord herhalen <input type= "password" name="wwconfirm"><br>
<input type="submit" value="registreren">
</form>

</body>
</html>