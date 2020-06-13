<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    session_unset();
    session_destroy();
    header("location: index.php");
}

?>

<?php
include("conn.php");
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
    <script src="https://code.jquery.com/jquery-1.12.4.min.js"></script>
    <title>main_page_beheerder</title>
    <script>
    
    
        
    </script>
    
</head>
<style>
   .topnav {
    background-color: #333;
    overflow: hidden;
  }
  
  /* Style the links inside the navigation bar */
  .topnav a {
    float: right;
    color: #f2f2f2;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
    font-size: 17px;
  }
  
  /* Change the color of links on hover */
  .topnav a:hover {
    background-color: orange;
    color: black;
  }
  
  /* Add a color to the active/current link */
  .topnav a.active {
    background-color: #4CAF50;
    color: white;
  }


  .box {
  background-color: orange;
  width: 650px;
  border: 15px solid black;
  padding: 50px;
  margin: 20px;
  position: absolute; 
  left:25%;
  margin-left:-225px;
  top:20%;
  box-shadow: 5px 10px;
}



#table {
  background-color: orange;
  width: 600px;
  border: 15px solid black;
  padding: 50px;
  margin: 20px;
  position: absolute; 
  right:15%;
  margin-right:-225px;
  top:20%;
  box-shadow: 5px 10px;
  
}

</style>
<body>

    
<div class="topnav">
            <img src="images/banner.png" height="75px" width="200px">
            <a href="Afwezigheden.php">Afwezigheidslijst</a>
            <a href="registreren.php">Registreren</a>
            <a href="index.php">Afmelden</a>
        
    
</div>

<h1 align="center">Welkom</h1>
<script>
    function ddlselect4()
    {
        var d=document.getElementById("dag");
        var displaytext = d.options[d.selectedIndex].text;
        document.getElementById("weekdag").value = displaytext;
    }
    </script>





</br>
</br>
   
  <form action="Main_Page_beheerder.php" method="post">
  
  
  
  <div class="container">
      <div class="box">
      <h2 align="center">Afwezige leerkracht</h2>

      <p>Dag van de week</p>
      <select id="dag" onchange="ddlselect4();">
  <option>Maandag</option>
  <option>Dinsdag</option>
  <option>Woensdag</option>
  <option>Donderdag</option>
  <option>Vrijdag</option>
  
  </select>
    <input type="text" placeholder="kies de weekdag" id="weekdag" readonly> 
     
		<div class="row">
			<p>Datum</p>
		</div>
		<div class="row">
	        <div class='col-sm-6'>
	        	<form>
		            <div class="form-group">
		                <div class='input-group date' id='datepicker'>
		                    <input type='date' id="datum" placeholder="datum ingeven" class="form-control" />
		                    
		                        
		                   
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


<script>
    function ddlselect3()
    {
        var d=document.getElementById("leerkrachtopties");
        var displaytext = d.options[d.selectedIndex].text;
        document.getElementById("leerkracht").value = displaytext;
    }
    </script>

<p>Leerkracht</p>
    <select id="leerkrachtopties" onchange="ddlselect3();">
  <?php
  while ($rows = $result->fetch_assoc())
 
  echo "<option>" . $rows['volledig'] . "</option>";
  ?>
</select>

    
    
    <input type="text" name="leerkracht" id="leerkracht" placeholder="kies een leerkracht" readonly>
    </br>
    
 
    </br>
    <script>
    function ddlselect2()
    {
        var d=document.getElementById("klasopties");
        var displaytext = d.options[d.selectedIndex].text;
        document.getElementById("klas").value = displaytext;
    }
    </script>

<p>Klas</p>
<select id="klasopties" onchange="ddlselect2();">
  <option>1Aa</option>
  <option>1Ab</option>
  <option>1bso</option>
  <option>2Aa</option>
  <option>2Ab</option>
  <option>2Ac</option>
  <option>2Ad</option>
  <option>3Econ</option>
  <option>3HuWe</option>
  <option>3La</option>
  <option>3We</option>
  <option>4Econ</option>
  <option>4Hand</option>
  <option>4HuWe</option>
  <option>4La</option>
  <option>4We</option>
  <option>5EcMt</option>
  <option>5EcWe</option>
  <option>5EcWi</option>
  <option>5HuWe</option>
  <option>5ITN</option>
  <option>5JHZ</option>
  <option>5LaWe</option>
  <option>5LaWi</option>
  <option>5STWe</option>
  <option>5WeWi</option>
  <option>6EcMt</option>
  <option>6EcWe</option>
  <option>6EcWi</option>
  <option>6HuWe</option>
  <option>6ITN</option>
  <option>6LaWe</option>
  <option>6LaWi</option>
  <option>6STWe</option>
  <option>6WeWi</option>
  <option>Duaal7Ki</option>
  <option>7Sales</option> 
  

</select>
<input type="text" id="klas" placeholder="kies een klas" readonly>
    </br>
    </br>
 
    <script>
    function ddlselect()
    {
        var d=document.getElementById("optieslesuur");
        var displaytext = d.options[d.selectedIndex].text;
        document.getElementById("lesuur").value = displaytext;
    }
    </script>

 <p>Lesuur</p>
 
 <select id="optieslesuur" onchange="ddlselect();">
  <option>Lesuur 1</option>
  <option>Lesuur 2</option>
  <option>Lesuur 3</option>
  <option>Lesuur 4</option>
  <option>Lesuur 5</option>
  <option>Lesuur 6</option>
  <option>Lesuur 7</option>
  <option>Lesuur 8</option>
</select>
 <input type="text" id="lesuur" placeholder="kies een lesuur" readonly></br>
<p>Taak</p>

 <input type="text" id="taak" placeholder="formuleer de taak"></br>
 
  

 <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
   
    </br>
    <div class="logo">
        <input type="button" onClick="insertData()" value="Leerkracht toevoegen">
        <input type="reset" value="Alle tekst legen">
    </div>
    <script language="javascript">


  
 function insertData() {
            $("#TableBody").html($("#TableBody").html() + "<tr><td>" + $("#weekdag").val() + "</td><td>" + $("#datum").val() + "</td><td>" + $("#leerkracht").val() + "</td><td>" + $("#klas").val() + "</td><td>" + $("#lesuur").val() + "</td><td>" + $("#taak").val() + "</td><td>" + "<button type='button'" +

                "onclick='delete();' " + "class='btn btn-default'>" +
                "<span class='glyphicon glyphicon-remove' />" + "</button>" + "</td>" + "</tr>");
        }

       
       
        

    </script>
<script>
function delete(ctl) {
  $(ctl).parents("tr").remove();
}
     
</script>
  </form>
  
  </div>



  <script>
function printDiv(table) {
      var printContents = document.getElementById(table).innerHTML;    
   var originalContents = document.body.innerHTML;      
   document.body.innerHTML = printContents;     
   window.print();     
   document.body.innerHTML = originalContents;
   }
</script>








  <!-- TWEEDE BOXMODEL -->
  
<div id="table">
<input type='button' value='tabel afprinten' onclick='printDiv("table");'/>

<table id="t1">

        <caption>Tabel met afwezige leerkrachten</caption>
     
       

        
        <colgroup>
            <col span="2" class="c2">
                <col>
                    <col class="c1">
        </colgroup>
        <thead>
            <tr>
            <th>
            Weekdag
            </th>
                
             <th>        
               Datum     
                </th>
  
                <th>
                    Leerkracht
                </th>
                <th>
                   Klas
                </th>
                <th>
                    Lesuur
                </th>
                <th>
                    Taak
                </th>
                <th>
                Rij verwijderen
                <script>
                     function delete(ctl) {
                     $(ctl).parents("tr").remove();
                }</script>
                </th>

            </tr>
        </thead>
        <tbody id="TableBody">
        </tbody>
    </table>
    


</div>
 <script>





 </script>



   
    
</body>
</html>