namespace LoginApp
{
    public partial class FrmLogin : Form
    {
        string ra = "2357029";


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void chbExibir_CheckedChanged(object sender, EventArgs e)
        {
            if (chbExibir.Checked)
                txtSenha.PasswordChar = '\0';
            else
            txtSenha.PasswordChar = '*';
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToUpper() == "ADMIN" && txtSenha.Text == "ra" + ra)
            {
                MessageBox.Show("Acesso Permitido!");
                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciais Incorretas");
            }
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo ao sistema de login de teste!");
        }
    }
}
