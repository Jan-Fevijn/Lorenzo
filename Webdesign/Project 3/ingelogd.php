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
<link rel="stylesheet" href="css/style.css">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <script>

        var exp = '', number, decimal, equal, operator, allowSR = true;
        var textview = document.forms['myform']['textview'];

        function insertNum(num){
            if (equal){
                exp = num;
                textview.value = exp;
                number = true;
                equal = false;
            }
            else{
                exp = textview.value + num;
                textview.value = exp;
                number = true;
            }
            id (operator) decimal = false;
        }
    </script>
</head>

<body>

<header>

    <ul>
        <li><a href="index.php">Afmelden</a></li>
    </ul>
</header>

<h1>WELKOM BIJ JE FAVORIETE BAKKER</h1>
<?php
$sql = "SELECT broodnaam, kostprijs, AantalIn, positie FROM opties";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    echo "<table><tr><th>Naam van het brood</th><th>kostprijs in €</th><th>Aantal stuks in het automaat</th><th>positie</th></tr>";
    // output data of each row
    while($row = $result->fetch_assoc()) {
        echo "<tr><td>" . $row["broodnaam"]. "</td><td>" . $row["kostprijs"]. "</td><td>" . $row["AantalIn"]. "</td><td>" . $row["positie"]. "</th></tr>";
    }
    echo "</table>";
} else {
    echo "0 results";
}

$conn->close();
?>
</br>
</br>

</br>
</br>

<?php
$sql = "SELECT naam, saldo FROM saldovanklant";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    echo "<table><tr><th>Naam van de klant</th><th>saldo</th></tr>";
    // output data of each row
    while($row = $result->fetch_assoc()) {
        echo "<tr><td>" . $row["naam"]. "</td><td>" . $row["saldo"]. "</td></tr>";
    }
    echo "</table>";
} else {
    echo "0 results";
}

$conn->close();
?>


<table class="automaat">
    <form name="myform">
    <input type="text" name="textview" disabled>
    </form>
    
    <tr>
    
        <td><input type="button" onclick="insertNum(0)" class="button" value="0"></td>
    </tr>
    <tr>
        <td><input type="button" onclick="insertNum(1)" class="button" value="1"></td>
        <td><input type="button" onclick="insertNum(2)" class="button" value="2"></td>
        <td><input type="button" onclick="insertNum(3)" class="button" value="3"></td>
    </tr>
    <tr>
        <td><input type="button" onclick="insertNum(4)" class="button" value="4"></td>
        <td><input type="button" onclick="insertNum(5)" class="button" value="5"></td>
        <td><input type="button" onclick="insertNum(6)" class="button" value="6"></td>
    </tr>

    <tr>
        <td><input type="button" onclick="insertNum(7)" class="button" value="7"></td>
        <td><input type="button" onclick="insertNum(8)" class="button" value="8"></td>
        <td><input type="button" onclick="insertNum(9)" class="button" value="9"></td>
    </tr>

</table>
<img src="images\brood.jpg" width="500" height="300" > 
</body>
</html>