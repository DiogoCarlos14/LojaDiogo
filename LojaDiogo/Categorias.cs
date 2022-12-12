using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDiogo
{
    public class Categorias
    {
        //Atributos
        private int codigo;  //maior que 0
        private string categoria; //de 3 a 50 chars
        private string zona; //letra de A a Z
        private int fila; // 1 a 100
        private int prateleira; // 1 a 10

        //construtor
        public Categorias()
        {
            this.codigo = -1;
            this.categoria = null;
            this.zona = null;
            this.fila = 0;
            this.prateleira = 0;
            
        }

        public Categorias(int codigo, string categoria, string zona, int fila, int prateleira)
        {
            this.codigo = codigo;
            this.categoria = categoria;
            this.zona = zona;
            this.fila = fila;
            this.prateleira = prateleira;
        }

        public int getCodigo() { return this.codigo; }
        public string getCategoria() { return this.categoria; }
        public string getZona() { return this.zona; }
        public int getFila() { return this.fila; }
        public int getPrateleira() { return this.prateleira; }

        //modficadores (setters)
        public void setCodigo(int codigo) { this.codigo = codigo; }
        public void setCategoria(string categoria) { this.categoria = categoria; }
        public void setZona(string zona) { this.zona = zona; }
        public void setFila(int fila) { this.fila = fila; }
        public void setPrateleira(int prateleira) { this.prateleira = prateleira; } 


    }
}
