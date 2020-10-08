using System;
using System.Drawing.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace es01_socket
{
    public partial class Form1 : Form
    {
        private clsSocket serverSocket;
        public delegate void aggiornaGraficaEventHandler(clsMessaggio Msg);

        public Form1()
        {
            InitializeComponent();
        }
        /**********************/
        /* Procedura iniziale */
        /**********************/
        private void Form1_Load(object sender, EventArgs e)
        {
            //Recupero gli IP del host locale
            clsAddress.cercaIP();
            lstIPServer.DataSource = clsAddress.ipVett;
            lstIPServer.SelectedIndex = 0;
        }
        /*****************************************/
        /* Gestisco selezione indirizzo IP server*/
        /*****************************************/
        private void lstIPServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //abilito il pulsante avvia server
            if (checkIPPorta())
            {
                btnAvviaServer.Enabled = true;
                cmbPortaServer.Enabled = false;
                lstIPServer.Enabled = false;
            }
        }
        /******************************************/
        /* Controllo seleezione ip e porta server */
        /******************************************/
        private bool checkIPPorta()
        {
            bool esito = false;
            if (lstIPServer.SelectedItem.ToString() != string.Empty && cmbPortaServer.Text != string.Empty)
                esito = true;

            return esito;
        }
        /**********************************/
        /* Gestisco selezione porta server*/
        /**********************************/
        private void cmbPortaServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkIPPorta())
            {
                btnAvviaServer.Enabled = true;
                cmbPortaServer.Enabled = false;
                lstIPServer.Enabled = false;
            }
        }
        /**********************/
        /* Avvio server socket*/
        /**********************/
        private void btnAvviaServer_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (serverSocket == null)
            {
                ip = clsAddress.ipVett[lstIPServer.SelectedIndex];
                //Istanzio il server socket
                serverSocket = new clsSocket(true, Convert.ToInt16(cmbPortaServer.Text), ip); //true perchè è il server
                serverSocket.datiRicevutiEvent += new datiRicevutiEventHandler(datiRicevuti);
            }

            //Richiamo la procesura di avvio del server
            serverSocket.avviaServer();
            //Gestico i bottoni del form
            btnAvviaServer.Enabled = false;
            btnArrestaServer.Enabled = true;
            btnInvia.Enabled = true;
            lblStatoServer.Text = "RUNNING";
        }
        /*************************************************/
        /* Procedura richiamata dall'evento dati riceuti */
        /*************************************************/
        private void datiRicevuti(clsMessaggio inMsg)
        {
            //Invio al client un ACK
            serverSocket.inviaMsg("ACK");
            //Visualizzo il messaggio inviato dal client
            aggiornaGraficaEventHandler pt = new aggiornaGraficaEventHandler(aggiornaGrafica); //puntatore alla procedura
            //Richiamo(invoco) la procedura che appartiene al thread della FORM1
            this.Invoke(pt, inMsg);
            /*
             * NB: Una procedura controllata da un thread non può scrivere direttamente su una FORM
             * ma li può leggere
             */
        }

        private void aggiornaGrafica(clsMessaggio inMsg)
        {
            //Visualizzo il messaggio inviato dal client
            txtMessaggioRicevuto.Text = inMsg.ToString();
        }
        /************************/
        /* Arresta server socket*/
        /************************/
        private void btnArrestaServer_Click(object sender, EventArgs e)
        {
            //Richiamo procedura di arresto del server
            serverSocket.arrestaServer();
            //Gestico i bottoni del form
            btnAvviaServer.Enabled = true;
            btnArrestaServer.Enabled = false;
            btnInvia.Enabled = false;
            lblStatoServer.Text = "STOPPED";
            txtMessaggioRicevuto.Text = String.Empty;
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {

        }
    }
}