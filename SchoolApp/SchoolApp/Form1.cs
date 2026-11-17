using MySql.Data.MySqlClient;
using System.Data;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        int selectedId = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private MySqlConnection Connection()
        {
            string strConnection = "Server=localhost;Database=pi_school;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }

        private void ShowData()
        {
            using (MySqlConnection conn = Connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM visitors";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvData.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                }
            }
        }

        private void ClearData()
        {
            txtName.Clear();
            txtInstitution.Clear();
            selectedId = 0;
            txtName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtInstitution.Text))
            {
                MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = Connection())
            {
                try
                {
                    conn.Open();
                    string queryInsert = "INSERT INTO visitors (visitor_name, institution) VALUES (@name, @institution)";
                    using (MySqlCommand cmd = new MySqlCommand(queryInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@institution", txtInstitution.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("input data success!", "Input Notif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInstitution.Clear();
                    txtName.Clear();

                    ShowData();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                Console.Write($"{row}");

                selectedId = Convert.ToInt32(row.Cells["id"].Value);

                txtName.Text = row?.Cells["visitor_name"]?.Value?.ToString();
                txtInstitution.Text = row?.Cells["institution"]?.Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a record to edit!", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtInstitution.Text))
            {
                MessageBox.Show("Please fill all fields!", "Edit Eror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = Connection())
            {
                try
                {
                    conn.Open();
                    string queryUpdate = "Update visitors SET visitor_name = @name, institution = @institution where id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(queryUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@institution", txtInstitution.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Update data Success!", "Input Notif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                    ClearData();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a record to delete!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogConfirm = MessageBox.Show("Are you sure want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogConfirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = Connection())
                {
                    try
                    {
                        conn.Open();
                        string queryDelete = "DELETE FROM visitors WHERE id = @id;";
                        using (MySqlCommand cmd = new MySqlCommand(queryDelete, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Delete data Success!", "Delete Notif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                        ClearData();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                    }
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
