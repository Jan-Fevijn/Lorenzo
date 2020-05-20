<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    session_unset();
    session_destroy();
    header("location: index.php");
}

?>

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

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="../css/reset.css"> 
    <link rel="stylesheet" type="text/css" href="css/Main_Style.css">
    <script src="jquery-3.5.1.min.js"></script>
    <title>main_page_beheerder</title>
</head>
<body>
<header>
    <p>Welkom</p>
        <ul class="main-nav">
            <li><a href="Afwezigheden.php">Afwezigheidslijst</a></li>
            <li><a href="registreren.php">Registreren</a></li>
            <li><a href="AfwezigeLeerkracht.php">Afwezige leerkracht bijvoegen</a></li>
            <li><a href="index.php">Afmelden</a></li>
        </ul>
    </header>




   
    
</body>
</html>