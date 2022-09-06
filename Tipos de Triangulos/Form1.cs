namespace Tipos_de_Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double lado1, lado2, lado3; //lados do tri�ngulo
                lado1 = Convert.ToDouble(txtLado1.Text);
                lado2 = Convert.ToDouble(txtLado2.Text);
                lado3 = Convert.ToDouble(txtLado3.Text);
                if ((lado1 + lado2 >= lado3) && (lado1 + lado3 >= lado2) && (lado2 + lado3 >= lado1))//verifica se � tri�ngulo
                {
                    if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1)//lados iguais?
                    {
                        lblResultado.Text = "Triangulo Equil�tero";
                    }
                    else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)// dois lados s�o iguais?
                    {
                        lblResultado.Text = "Triangulo Is�sceles";
                    }
                    else if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1)//os lados s�o diferentes?
                    {
                        lblResultado.Text = "Triangulo Escaleno";
                    }
                }
                else
                {
                    lblResultado.Text = "N�o � um tri�ngulo";
                }
            }
            catch
            {
                lblResultado.Text = "Error!"; MessageBox.Show("Insira valores num�ricos v�lidos!", "Erro");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Close();
            txtLado1.Text = "";
            txtLado2.Text = "";
            txtLado3.Text = "";
            lblResultado.Text = "";
            
        }
    }
}