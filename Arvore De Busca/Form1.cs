using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arvore_De_Busca
{
    public partial class Form1 : Form
    {
        Arvore arv = new Arvore(); Noh noh = new Noh(0);
        public Form1()
        {
            InitializeComponent();
        }
        void PreencherMostrar(string espaco, int nVezes)//preenche com espacos as partes onde nao tem valores
        {
            for (int i = 0; i < nVezes; i++)
            {
                Console.Write(espaco);
                richTextBox1.AppendText(espaco);
            }
        }
        void Mostrar(int linha, Noh no)
        {
            if (no == null)
            {
                PreencherMostrar("   ", linha);//espaços depois do valor, linha = quantidade de elementos na arvore
                Console.WriteLine("  ");
                richTextBox1.AppendText("  " + Environment.NewLine);
            }
            else
            {
                Mostrar(linha + 1, no.Direita);
                PreencherMostrar("   ", linha);//espaços antes do valor
                Console.Write(no.Valor);//imprime o valor digitado
                richTextBox1.AppendText(no.Valor.ToString());
                Mostrar(linha + 1, no.Esquerda);
            }

        }
        void PreOrdem(Noh no)
        {
            if (no != null)
            {
                richTextBox1.AppendText(no.Valor + ", ");
                PreOrdem(no.Esquerda);
                PreOrdem(no.Direita);
            }
        }
        void PosOrdem(Noh no)
        {
            if (no != null)
            {
                EmOrdem(no.Esquerda);
                EmOrdem(no.Direita);
                richTextBox1.AppendText(no.Valor + ", ");
            }
        }
        void EmOrdem(Noh no)
        {
            if (no != null)//pega o menor (esquerda) depois o maior (direita)
            {
                EmOrdem(no.Esquerda);
                richTextBox1.AppendText(no.Valor + ", ");
                EmOrdem(no.Direita);
            }
        }
       
        private void Mensagem(string mensagem, string titulo, bool erro, bool info)
        {
            if (erro == true)
            {
                lblstats.Text = titulo;
                lblstats.ForeColor = Color.Red;
                MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (info == true)
            {
                lblstats.Text = titulo;
                lblstats.ForeColor = Color.Green;
                MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblstats.Text = mensagem;
                lblstats.ForeColor = Color.Green;
            }
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != null)
            {
                int valor = Convert.ToInt32(textBox1.Text);
                arv.Inserir(valor);
                if (Noh.Repetido == false)
                {
                    Mensagem("Valor adicionado com sucesso!", "", false, false);
                    Mostrar(0, arv.raiz);
                }
                else
                {
                    Mensagem("Este valor já foi adicionado!", "Valor repetido", true, false);
                }
                richTextBox1.Clear();
                Mostrar(0, arv.raiz);
            }
            else
            {
                Mensagem("Favor inserir um valor!", "Erro", true, false);
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            lblstats.Text = "-";
        }
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (textBox1.Text != "" & Convert.ToInt32(arv.Quantidade) > 0)
            {
                arv.Remover(arv.Raiz, Convert.ToInt32(textBox1.Text));

                Mostrar(0, arv.Raiz);
                if (Arvore.AUX == true)
                {
                    Mensagem("Valor removido com sucesso!", "", false, false);
                }
                else
                {
                    Mensagem("Não foi possivel remover este valor, verifique se o valor está correto e tente novamente!", "Valor não removido!", true, false);
                }
            }
        }
        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != null)
            {
                arv.Procurar(arv.Raiz, Convert.ToInt32(textBox1.Text));
                if (Arvore.AUX == true)
                {
                    Mensagem("Valor \"" + Arvore.ValorProc + "\" encontrado com sucesso! ", "Valor encontrado!", false, true);
                }
                else
                {
                    Mensagem("Valor não encontrado, verifique se o valor está correto e tente novamente!", "Valor não encontrado!", true, false);
                }
            }
            else
            {
                Mensagem("Favor inserir um valor!", "Erro", true, false);
            }
        }
        private void BtnPreOrdem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Environment.NewLine + "Valores em pré ordem: ");
            PreOrdem(arv.Raiz);
        }
        private void BtnPosOrdem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Environment.NewLine + "Valores em pós ordem: ");
            PosOrdem(arv.Raiz);
        }
        private void BtnEmOrdem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Environment.NewLine + "Valores em ordem: ");
            EmOrdem(arv.Raiz);
        }
        private void BtnLargura_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Environment.NewLine + "Largura da árvore: " + arv.Largura(arv.Raiz));
        }
    }
}
