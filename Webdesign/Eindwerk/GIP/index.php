
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<style>
body {
    background-color:lightblue;
}
</style>
<body>
    <h1>Inloggen</h1>

    <form action="php/inloggen.php" method="post">
    <label for="psw"><b>Gebruikersnaam</b></label>
    <input type="text" name="Gebruikersnaam"><br>
    <label for="psw"><b>Wachtwoord</b></label>
    <input type="password" name="Wachtwoord">
    <input type="submit" name="verzenden">
    </form>
</body>
</html>