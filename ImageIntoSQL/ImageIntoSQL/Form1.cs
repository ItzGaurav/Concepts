using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ImageIntoSQL
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=OM-PC\\SQLEXPRESS; Initial Catalog=Gaurav; User ID=sa; Password=mv;");
        SqlCommand cmd;
        string ImgLoc = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg) | *.jpg|GIF Files (*.gif)|*.gif | All Files(*.*)|*.*";
                dlg.Title = "Select Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ImgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = ImgLoc;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(ImgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                img = br.ReadBytes((int)fs.Length);
                string sql = "Insert into T_Image(Name,Image) Values('"+txt_name.Text+"',@img)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@img",img));
                int x = cmd.ExecuteNonQuery();
                MessageBox.Show(x.ToString() + "record(s) saved");
                con.Close();
                txt_name.Text = "";
                pictureBox1.Image = null;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select Name,Image From T_Image where ID='"+txt_id.Text+"'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    txt_name.Text = rd["Name"].ToString();
                    byte[] img = (Byte[])(rd["Image"]);
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }

                }
                else
                {
                    MessageBox.Show("This ID dose not Exist");
                }


                con.Close();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }


    }
}
