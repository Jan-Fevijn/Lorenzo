<?php



include ("conn.php");


$sql = "SELECT * FROM leerkracht";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
  // output data of each row
  while($row = $result->fetch_assoc()) {
    echo "Insert into leerkracht (volledig, naam, voornaam, code) VALUES ('" . $row["volledig"] . "', '" . $row["naam"]. "', '" . $row["voornaam"] . "', '" . $row["code"]. "');" . "</br>";
  }
} else {
  echo "0 results";
}
$conn->close();
?>

