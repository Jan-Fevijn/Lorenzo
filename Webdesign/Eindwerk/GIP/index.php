
<!DOCTYPE html>
<html lang="en">
<head>
    
<link rel="stylesheet" type="text/css" href="css/styleindex.css">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>index</title>
</head>
<style>
    
   
    body  {
     background-image: url("images/background.jpg");
     background-repeat: no-repeat;
     width:100%;
     height:100%;
     
   }
    
    </style>


<body>

<div id="main">
<h1 align="center">Studielijsten</h1>
<div id="login">
<h2>Log in</h2></br>
<form id="form" action="inloggen.php" method="post">
<label>Gebruikersnaam :</label>
<input id="name" name="Gebruikersnaam" type="text">
<label>Wachtwoord :</label>
<input id="password" name="Wachtwoord" type="password"></br></br>
<a href="reset-password.php">Wachtwoord vergeten?</a>
</br>
</br>
<input name="submit" type="submit" value="Aanmelden">

</form>
<?php

if (isset($_GET["newpwd"])) {
    if ($_GET["newpwd"] == "passwordupdated") {
        echo '<p class="signupsucces">Your password has been reset</p>';
    }
}
?>


</div>
</div>
</body>


</html>