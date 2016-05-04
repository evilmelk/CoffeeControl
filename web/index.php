<?php
$db_conn = new mysqli("coffee-control.ru", "u0187820_default", "280595", "u0187820_default");
if (mysqli_connect_errno())
  {
  echo 'Connection to database failed:'.mysqli_connect_error();
  exit();
  }
else
  {
  echo 'Ok';
  }
?>