<?php
header('Content-type: text/html; charset=utf-8');
mysql_connect("coffee-control.ru", "u0187820_default", "280595");

 
$sql = "SELECT name FROM workers";
 
$result_select = mysql_query($sql);

?>

<html>
<head>
<meta charset="UTF-8" Content-type: text/html;>
</head>
<body>
<form>
   <p><select size="1">
    <option disabled>Выберите имя</option>
    <?php while($object = mysql_fetch_object($result_select)):?>
    <option value ="<?=$object->column_name?>"><?=$object->column_name?></option>
    <?php endwhile;?>
   </select></p>
  </form>
</body>
</html>
