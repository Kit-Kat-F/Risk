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
    public partial class Map_Form : Form
    {
        int max;
        public Map_Form(int MaxPlayers)
        {
            MessageBox.Show("here");
            InitializeComponent();
            int Player = 1;
            bool GameWon = false;
            while (GameWon == false)
            {
                PlayerTurn.Text="Player [0]" + Convert.ToString(Player);
            }
            max = MaxPlayers;
        }
        static bool Roll(int armytotalA, int armytotalD)
        {
            Random Rand = new Random();
            int AttackTot = 0;
            int DefenseTot = 0;
            if (armytotalA <= armytotalD)
            {
                while (armytotalA != 0 || armytotalD != 0)
                {
                    AttackTot = Rand.Next(1, 6);
                    DefenseTot = Rand.Next(1, 6) + Rand.Next(1, 6);
                    if (AttackTot > DefenseTot)
                    {
                        armytotalD -= 1;
                    }
                    else
                    {
                        armytotalA -= 1;
                    }
                }
                if (armytotalA == 0)
                {
                    return true; /// true means Attacker wins false means attacker loses
                }
                else if (armytotalD == 0)
                {
                    return false;
                }
            }
            else if (armytotalA > armytotalD)
            {
                while (armytotalA != 0 || armytotalD != 0)
                {
                    if (armytotalA - armytotalD == 1)
                    {
                        AttackTot = Rand.Next(1, 6) + Rand.Next(1, 6);
                        DefenseTot = Rand.Next(1, 6) + Rand.Next(1, 6);
                    }
                    else if (armytotalA - armytotalD > 2)
                    {
                        AttackTot = Rand.Next(1, 6) + Rand.Next(1, 6) + Rand.Next(1, 6);
                        DefenseTot = Rand.Next(1, 6) + Rand.Next(1, 6);
                    }
                    if (AttackTot > DefenseTot)
                    {
                        armytotalD -= 1;
                    }
                    else
                    {
                        armytotalA -= 1;
                    }
                }
                if (armytotalA == 0)
                {
                    return true; /// true means Attacker wins false means attacker loses
                }
                else if (armytotalD == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void Map_Form_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(max.ToString());
        }
    }
}
