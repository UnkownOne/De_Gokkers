<?php
$message = ('Logged out');
require('database.php');
session_start();

$_SESSION['logged_in'] = false;


header("Location: login.php?message=$message");