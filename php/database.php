<?php

$database = new PDO
    ('mysql:host=localhost;dbname=degokkers_inlog',
    'root',
    '');
$database->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);