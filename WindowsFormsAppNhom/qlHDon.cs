﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        string connectionString = "Data Source=ADMIN\\QUOCHUY;Initial Catalog=quanlybandtdd; Integrated Security=True";
        SqlConnection connection = null;
        DataTable dttb;
        public qlHDon()
        {
            InitializeComponent();
        }

        private void qlHDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string qerry = "select maKh,tenKh,soDienThoai from khachHang";
<<<<<<< HEAD
            
=======
<<<<<<< HEAD
            
=======
            string querry = "select mahh,giaban from hanghoa";
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
>>>>>>> 4779f2e7b36ec845870772a12a143de3eb042b64
            SqlDataAdapter dtp = new SqlDataAdapter(qerry, connection);
            dttb = new DataTable();
            dtp.Fill(dttb);
            DtgvDSHD.DataSource = dttb;
        }
    }
}
