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
    public partial class Form6 : Form
    {

        //Array
        string[] array_Questao = new string[] { "A Lua é um:", "Quantos minutos há em 2 horas?", "Nos livros da série Percy Jackson, de que deus grego Percy é filho?" };
        string[] array_Resposta = new string[] { "Satélite", "Asteroide", "Buraco Negro", "Planeta", "60 min", "160 min", "120 min", "180 min", "Hades", "Athena", "Zeus", "Poseidon" };
        //respostas rdo1, rdo3,rdo4

        //Variavel
        int randAux;


        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
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

            Form7 form7 = new Form7();

            if (randAux == 0 && rdoVal1.Checked)
            {
                MessageBox.Show("Acertou", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form7.Show();
                this.Hide();
            }
            else if (randAux == 1 && rdoVal3.Checked)
            {
                MessageBox.Show("Acertou", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form7.Show();
                this.Hide();
            }
            else if (randAux == 2 && rdoVal4.Checked)
            {
                MessageBox.Show("Acertou", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Errou", "Que Pena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
