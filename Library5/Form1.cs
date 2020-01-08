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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcmain.Image = new Bitmap(@"C:\Users\User\source\repos\Library5\Library5\img\1.jpg");
            pcmain.Location = new Point((this.ClientSize.Width - pcmain.Size.Width) / 2,
                       (this.ClientSize.Width - pcmain.Size.Height) / 2);
        }

        private void Pcmain_Click(object sender, EventArgs e)
        {

        }

        private void ReadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReaders adn = new AddReaders();
            adn.ShowDialog();
        }

        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReaders sr = new ShowReaders();
            sr.Show();

        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksForm bkf = new BooksForm();
            bkf.ShowDialog();


        }
    }
}
