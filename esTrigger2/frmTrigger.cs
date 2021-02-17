using System;
using System.Windows.Forms;

namespace esTrigger2
{
    public partial class frmTrigger : Form
    {
        public frmTrigger()
        {
            InitializeComponent();
        }

        private void frmTrigger_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dbTrigger2DataSet.Cliente'. È possibile spostarla o rimuoverla se necessario.
            clienteTableAdapter.Fill(dbTrigger2DataSet.Cliente);
            updateAll();
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            clienteTableAdapter.Update(dbTrigger2DataSet.Cliente);
            updateAll();
        }

        private void updateAll()
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dbTrigger2DataSet.StoricoUpdate'. È possibile spostarla o rimuoverla se necessario.
            storicoUpdateTableAdapter.Fill(dbTrigger2DataSet.StoricoUpdate);
            // TODO: questa riga di codice carica i dati nella tabella 'dbTrigger2DataSet.StoricoCancellazioni'. È possibile spostarla o rimuoverla se necessario.
            storicoCancellazioniTableAdapter.Fill(dbTrigger2DataSet.StoricoCancellazioni);
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
            dataGridView3.Update();
            dataGridView3.Refresh();
        }

        private void tabControlTrigger_Selecting(object sender, TabControlCancelEventArgs e)
        {
            updateAll();
        }
    }
}
