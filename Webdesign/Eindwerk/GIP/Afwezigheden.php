<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Afwezigheden</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.7.1/css/bootstrap-datepicker3.css" rel="stylesheet" id="bootstrap-css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    
   
</head>

<style>

.topnavigation {
    background-color: #333;
    overflow: hidden;
  }
  
  /* Style the links inside the navigation bar */
  .topnavigation a {
    float: right;
    color: #f2f2f2;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
    font-size: 17px;
  }
  
  /* Change the color of links on hover */
  .topnavigation a:hover {
    background-color: orange;
    color: black;
  }
  
  /* Add a color to the active/current link */
  .topnavigation a.active {
    background-color: #4CAF50;
    color: white;
  }

  .container {
  background-color: orange;
  width: 500px;
  border: 15px solid black;
  padding: 50px;
  margin: 20px;
  position: absolute; 
  left:25%;
  margin-left:-225px;
  top:25%;
  box-shadow: 5px 10px;
}

</style>
<div class="topnavigation">
       
            <a href="Main_Page_beheerder.php">Home</a>
            <a href="registreren.php">Registreren</a>
            <a href="index.php">Afmelden</a>
        
    
</div><body>


   <h1 align="center">Afwezige leerlingen aanduiden</h1> 

 

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
 

<label for="klas">Kies een klas:</label>

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
    </div>

    
<?php


$leerlingen = 
// API Platform and key
$platform = "kaas-sgr25.smartschool.be";
$webservicepwd = "5f672179d26822463055";

try {
    // Dit heb je nodig om externe entitieiten te ontvangen
    libxml_disable_entity_loader(false);
    $soap = new SoapClient('https://'.$platform.'/Webservices/V3?wsdl', ['cache_wsdl' => WSDL_CACHE_NONE]);
    // Webservice Call

    //mixed getAllAccounts (string $accesscode, string $code, string $recursive) 
    $result = $soap->getAllAccounts($webservicepwd, 'officlass_pwd59a8728b67844', '1'); //officlass_pwd5b8d201fcf1be
    // de string dat je mee krijgt is veel te groot om in 1 keer te decoderen dus moet je het in stukjes doen
    // Daarna de string weer samenvoegen zodat je een complete xml bestand hebt

    $decoded = '';
    for ($i=0; $i < ceil(strlen($result)/256); $i++) { 
        $decoded = $decoded . base64_decode(substr($result,$i*256,256));
    }

    // je moet het xml object als simplexml gebruiken om er iets mee te kunnen doen
    $decoded = simplexml_load_string($decoded);
    
   // Alle gebruikers van smartschool in een lijst van gebruikers zetten
    foreach ($decoded->account as $extraInfo) {
        echo $extraInfo->gebruikersnaam . "<br>";
    }
     
} catch (\Exception $e) {
    echo $e;
}
?>
</select>
 

</body>
</html>