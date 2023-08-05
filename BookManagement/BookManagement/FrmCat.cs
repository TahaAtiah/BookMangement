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

namespace BookManagement
{

    public partial class FrmCat : Form
    {
        // var Move form without border
        int move;
        int x;
        int y;
        // var for sqlconnction
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public FrmCat()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_CatName.Text != "") {
                //con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MC\Documents\Visual Studio 2015\Projects\BookManagement\BookManagement\DBBOOK.mdf;Integrated Security=True");
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MC\Documents\Visual Studio 2015\Projects\BookManagement\BookManagement\DBBOOK.mdf;Integrated Security=True");
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO TBCat (Cat) Values (@Cat)";
            cmd.Parameters.AddWithValue("@Cat", txt_CatName.Text);
            cmd.ExecuteNonQuery();
            cmd.Clone();
            Form frm_add = new Frm_Dl_Add();
                frm_add.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("يرجى ادخال اسم الصنف اولاً !!!");
            }
        }
    }
}
