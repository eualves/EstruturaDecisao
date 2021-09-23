using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaDecisão
{
    public partial class TelaEstrutura : Form
    {
        public TelaEstrutura()
        {
            InitializeComponent();
        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            int valor01 = Convert.ToInt32(Num01.Value);
            int valor02 = Convert.ToInt32(Num02.Value);
            int valor03 = Convert.ToInt32(Num03.Value);

            if (valor01 == valor02 && valor02 == valor03)
            {
                lblResultado.Text = "Os valores são iguais!";
                return;
            }
            if (valor01 > valor02 && valor01 > valor03)
            {
                lblResultado.Text = "O Valor 1 é o maior!";
            }else if (valor02 > valor01 && valor02 > valor03){
                lblResultado.Text = "O Valor 2 é o maior!";
                return;
            } else if (valor03 > valor01 && valor03 > valor02)
            {
                lblResultado.Text = "O Valor 3 é o maior!";
                return;
            }

            if (valor01 == valor02 && valor01 > valor03 && valor02 > valor03)
            {
                lblResultado.Text = "Os valores 1 e 2 são maiores!";
                return;
            }else if (valor01 == valor03 && valor01 > valor02 && valor03 > valor02)
            {
                lblResultado.Text = "Os valores 1 e 3 são maiores!";
                return;
            }
            else if (valor02 == valor03 && valor02 > valor01 && valor03 > valor01)
            {
                lblResultado.Text = "Os valores 2 e 3 são maiores!";
                return;
            }
        }



        private void TelaEstrutura_Load(object sender, EventArgs e)
        {

        }
    }
}
