using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNhom
{
    public partial class xemSP : Form
    {
        int i = 0;
        public static string stringName = null;
        public static string stringGiasp = null;
        public static string stringslcon = null;
        public static string stringlink = null;
        public static string stringmasp = null;
        public List<object> dataListLink = new List<object>();
        public List<object> dataListName = new List<object>();
        public List<object> dataListMasp = new List<object>();
        public List<object> datalistGia = new List<object>();
        public List<object> datalistSl = new List<object>();
        string connectionString = "Data Source='"+dkTK.nameSQL+"';Initial Catalog=quanlybandtdd; Integrated Security=True";
        SqlConnection connection = null;
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
        }

        private void xemSP_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select linkImg,tensp,mahh,giaban,soLuong from hangHoa";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                object data = reader.GetValue(0);
                object getName = reader.GetValue(1);
                object masp = reader.GetValue(2);
                object giasp = reader.GetValue(3);
                object slsp = reader.GetValue(4);
                dataListLink.Add(data);
                dataListName.Add(getName);
                dataListMasp.Add(masp);
                datalistGia.Add(giasp);
                datalistSl.Add(slsp);
            }
            reader.Close();
            var pictureBoxes = this.Controls.OfType<PictureBox>();
            pictureBox1.ImageLocation = (string)dataListLink[0];
            pictureBox2.ImageLocation = (string)dataListLink[1];
            pictureBox3.ImageLocation = (string)dataListLink[2];
            pictureBox4.ImageLocation = (string)dataListLink[3];
            pictureBox5.ImageLocation = (string)dataListLink[4];
            pictureBox6.ImageLocation = (string)dataListLink[5];
            pictureBox7.ImageLocation = (string)dataListLink[6];
            pictureBox8.ImageLocation = (string)dataListLink[7];
            pictureBox9.ImageLocation = (string)dataListLink[8];

            //Số cột và số hàng của TableLayoutPanel
            //Số cột và số hàng của TableLayoutPanel

          

        }

        private void Link_Click(object sender, EventArgs e)
        {
            PictureBox k = (PictureBox)sender;
            stringlink = k.ImageLocation;
            List<string> datalink = new List<string>();
            List<string> dataname = new List<string>();
            string query = "select linkImg,tensp from hangHoa";

            foreach(string link in dataListLink)
            {
               if(stringlink == link)
                {
                    break;
               }else
                {
                    i++;
                }    
            }
            stringName = dataListName[i].ToString();
            stringmasp = dataListMasp[i].ToString();
            stringGiasp = datalistGia[i].ToString();
            stringslcon = datalistSl[i].ToString();
            this.Hide();
            XemCtSP xemCtSP = new XemCtSP();
           
            xemCtSP.ShowDialog();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
            pictureBoxes.Add(pictureBox6);
            pictureBoxes.Add(pictureBox7);
            pictureBoxes.Add(pictureBox8);
            pictureBoxes.Add(pictureBox9);
            foreach(PictureBox pic in pictureBoxes)
            {
                pic.ImageLocation = "";
            }
            string strsearch = textBox1.Text;
            string query = "select form hangban where tensp like"+"%"+strsearch+"%";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

        }
    }
}   
