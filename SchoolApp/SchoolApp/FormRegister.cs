using MySql.Data.MySqlClient;

namespace SchoolApp
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Registrasi Gagal! Full Name, Username dan Password wajib diisi!.");
                return;
            }

            bool validation = Validation.UniqueData("Users", "Username", txtUsername.Text);

            if (validation)
            {
                MessageBox.Show("Registrasi gagal! Username sudah terdaftar.");
                return;
            }
            string passwordhashed = SecurityHelper.HashingPassword(txtPassword.Text);
            Connection conn = new Connection();

            using (MySqlConnection connection = conn.ConnectionToSQL())
            {
                connection.Open();

                string query = "INSERT INTO users (full_name, username, password) VALUES (@full_name, @user, @pass)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);

                    cmd.Parameters.AddWithValue("@pass", passwordhashed);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Registrasi Berhasil! Silahkan Login");
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
        }

        private void btnNavToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmLogin = new();
            frmLogin.Show();
        }
    }
}
