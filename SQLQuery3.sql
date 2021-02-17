CREATE TRIGGER salvaStoricoUpdate
ON Cliente
AFTER UPDATE
AS
INSERT INTO StoricoUpdate(idCliente, oldNome, oldCognome, oldIdCarrello, newNome, newCognome, newIdCarrello, dataOra)
(SELECT d.IdCliente, d.Nome, d.Cognome, d.IdCarrello, i.Nome, i.Cognome, i.IdCarrello, CURRENT_TIMESTAMP
FROM deleted d
INNER JOIN inserted i ON i.IdCliente=d.IdCliente)