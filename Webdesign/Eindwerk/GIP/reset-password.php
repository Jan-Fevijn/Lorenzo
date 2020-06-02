<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
   <h1> wachtwoord vernieuwen</h1> 
   <p>U krijgt een email met instructies om uw wachtwoord te vernieuwen.</p>

   <form action="reset-request.php" method="post">

   <input type="text" name="email" placeholder="Vul hier uw emailadres in">
   <button type="submit" name="reset-request-submit">wachtwoord vernieuwen</button>
   </form>

   <?php
    if (isset($_GET["reset"])) {
        if ($_GET["reset"] == "succes") {
            echo '<p class="signupsucces">Check your email!</p>';
        }
    }
?>
</body>
</html>