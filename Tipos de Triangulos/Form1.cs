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
                double lado1, lado2, lado3; //lados do triângulo
                lado1 = Convert.ToDouble(txtLado1.Text);
                lado2 = Convert.ToDouble(txtLado2.Text);
                lado3 = Convert.ToDouble(txtLado3.Text);
                if ((lado1 + lado2 >= lado3) && (lado1 + lado3 >= lado2) && (lado2 + lado3 >= lado1))//verifica se é triângulo
                {
                    if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1)//lados iguais?
                    {
                        lblResultado.Text = "Triangulo Equilátero";
                    }
                    else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)// dois lados são iguais?
                    {
                        lblResultado.Text = "Triangulo Isósceles";
                    }
                    else if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1)//os lados são diferentes?
                    {
                        lblResultado.Text = "Triangulo Escaleno";
                    }
                }
                else
                {
                    lblResultado.Text = "Não é um triângulo";
                }
            }
            catch
            {
                lblResultado.Text = "Error!"; MessageBox.Show("Insira valores numéricos válidos!", "Erro");
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