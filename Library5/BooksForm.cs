using Library5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library5
{
    public partial class BooksForm : Form
    {
        lbdb db = new lbdb();

        public BooksForm()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            BookLoad();
            cmbaut.Items.AddRange(db.Authors.Select(ath => ath.AutName).ToArray());


        }

        public void BookLoad()
        {
            dtgbooks.DataSource = db.Books.Select(bk => new { bk.BookName, bk.Counts, bk.Author.AutName, bk.CreateDate }).ToList();
        }

        private void Btnaddb_Click(object sender, EventArgs e)
        {
            string bkname = txtbn.Text;
            string count = txtcn.Text;
            string authornm = cmbaut.Text;
            DateTime publish = dtpd.Value;
            if (bkname != string.Empty && count != string.Empty && authornm != string.Empty && publish <= DateTime.Now)
            {
                int autId = db.Authors.First(ath => ath.AutName == authornm).ID;
                int countNum = Convert.ToInt32(count);
                Book bk = new Book();
                bk.BookName = bkname;
                bk.Counts = countNum;
                bk.AuthorId = autId;
                bk.CreateDate = publish;
                db.Books.Add(bk);
                db.SaveChanges();
                MessageBox.Show("Kitab Elave Edildi");
                BookLoad();


            }
            else
            {
                lblerror.Text = "Butun Xanalari Doldur";
                lblerror.Visible = true;
            }

        }

        private void Txtcn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<47 || e.KeyChar>58 )&& e.KeyChar!=8)
            {
                e.Handled = true;
                
            }
        }
    }
}
