<?php 

//$mysqli = new mysqli("localhost", "root", "1lax", "coffe_control_db");

$mysqli = new mysqli("coffee-control.ru", "u0187820_default", "280595", "u0187820_default");
if ($mysqli->connect_errno) {
    echo "Не удалось подключиться к MySQL: (" . $mysqli->connect_errno . ") " . $mysqli->connect_error;
}

?>