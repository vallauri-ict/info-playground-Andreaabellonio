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
            //vedere roundtrip che ricarica ogni volta cmb
        }

        protected void btnInvia_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                lblMessaggio.Text = "Inserire Nome";
            else
                lblMessaggio.Text = "Ciao "+txtNome.Text;
        }
    }
}