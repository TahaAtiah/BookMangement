using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace BookManagement
{

    public partial class FrmAdd : Form
    {
        //var Move form without border
        int move;
        int movex;
        int movey;
        // var sqlconnection
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();
        public int state;
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gBox_Info_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmAdd = new FrmCat();
            bunifuTransition1.ShowSync(frmAdd);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MC\Documents\Visual Studio 2015\Projects\BookManagement\BookManagement\DBBOOK.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT Cat FROM TBCat";
                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                }
                int i = 0;
                while (i < List.LongCount())
                {
                    comBox_Cat.Items.Add(List[i]);
                    i = i + 1;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {

                con.Close();

            }

        }

        private void FrmAdd_Activated(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_BookName.Text==" " || txt_Auther.Text=="" || txt_Price.Text ==" " || comBox_Cat.Text==" ")
            {
                MessageBox.Show("يرجى اكمل معلومات الكتاب اولاً");
            }
            else
            {
                if(state == 0)
                {
                    // Insert
                    // for convert image to binary
                    MemoryStream ma = new MemoryStream();
                    pic_Book.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                    var _cover = ma.ToArray();

                    // sql command
                    con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MC\Documents\Visual Studio 2015\Projects\BookManagement\BookManagement\DBBOOK.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO BOOkS (Title,Auther,Price,Cat,Date,Rate,Cover) Values (@Title,@Auther,@Price,@Cat,@Date,@Rate,@Cover)";
                    cmd.Parameters.AddWithValue("@Title", txt_BookName.Text);
                    cmd.Parameters.AddWithValue("@Auther", txt_Auther.Text);
                    cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
                    cmd.Parameters.AddWithValue("@Cat", comBox_Cat.Text);
                    cmd.Parameters.AddWithValue("@Date", bunifuDatepicker1.Value);
                    cmd.Parameters.AddWithValue("@Rate", bunifuRating1.Value);
                    cmd.Parameters.AddWithValue("@Cover", _cover);


                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    Form frm_add = new Frm_Dl_Add();
                    frm_add.Show();
                    this.Close();
                } 
                else
                {
                    // Edit 
                    // Insert
                    // for convert image to binary
                    MemoryStream ma = new MemoryStream();
                    pic_Book.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                    var _cover = ma.ToArray();

                    // sql command
                    con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MC\Documents\Visual Studio 2015\Projects\BookManagement\BookManagement\DBBOOK.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE BOOkS SET Title=@Title,Auther=@Auther,Price=@Price,Cat=@Cat,Date=@Date,Rate=@Rate,Cover=@Cover where ID=@ID";
                    cmd.Parameters.AddWithValue("@Title", txt_BookName.Text);
                    cmd.Parameters.AddWithValue("@Auther", txt_Auther.Text);
                    cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
                    cmd.Parameters.AddWithValue("@Cat", comBox_Cat.Text);
                    cmd.Parameters.AddWithValue("@Date", bunifuDatepicker1.Value);
                    cmd.Parameters.AddWithValue("@Rate", bunifuRating1.Value);
                    cmd.Parameters.AddWithValue("@Cover", _cover);
                    cmd.Parameters.AddWithValue("@ID", state);


                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    Form frm_Edit = new Frm_Dl_Edit();
                    frm_Edit.Show();
                    this.Close();
                }
                
            }

            cmd.Parameters.Clear();
          
        }

        private void linklbl_UplodeImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
         //   dia.Filter = "png|*.png";
            var result = dia.ShowDialog();
            if(result == DialogResult.OK)
            {
                pic_Book.Image = Image.FromFile(dia.FileName);
            }
        }
    }
}
