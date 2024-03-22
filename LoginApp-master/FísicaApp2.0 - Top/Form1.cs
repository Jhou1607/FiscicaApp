namespace FísicaApp2._0___Top
{
    public partial class Form1 : Form
    {
        // Variável global para armazenar o painel ativo
        Panel painelAtivo;

        // Evento para identificar o painel ativo
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            painelAtivo = (sender as radiobutton).Tag as Panel;
        }

       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            double valor1 = 0;
            double valor2 = 0;

            foreach (Control control in painelAtivo.Controls)
            {
                if (control is TextBox txt)
                {
                    if (txt.Name == "txtValor1")
                    {
                        valor1 = double.Parse(txt.Text);
                    }
                    else if (txt.Name == "txtValor2")
                    {
                        valor2 = double.Parse(txt.Text);
                    }
                }
            }
            double resposta = valor1 + valor2;

            lblResultado.Text = resposta.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Painelvmedia.Visible = false;
            Paineltorricelli.Visible = false;
            Painelxrl8.Visible = false;
            PainelMU.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Painelvmedia.Visible = false;
            Paineltorricelli.Visible = false;
            Painelxrl8.Visible = true;
            PainelMU.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Painelvmedia.Visible = true;
            Paineltorricelli.Visible = false;
            Painelxrl8.Visible = false;
            PainelMU.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void xrl8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Painelvmedia.Visible = false;
            Paineltorricelli.Visible = true;
            Painelxrl8.Visible = false;
            PainelMU.Visible = false;
        }

        private void Calcular_Click(object sender, EventArgs e)
        {

        }
    }
}
