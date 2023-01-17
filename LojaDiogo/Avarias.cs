using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDiogo
{
    internal class Avarias
    {
        private int codigo;
        private DateTime data;
        private string nomeCliente;
        private long telefone;
        private string email;
        private string avaria;
        private Boolean garantia;

        public Avarias()
        {
            this.codigo = 0;
            this.data = DateTime.MinValue;
            this.nomeCliente = null;
            this.telefone = 0;
            this.email = null;
            this.avaria = null;
            this.garantia = false;
        }
    }
}
