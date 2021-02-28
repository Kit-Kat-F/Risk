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
    public partial class GameSetup : Form
    {
        bool[,] Matrix;
        public GameSetup(ref bool[,] matrix)
        {
            InitializeComponent();
            Matrix = matrix;
        }

        private void Start_but_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map_Form3 Map = new Map_Form3(Convert.ToInt32(PlayerCount.Text),ref Matrix);
            Map.ShowDialog();
        }

        private void GameSetup_Load(object sender, EventArgs e)
        {
        }
    }
}
