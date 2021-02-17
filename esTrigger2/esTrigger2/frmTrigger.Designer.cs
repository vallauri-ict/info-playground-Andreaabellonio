
namespace esTrigger2
{
    partial class frmTrigger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabStoricoUpdate = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabStoricoCancellazioni = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabClienti = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlTrigger = new System.Windows.Forms.TabControl();
            this.dbTrigger2DataSet = new esTrigger2.dbTrigger2DataSet();
            this.dbTrigger2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new esTrigger2.dbTrigger2DataSetTableAdapters.ClienteTableAdapter();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarrelloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storicoCancellazioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storicoCancellazioniTableAdapter = new esTrigger2.dbTrigger2DataSetTableAdapters.StoricoCancellazioniTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarrelloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storicoUpdateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storicoUpdateTableAdapter = new esTrigger2.dbTrigger2DataSetTableAdapters.StoricoUpdateTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldCognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldIdCarrelloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newIdCarrelloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStoricoUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabStoricoCancellazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabClienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlTrigger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbTrigger2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTrigger2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storicoCancellazioniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storicoUpdateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStoricoUpdate
            // 
            this.tabStoricoUpdate.Controls.Add(this.dataGridView3);
            this.tabStoricoUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabStoricoUpdate.Name = "tabStoricoUpdate";
            this.tabStoricoUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabStoricoUpdate.Size = new System.Drawing.Size(964, 478);
            this.tabStoricoUpdate.TabIndex = 2;
            this.tabStoricoUpdate.Text = "STORICO UPDATE";
            this.tabStoricoUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idClienteDataGridViewTextBoxColumn2,
            this.oldNomeDataGridViewTextBoxColumn,
            this.oldCognomeDataGridViewTextBoxColumn,
            this.oldIdCarrelloDataGridViewTextBoxColumn,
            this.newNomeDataGridViewTextBoxColumn,
            this.newCognomeDataGridViewTextBoxColumn,
            this.newIdCarrelloDataGridViewTextBoxColumn,
            this.dataOraDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.storicoUpdateBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(958, 472);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabStoricoCancellazioni
            // 
            this.tabStoricoCancellazioni.Controls.Add(this.dataGridView2);
            this.tabStoricoCancellazioni.Location = new System.Drawing.Point(4, 22);
            this.tabStoricoCancellazioni.Name = "tabStoricoCancellazioni";
            this.tabStoricoCancellazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabStoricoCancellazioni.Size = new System.Drawing.Size(964, 478);
            this.tabStoricoCancellazioni.TabIndex = 1;
            this.tabStoricoCancellazioni.Text = "STORICO CANCELLAZIONI";
            this.tabStoricoCancellazioni.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.cognomeDataGridViewTextBoxColumn1,
            this.idCarrelloDataGridViewTextBoxColumn1,
            this.dataOraDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.storicoCancellazioniBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(958, 472);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabClienti
            // 
            this.tabClienti.Controls.Add(this.dataGridView1);
            this.tabClienti.Location = new System.Drawing.Point(4, 22);
            this.tabClienti.Name = "tabClienti";
            this.tabClienti.Padding = new System.Windows.Forms.Padding(3);
            this.tabClienti.Size = new System.Drawing.Size(964, 478);
            this.tabClienti.TabIndex = 0;
            this.tabClienti.Text = "CLIENTI";
            this.tabClienti.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.idCarrelloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(958, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            // 
            // tabControlTrigger
            // 
            this.tabControlTrigger.Controls.Add(this.tabClienti);
            this.tabControlTrigger.Controls.Add(this.tabStoricoCancellazioni);
            this.tabControlTrigger.Controls.Add(this.tabStoricoUpdate);
            this.tabControlTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTrigger.Location = new System.Drawing.Point(0, 0);
            this.tabControlTrigger.Name = "tabControlTrigger";
            this.tabControlTrigger.SelectedIndex = 0;
            this.tabControlTrigger.Size = new System.Drawing.Size(972, 504);
            this.tabControlTrigger.TabIndex = 0;
            this.tabControlTrigger.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlTrigger_Selecting);
            // 
            // dbTrigger2DataSet
            // 
            this.dbTrigger2DataSet.DataSetName = "dbTrigger2DataSet";
            this.dbTrigger2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbTrigger2DataSetBindingSource
            // 
            this.dbTrigger2DataSetBindingSource.DataSource = this.dbTrigger2DataSet;
            this.dbTrigger2DataSetBindingSource.Position = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dbTrigger2DataSetBindingSource;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            // 
            // idCarrelloDataGridViewTextBoxColumn
            // 
            this.idCarrelloDataGridViewTextBoxColumn.DataPropertyName = "IdCarrello";
            this.idCarrelloDataGridViewTextBoxColumn.HeaderText = "IdCarrello";
            this.idCarrelloDataGridViewTextBoxColumn.Name = "idCarrelloDataGridViewTextBoxColumn";
            // 
            // storicoCancellazioniBindingSource
            // 
            this.storicoCancellazioniBindingSource.DataMember = "StoricoCancellazioni";
            this.storicoCancellazioniBindingSource.DataSource = this.dbTrigger2DataSetBindingSource;
            // 
            // storicoCancellazioniTableAdapter
            // 
            this.storicoCancellazioniTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn1
            // 
            this.idClienteDataGridViewTextBoxColumn1.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn1.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn1.Name = "idClienteDataGridViewTextBoxColumn1";
            this.idClienteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn1
            // 
            this.cognomeDataGridViewTextBoxColumn1.DataPropertyName = "cognome";
            this.cognomeDataGridViewTextBoxColumn1.HeaderText = "cognome";
            this.cognomeDataGridViewTextBoxColumn1.Name = "cognomeDataGridViewTextBoxColumn1";
            this.cognomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idCarrelloDataGridViewTextBoxColumn1
            // 
            this.idCarrelloDataGridViewTextBoxColumn1.DataPropertyName = "idCarrello";
            this.idCarrelloDataGridViewTextBoxColumn1.HeaderText = "idCarrello";
            this.idCarrelloDataGridViewTextBoxColumn1.Name = "idCarrelloDataGridViewTextBoxColumn1";
            this.idCarrelloDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataOraDataGridViewTextBoxColumn
            // 
            this.dataOraDataGridViewTextBoxColumn.DataPropertyName = "dataOra";
            this.dataOraDataGridViewTextBoxColumn.HeaderText = "dataOra";
            this.dataOraDataGridViewTextBoxColumn.Name = "dataOraDataGridViewTextBoxColumn";
            this.dataOraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storicoUpdateBindingSource
            // 
            this.storicoUpdateBindingSource.DataMember = "StoricoUpdate";
            this.storicoUpdateBindingSource.DataSource = this.dbTrigger2DataSetBindingSource;
            // 
            // storicoUpdateTableAdapter
            // 
            this.storicoUpdateTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn2
            // 
            this.idClienteDataGridViewTextBoxColumn2.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn2.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn2.Name = "idClienteDataGridViewTextBoxColumn2";
            this.idClienteDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // oldNomeDataGridViewTextBoxColumn
            // 
            this.oldNomeDataGridViewTextBoxColumn.DataPropertyName = "oldNome";
            this.oldNomeDataGridViewTextBoxColumn.HeaderText = "oldNome";
            this.oldNomeDataGridViewTextBoxColumn.Name = "oldNomeDataGridViewTextBoxColumn";
            this.oldNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oldCognomeDataGridViewTextBoxColumn
            // 
            this.oldCognomeDataGridViewTextBoxColumn.DataPropertyName = "oldCognome";
            this.oldCognomeDataGridViewTextBoxColumn.HeaderText = "oldCognome";
            this.oldCognomeDataGridViewTextBoxColumn.Name = "oldCognomeDataGridViewTextBoxColumn";
            this.oldCognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oldIdCarrelloDataGridViewTextBoxColumn
            // 
            this.oldIdCarrelloDataGridViewTextBoxColumn.DataPropertyName = "oldIdCarrello";
            this.oldIdCarrelloDataGridViewTextBoxColumn.HeaderText = "oldIdCarrello";
            this.oldIdCarrelloDataGridViewTextBoxColumn.Name = "oldIdCarrelloDataGridViewTextBoxColumn";
            this.oldIdCarrelloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newNomeDataGridViewTextBoxColumn
            // 
            this.newNomeDataGridViewTextBoxColumn.DataPropertyName = "newNome";
            this.newNomeDataGridViewTextBoxColumn.HeaderText = "newNome";
            this.newNomeDataGridViewTextBoxColumn.Name = "newNomeDataGridViewTextBoxColumn";
            this.newNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newCognomeDataGridViewTextBoxColumn
            // 
            this.newCognomeDataGridViewTextBoxColumn.DataPropertyName = "newCognome";
            this.newCognomeDataGridViewTextBoxColumn.HeaderText = "newCognome";
            this.newCognomeDataGridViewTextBoxColumn.Name = "newCognomeDataGridViewTextBoxColumn";
            this.newCognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newIdCarrelloDataGridViewTextBoxColumn
            // 
            this.newIdCarrelloDataGridViewTextBoxColumn.DataPropertyName = "newIdCarrello";
            this.newIdCarrelloDataGridViewTextBoxColumn.HeaderText = "newIdCarrello";
            this.newIdCarrelloDataGridViewTextBoxColumn.Name = "newIdCarrelloDataGridViewTextBoxColumn";
            this.newIdCarrelloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataOraDataGridViewTextBoxColumn1
            // 
            this.dataOraDataGridViewTextBoxColumn1.DataPropertyName = "dataOra";
            this.dataOraDataGridViewTextBoxColumn1.HeaderText = "dataOra";
            this.dataOraDataGridViewTextBoxColumn1.Name = "dataOraDataGridViewTextBoxColumn1";
            this.dataOraDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // frmTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 504);
            this.Controls.Add(this.tabControlTrigger);
            this.Name = "frmTrigger";
            this.Text = "Trigger";
            this.Load += new System.EventHandler(this.frmTrigger_Load);
            this.tabStoricoUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabStoricoCancellazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabClienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlTrigger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbTrigger2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTrigger2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storicoCancellazioniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storicoUpdateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabStoricoUpdate;
        private System.Windows.Forms.TabPage tabStoricoCancellazioni;
        private System.Windows.Forms.TabPage tabClienti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControlTrigger;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource dbTrigger2DataSetBindingSource;
        private dbTrigger2DataSet dbTrigger2DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private dbTrigger2DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarrelloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storicoCancellazioniBindingSource;
        private dbTrigger2DataSetTableAdapters.StoricoCancellazioniTableAdapter storicoCancellazioniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarrelloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storicoUpdateBindingSource;
        private dbTrigger2DataSetTableAdapters.StoricoUpdateTableAdapter storicoUpdateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldCognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldIdCarrelloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newCognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newIdCarrelloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOraDataGridViewTextBoxColumn1;
    }
}