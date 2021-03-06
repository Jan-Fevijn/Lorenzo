<?php

    if (isset($_POST["reset-password-submit"])) {

        $selector = $_POST["selector"];
        $validator = $_POST["validator"];
        $password = $_POST["pwd"];
        $passwordRepeat = $_POST["pwd-repeat"];

        if (empty($password) || empty($passwordRepeat)) {
            header("Location : index.php?newpwd = empty");
            exit();

        }  elseif ($password != $passwordRepeat) {
            header("Location : index.php?newpwd = pwdnotsame");
            exit();

        }


        $currentDate = date("U");

        require 'conn.php';

        $sql = "SELECT * FROM pwdReset WHERE pwdResetSelector=? AND pwdResetExpires >= ?";
        $stmt = mysqli_stmt_init($conn);
        if (!mysqli_stmt_prepare($stmt, $sql)) {
            echo "There was an error!";
            exit();
        } else {
            mysqli_stmt_bind_param($stmt, "s", $selector );
            mysqli_stmt_execute($stmt, $currentDate);

            $result = mysql_stmt_get_result($stmt);
            if (!$row = mysqli_fetch_assoc($result)) {
                echo "you need to re-submit your reset request.";  
                exit();
            }else{

                    $tokenBin = hex2bin($validator);
                    $tokenCheck = password_verify($tokenBin, $row["pwdResetToken"]);

                    if ($tokenCheck === false) {
                            echo "you need to re-submit your reset request.";
                            exit();
                    } elseif ($tokenCheck === true) {
                        
                        $tokenEmail = $row['pwdResetEmail'];

                        $sql = "SELECT * FROM gebruiker WHERE email=?;";
                        $stmt = mysqli_stmt_init($conn);
                        if (!mysqli_stmt_prepare($stmt, $sql)) {
                            echo "There was an error!";
                            exit();
                        } else {
                            mysqli_stmt_bind_param($stmt, "s", $tokenEmail);
                            mysqli_stmt_execute($stmt);
                            $result = mysql_stmt_get_result($stmt);
                            if (!$row = mysqli_fetch_assoc($result)) {
                                echo "There was an error.";  
                                exit();
                            }else{

                                $sql = "UPDATE gebruiker SET ww=? WHERE email=?";
                                $stmt = mysqli_stmt_init($conn);
                                if (!mysqli_stmt_prepare($stmt, $sql)) {
                            echo "There was an error!";
                            exit();
                        } else {
                            $newpwdHash = password_hash($password, PASSWORD_DEFAULT);
                            mysqli_stmt_bind_param($stmt, "ss", $newpwdHash, $tokenEmail);
                            mysqli_stmt_execute($stmt);

                            $sql = "DELETE FROM pwdReset WHERE pwdResetEmail=?";
                            $stmt = mysqli_stmt_init($conn);
                        
                            if (!mysqli_stmt_prepare($stmt, $sql)) {
                                echo "There was an error!";
                                exit();
                            } else {
                                mysqli_stmt_bind_param($stmt, "s", $tokenEmail);
                                mysqli_stmt_execute($stmt);
                                header('Location: index.php');
                            } 
                        }
                     }
                    }


                }

            }
        }
    
    

    }  else{
        header("Location: index.php");
    }

?>