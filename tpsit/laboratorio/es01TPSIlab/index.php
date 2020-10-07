<?php
require "C:\\xampp\htdocs\\es01TPSIlab\dbConnection.php";
session_start();
$_SESSION["autenticato"] = 0; //variabile session autenticazione alunno
$_SESSION["idAlunno"] = ""; //id alunno per leggere dati nel portale.php
$_SESSION["autenticatoR"] = 0; //autenticazione area riservata
?>
<html lang="en">

<head>
    <title>Es 01 TPSI lab - LOGIN</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>

<body>
    <button type="button" class="btn btn-primary" onclick="window.location.href='gestioneAlunni.php'" style="float: right; margin: 60px">AREA RISERVATA GESTIONE</button>
    <?php
    if (isset($_POST["idAlunno"]) && isset($_POST["password"])) { //LOGIN
        $pwd = md5($_POST["password"]);
        $query = "SELECT * FROM alunni WHERE idAlunno=:idAlunno AND password=:pwd";
        $sth = $pdo->prepare($query);
        //ATTENZIONE all'SQLinjection (bindParam dovrebbe già agire)
        $sth->bindParam(':idAlunno', $_POST['idAlunno'], PDO::PARAM_STR);
        $sth->bindParam(':pwd', $pwd, PDO::PARAM_STR);
        $sth->execute();
        if ($sth->rowCount() == 1) {
            $_SESSION["autenticato"] = 1;
            $_SESSION["idAlunno"] = $_POST["idAlunno"];
            header("Location: portale.php");
        } else {
            $_SESSION["autenticato"] = 0;
    ?>
            <div class="alert alert-danger" role="alert">
                Credenziali non corrette! Riprova
            </div>
    <?php
        }
    }
    ?>
    <div class="mx-auto" style="width: 400px; margin-top: 100px;">
        <h2>Es 01 tpsi lab LOGIN ALUNNO</h2>
        <h3>Accesso area riservata alunno</h3>
        <form action="index.php" method="post">
            <div class="form-group">
                <label for="idAlunno">Codice alunno</label>
                <input type="text" class="form-control" id="idAlunno" name="idAlunno">
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <input type="password" class="form-control" id="password" name="password">
            </div>
            <button type="submit" class="btn btn-primary">Accedi</button>
            <button type="button" onclick="window.location.href='signup.php'" class="btn btn-primary">REGISTRATI</button>
        </form>
    </div>
</body>

</html>