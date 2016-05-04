<?php
 
/*—оедин€ес€ с базой и делаем выборку из таблицы*/
header('Content-type: text/html; charset=utf8');
$connect_to_db =mysql_connect("coffee-control.ru", "u0187820_default", "280595");

mysql_query('SET names "utf8"');
mysql_select_db("u0187820_default");

//ƒанные работника
$sql_worker = "SELECT name FROM workers"; 
$result_select_worker = mysql_query($sql_worker);
//ƒанные кофеен
$sql_shop = "SELECT title FROM shops"; 
$result_select_shop = mysql_query($sql_shop);
//ввод даты
$date = isset($_POST['date']) ? $_POST['date'] : 'Unknown';
//$age = isset($_POST['age']) and $_POST['age'] > 0 ? (int) $_POST['age'] : 'Unknown';



 
?>
<html>
<head>
<meta http-equiv=ФContent-TypeФ content=Фtext/html; charset="utf8" >
</head>
<body>



<select size="1" name='shop'>
       <?php header('Content-type: text/html; charset=utf8');
        while($object = mysql_fetch_object($result_select_shop)): ?>
    <option value ="<?=$object->{title}?>"><?=$object->{title}?></option>
    <?php endwhile;?>
   </select>



   <select size="1" name='worker'>
       <?php header('Content-type: text/html; charset=utf8');
        while($object = mysql_fetch_object($result_select_worker)): ?>
    <option value ="<?=$object->{name}?>"><?=$object->{name}?></option>
    <?php endwhile;?>
   </select>


<form action="lost.php" method="post" accept-charset="utf8">
Date ( year-month-day: 2016-05-04): <input type=text name="name"><br>
<input type=submit value="GO!">
</form>


   
  
</body>
</html>
<?php mysql_close($connect_to_db);
?>

