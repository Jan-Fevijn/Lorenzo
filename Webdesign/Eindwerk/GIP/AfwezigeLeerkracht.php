<!DOCTYPE html>
<html lang="en">
<head>

<script src="jquery/jquery-3.4.1.min"></script>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.7.1/css/bootstrap-datepicker3.css" rel="stylesheet" id="bootstrap-css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title>Document</title>
    
</head>

<?php 
session_start();
// DB CONNECTIE
$servername = "127.0.0.1";
$username = "root";
$password = "usbw";
$dbname = "gip";

$foutclass = "";
$foutster = "";
// Maak je connectie
$conn = new mysqli($servername, $username, $password, $dbname);
$debug = false;
// controle van je connectie
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 
$result = $conn->query("select volledig from leerkracht");
?>

<body>
    <h1 align="center">Afwezige leerkracht invoegen</h1>
    <div class="container">
		<div class="row">
			<h2>Datum</h2>
		</div>
		<div class="row">
	        <div class='col-sm-6'>
	        	<form>
		            <div class="form-group">
		                <div class='input-group date' id='datepicker'>
		                    <input type='text' class="form-control" />
		                    <span class="input-group-addon">
		                        <span class="glyphicon glyphicon-calendar"></span>
		                    </span>
		                </div>
		            </div>
		        </form>
	        </div>
	    </div>
	</div>
	<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.7.1/js/bootstrap-datepicker.min.js"></script>
	<script >
	    $(function () {
	        $('#datepicker').datepicker({
	            format: "dd/mm/yyyy",
	            autoclose: true,
	            todayHighlight: true,
		        showOtherMonths: true,
		        selectOtherMonths: true,
		        autoclose: true,
		        changeMonth: true,
		        changeYear: true,
		        orientation: "button"
	        });
	    });
	</script>
 
 <label for="leerkracht">Kies een leerkracht:</label>

<select name="leerkracht">
  <?php
  while ($rows = $result->fetch_assoc())
 
  echo "<option value='$rows'>" . $rows['volledig'] . "</option>";
  ?>
</select>

</body>
</html>