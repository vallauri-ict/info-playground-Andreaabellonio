<?php
header('Content-Type: application/json; charset=utf-8');
if (isset($_POST['nome']) && isset($_POST['cognome']) && isset($_POST['nuovaClasse']) && isset($_POST['nuovaCitta']) && isset($_POST['password'])) {
    require "C:\\xampp\htdocs\\es01TPSIlab\dbConnection.php";
    $cls = $_POST["nuovaClasse"];
    $query = "SELECT idClasse FROM classi WHERE classe='" . $cls . "'";
    $sth = $pdo->prepare($query);
    $sth->execute();
    $classe = $sth->fetchAll();
    if ($classe == null) {
        $query = "INSERT INTO classi VALUES (null,'" . $cls . "')";
        $sth = $pdo->prepare($query);
        $sth->execute();
        $query = "SELECT idClasse FROM classi WHERE classe='" . $cls . "'";
        $sth = $pdo->prepare($query);
        $sth->execute();
        $classe = $sth->fetchAll();
    }
    $ct = $_POST["nuovaCitta"];
    $query = "SELECT idCitta FROM citta WHERE nomeCitta='" . $ct . "'";
    $sth = $pdo->prepare($query);
    $sth->execute();
    $citta = $sth->fetchAll();
    if ($citta == null) {
        $query = "INSERT INTO citta VALUES (null,'" . $ct . "')";
        $sth = $pdo->prepare($query);
        $sth->execute();
        $query = "SELECT idCitta FROM citta WHERE nomeCitta='" . $ct . "'";
        $sth = $pdo->prepare($query);
        $sth->execute();
        $citta = $sth->fetchAll();
    }
    $pwd = md5($_POST["password"]);
    $query = "INSERT INTO alunni VALUES(null, '" . $_POST['cognome'] . "','" . $_POST['nome'] . "'," . $citta[0][0] . "," . $classe[0][0] . ",'" . $pwd . "')";
    $sth = $pdo->prepare($query);
    $sth->execute();
    $query = "SELECT idAlunno FROM alunni WHERE password='".$pwd."'";
    $sth = $pdo->prepare($query);
    $sth->execute();
    $id=$sth->fetchAll();
    $risposta=array("Messaggio"=>"Registrazione effettuata con successo","idAlunno"=>$id[0]);
    $s=json_encode($risposta);
    echo $s;
} else {
    http_response_code(400);
    die("Parametro mancante");
}
