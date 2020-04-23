<!DOCTYPE html>
<html lang="en">
<head>
<script src="jquery/jquery-3.4.1.min"></script>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <script>
    $( "#created_date_new" ).datepicker({
    'dateFormat':'yy-mm-dd',
    onSelect: function(dateText){
        var seldate = $(this).datepicker('getDate');
        seldate = seldate.toDateString();
        seldate = seldate.split(' ');
        var weekday=new Array();
            weekday['Mon']="Monday";
            weekday['Tue']="Tuesday";
            weekday['Wed']="Wednesday";
            weekday['Thu']="Thursday";
            weekday['Fri']="Friday";
            weekday['Sat']="Saturday";
            weekday['Sun']="Sunday";
        var dayOfWeek = weekday[seldate[0]];
        $('#dayOfWeek').val(dayOfWeek);
    }
});
    </script>
</head>
<body>
    <h1>Afwezige leerkracht invoegen</h1>


</body>
</html>