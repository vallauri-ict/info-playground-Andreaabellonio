<?php
session_start();
require "C:\\xampp\htdocs\\es01TPSIlab\dbConnection.php";
?>
<html lang="en">

<head>
    <title>Es 01 TPSI lab - REGISTRAZIONE STUDENTE</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>

<body>
    <?php
    $query2 = "SELECT nomeCitta FROM citta";
    $sth2 = $pdo->prepare($query2);
    $sth2->execute();
    $citta = $sth2->fetchAll();
    $query3 = "SELECT classe FROM classi";
    $sth3 = $pdo->prepare($query3);
    $sth3->execute();
    $classi = $sth3->fetchAll();
    ?>
    <div class="mx-auto" style="width: 500px">
        <h3>Iscrizione studente</h3>
        <form method="POST" action="signupWEBSERVICE.php">
            <div class="form-row">
                <div class="col">
                    <label for="nome">Nome</label>
                    <input type="text" class="form-control" name="nome" required>
                </div>
            </div>
            <div class="form-row">
                <div class="col">
                    <label for="cognome">Cognome</label>
                    <input type="text" class="form-control" name="cognome" required>
                </div>
            </div>
            <div class="form-row" style="padding-top:10px">
                <div class="col">
                    <label for="classe">Classe</label>
                    <input type="text" list="classe" name="nuovaClasse" required>
                    <datalist id="classe" name="classe">
                        <?php
                        foreach ($classi as $singola) {
                        ?>
                            <option><?php echo $singola[0] ?></option>
                        <?php
                        }
                        ?>
                    </datalist>
                </div>
                <div class="col">
                    <label for="citta">Citta</label>
                    <input type="text" name="nuovaCitta" list="citta" required>
                    <!--Questo serve per scrivere dentro la combo box -->
                    <datalist id="citta" name="citta">
                        <?php
                        foreach ($citta as $singola) {
                        ?>
                            <option><?php echo $singola[0] ?></option>
                        <?php
                        }
                        ?>
                    </datalist>
                </div>
            </div>
            <div class="form-row">
                <div class="col">
                    <label for="password">Password</label>
                    <input type="password" class="form-control" name="password" required>
                </div>
            </div>
            <div class="form-row" style="padding-top: 50px">
                <button class="btn btn-primary" type="submit" style="width: 1000px;">REGISTRATI</button>
            </div>
        </form>
    </div>
</body>