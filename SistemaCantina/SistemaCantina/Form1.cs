using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCantina
{
    public partial class Form1 : Form
    {
        /* Declaração de 3 arrays para armazenar 6 produtos cada um e seus respectivos códigos e valores. */

        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma = 0;

       


        public Form1()
        {
            InitializeComponent();
        }

       

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
            /*inicia com uma condição, se o usuário digitar um código com 5 caracteres (length), esse código é adicionado ao listBox. 
              A propriedade length retorna a quantidade de caracteres.*/ 

            if(textCodigo.Text.Length == 3)
           

            {
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++ )

                /*Faça enquanto o prod for menor ou igual a qtde de itens do array */
                {
                    if(textCodigo.Text == codigo[prod])
                    {
                        indice = prod;

                    }
                }

               if(indice == 0)
               {
                   MessageBox.Show("Produto não encontrado");
               }

                   /*Condição, se foi encontrado o produto ele retorna as informações de acordo com o índice 
                     caso não encontre aparecerá a mensagem, Produto não encontrado*/

                else
               {
                   listCaixa.Items.Add(textCodigo.Text + "--" + produtos[indice] + "--R$ " + valor[indice]);

                   /* Conteúdo adicionado no ListBox, concatena (+) as informaçôes (código/nome/valor)*/
                  
                   soma = soma + valor[indice];
                   lblTitulo3.Text = ("R$: " + soma);

                   picImagem.ImageLocation = "c:/imagem/" + codigo[indice] + ".jpg";
                   textCodigo.Text = "";
                   textCodigo.Focus();

                   /*localização da imagem que deve ser colocada em uma pasta em c: em uma pasta imagens otextbox
                    será limpo e o Focus posiciona o cursorpara o TextBox para uma nova digitação*/



               }
            } 

               
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Ao entrar no Form Load será chamado o método*/
            
            carregarArray();
            soma = 0;


        }
        /*Ao entra no from load será chamando o método */ 

        private void carregarArray()
        {
            /*Criação do Método para ser chamado quando necessário, 
             isso evita repetir várias vezes o mesmo código*/

            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot_Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "suco";

            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;
        }

        /*Códigos, Produtos e Valores ref. os arrays que foram declarados*/

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando codigo Sair close

            Close();

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando o codigo Limpar , listCaixa, picImage, lbTitulo3.text

            listCaixa.Items.Clear();
            picImagem.Image = null;
            lblTitulo3.Text = " ";


            
            



        }

        private void lblTitulo4_Click(object sender, EventArgs e)
        {

        }
    }
}
