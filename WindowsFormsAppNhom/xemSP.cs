﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNhom
{
    public partial class xemSP : Form
    {
        public xemSP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dkTK dkTK = new dkTK();
            dkTK.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangNhap dangNhap = new dangNhap();
            dangNhap.ShowDialog();
            this.Close();
            khachHang dkHK = new khachHang();
            dkHK.Close();
<<<<<<< HEAD
=======
        }

        private void xemSP_Load(object sender, EventArgs e)
        {

>>>>>>> c68133ec8eb1ff0d5ea3c4fcdec58ba2c32b2ba4
        }

        private void xemSP_Load(object sender, EventArgs e)
        {

        }
    }
}
