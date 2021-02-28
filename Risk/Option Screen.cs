using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk
{
    public partial class Option_Screen : Form
    {
        bool[,] Matrix;
        public Option_Screen(ref bool[,] matrix)
        {
            InitializeComponent();
            Matrix = matrix;
        }

        private void Quite_GAme_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void New_GAme_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameSetup Setup = new GameSetup(ref Matrix);
            Setup.ShowDialog();
        }

        private void Load_GAme_Click(object sender, EventArgs e)
        {

        }
    }
}
