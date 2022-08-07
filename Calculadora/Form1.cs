using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {
        private string[] aValores;
        private float fValorTotal = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button oButton = (Button)sender;
            txtResultado.Text += oButton.Text;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1 );
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string sValue = txtResultado.Text;

            if (sValue.Contains("+"))
            {
                aValores = sValue.Split('+');
                for (int i = 1; i < aValores.Length; i++)
                {
                    fValorTotal = float.Parse(aValores[i - 1]);
                    fValorTotal += float.Parse(aValores[i]);
                }
            }

            if (sValue.Contains("-")){
                aValores = sValue.Split('-');

                for (int i = 1; i < aValores.Length; i++)
                {
                    fValorTotal = float.Parse(aValores[i - 1]);
                    fValorTotal -= float.Parse(aValores[i]);
                }
            }

            if (sValue.Contains("x"))
            {
                aValores = sValue.Split('x');

                for (int i = 1; i < aValores.Length; i++)
                {
                    fValorTotal = float.Parse(aValores[i - 1]);
                    fValorTotal *= float.Parse(aValores[i]);
                }
            }

            if (sValue.Contains("÷"))
            {
                aValores = sValue.Split('÷');

                for (int i = 1; i < aValores.Length; i++)
                {
                    fValorTotal = float.Parse(aValores[i - 1]);
                    fValorTotal /= float.Parse(aValores[i]);
                }
            }

            txtResultado.Text = fValorTotal.ToString();
        }
    }
}
