using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ADOSQLServer2017_ns;
using System.Data;
using System.Data.SqlClient;

public class clsDB
{
    ADOSQLServer2017 ado;

    public clsDB(string nomeDB)
    {
        this.ado = new ADOSQLServer2017(nomeDB);
    }

    public DataTable caricaRegioni()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM Regioni ORDER BY Regione";
        return ado.EseguiQuery(cmd);
    }

    public DataTable caricaProvincie(string id)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM Province WHERE idRegione=@id ORDER BY Provincia";
        cmd.Parameters.AddWithValue("@id", id);
        return ado.EseguiQuery(cmd);
    }

    public DataTable caricaComuni(string id)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM Comuni WHERE idProvincia=@id ORDER BY Comune";
        cmd.Parameters.AddWithValue("@id", id);
        return ado.EseguiQuery(cmd);
    }
}