<?
if (isset($_POST["reset-request-submit"])){

    $selector = bin2hex(random_bytes(8));
    $token = random_bytes(32);

    $url = "create-new-password.php?selector=" . $selector . "&validator=" . bin2hex($token);

    $expires = date("U") + 1800; 



    require 'conn.php';

    $userEmail = $_POST["email"];

    $sql = "DELETE FROM pwdReset WHERE pwdResetEmail=?";
    $stmt = mysqli_stmt_init($conn);

    if (!mysqli_stmt_prepare($stmt, $sql)) {
        echo "There was an error!";
        exit();
    } else {
        mysqli_stmt_bind_param($stmt, "s", $userEmail);
        mysqli_stmt_execute($stmt);
    }


    $sql = "INSERT INTO pwdReset (pwdResetEmail, pwd ResetSelector, pwdResetToken, pwdResetExpires) VALUES (?, ?, ?, ?);";

    $stmt = mysqli_stmt_init($conn);

    if (!mysqli_stmt_prepare($stmt, $sql)) {
        echo "There waas an error!";
        exit();
    } else {
        $hashedToken = password_hash($token, PASSWORD_DEFAULT); 
        mysqli_stmt_bind_param($stmt, "s", $userEmail, $selector, $hashedToken, $expires);
        mysqli_stmt_execute($stmt);
    }

    mysqli_stmt_close($stmt);
    mysqli_close($conn);


    $to = $userEmail;

    $subject = 'Wachtwoord vernieuwen';

     $message = 'p>Er is een verzoek geweest om uw wachtwoord te veranderen, was jij dit niet dan mag je deze mail negeren.</p>';

     $message .= '<p> Hier is een link om uw wachtwoord te wijzigen: </br>';
     $message .= '<a href="' . $url . '">' . $url . '</a></p>';


     $headers = "From: changepassword <changepassword@studielijsten.com>\r\n";
     $headers .= "Content-type: text/html\r\n";


     mail($to, $subject, $message, $headers);

     header("Location: reset-password.php?reset=succes");
} else{
    header("Location: index.php");
}