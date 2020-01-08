using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library5.Models;

namespace Library5
{
    public partial class ShowReaders : Form
    {
        public ShowReaders()
        {
            InitializeComponent();
        }

        private void ShowReaders_Load(object sender, EventArgs e)
        {
            lbdb db = new lbdb();
            dtgReaders.DataSource = db.Readers.Select(rs => new
            {
                rs.Rnm, rs.RSnm, rs.Rphon,rs.Fakulteler.FakulteAdi

            }).ToList();





            //using (SqlConnection con = new SqlConnection(Properties.Settings.Default.libCon))
            //{
            //    string comstring = "Select bk.BookName,bk.CreateDate,ath.AutName"+
            //        " from Books bk"+
            //        " join Authors ath "+
            //        " on ath.Id=bk.AuthorId ";
            //    SqlDataAdapter da = new SqlDataAdapter(comstring,con);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds,"bk");
            //    dtgReaders.DataSource = ds.Tables["bk"];


            //}
        }

        private void DtgReaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
