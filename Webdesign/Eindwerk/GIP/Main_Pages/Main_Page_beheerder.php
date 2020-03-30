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
    <link rel="stylesheet" type="text/css" href="../css/Main_Style.css"> 
    <title>main_page_beheerder</title>
</head>
<body>
<header>
    <p>Welkom Beheerder</p>
        <ul class="main-nav">
            <li><a href="#">Nav1</a></li>
            <li><a href="#">Nav2</a></li>
            <li><a href="#">Nav3</a></li>
        </ul>
    </header>

    <main>

    </main>
</body>
</html>