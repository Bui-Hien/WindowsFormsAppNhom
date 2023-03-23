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
using System.Windows.Markup;

namespace WindowsFormsAppNhom
{
    public partial class xemSP : Form
    {
<<<<<<< HEAD
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
        List<PictureBox> pictureBoxes = new List<PictureBox>();
=======
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251
        string connectionString = "Data Source=ADMIN\\QUOCHUY;Initial Catalog=quanlybandtdd; Integrated Security=True";
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
<<<<<<< HEAD
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
            pictureBoxes.Add(pictureBox6);
            pictureBoxes.Add(pictureBox7);
            pictureBoxes.Add(pictureBox8);
            pictureBoxes.Add(pictureBox9);

            int i = 0;
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
                i++;
            }
            reader.Close();
         
             for(int j=0;j<i;j++)
            {
                pictureBoxes[j].ImageLocation = (string)dataListLink[j];
            }    




            //Số cột và số hàng của TableLayoutPanel
            //Số cột và số hàng của TableLayoutPanel

          
=======
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "select linkImg from hangHoa";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = null;
            List<object> dataList = new List<object>();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Lấy giá trị của cột từ SqlDataReader và chuyển đổi nó thành kiểu dữ liệu đối tượng (object)
                object data = reader.GetValue(0);

                // Thêm giá trị của cột vào danh sách
                dataList.Add(data);
                textBox1.Text = data.ToString();
            }
            reader.Close();
            pictureBox1.ImageLocation = (string)dataList[0];
            pictureBox2.ImageLocation = (string)dataList[1];
            pictureBox3.ImageLocation = (string)dataList[2];
            pictureBox4.ImageLocation = (string)dataList[3];
            pictureBox5.ImageLocation = (string)dataList[4];
            pictureBox6.ImageLocation = (string)dataList[5];
            pictureBox7.ImageLocation = (string)dataList[7];
            pictureBox8.ImageLocation = (string)dataList[7];
            pictureBox9.ImageLocation = (string)dataList[8];
            //textBox1.Text = (string)dataList[6];
>>>>>>> af48c4a4b8de0afadda9c707e10b92b2de6e6251

        }

        private void Link_Click(object sender, EventArgs e)
        {
            PictureBox k = (PictureBox)sender;
            stringlink = k.ImageLocation;
            List<string> datalink = new List<string>();
            List<string> dataname = new List<string>();

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
 
            dataListLink.Clear();
            dataListName.Clear();
            dataListMasp.Clear();
            datalistGia.Clear();
            datalistSl.Clear();
            foreach(PictureBox pic in pictureBoxes)
            {
                pic.ImageLocation = "";
            }
            string strsearch = textBox1.Text;
            strsearch = "'%" + strsearch + "%'";
            string query = "select linkImg,tensp,mahh,giaban,soLuong from hangHoa where tensp like "+strsearch;
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
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
            int i = 0;
            foreach (object link in dataListLink)
            {
                i++;
            }
            textBox1.Text = i.ToString();
            for(int j=0;j<i;j++)
            {
                pictureBoxes[j].ImageLocation = (string)dataListLink[j];
            }    
        }
    }
}   
