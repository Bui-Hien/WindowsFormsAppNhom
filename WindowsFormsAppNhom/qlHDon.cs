using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNhom
{
    public partial class qlHDon : Form
    {
        string connectString = "Data Source=ADMIN\\QUOCHUY;Initial Catalog=SQLTest; Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dtap;
        DataTable dt = new DataTable();
        public qlHDon()
        {
            InitializeComponent();
        }

        private void qlHDon_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectString);

            try
            {
                con.Open();
                string sql = "Select * from SanPham";
                dtap = new SqlDataAdapter(sql, con);
                dtap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
