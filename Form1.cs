using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysqltest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try {
            //    MySqlConnection con = new MySqlConnection();
            //    con.ConnectionString = "server=localhost; database=animes; user id=root; password=pastel; port=3306;";
            //    con.Open();
            //    MessageBox.Show("Ok!");
            //}
            //catch (Exception ex) {
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost; database=animes; user id=root; password=pastel; port=3306;";
                con.Open();

                string sql = "INSERT INTO my_anime_list (name, episodes, year, score) VALUES (@name, @episodes, @year, @score)";

                MySqlCommand c = new MySqlCommand(sql, con);

                c.Parameters.Add(new MySqlParameter("@name", this.txtname.Text));
                c.Parameters.Add(new MySqlParameter("@episodes", this.txtepisodes.Text));
                c.Parameters.Add(new MySqlParameter("@year", this.txtyear.Text));
                c.Parameters.Add(new MySqlParameter("@score", this.txtscore.Text));

                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ok!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
