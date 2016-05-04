<?php
header('Content-Type: text/html; charset=utf8');
require_once 'config.php'; // The mysql database connection script
$materials_id = '%';
if(isset($_GET['materials_id'])){
$materials_id = $_GET['materials_id'];
}
$query="SET NAMES `utf8`";
$result = $mysqli->query($query) or die($mysqli->error.__LINE__);

if ($materials_id !== '%'){
    $query="SELECT * FROM `materials` WHERE `materials_id`='$materials_id'";
}
else $query="SELECT * FROM `materials`";
$result = $mysqli->query($query) or die($mysqli->error.__LINE__);
 
$arr = array();
if($result->num_rows > 0) {
while($row = $result->fetch_assoc()) {
$arr[] = $row;
}
}
 
# JSON-encode the response
echo $json_response = json_encode($arr);
?>