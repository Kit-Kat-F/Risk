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
    public partial class Risk_Home : Form
    {
        bool[,] Matrix;
        public Risk_Home(ref bool [,]matrix)
        {
            InitializeComponent();
            Matrix = matrix;
        }

        private void StartButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Option_Screen option = new Option_Screen(ref Matrix);
            option.ShowDialog();
        }
    }
}
