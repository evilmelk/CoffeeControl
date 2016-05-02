<?php
require_once 'config.php'; // The mysql database connection script

if(isset($_GET['name']))
{
$name = $_GET['name']; 
$pieces = $_GET['pieces'];
$unitName = $_GET['unitName'];
$modifier = $_GET['modifier'];
$type = $_GET['type'];
}

//запрос к БД на установку кодировки
$query="SET NAMES `utf8`";
$result = $mysqli->query($query) or die($mysqli->error.__LINE__);

//$materials_id = "5";


$query="INSERT INTO materials(materials_id, name, pieces, unitName, modifier, type) 
VALUES(NULL, '$name', '$pieces', '$unitName', '$modifier', '$type')";
$result = $mysqli->query($query) or die($mysqli->error.__LINE__);

$result = $mysqli->affected_rows; 
echo $json_response = json_encode($result);

?>

