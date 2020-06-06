<!DOCTYPE html>
<html lang="en">
<head>
<link rel="stylesheet" type="text/css" href="css/stijlregistreren.css">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<?php
include("conn.php");
?>




<?php
if (isset($_POST["gbr"]) && isset($_POST["ww"]) && !empty($_POST["gbr"]) && 
!empty($_POST["ww"]) && !empty($_POST["wwconfirm"]) && !empty($_POST["wwconfirm"])){

     $gbr = $_POST['gbr'];
     $ww = $_POST['ww'];
     $wwconfirm = $_POST['wwconfirm'];

     if ($ww !== $wwconfirm) {
        die('Uw wachtwoorden komen niet overeen!
        Keer terug om opnieuw te proberen');
        
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






?>
<style>
  .form {
  background-color: orange;
  width: 300px;
  border: 15px solid black;
  padding: 50px;
  margin: 20px;
  position: absolute; 
  left:50%;
  margin-left:-225px;
  top:25%;
  box-shadow: 5px 10px;
}

.topnav {
    background-color: #333;
    overflow: hidden;
    width:100%;
    top:0px;
    position:absolute;
  }
  
  /* Style the links inside the navigation bar */
  .topnav a {
    float: right;
    color: #f2f2f2;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
    font-size: 17px;
  }
  
  /* Change the color of links on hover */
  .topnav a:hover {
    background-color: orange;
    color: black;
  }
  
  /* Add a color to the active/current link */
  .topnav a.active {
    background-color: #4CAF50;
    color: white;
  }

</style>
<body>
<div class="topnav">
            <img src="images/banner.png" height="75px" width="200px">
            <a href="Afwezigheden.php">Afwezigheidslijst</a>
            <a href="Main_Page_beheerder.php">Home</a>
            <a href="index.php">Afmelden</a>
        
    
</div>


  <div class="form">
    <h1>Registreren</h1>

<form action="registreren.php" method="post">
Gebruikersnaam: <input type="text" name="gbr"><br>
Wachtwoord: <input type="password" name="ww"><br>
Wachtwoord herhalen <input type= "password" name="wwconfirm"><br>
<input type="submit" value="registreren">
</form>

</div>
</body>
</html>