namespace es01_socket
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.txtMessaggioRicevuto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPortaServer = new System.Windows.Forms.ComboBox();
            this.btnArrestaServer = new System.Windows.Forms.Button();
            this.btnAvviaServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstIPServer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIPHostRemoto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMessaggioDaInviare = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.cmbPortaHostRemoto = new System.Windows.Forms.ComboBox();
            this.grpServer.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpServer
            // 
            this.grpServer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpServer.Controls.Add(this.txtMessaggioRicevuto);
            this.grpServer.Controls.Add(this.label3);
            this.grpServer.Controls.Add(this.cmbPortaServer);
            this.grpServer.Controls.Add(this.btnArrestaServer);
            this.grpServer.Controls.Add(this.btnAvviaServer);
            this.grpServer.Controls.Add(this.label2);
            this.grpServer.Controls.Add(this.lstIPServer);
            this.grpServer.Controls.Add(this.label1);
            this.grpServer.Location = new System.Drawing.Point(12, 12);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(676, 243);
            this.grpServer.TabIndex = 0;
            this.grpServer.TabStop = false;
            this.grpServer.Text = "Server";
            // 
            // txtMessaggioRicevuto
            // 
            this.txtMessaggioRicevuto.Location = new System.Drawing.Point(211, 169);
            this.txtMessaggioRicevuto.Name = "txtMessaggioRicevuto";
            this.txtMessaggioRicevuto.ReadOnly = true;
            this.txtMessaggioRicevuto.Size = new System.Drawing.Size(300, 22);
            this.txtMessaggioRicevuto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Messaggio ricevuto:";
            // 
            // cmbPortaServer
            // 
            this.cmbPortaServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortaServer.FormattingEnabled = true;
            this.cmbPortaServer.Items.AddRange(new object[] {
            "8080",
            "8888",
            "9999",
            "9090"});
            this.cmbPortaServer.Location = new System.Drawing.Point(351, 39);
            this.cmbPortaServer.Name = "cmbPortaServer";
            this.cmbPortaServer.Size = new System.Drawing.Size(121, 24);
            this.cmbPortaServer.TabIndex = 6;
            // 
            // btnArrestaServer
            // 
            this.btnArrestaServer.Enabled = false;
            this.btnArrestaServer.Location = new System.Drawing.Point(364, 97);
            this.btnArrestaServer.Name = "btnArrestaServer";
            this.btnArrestaServer.Size = new System.Drawing.Size(147, 23);
            this.btnArrestaServer.TabIndex = 5;
            this.btnArrestaServer.Text = " ARRESTA SERVER";
            this.btnArrestaServer.UseVisualStyleBackColor = true;
            // 
            // btnAvviaServer
            // 
            this.btnAvviaServer.Enabled = false;
            this.btnAvviaServer.Location = new System.Drawing.Point(211, 97);
            this.btnAvviaServer.Name = "btnAvviaServer";
            this.btnAvviaServer.Size = new System.Drawing.Size(147, 23);
            this.btnAvviaServer.TabIndex = 4;
            this.btnAvviaServer.Text = "AVVIA SERVER";
            this.btnAvviaServer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta di ascolto:";
            // 
            // lstIPServer
            // 
            this.lstIPServer.FormattingEnabled = true;
            this.lstIPServer.ItemHeight = 16;
            this.lstIPServer.Location = new System.Drawing.Point(19, 59);
            this.lstIPServer.Name = "lstIPServer";
            this.lstIPServer.Size = new System.Drawing.Size(140, 132);
            this.lstIPServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP di ascolto:";
            // 
            // grpClient
            // 
            this.grpClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpClient.Controls.Add(this.cmbPortaHostRemoto);
            this.grpClient.Controls.Add(this.btnInvia);
            this.grpClient.Controls.Add(this.txtMessaggioDaInviare);
            this.grpClient.Controls.Add(this.label6);
            this.grpClient.Controls.Add(this.label5);
            this.grpClient.Controls.Add(this.txtIPHostRemoto);
            this.grpClient.Controls.Add(this.label4);
            this.grpClient.Location = new System.Drawing.Point(12, 273);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(676, 260);
            this.grpClient.TabIndex = 1;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 46);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP host remoto:";
            // 
            // txtIPHostRemoto
            // 
            this.txtIPHostRemoto.Location = new System.Drawing.Point(178, 41);
            this.txtIPHostRemoto.Name = "txtIPHostRemoto";
            this.txtIPHostRemoto.Size = new System.Drawing.Size(140, 22);
            this.txtIPHostRemoto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Porta host remoto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Messaggio da inviare:";
            // 
            // txtMessaggioDaInviare
            // 
            this.txtMessaggioDaInviare.Location = new System.Drawing.Point(159, 181);
            this.txtMessaggioDaInviare.Name = "txtMessaggioDaInviare";
            this.txtMessaggioDaInviare.Size = new System.Drawing.Size(313, 22);
            this.txtMessaggioDaInviare.TabIndex = 5;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(211, 222);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(186, 23);
            this.btnInvia.TabIndex = 6;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            // 
            // cmbPortaHostRemoto
            // 
            this.cmbPortaHostRemoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortaHostRemoto.FormattingEnabled = true;
            this.cmbPortaHostRemoto.Items.AddRange(new object[] {
            "8080",
            "8888",
            "9999",
            "9090"});
            this.cmbPortaHostRemoto.Location = new System.Drawing.Point(178, 84);
            this.cmbPortaHostRemoto.Name = "cmbPortaHostRemoto";
            this.cmbPortaHostRemoto.Size = new System.Drawing.Size(140, 24);
            this.cmbPortaHostRemoto.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 554);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.grpServer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Socket es01";
            this.grpServer.ResumeLayout(false);
            this.grpServer.PerformLayout();
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.ComboBox cmbPortaServer;
        private System.Windows.Forms.Button btnArrestaServer;
        private System.Windows.Forms.Button btnAvviaServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIPServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.TextBox txtMessaggioRicevuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPortaHostRemoto;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.TextBox txtMessaggioDaInviare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIPHostRemoto;
        private System.Windows.Forms.Label label4;
    }
}

