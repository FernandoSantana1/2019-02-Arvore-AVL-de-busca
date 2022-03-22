using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore_De_Busca
{
    class Noh
    {
        int? valor;
        private static bool repetido;
        Noh anterior, esquerda, direita;
        public int? Valor
        {
            get { return valor; }
        }
        public static bool Repetido
        {
            get { return repetido; }
            set { repetido = value; }
        }
        public Noh Anterior
        {
            get { return anterior; }
        }
        public Noh(int valor)
        {
            this.valor = valor;
        }
        public Noh Direita
        {
            get { return direita; }
            set { direita = value; }
        }
        public Noh Esquerda
        {
            get { return esquerda; }
            set { esquerda = value; }
        }
        public void setValor(int? val)
        {
            valor = val;
        }
        public void setAnterior(Noh no)
        {
            anterior = no;
        }
        public void setDireita(Noh no)
        {
            direita = no;
        }
        public void setEsquerda(Noh no)
        {
            esquerda = no;
        }
    }
}
