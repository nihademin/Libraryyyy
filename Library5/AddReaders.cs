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
using Library5.Models;

namespace Library5
{
    public partial class AddReaders : Form

    {
        lbdb db = new lbdb();

        public AddReaders()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btnreader_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.libCon))
            {
                string ComQuery = "Selecet FakulteAdi from Fakulteler";
                SqlCommand com = new SqlCommand(ComQuery,con);
                con.Open();
                var rd = com.ExecuteReader();
                while (rd.Read())
                {
                    fklt.Items.Add(rd.GetValue(0).ToString());
                    
                }

            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string frstnm =first.Text;
            string lstnm = last.Text;
            string phone = phon.Text;
            string faculte = fklt.Text;
            string tbno = tno.Text;
            long newphon;
            if (frstnm != "" && lstnm != "" && phone != "" && faculte != "")
            {
                if (long.TryParse(phone, out newphon))
                {


                    Reader rd = new Reader();
                    rd.Rnm = frstnm;
                    rd.RSnm = lstnm;
                    rd.Rphon = phone;
                    db.Readers.Add(rd);
                    db.SaveChanges();

                }

                else
                {
                    MessageBox.Show("Duz yaz ee Telefonu", "EROOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Doldur", "EROOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void Fklt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
