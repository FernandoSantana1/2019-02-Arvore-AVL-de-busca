using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore_De_Busca
{
    class Arvore
    {
        int quantidade = 0;
        public Noh Raiz
        {
            get { return raiz; }
        }
        private static bool aux;
        private static int valorProc;
        public static int ValorProc
        {
            get { return valorProc; }
            set { valorProc = value; }
        }
        public static bool AUX
        {
            get { return aux; }
            set { aux = value; }
        }
        public string Quantidade
        {
            get { return quantidade.ToString(); }
        }
        public Noh raiz;
        public int max(int larg, int dir)
        {
            return larg > dir ? larg : dir; //retorna se larg for maior q a dir = larg, se nao = dir
        }
        public void Inserir(int valor)
        {
            Noh num = new Noh(valor);
            if (raiz == null)
            {
                raiz = num;
                raiz.setValor(valor);
                raiz.setDireita(null);
                raiz.setEsquerda(null);
            }
            else
            {
                Noh aux = BuscarInsercao(valor);
                if (aux == null)
                {
                    Noh.Repetido = true;
                }
                else
                {
                  
                    raiz = Inserir(raiz, num);
                    Noh.Repetido = false;
                }
            }
        }
        private Noh Inserir(Noh noh, Noh raiz)
        {
            if (noh == null)
            {
                noh = raiz;
                return noh;
            }
            else if (raiz.Valor < noh.Valor)
            {
                noh.Esquerda = Inserir(noh.Esquerda, raiz);
                noh = Balancear(noh);
                raiz.setAnterior(noh);
            }
            else if (raiz.Valor > noh.Valor)
            {
                noh.Direita = Inserir(noh.Direita, raiz);
                noh = Balancear(noh);
                raiz.setAnterior(noh);
            }
            quantidade++;
            return noh;
        }
        public void Remover(Noh no, int? valor)
        {
            if (no == null)
            {
                AUX = false;
            }
            else
            {
                if (valor > no.Valor)
                {
                    Remover(no.Direita, valor);
                }
                else if (valor < no.Valor)
                {
                    Remover(no.Esquerda, valor);
                }
                else
                {
                    if (no.Direita != null && no.Esquerda != null)//se tem os dois filhos
                    {
                        Noh aux;
                        aux = no.Direita;
                        while (aux.Esquerda != null)// percorre até chegar ao nó mais a esquerda do nó a direita (menor nó da direita)
                        {
                            aux = aux.Esquerda;
                        }
                        no.setValor(aux.Valor);// torna o valor o novo pai
                        Remover(aux, aux.Valor);//aplica para o filho do novo pai
                    }
                    else if (no.Direita != null)//se tem apenas o filho direito
                    {
                        SubstituirPai(no.Direita);
                    }
                    else if (no.Esquerda != null)// se tem apenas o filho esquerdo
                    {

                        SubstituirPai(no.Esquerda);
                    }
                    else // se não tem nenhum filho
                    {
                        {
                            if (no.Anterior != null)
                            {
                                if (no.Valor >= no.Anterior.Valor)
                                {
                                    no.Anterior.setDireita(null); //remove 
                                }
                                else
                                {
                                    no.Anterior.setEsquerda(null);//remove 
                                }
                            }
                        }
                    }

                    quantidade--;
                    AUX = true;
                }
            }
        }
        public Noh Procurar(Noh no, int valor)
        {
            if (no == null)//se nao existir o nó
            {
                AUX = false;//usada para verificar se o valor foi encontrado ou nao
                return null;
            }
            else
            {
                if (valor == no.Valor)
                {
                    AUX = true;
                    ValorProc = valor;
                    return no;
                }
                else if (valor < no.Valor)
                {
                    Procurar(no.Esquerda, valor);
                }
                else
                {
                    Procurar(no.Direita, valor);
                }
            }
            return null;
        }
        public int Maior(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public int Largura(Noh no)
        {
            if ((no == null) || (no.Esquerda == null && no.Direita == null))
            {
                return 0;
            }
            else
            {
                return 1 + (Maior(Largura(no.Esquerda), Largura(no.Direita)));
            }
        }
        public void SubstituirPai(Noh no)
        {
            if (no == no.Anterior.Esquerda)// se for o nó esquerdo
            {
                no.setAnterior(no.Anterior.Anterior);
                no.Anterior.setEsquerda(no);// remove o filho da esquerda
            }
            else if (no == no.Anterior.Direita)// se for o nó direito
            {
                no.setAnterior(no.Anterior.Anterior);// remove o filho da direita
                no.Anterior.setDireita(no);
            }
        }
        public Noh BuscarInsercao(int valor)
        {
            Noh no;
            no = Raiz;
            bool x = true;
            do
            {
                if (valor < no.Valor)
                {
                    if (no.Esquerda == null)
                    {
                        return no;
                    }
                    if (no.Esquerda != null)
                    {
                        no = no.Esquerda;
                    }
                }

                if (valor > no.Valor)
                {
                    if (no.Direita == null)
                    {
                        return no;
                    }
                    if (no.Direita != null)
                    {
                        no = no.Direita;
                    }
                }

                if (valor == no.Valor)
                {
                    return null;
                }
            } while (x);
            return null;
        }

        ///////////////////////////  AVL  ///////////////////////////
        public Noh Balancear(Noh noh)
        {
            int altura = CalcBalanco(noh);
            if (altura > 1)
            {
                //rotacoes
                if (CalcBalanco(noh.Esquerda) > 0)
                {
                    noh = GirarDir(noh);
                }
                else
                {
                    noh = GirarEsqDir(noh);
                }
            }
            else if (altura < -1)
            {
                if (CalcBalanco(noh.Direita) > 0)
                {
                    noh = GirarDirEsq(noh);
                }
                else
                {
                    noh = GirarEsq(noh);
                }
            }
            return noh;
        }
        public int tamanho(Noh filho)
        {
            int tamaho = 0;
            if (filho != null)
            {
                int esq = tamanho(filho.Esquerda);
                int dir = tamanho(filho.Direita);
                int m = max(esq, dir);
                tamaho = m + 1;
            }
            return tamaho;
        }
        public int CalcBalanco(Noh filho)
        {
            int l = tamanho(filho.Esquerda);
            int r = tamanho(filho.Direita);
            int balance = l - r;
            return balance;
        }
        public Noh GirarEsq(Noh filho)
        {
            Noh index = filho.Direita;
            filho.Direita = index.Esquerda;
            index.Esquerda = filho;
            return index;
        }
        public Noh GirarDir(Noh filho)
        {
            Noh index = filho.Esquerda;
            filho.Esquerda = index.Direita;
            index.Direita = filho;
            return index;
        }

        public Noh GirarEsqDir(Noh filho)
        {
            Noh index = filho.Esquerda;
            filho.Esquerda = GirarEsq(index);
            return GirarDir(filho);
        }

        public Noh GirarDirEsq(Noh filho)
        {
            Noh index = filho.Direita;
            filho.Direita = GirarDir(index);
            return GirarEsq(filho);
        }
    }
}
