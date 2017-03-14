<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Register</title>
</head>
<body>

<label for="Username">Username</label>
    <form action="Emailcheck.php">
        <input type="text" id="Username" name="username" required><br>
    <label for="email">E-mail Address</label><br>
        <input type="email" id="email" name="email" required><br>
    <label for="firstname">First Name</label><br>
        <input type="text" id="firstname" name="fname" required><br>
    <label for="lastname">Last Name</label><br>
        <input type="text" id="lastname" name="lname" required><br>
    <label for="password">Password</label><br>
        <input type="password" id="password" name="password" required><br>
    <label for="confirm_password">Confirm password</label><br>
        <input type="password" id="confirm_password" required><br>
        <input type="submit"><br>
    </form>
<script>
    var password = document.getElementById("password")
        , confirm_password = document.getElementById("confirm_password");

    function validatePassword(){
        if(password.value != confirm_password.value) {
            confirm_password.setCustomValidity("Passwords Don't Match");
        } else {
            confirm_password.setCustomValidity('');
        }
    }

    password.onchange = validatePassword;
    confirm_password.onkeyup = validatePassword;
</script>

</body>
</html>
