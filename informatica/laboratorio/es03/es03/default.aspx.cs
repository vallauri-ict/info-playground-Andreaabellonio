using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace es03
{
    public partial class _default : System.Web.UI.Page
    {
        private clsDB db;
        protected void Page_Load(object sender, EventArgs e)
        {
            //la connessione al db va SEMPRE fatta a ogni caricamento
            db = new clsDB("App_Data\\dbItalia.mdf");
            if(!Page.IsPostBack)
                popolaCmbRegioni();
        }

        private void popolaCmbRegioni()
        {
            cmbRegioni.DataSource = db.caricaRegioni();
            cmbRegioni.DataValueField = "idRegione";//nome del valore
            cmbRegioni.DataTextField = "Regione";//nome del campo visualizzato
            //obbligatorio per tutti gli oggetti a cui associamo il datasource
            cmbRegioni.DataBind(); //DA FARE SEMPRE SENNO NON FUNZIONA
            cmbRegioni.Items.Insert(0,"-SELEZIONA UNA REGIONE-");
        }

        protected void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvince.SelectedIndex == 0)
            {
                cmbComuni.Items.Clear();
                cmbComuni.DataSource = null;
                cmbComuni.DataBind();
            }
            else
            {
                cmbComuni.DataSource = db.caricaComuni(cmbProvince.SelectedValue);
                cmbComuni.DataValueField = "idComune";
                cmbComuni.DataTextField = "Comune";
                cmbComuni.DataBind();
                cmbComuni.Items.Insert(0, "-SELEZIONA UN COMUNE-");
            }
        }

        protected void cmbRegioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegioni.SelectedIndex == 0)
            {
                cmbProvince.Items.Clear();
                cmbProvince.DataSource = null;
                cmbProvince.DataBind();
                cmbComuni.Items.Clear();
                cmbComuni.DataSource = null;
                cmbComuni.DataBind();
            }
            else
            {
                cmbProvince.DataSource = db.caricaProvincie(cmbRegioni.SelectedValue);
                cmbProvince.DataValueField = "idProvincia";
                cmbProvince.DataTextField = "Provincia";
                cmbProvince.DataBind();
                cmbProvince.Items.Insert(0, "-SELEZIONA UNA PROVINCIA-");
            }
        }
    }
}