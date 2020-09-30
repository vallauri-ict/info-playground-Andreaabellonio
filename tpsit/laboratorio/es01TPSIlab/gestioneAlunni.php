<?php
session_start();
require "C:\\xampp\htdocs\\es01TPSIlab\dbConnection.php";
?>
<html lang="en">

<head>
    <title>Es 01 TPSI lab - LOGIN RISERVATO</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>

<body>
    <button type="button" class="btn btn-primary" onclick="window.location.href='index.php'" style="float: right;">AREA RISERVATA ALUNNI</button>
    <?php
    if (isset($_SESSION["autenticatoR"]) && $_SESSION["autenticatoR"] == 1) {
        if (isset($_GET["elimina"])) {
            $query = "DELETE FROM alunni WHERE idAlunno=" . $_GET["idAlunno"];
            $sth = $pdo->prepare($query);
            $sth->execute();
        } else if (isset($_GET["modifica"])) {
            $cls = $_GET["nuovaClasse"];
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
            $ct = $_GET["nuovaCitta"];
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
            $query = "UPDATE alunni SET nome='" . $_GET["nome"] . "', cognome='" . $_GET["cognome"] . "', idClasse=" . $classe[0][0] . ", idCitta=" . $citta[0][0] . " WHERE idAlunno=" . $_GET["idAlunno"];
            $sth = $pdo->prepare($query);
            $sth->execute();
        } else if (isset($_GET["aggiungi"])) {
            $cls = $_GET["nuovaClasse"];
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
            $ct = $_GET["nuovaCitta"];
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
            $pwd = md5($_GET["password"]);
            $query = "INSERT INTO alunni VALUES(null, '" . $_GET['cognome'] . "','" . $_GET['nome'] . "'," . $citta[0][0] . "," . $classe[0][0] . ",'" . $pwd . "')";
            $sth = $pdo->prepare($query);
            $sth->execute();
        }
    ?>
        <h2>Es 01 tpsi lab VISTA GESTIONE RISERVATA</h2>
        <h3>Dati studenti</h3>
        <br>
        <table class="table table-stripped">
            <thead class="thead-dark">
                <th>Codice Alunno</th>
                <th>Cognome</th>
                <th>Nome</th>
                <th>Citta</th>
                <th>Classe</th>
            </thead>
            <tbody>
                <?php
                $query = "SELECT a.idAlunno, a.Nome, a.Cognome, ci.nomeCitta, cl.classe FROM alunni a, citta ci, classi cl WHERE a.idCitta=ci.idCitta AND a.idClasse=cl.idClasse";
                $sth = $pdo->prepare($query);
                $sth->execute();
                $dati = $sth->fetchAll();
                $query2 = "SELECT nomeCitta FROM citta";
                $sth2 = $pdo->prepare($query2);
                $sth2->execute();
                $citta = $sth2->fetchAll();
                $query3 = "SELECT * FROM classi";
                $sth3 = $pdo->prepare($query3);
                $sth3->execute();
                $classi = $sth3->fetchAll();
                foreach ($dati as $riga) {
                ?>
                    <tr class="table-row">
                        <form>
                            <td class="table-cell"><input type="text" name="idAlunno" readonly value="<?php echo $riga[0] ?>"></td>
                            <td class="table-cell"><input type="text" name="cognome" value="<?php echo $riga[2] ?>"></td>
                            <td class="table-cell"><input type="text" name="nome" value="<?php echo $riga[1] ?>"></td>
                            <td class="table-cell">
                                <input type="text" list="citta" name="nuovaCitta" value="<?php echo $riga[3] ?>">
                                <datalist id="citta" name="citta">
                                    <?php
                                    foreach ($citta as $singola) {
                                    ?>
                                        <option <?php if ($singola[0] == $riga[3]) {
                                                    echo 'selected';
                                                } ?>><?php echo $singola[0] ?></option>
                                    <?php
                                    }
                                    ?>
                                </datalist></td>
                            <td class="table-cell">
                                <input type="text" list="classe" name="nuovaClasse" value="<?php echo $riga[4] ?>">
                                <datalist id="classe" name="classe">
                                    <?php
                                    foreach ($classi as $singola) {
                                    ?>
                                        <option <?php if ($singola[1] == $riga[4]) {
                                                    echo 'selected';
                                                } ?>><?php echo $singola[1] ?></option>
                                    <?php
                                    }
                                    ?>
                                </datalist></td>
                            <td class="table-cell"><button type="submit" class="btn btn-danger" data-toggle="modal" data-target="#exampleModal">ELIMINA</button>
                                <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <h5 class="modal-title" id="exampleModalLabel">ELIMINAZIONE</h5>
                                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                    <span aria-hidden="true">&times;</span>
                                                </button>
                                            </div>
                                            <div class="modal-body">
                                                Conferma eliminazione
                                            </div>
                                            <div class="modal-footer">
                                                <button type="button" class="btn btn-primary" data-dismiss="modal">Close</button>
                                                <button type="submit" class="btn btn-danger" name="elimina">CONFERMA</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <button type="submit" class="btn btn-success" value="Modifica" name="modifica">MODIFICA</button>
                            </td>
                        </form>
                    </tr>
                <?php
                }
                ?>
                <tr class="table-row">
                    <td class="table-cell">AGGIUNTA ALUNNO</td>
                </tr>
                <tr class="table-row bg-primary">
                    <form>
                        <td class="table-cell"><input type="text" name="cognome" placeholder="Cognome"></td>
                        <td class="table-cell"><input type="text" name="nome" placeholder="Nome"></td>
                        <td class="table-cell"><input type="password" name="password" placeholder="Password"></td>
                        <td class="table-cell">
                            <input type="text" name="nuovaCitta" list="citta" placeholder="Citta">
                            <datalist id="citta" name="citta">
                                <?php
                                foreach ($citta as $singola) {
                                ?>
                                    <option><?php echo $singola[0] ?></option>
                                <?php
                                }
                                ?>
                            </datalist></td>
                        <td class="table-cell">
                            <input type="text" name="nuovaClasse" list="classe" placeholder="Classe">
                            <datalist id="classe" name="classe">
                                <?php
                                foreach ($classi as $singola) {
                                ?>
                                    <option><?php echo $singola[1] ?></option>
                                <?php
                                }
                                ?>
                            </datalist></td>
                        <td class="table-cell"><button type="submit" class="btn btn-secondary" value="Aggiungi" name="aggiungi">AGGIUNGI</button>
                    </form>
                    </tbdoy>
        </table>
        <?php
    } else {
        if (isset($_POST["idOperatore"]) && isset($_POST["password"])) {
            $pwd = md5($_POST["password"]);
            $query = "SELECT * FROM operatori WHERE idOperatore=:idOperatore AND password=:pwd";
            $sth = $pdo->prepare($query);
            //ATTENZIONE all'SQLinjection (bindParam dovrebbe già agire)
            $sth->bindParam(':idOperatore', $_POST['idOperatore'], PDO::PARAM_STR);
            $sth->bindParam(':pwd', $pwd, PDO::PARAM_STR);
            $sth->execute();
            if ($sth->rowCount() == 1) {
                $_SESSION["autenticatoR"] = 1;
                $_SESSION["idOperatore"] = $_POST["idOperatore"];
                header("Location: gestioneAlunni.php");
            } else {
                $_SESSION["autenticatoR"] = 0;
        ?>
                <div class="alert alert-danger" role="alert">
                    Credenziali non corrette! Riprova
                </div>
        <?php
            }
        }
        ?>
</body>

</html>
<?php
    }
?>