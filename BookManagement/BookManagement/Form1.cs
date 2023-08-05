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
    public partial class Form1 : Form
    {
        //var Move form without border
        int ve;
        int x;
        int y;
        // var for sqlconnection
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn_MaxAndMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ve = 1;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ve = 0;
             
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(ve == 1 )
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MC\Documents\Visual Studio 2015\Projects\BookManagement\BookManagement\DBBOOK.mdf;Integrated Security=True");
            var sql = "SELECT id,Title,Auther,Price,Cat from BOOKS";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "التسلسل";
            dataGridView1.Columns[1].HeaderText = "اسم الكتاب";
            dataGridView1.Columns[2].HeaderText = "المؤلف";
            dataGridView1.Columns[3].HeaderText = "سعر الكتاب";
            dataGridView1.Columns[4].HeaderText = "الفئة";

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            frmAdd.btn_Add.ButtonText = "أضافة";
            frmAdd.state = 0;
            bunifuTransition1.Show(frmAdd);
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            FrmDetails frmdet = new FrmDetails();
            bunifuTransition2.ShowSync(frmdet);
            frmdet.txt_BookName.Enabled =false;
            frmdet.txt_Auther.Enabled = false;
            frmdet.txt_cat.Enabled = false;
            frmdet.txt_Price.Enabled = false;
            frmdet.bunifuDatepicker1.Enabled = false;
            frmdet.bunifuRating1.Enabled = false;






            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MC\Documents\Visual Studio 2015\Projects\BookManagement\BookManagement\DBBOOK.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT Title,Auther,Price,Cat,Date,Rate FROM BOOKS WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));

                }
                frmdet.txt_BookName.Text = List[0];
                frmdet.txt_Auther.Text = List[1];
                frmdet.txt_Price.Text = List[2];
                frmdet.txt_cat.Text = List[3];
                frmdet.bunifuDatepicker1.Text = List[5];
                frmdet.bunifuRating1.Value =Convert.ToInt16( List[5]);
                con.Close();

                // read image from database
                con.Open();
                cmd.CommandText = "SELECT Cover FROM BOOKS WHERE ID=@IDIMAGE";
                cmd.Parameters.AddWithValue("@IDIMAGE", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                frmdet.pic_Book.Image = Image.FromStream(ma);


            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {

                con.Close();

            }
            cmd.Parameters.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            frmAdd.btn_Add.ButtonText = "تعديل";
            frmAdd.state =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frmAdd);

            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MC\Documents\Visual Studio 2015\Projects\BookManagement\BookManagement\DBBOOK.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT Title,Auther,Price,Cat,Date,Rate FROM BOOKS WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID",Convert.ToInt16( dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));

                }
                frmAdd.txt_BookName.Text = List[0];
                frmAdd.txt_Auther.Text = List[1];
                frmAdd.txt_Price.Text = List[2];
                frmAdd.comBox_Cat.Text = List[3];
                frmAdd.bunifuDatepicker1.Text = List[4];
                frmAdd.bunifuRating1.Text = List[5];
                con.Close();

                // read image from database
                con.Open();
                cmd.CommandText = "SELECT Cover FROM BOOKS WHERE ID=@IDIMAGE";
                cmd.Parameters.AddWithValue("@IDIMAGE", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                byte[] img =(byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                frmAdd.pic_Book.Image = Image.FromStream(ma);


            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {

                con.Close();

            }
            cmd.Parameters.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MC\Documents\Visual Studio 2015\Projects\BookManagement\BookManagement\DBBOOK.mdf;Integrated Security=True");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM BOOKS WHERE ID=@ID";
            cmd.Parameters.AddWithValue("@ID",dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();

            Frm_Dl_Delete frmdel = new Frm_Dl_Delete();
            frmdel.Show();
            cmd.Parameters.Clear();
        }
    }
}
    