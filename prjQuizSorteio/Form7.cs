using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjQuizSorteio
{
    public partial class Form7 : Form
    {

        //Array
        string[] array_Questao = new string[] { "Qual é o coletivo de peixes?", "Qual dos Pokémons abaixo é do tipo fogo?", "Que planeta do nosso Sistema Solar é famoso por seus grandes anéis de poeira?" };
        string[] array_Resposta = new string[] { "Cardume", "Grupo", "Maré", "Corrente marítima", "Pikachu", "Squirtle", "Charmander", "Bulbassauro", "Júpiter", "Marte", "Urano", "Saturno" };
        //respostas rdo1, rdo3,rdo4

        //Variavel
        int randAux;


        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            //Instanciando o metodo random
            Random rnd = new Random();

            //declarando uma variavel que capture as perguntas aleatoriamente dentro do array
            int rand = rnd.Next(array_Questao.Length);

            randAux = rand;

            lblPergunta.Text = array_Questao[rand];

            if (rand == 0)
            {
                rdoVal1.Text = array_Resposta[0];
                rdoVal2.Text = array_Resposta[1];
                rdoVal3.Text = array_Resposta[2];
                rdoVal4.Text = array_Resposta[3];
            }
            else if (rand == 1)
            {
                rdoVal1.Text = array_Resposta[4];
                rdoVal2.Text = array_Resposta[5];
                rdoVal3.Text = array_Resposta[6];
                rdoVal4.Text = array_Resposta[7];
            }
            else
            {
                rdoVal1.Text = array_Resposta[8];
                rdoVal2.Text = array_Resposta[9];
                rdoVal3.Text = array_Resposta[10];
                rdoVal4.Text = array_Resposta[11];
            }
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {

            Form8 form8 = new Form8();

            if (randAux == 0 && rdoVal1.Checked)
            {
                MessageBox.Show("Acertou", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form8.Show();
                this.Hide();
            }
            else if (randAux == 1 && rdoVal3.Checked)
            {
                MessageBox.Show("Acertou", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form8.Show();
                this.Hide();
            }
            else if (randAux == 2 && rdoVal4.Checked)
            {
                MessageBox.Show("Acertou", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form8.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Errou", "Que Pena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
