<?php
session_start();
require "C:\\xampp\htdocs\\es01TPSIlab\dbConnection.php";
if ($_SESSION["autenticato"] == 1) {
?>
    <html lang="en">

    <head>
        <title>Es 01 TPSI lab - PORTALE</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
    </head>

    <body>
        <button type="button" class="btn btn-primary" onclick="window.location.href='index.php'" style="float: right;">Ritorna al login</button>
        <h2>Es 01 tpsi lab VISTA STUDENTE</h2>
        <h3>Dati studente</h3>
        <br>
        <?php
        $query = "SELECT a.idAlunno, a.Nome, a.Cognome, ci.nomeCitta, cl.classe FROM alunni a, citta ci, classi cl WHERE a.idAlunno=:idAlunno AND a.idCitta=ci.idCitta AND a.idClasse=cl.idClasse";
        $sth = $pdo->prepare($query);
        $sth->bindParam(':idAlunno', $_SESSION['idAlunno'], PDO::PARAM_STR);
        $sth->execute();
        $riga = $sth->fetchAll();
        ?>
        <h4>Codice: <?php echo $riga[0][0] ?></h4>
        <h4>Nome: <?php echo $riga[0][1] ?></h4>
        <h4>Cognome: <?php echo $riga[0][2] ?></h4>
        <h4>Citta: <?php echo $riga[0][3] ?></h4>
        <h4>Classe: <?php echo $riga[0][4] ?></h4>
        <?php
        ?>
    </body>

    </html>
<?php
} else {
    header("Location: index.php");
}
?>