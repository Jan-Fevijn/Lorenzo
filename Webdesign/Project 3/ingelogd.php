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

function myFunction0() {
  var x = document.getElementById("myBtn0").value;
  document.getElementById("text").innerHTML = x;
}
function myFunction1() {
  var x = document.getElementById("myBtn1").value;
  document.getElementById("text").innerHTML = x;
}
function myFunction2() {
  var x = document.getElementById("myBtn2").value;
  document.getElementById("text").innerHTML = x;
}
function myFunction3() {
  var x = document.getElementById("myBtn3").value;
  document.getElementById("text").innerHTML = x;
}
function myFunction4() {
  var x = document.getElementById("myBtn4").value;
  document.getElementById("text").innerHTML = x;
}
function myFunction5() {
  var x = document.getElementById("myBtn5").value;
  document.getElementById("text").innerHTML = x;
}
function myFunction6() {
  var x = document.getElementById("myBtn6").value;
  document.getElementById("text").innerHTML = x;
}
function myFunction7() {
  var x = document.getElementById("myBtn7").value;
  document.getElementById("text").innerHTML = x;
}
function myFunction8() {
  var x = document.getElementById("myBtn8").value;
  document.getElementById("text").innerHTML = x;
}
function myFunction9() {
  var x = document.getElementById("myBtn9").value;
  document.getElementById("text").innerHTML = x;
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


?>
</br>
</br>

</br>
</br>

<?php
$sql = "SELECT idklant, saldo FROM saldo";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    echo "<table><tr><th>idklant</th><th>saldo</th></tr>";
    // output data of each row
    while($row = $result->fetch_assoc()) {
        echo "<tr><td>" . $row["idklant"]. "</td><td>" . $row["saldo"]. "</td></tr>";
    }
    echo "</table>";
} else {
    echo "0 results";
}

$conn->close();
?>
</br>
</br>
<h2>Maak uw keuze</h2>
<input type="button" onclick="myFunction0()" id="myBtn0" value="0">
<input type="button" onclick="myFunction1()" id="myBtn1" value="1">
<input type="button" onclick="myFunction2()" id="myBtn2" value="2">
<input type="button" onclick="myFunction3()" id="myBtn3" value="3">
<input type="button" onclick="myFunction4()" id="myBtn4" value="4">
<input type="button" onclick="myFunction5()" id="myBtn5" value="5">
<input type="button" onclick="myFunction6()" id="myBtn6" value="6">
<input type="button" onclick="myFunction7()" id="myBtn7" value="7">
<input type="button" onclick="myFunction8()" id="myBtn8" value="8">
<input type="button" onclick="myFunction9()" id="myBtn9" value="9">

<p id="text"></p>
</body>
</html>