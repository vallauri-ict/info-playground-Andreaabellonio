using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace es02
{
    public partial class _default : System.Web.UI.Page
    {
        public Color[] colori = {Color.Black, Color.Green, Color.Blue, Color.Yellow};
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                foreach (Color colore in colori)
                {
                    cmbColore.Items.Add(colore.Name);
                }

                pnlColore.BackColor = colori[0];
                chkAutoPost.AutoPostBack = true; //con AutoPostBack a TRUE ogni volta che la chk cambia stato(checked/unchecked)
                                                 //viene generato in automatico un submit(PostBack) in questo modo posso gestire
                                                 //subito l'elenco
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void cmbColore_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlColore.BackColor = colori[cmbColore.SelectedIndex];
        }

        protected void chkAutoPostBack_CheckedChanged(object sender, EventArgs e)
        {
            cmbColore.AutoPostBack = chkAutoPost.Checked;
        }
    }
}