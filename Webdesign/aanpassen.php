<?php
$servername = "localhost";
$username = "root";
$password = "usbw";
$dbname = "playstation";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
echo "Connected successfully";
$result = mysqli_query($conn,"SELECT * FROM spel");

echo "<table border='1'>
<tr>

<th>id</th>
<th>naam</th>
<th>korte inhoud</th>
<th>uitgever</th>
<th>idtype</th>
</tr>";

while($row = mysqli_fetch_array($result))
{
echo "<tr>";

echo "<td>" . $row['idspel'] . "</td>";
echo "<td>" . $row['naam'] . "</td>";
echo "<td>" . $row['korteInhoud'] . "</td>";
echo "<td>" . $row['uitgever'] . "</td>";
echo "<td>" . $row['idtype'] . "</td>";
echo "</tr>";
}
echo "</table>";

mysqli_close($conn);


?>





<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    <script type="text/javascript" src="dist/jquery.tabledit.js"></script>
    <script type="text/javascript" src="custom_table_edit.js"></script>
    <script>
    $(document).ready(function(){
$('#data_table').Tabledit({
deleteButton: false,
editButton: false,
columns: {
identifier: [0, 'id'],
editable: [[1, 'naam']]
},
hideIdentifier: true,
url: 'aanpassen.php'
});
});
</script>
</head>
<body>
<?php

$input = filter_input_array(INPUT_POST);
if ($input['action'] == 'edit') {
$update_field='';
if(isset($input['name'])) {
$update_field.= "name='".$input['name']."'";

if($update_field && $input['id']) {
$sql_query = "UPDATE spel SET $update_field WHERE id='" . $input['id'] . "'";
mysqli_query($conn, $sql_query) or die("database error:". mysqli_error($conn));
}
}
}
?>
</body>
</html>
