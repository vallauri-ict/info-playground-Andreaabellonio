using System;

namespace es01_socket
{
    public class clsMessaggio
    {
        public string ip;
        public UInt16 porta;
        public string messaggio;

        public override string ToString()
        {
            // Ritorno del Metodo ToString() base
            // return base.ToString();

            return this.ip + " : " +
                   this.porta.ToString() + " - " +
                   this.messaggio;
        }
    }
}