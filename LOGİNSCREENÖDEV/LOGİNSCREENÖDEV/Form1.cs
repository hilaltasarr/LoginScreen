namespace LOGİNSCREENÖDEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdı.Text == "hilaltasar" && txtPassword.Text == "hilal123")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış,tekrar deneyiniz");
                txtKullanıcıAdı.Clear();
                txtPassword.Clear();
                txtKullanıcıAdı.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
               txtPassword.PasswordChar=  '*';
            }
        }
    }
}