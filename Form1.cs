using System.Data.SqlClient;
using System.Diagnostics;
using tanverseny.Properties;

namespace tanverseny
{
    public partial class Form1 : Form
    {
        private static SqlConnection connection = new SqlConnection(Resources.DBConnectionString);

        public Form1()
        {
            InitializeComponent();
            
        }
        private void FrmLoad(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void Frissites(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("select * from tanverseny;", connection);

            SqlDataReader reader = sql.ExecuteReader();

            dgvTablazat.Rows.Clear();
            while (reader.Read())
            {
                dgvTablazat.Rows.Add(
                    reader.GetInt32(0),
                    reader[1],
                    reader[2],
                    reader[3],
                    reader.GetDateTime(4).ToShortDateString());
            }
            dgvTablazat.AutoResizeColumns();

            reader.Close();
        }

        private void Modositas(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan menteni szeretne?", "Adatentés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result.HasFlag(DialogResult.No)) return;

            SqlCommand sql = new SqlCommand("update tanverseny.dbo.tanverseny set " +
                $"versenynev = '{tbVnev.Text}', " +
                $"tipus = '{tbVtipus.Text}', " +
                $"esemeny = '{tbEsemeny.Text}', " +
                $"datum = '{dtp.Value.ToShortDateString().Replace(".", "").Replace(" ", "-")}' " +
                $"where azonosito = {GetRowIndex()};", connection);


            sql.ExecuteNonQuery();

            Frissites(null, null);
        }

        private void Beszuras(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan szeretné hozzáadni a sort az adatbázishoz?", "Adatentés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result.HasFlag(DialogResult.No)) return;

            SqlCommand sql = new SqlCommand($"insert into tanverseny.dbo.tanverseny values " +
                $"({dgvTablazat.RowCount + 1}, '{tbVnev.Text}', '{tbVtipus.Text}', '{tbEsemeny.Text}', '{dtp.Value.ToShortDateString().Replace(".", "").Replace(" ", "-")}');", connection);

            sql.ExecuteNonQuery();

            Frissites(null, null);
        }


        private void KijelolesValtozott(object sender, EventArgs e)
        {
            if (dgvTablazat.SelectedRows.Count == 1)
            {
                tbVnev.Text = Convert.ToString(dgvTablazat.SelectedRows[0].Cells[1].Value);
                tbVtipus.Text = Convert.ToString(dgvTablazat.SelectedRows[0].Cells[2].Value);
                tbEsemeny.Text = Convert.ToString(dgvTablazat.SelectedRows[0].Cells[3].Value);

                string[] date = Convert.ToString(dgvTablazat.SelectedRows[0].Cells[4].Value).Replace(".", "").Split(" ");
                dtp.Value = new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
                btnModosit.Enabled = true;
            }
            else
                btnModosit.Enabled = false;
        }

        private void TextBoxValtozott(object sender, EventArgs e)
        {
            if (tbEsemeny.Text.Trim().Length > 0 && tbVtipus.Text.Trim().Length > 0 && tbVnev.Text.Trim().Length > 0)
                btnBeszur.Enabled = true;
            else
                btnBeszur.Enabled = false;
        }

        private int GetRowIndex() => Convert.ToInt32(dgvTablazat.SelectedRows[0].Cells[0].Value);


    }
}