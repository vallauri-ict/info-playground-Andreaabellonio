CREATE TRIGGER salvaStorico
ON Cliente
AFTER DELETE
AS
INSERT INTO StoricoCancellazioni(idCliente, oldNome, oldCognome, oldIdCarrello, dataOra)
(SELECT d.IdCliente, d.Nome, d.Cognome, d.IdCarrello, CURRENT_TIMESTAMP
FROM deleted d)