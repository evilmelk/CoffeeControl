<?php
 
/*Ñîåäèíÿåñÿ ñ áàçîé è äåëàåì âûáîðêó èç òàáëèöû*/
header('Content-type: text/html; charset=utf8');
$connect_to_db =mysql_connect("coffee-control.ru", "u0187820_default", "280595");

mysql_query('SET names "utf8"');

mysql_select_db("u0187820_default");

$sql = "SELECT name FROM workers";
 
$result_select = mysql_query($sql);
 
?>
<html>
<head>
<meta http-equiv=”Content-Type” content=”text/html; charset="utf8" >
</head>
<body>
   <p><select size="1" name='worker'>
       <?php header('Content-type: text/html; charset=utf8');
        while($object = mysql_fetch_object($result_select)): ?>
    <option value ="<?=$object->{name}?>"><?=$object->{name}?></option>
    <?php endwhile;?>
   </select></p>
   
  
</body>
</html>
<?php mysql_close($connect_to_db);
?>

