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
$result = $conn->query("select volledig from leerkracht");
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="../css/reset.css"> 
    <link rel="stylesheet" type="text/css" href="css/Main_Style.css">
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.7.1/css/bootstrap-datepicker3.css" rel="stylesheet" id="bootstrap-css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="js/script.js"></script>
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






<h2 align="center">Afwezige leerkracht</h2>


</br>
</br>
   
  

    <div class="container">
		<div class="row">
		
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
	</div><script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.7.1/js/bootstrap-datepicker.min.js"></script>
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


    <select id="leerkrachtopties">
  <?php
  while ($rows = $result->fetch_assoc())
 
  echo "<option value='$rows'>" . $rows['volledig'] . "</option>";
  ?>
</select>

    </br>
    <input type="text" name="leerkracht" id="leerkrachttextbox" readonly="readonly">
    <script>
     function leerkracht()
     {
         var d = document.getElementById("leerkrachtleerkrachtopties");
         var displaytext = d.options[d.selectedIndex].text;
         document.getElementById("leerkrachttextbox").value = displaytext;
     }
  </script>
 
    </br>


<select id="klas">
  <option value="officlass_pwd5e1c36e886f65">1Aa</option>
  <option value="officlass_pwd5e1db362603dd">1Ab</option>
  <option value="officlass_pwd5d887a425f221">1bso</option>
  <option value="officlass_pwd59a8728b67844">2Aa</option>
  <option value="officlass_pwd59a8728a6e994">2Ab</option>
  <option value="officlass_pwd59a8728cc6fe9">2Ac</option>
  <option value="officlass_pwd59a872890644c">2Ad</option>
  <option value="officlass_pwd59a872b17aeb1">3Econ</option>
  <option value="officlass_pwd59a872a9a3fa6">3HuWe</option>
  <option value="officlass_pwd59a872b3c4bcb">3La</option>
  <option value="officlass_pwd59a872b500e1f">3We</option>
  <option value="officlass_pwd59a872f2b70be">4Econ</option>
  <option value="officlass_pwd57c6ea167191c">4Hand</option>
  <option value="officlass_pwd59a872beb486e">4HuWe</option>
  <option value="officlass_pwd59a872bd4eaeb">4La</option>
  <option value="officlass_pwd59a872a7920a0">4We</option>
  <option value="officlass_pwd59a872bde9b87">5EcMt</option>
  <option value="officlass_pwd59a872d3d1005">5EcWe</option>
  <option value="officlass_pwd59a872bd34a99">5EcWi</option>
  <option value="officlass_pwd59a872b59851d">5HuWe</option>
  <option value="officlass_pwd5b8d200e3e4bd">5ITN</option>
  <option value="officlass_pwd57c6e9f178c06">5JHZ</option>
  <option value="officlass_pwd59ae5eab41ee1">5LaWe</option>
  <option value="officlass_pwd59a872e827fe2">5LaWi</option>
  <option value="officlass_pwd57c6e9e89b288">5STWe</option>
  <option value="officlass_pwd59a872be86b4b">5WeWi</option>
  <option value="officlass_pwd5b8d201c08dbc">6EcMt</option>
  <option value="officlass_pwd59a872a8ddcea">6EcWe</option>
  <option value="officlass_pwd59a872b3020dd">6EcWi</option>
  <option value="officlass_pwd59a872a58a087">6HuWe</option>
  <option value="officlass_pwd5b8d201fcf1be">6ITN</option>
  <option value="officlass_pwd59a872bb24db4">6LaWe</option>
  <option value="officlass_pwd5b9a184200987">6LaWi</option>
  <option value="officlass_pwd57c6e9c9ca15e">6STWe</option>
  <option value="officlass_pwd59a872b09a5a5">6WeWi</option>
  <option value="officlass_pwd5d7f6c557a689">Duaal7Ki</option>
  <option value="officlass_pwd5b8d202ea53ee">7Sales</option>
  

</select>
 
    </br>
    </br>
 
 
 
 
 <select id="lesuur">
  <option value="lesuur1">Lesuur 1</option>
  <option value="lesuur2">Lesuur 2</option>
  <option value="lesuur3">Lesuur 3</option>
  <option value="lesuur4">Lesuur 4</option>
  <option value="lesuur5">Lesuur 5</option>
  <option value="lesuur6">Lesuur 6</option>
  <option value="lesuur7">Lesuur 7</option>
  <option value="lesuur8">Lesuur 8</option>
</select></br></br>
 
  <input type="submit" id="entry" value="Leerkracht toevoegen" >



<table align="center">
    <tr>
        <th>Datum</th>
        <th>leerkracht</th>
        <th>lesuur</th>
        <th>klas</th>
        <th>taak</th>
    </tr>

</table>

    





   
    
</body>
</html>