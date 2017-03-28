<?php
$servername = "localhost";
$username = "root";
$password = null;
$dbname = "degokkers_inlog";


// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}


$email = $_GET["email"];
$fname = $_GET["fname"];
$lname = $_GET["lname"];
$username = $_GET["username"];
$hash=md5($_GET["password"]);




if (isset($email) && !empty($email) && isset($fname) && !empty($fname) && isset($lname) && !empty($lname)  && isset($username) && !empty($username)  && isset($hash) && !empty($hash)){
    if (filter_var($email, FILTER_VALIDATE_EMAIL)){
       // $check = "SELECT COUNT(4, 5) FROM tablename WHERE username = '$username' AND email = '$email'";
       // if (mysql_num_rows($email) == 0 and mysql_num_rows($username) == 0) {
            $sql = "INSERT INTO login_data (username, email, fname, lname, password)
        VALUES ('$username', '$email', '$fname', '$lname','$hash')";
            // header('location: register.php');
        }else{
            echo "error: ALREADY EXISTS";
        }
    }
    else{
        $message = "Error: Email incorrect";
   // }
}

if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}


