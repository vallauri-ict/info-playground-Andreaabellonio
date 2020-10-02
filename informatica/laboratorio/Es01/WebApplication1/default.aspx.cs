using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //viene richiamato ad ogni caricamento della pagina
            if (!Page.IsPostBack)
            {
                //IsPostBack è boolean FALSE se è la prima volta, TRUE le altre
                //operazioni svolte soltanto la prima volta che viene richiamata
                cmbCitta.Items.Add("Cuneo");
                cmbCitta.Items.Add("Fossano");
                cmbCitta.Items.Add("Torino");
            }
        }

        protected void btnInvia_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                lblMessaggio.Text = "Inserire Nome";
            else
                lblMessaggio.Text = "Ciao " + txtNome.Text;
        }
    }
}