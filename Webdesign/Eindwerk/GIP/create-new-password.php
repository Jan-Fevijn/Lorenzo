<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $selector = $_GET["selector"];
        $validator = $_GET["validator"];

        if (empty($selector) || empty($validator)) {
            echo "Could not validate your request!";
        } else{
            if (ctype_xdigit($selector) !== false && ctype_xdigit($validator) !== false ) {
                ?>
                <form action="reset_password.php">
                <input type="hidden" name="selector" value="<?php echo $selector; ?>">
                <input type="hidden" name="validator" value="<?php echo $validator; ?>">
                <input type="password" name="pwd" placeholder="Enter a new password ..">
                <input type="password" name="pwd-repeat" placeholder="Repeat new password ..">
                <button type="submit" name="reset-password-submit">Reset password</button>
                </form>

                <?php
            }
        }

    ?>
</body>
</html>