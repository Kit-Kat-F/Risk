﻿using System;
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
    public partial class Map_Form3 : Form
    {
        bool[,] AdjacencyMatrix = new bool[43, 43];


        int max;
        int Round;
        int initial_armies;
        int[,] TroopCount = new int[43, 43];
        string[] Continents = new string[] { "Asia", "North America", "Europe", "Africa", "Oceana", "South America" };
        int Player = 0;

        List<int> Asia = new List<int>() { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        List<int> North_America = new List<int>() { 1, 2, 3, 22, 23, 24, 25, 26, 41 };
        List<int> Europe = new List<int>() { 16, 17, 18, 19, 20, 21, 42 };
        List<int> Africa = new List<int>() { 31, 32, 33, 34, 35, 36 };
        List<int> Oceana = new List<int>() { 37, 38, 39, 40 };
        List<int> South_America = new List<int>() { 27, 28, 29, 30 };


        List<List<int>> Player_Countries = new List<List<int>>();
        List<List<int>> Player_Continents = new List<List<int>>();

        bool firstbutt = true;
        int butt1;

        public Map_Form3(int MaxPlayers, ref bool[,] matrix)
        {
            InitializeComponent();
            max = MaxPlayers;
            AdjacencyMatrix[1, 2] = true;
            AdjacencyMatrix[1, 3] = true;
            AdjacencyMatrix[1, 25] = true;
            AdjacencyMatrix[1, 41] = true;
            AdjacencyMatrix[2, 1] = true;
            AdjacencyMatrix[2, 3] = true;
            AdjacencyMatrix[2, 41] = true;
            AdjacencyMatrix[2, 22] = true;
            AdjacencyMatrix[3, 1] = true;
            AdjacencyMatrix[3, 2] = true;
            AdjacencyMatrix[3, 4] = true;
            AdjacencyMatrix[4, 3] = true;
            AdjacencyMatrix[4, 5] = true;
            AdjacencyMatrix[4, 10] = true;
            AdjacencyMatrix[4, 11] = true;
            AdjacencyMatrix[4, 12] = true;
            AdjacencyMatrix[5, 4] = true;
            AdjacencyMatrix[5, 6] = true;
            AdjacencyMatrix[5, 11] = true;
            AdjacencyMatrix[6, 5] = true;
            AdjacencyMatrix[6, 7] = true;
            AdjacencyMatrix[6, 9] = true;
            AdjacencyMatrix[6, 10] = true;
            AdjacencyMatrix[6, 11] = true;
            AdjacencyMatrix[7, 6] = true;
            AdjacencyMatrix[7, 8] = true;
            AdjacencyMatrix[7, 9] = true;
            AdjacencyMatrix[7, 42] = true;
            AdjacencyMatrix[8, 7] = true;
            AdjacencyMatrix[8, 9] = true;
            AdjacencyMatrix[8, 14] = true;
            AdjacencyMatrix[8, 15] = true;
            AdjacencyMatrix[8, 42] = true;
            AdjacencyMatrix[9, 6] = true;
            AdjacencyMatrix[9, 7] = true;
            AdjacencyMatrix[9, 8] = true;
            AdjacencyMatrix[9, 10] = true;
            AdjacencyMatrix[9, 13] = true;
            AdjacencyMatrix[9, 14] = true;
            AdjacencyMatrix[10, 4] = true;
            AdjacencyMatrix[10, 6] = true;
            AdjacencyMatrix[10, 9] = true;
            AdjacencyMatrix[10, 11] = true;
            AdjacencyMatrix[10, 12] = true;
            AdjacencyMatrix[11, 4] = true;
            AdjacencyMatrix[11, 5] = true;
            AdjacencyMatrix[11, 6] = true;
            AdjacencyMatrix[11, 10] = true;
            AdjacencyMatrix[12, 4] = true;
            AdjacencyMatrix[12, 10] = true;
            AdjacencyMatrix[13, 9] = true;
            AdjacencyMatrix[13, 14] = true;
            AdjacencyMatrix[13, 37] = true;
            AdjacencyMatrix[14, 8] = true;
            AdjacencyMatrix[14, 9] = true;
            AdjacencyMatrix[14, 13] = true;
            AdjacencyMatrix[14, 15] = true;
            AdjacencyMatrix[15, 8] = true;
            AdjacencyMatrix[15, 14] = true;
            AdjacencyMatrix[15, 16] = true;
            AdjacencyMatrix[15, 32] = true;
            AdjacencyMatrix[15, 36] = true;
            AdjacencyMatrix[15, 42] = true;
            AdjacencyMatrix[16, 15] = true;
            AdjacencyMatrix[16, 17] = true;
            AdjacencyMatrix[16, 18] = true;
            AdjacencyMatrix[16, 31] = true;
            AdjacencyMatrix[16, 32] = true;
            AdjacencyMatrix[16, 42] = true;
            AdjacencyMatrix[17, 16] = true;
            AdjacencyMatrix[17, 18] = true;
            AdjacencyMatrix[17, 19] = true;
            AdjacencyMatrix[17, 21] = true;
            AdjacencyMatrix[17, 42] = true;
            AdjacencyMatrix[18, 16] = true;
            AdjacencyMatrix[18, 17] = true;
            AdjacencyMatrix[18, 19] = true;
            AdjacencyMatrix[18, 31] = true;
            AdjacencyMatrix[19, 17] = true;
            AdjacencyMatrix[19, 18] = true;
            AdjacencyMatrix[19, 20] = true;
            AdjacencyMatrix[19, 21] = true;
            AdjacencyMatrix[20, 19] = true;
            AdjacencyMatrix[20, 21] = true;
            AdjacencyMatrix[20, 22] = true;
            AdjacencyMatrix[21, 17] = true;
            AdjacencyMatrix[21, 19] = true;
            AdjacencyMatrix[21, 20] = true;
            AdjacencyMatrix[21, 42] = true;
            AdjacencyMatrix[22, 2] = true;
            AdjacencyMatrix[22, 20] = true;
            AdjacencyMatrix[22, 23] = true;
            AdjacencyMatrix[22, 41] = true;
            AdjacencyMatrix[23, 22] = true;
            AdjacencyMatrix[23, 24] = true;
            AdjacencyMatrix[23, 41] = true;
            AdjacencyMatrix[24, 23] = true;
            AdjacencyMatrix[24, 25] = true;
            AdjacencyMatrix[24, 26] = true;
            AdjacencyMatrix[24, 41] = true;
            AdjacencyMatrix[25, 1] = true;
            AdjacencyMatrix[25, 24] = true;
            AdjacencyMatrix[25, 26] = true;
            AdjacencyMatrix[25, 41] = true;
            AdjacencyMatrix[26, 24] = true;
            AdjacencyMatrix[26, 25] = true;
            AdjacencyMatrix[26, 27] = true;
            AdjacencyMatrix[27, 26] = true;
            AdjacencyMatrix[27, 28] = true;
            AdjacencyMatrix[27, 30] = true;
            AdjacencyMatrix[28, 27] = true;
            AdjacencyMatrix[28, 29] = true;
            AdjacencyMatrix[28, 30] = true;
            AdjacencyMatrix[29, 28] = true;
            AdjacencyMatrix[29, 30] = true;
            AdjacencyMatrix[30, 27] = true;
            AdjacencyMatrix[30, 28] = true;
            AdjacencyMatrix[30, 29] = true;
            AdjacencyMatrix[30, 31] = true;
            AdjacencyMatrix[31, 16] = true;
            AdjacencyMatrix[31, 18] = true;
            AdjacencyMatrix[31, 30] = true;
            AdjacencyMatrix[31, 32] = true;
            AdjacencyMatrix[31, 33] = true;
            AdjacencyMatrix[31, 36] = true;
            AdjacencyMatrix[32, 15] = true;
            AdjacencyMatrix[32, 16] = true;
            AdjacencyMatrix[32, 31] = true;
            AdjacencyMatrix[32, 36] = true;
            AdjacencyMatrix[33, 31] = true;
            AdjacencyMatrix[33, 34] = true;
            AdjacencyMatrix[33, 36] = true;
            AdjacencyMatrix[34, 33] = true;
            AdjacencyMatrix[34, 35] = true;
            AdjacencyMatrix[34, 36] = true;
            AdjacencyMatrix[35, 34] = true;
            AdjacencyMatrix[35, 36] = true;
            AdjacencyMatrix[36, 15] = true;
            AdjacencyMatrix[36, 31] = true;
            AdjacencyMatrix[36, 32] = true;
            AdjacencyMatrix[36, 33] = true;
            AdjacencyMatrix[36, 34] = true;
            AdjacencyMatrix[36, 35] = true;
            AdjacencyMatrix[37, 13] = true;
            AdjacencyMatrix[37, 38] = true;
            AdjacencyMatrix[38, 37] = true;
            AdjacencyMatrix[38, 39] = true;
            AdjacencyMatrix[38, 40] = true;
            AdjacencyMatrix[39, 38] = true;
            AdjacencyMatrix[39, 40] = true;
            AdjacencyMatrix[40, 38] = true;
            AdjacencyMatrix[40, 39] = true;
            AdjacencyMatrix[41, 1] = true;
            AdjacencyMatrix[41, 2] = true;
            AdjacencyMatrix[41, 22] = true;
            AdjacencyMatrix[41, 23] = true;
            AdjacencyMatrix[41, 24] = true;
            AdjacencyMatrix[41, 25] = true;
            AdjacencyMatrix[42, 7] = true;
            AdjacencyMatrix[42, 8] = true;
            AdjacencyMatrix[42, 15] = true;
            AdjacencyMatrix[42, 16] = true;
            AdjacencyMatrix[42, 17] = true;
            AdjacencyMatrix[42, 21] = true;
            for (int i = 1; i < 43; i++)
            {
                for (int j = 1; j < 43; j++)
                {
                    if (AdjacencyMatrix[i, j] != true)
                    {
                        AdjacencyMatrix[i, j] = false;
                    }
                }
            }
        }

        struct bool_int
        {
            public bool win;
            public int sub;
        }

        static bool_int Roll(int armytotalA, int armytotalD)
        {
            Random Rand = new Random();
            int AttackTot = 0; /// total score from dice rolled
            int DefenseTot = 0;
            bool_int result1;
            bool_int result2;
            bool_int ResultDefault;
            result1.sub = 0;
            result2.sub = 0;
            ResultDefault.win = true;
            ResultDefault.sub = 0;
            if (armytotalA <= armytotalD)
            {
                while (armytotalA != 0 || armytotalD != 0)
                {
                    AttackTot = Rand.Next(1, 7);
                    DefenseTot = Rand.Next(1, 7) + Rand.Next(1, 7);
                    if (AttackTot > DefenseTot)
                    {
                        armytotalD -= 1;
                        result2.sub += 1;
                        if (armytotalD <= 0)
                        {
                            result1.win = true;
                            return result1;
                        }
                    }
                    else
                    {
                        armytotalA -= 1;
                        result1.sub += 1;
                        if (armytotalA <= 0)
                        {
                            result2.win = false;
                            return result2;
                        }
                    }
                }
            }
            else if (armytotalA > armytotalD)
            {
                while (armytotalA != 0 || armytotalD != 0)
                {
                    if (armytotalA - armytotalD == 1)
                    {
                        AttackTot = Rand.Next(1, 7) + Rand.Next(1, 7);
                        DefenseTot = Rand.Next(1, 7) + Rand.Next(1, 7);
                    }
                    else if (armytotalA - armytotalD >= 2)
                    {
                        AttackTot = Rand.Next(1, 7) + Rand.Next(1, 7) + Rand.Next(1, 7);
                        DefenseTot = Rand.Next(1, 7) + Rand.Next(1, 7);
                    }
                    if (AttackTot > DefenseTot)
                    {
                        armytotalD -= 1;
                        result2.sub += 1;
                        if (armytotalD <= 0)
                        {
                            result1.win = true;
                            return result1;
                        }
                    }
                    else
                    {
                        armytotalA -= 1;
                        result1.sub += 1;
                        if (armytotalA <= 0)
                        {
                            result2.win = false;
                            return result2;
                        }
                    }
                }
            }
            return ResultDefault;
        } ///determines the winner of a roll (Don't touch, this works and will break if you touch)

        private void Continent_Count()
        {
            if (Asia.Except(Player_Countries[Player]).ToList().Count() == 0)
            {
                if (Player_Continents[Player].Contains(0) == false)
                {
                    Player_Continents[Player].Add(0);
                }
            }
            else
            {
                Player_Continents[Player].Remove(0);
            }
            if (North_America.Except(Player_Countries[Player]).ToList().Count() == 0)
            {
                if (Player_Continents[Player].Contains(1) == false)
                {
                    Player_Continents[Player].Add(1);
                }
            }
            else
            {
                Player_Continents[Player].Remove(1);
            }
            if (Europe.Except(Player_Countries[Player]).ToList().Count() == 0)
            {
                if (Player_Continents[Player].Contains(2) == false)
                {
                    Player_Continents[Player].Add(2);
                }
            }
            else
            {
                Player_Continents[Player].Remove(2);
            }
            if (Africa.Except(Player_Countries[Player]).ToList().Count == 0)
            {
                if (Player_Continents[Player].Contains(3) == false)
                {
                    Player_Continents[Player].Add(3);
                }
            }
            else
            {
                Player_Continents[Player].Remove(3);
            }
            if (Oceana.Except(Player_Countries[Player]).ToList().Count() == 0)
            {
                if (Player_Continents[Player].Contains(4) == false)
                {
                    Player_Continents[Player].Add(4);
                }
            }
            else
            {
                Player_Continents[Player].Remove(4);
            }
            if (South_America.Except(Player_Countries[Player]).ToList().Count == 0)
            {
                if (Player_Continents[Player].Contains(5) == false)
                {
                    Player_Continents[Player].Add(5);
                }
            }
            else
            {
                Player_Continents[Player].Remove(5);
            }
        } /// Caluclates who owns which continents

        private void NewArmy()
        {
            int NewArmyTotal = 0;
            Continent_Count();
            int current_territory_count = Player_Countries[Player].Count();
            int current_continent_count = Player_Continents[Player].Count();
            NewArmyTotal += current_territory_count / 3;
            for (int i = 0; i < current_continent_count; i++)
            {
                switch (Player_Continents[Player][i])
                {
                    case 0:
                        NewArmyTotal += 7;
                        break;
                    case 1:
                    case 2:
                        NewArmyTotal += 5;
                        break;
                    case 3:
                        NewArmyTotal += 3;
                        break;
                    case 4:
                    case 5:
                        NewArmyTotal += 2;
                        break;
                }
            }
            AvailableTroops.Text = NewArmyTotal.ToString();
        } /// Calculates the number of troops given on the next turn - Need to implement cards

        private void TerritoryGive(ref List<List<int>> OwnedCountries)
        {///seems to be functional (for now)
            List<int> RemainingLand = new List<int>();
            for (int i = 1; i < 43; i++)
            {
                RemainingLand.Add(i);
            }
            Random rnd = new Random();
            int currentnumber;
            int currentplayer = 0;
            for (int i = 1; i < 43; i++)
            {
                if (currentplayer == max)
                    currentplayer = 0;
                currentnumber = rnd.Next(RemainingLand.Count);
                currentnumber = RemainingLand[currentnumber];
                RemainingLand.Remove(currentnumber);
                Player_Territory_Start(currentplayer, currentnumber, ref OwnedCountries);
                currentplayer += 1;
            }

            ///Debugging
            ///string message = "";
            //for (int i = 0; i<=OwnedCountries[0].Count-1; i++)
            //{
            ///    message = message + Convert.ToString(OwnedCountries[0][i]) + ", ";
            ///}
            ///MessageBox.Show(message);
        } /// Randomly assigns the initial boardstate

        private void Player_Territory_Start(int currentplayer, int currentnumber, ref List<List<int>> Players)
        {
            List<int> PlayerCountries = new List<int>();
            PlayerCountries = Players[currentplayer];
            PlayerCountries.Add(currentnumber);
            Button_Colour(currentplayer, currentnumber);
        } ///kinda wonky way to add player's countries but it works

        private void Map_Form3_Load(object sender, EventArgs e)
        {
            ButtUpDown1.Enabled = false;
            Round = 1;
            bool GameWon = false;
            initial_armies = (-5 * max) + 50;
            GameState.Text = "Allocate Your Troops";
            Round_Count.Text = "Round " + Round.ToString() + ":";
            PlayerTurn.Text = "Player " + Convert.ToString(Player + 1);
            Colour_Hold(Player);

            for (int i = 0; i <= max - 1; i++)  /// not looping (Fixed)
            {
                switch (i)
                {
                    case 0:
                        List<int> OwnedContinents1 = new List<int>();
                        List<int> OwnedCountries1 = new List<int>();
                        Player_Countries.Add(OwnedCountries1);
                        Player_Continents.Add(OwnedContinents1);
                        break;
                    case 1:
                        List<int> OwnedContinents2 = new List<int>();
                        List<int> OwnedCountries2 = new List<int>();
                        Player_Countries.Add(OwnedCountries2);
                        Player_Continents.Add(OwnedContinents2);
                        break;
                    case 2:
                        List<int> OwnedContinents3 = new List<int>();
                        List<int> OwnedCountries3 = new List<int>();
                        Player_Countries.Add(OwnedCountries3);
                        Player_Continents.Add(OwnedContinents3);
                        break;
                    case 3:
                        List<int> OwnedContinents4 = new List<int>();
                        List<int> OwnedCountries4 = new List<int>();
                        Player_Countries.Add(OwnedCountries4);
                        Player_Continents.Add(OwnedContinents4);
                        break;
                    case 4:
                        List<int> OwnedContinents5 = new List<int>();
                        List<int> OwnedCountries5 = new List<int>();
                        Player_Countries.Add(OwnedCountries5);
                        Player_Continents.Add(OwnedContinents5);
                        break;
                    case 5:
                        List<int> OwnedContinents6 = new List<int>();
                        List<int> OwnedCountries6 = new List<int>();
                        Player_Countries.Add(OwnedCountries6);
                        Player_Continents.Add(OwnedContinents6);
                        break;
                }
            } /// sets up country and continent lists

            TerritoryGive(ref Player_Countries); ///allocates initial countries
            AvailableTroops.Text = Convert.ToString(initial_armies);
            Grey_Buttons(1, ref Player_Countries, false, true);
            Grey_Buttons(0, ref Player_Countries, true, false);
        }

        private void Colour_Hold(int current_player)
        {
            switch (current_player)
            {
                case 0:
                    Colour_Holder.BackColor = Color.White;
                    Colour_Holder.ForeColor = Color.White;
                    break;
                case 1:
                    Colour_Holder.BackColor = Color.HotPink;
                    Colour_Holder.ForeColor = Color.HotPink;
                    break;
                case 2:
                    Colour_Holder.BackColor = Color.Red;
                    Colour_Holder.ForeColor = Color.Red;
                    break;
                case 3:
                    Colour_Holder.BackColor = Color.Green;
                    Colour_Holder.ForeColor = Color.Green;
                    break;
                case 4:
                    Colour_Holder.BackColor = Color.Blue;
                    Colour_Holder.ForeColor = Color.Blue;
                    break;
                case 5:
                    Colour_Holder.BackColor = Color.Orange;
                    Colour_Holder.ForeColor = Color.Orange;
                    break;
            }
        } /// finish this with other colours once other players work

        /// Button work

        private bool Decrement()
        {
            if (AvailableTroops.Text != "0")
            {
                AvailableTroops.Text = Convert.ToString(Convert.ToInt32(AvailableTroops.Text) - 1);
                return true;
            }
            else
            {
                return false;
            }
        } /// Decrements the amount of availiable troops by one

        bool secondbutt = false;

        private void Butt_Click(object sender, EventArgs e)
        {
            Button butt = sender as Button;

            if (GameState.Text == "Allocate Your Troops")
            {
                butt.Text = Convert.ToString(Convert.ToInt32(butt.Text) + 1);
                if (Decrement() == false)
                {
                    butt.Text = Convert.ToString(Convert.ToInt32(butt.Text) - 1);
                }
            }
            else if (GameState.Text == "Attacking") /// during attack
            {
                if (firstbutt == true && secondbutt == false) /// first attack phase
                {


                    butt.BackColor = Color.BurlyWood; /// sets colour to show selected button

                    Button bt = this.Controls.Find("-1", true).FirstOrDefault() as Button;
                    for (int i = 1; i < 43; i++)
                    {
                        string ButtonName = "C" + i.ToString();
                        bt = this.Controls.Find(ButtonName, true).FirstOrDefault() as Button;
                        if (bt.BackColor == Color.BurlyWood)
                        {
                            butt1 = i;
                            break;
                        }
                    } /// finds the selected button and saves as butt1

                    int opposing_player = button_player(butt1);

                    Grey_Buttons(1, ref Player_Countries, false, true);

                    for (int i = 1; i < 43; i++)
                    {
                        string b1 = "C" + i.ToString();
                        Button PlayersColor = this.Controls.Find(b1, true).FirstOrDefault() as Button;
                        if (AdjacencyMatrix[butt1, i] == true && PlayersColor.BackColor != Player_colour_from_number(Player))
                        {
                            Individual_Button_Grey(true, i);
                        }
                    } /// checks if player owns a neighbouring country

                    firstbutt = false;
                }
                else if (firstbutt == false && secondbutt == false)/// second attack phase
                {
                    string b1 = "C" + butt1.ToString();
                    Button Attacking = this.Controls.Find(b1, true).FirstOrDefault() as Button;
                    int armya = Convert.ToInt32(Attacking.Text);
                    int armyd = Convert.ToInt32(butt.Text);
                    bool_int roll_result = Roll(armya, armyd); /// true means attacker wins (doesn't work)
                    if (roll_result.win == true)
                    {
                        ///vague outline:
                        ///get current player colour DONE
                        ///subtract lost units from winner somehow DONE?
                        ///get owner of dead tile DONE
                        ///remove tile from previous owner and give to current player DONE
                        ///call the colour set funciton to correct the colours DONE
                        ///new bug, you can softlock game by clicking a tile surrounded by nothing but your own colour
                        butt.Text = "1";
                        Color Current_player_colour = Player_colour_from_number(Player);
                        for (int i = 0; i < Player_Countries[Player].Count(); i++)
                        {
                            string buttname = "C" + Player_Countries[Player][i].ToString();
                            Button Player_Butt = this.Controls.Find(buttname, true).FirstOrDefault() as Button;
                            if (Player_Butt.BackColor == Color.BurlyWood)
                            {
                                Player_Butt.Text = Convert.ToString(Convert.ToInt32(Player_Butt.Text) - roll_result.sub);
                            }
                        }

                        string E_Button_Name = butt.Name;
                        string E_Button_Number = "";
                        for (int i = 1; i < E_Button_Name.Length; i++)
                        {
                            E_Button_Number += E_Button_Name[i];
                        }
                        int E_butt_val = Convert.ToInt32(E_Button_Number);
                        Color E_Colour = butt.BackColor;
                        int E_Num = Player_number_from_colour(E_Colour);
                        Player_Countries[E_Num].Remove(E_butt_val);
                        Player_Territory_Start(Player, E_butt_val, ref Player_Countries);



                        /// ADD functionality to move troops when country is taken
                        /// ADD 

                        /// Reset to initial state so more tiles can be taken

                        firstbutt = true;

                        Grey_Buttons(1, ref Player_Countries, false, true);

                        Next_Player_Button.Enabled = false;
                        ButtUpDown1.Enabled = true;
                        butt.Enabled = true;
                        MessageBox.Show("Please enter the amount of troops you wish to transfer into the box on the left");
                        secondbutt = true;





                    }
                    else /// this means that if you fail a roll your turn ends, I'm not sure if I should keep this implementation or not.
                    {
                        butt.Text = Convert.ToString(Convert.ToInt32(butt.Text) - roll_result.sub);
                        Color Current_player_colour = Player_colour_from_number(Player);
                        for (int i = 0; i < Player_Countries[Player].Count(); i++)
                        {
                            string buttname = "C" + Player_Countries[Player][i].ToString();
                            Button Player_Butt = this.Controls.Find(buttname, true).FirstOrDefault() as Button;
                            if (Player_Butt.BackColor == Color.BurlyWood)
                            {
                                Player_Butt.BackColor = Current_player_colour;
                                Player_Butt.Text = "1";
                            }
                        }
                        Grey_Buttons(1, ref Player_Countries, false, true);
                        MessageBox.Show("You failed the attack, you have been moved to the fortification stage");
                        firstbutt = true;
                        Next_Player_Button_Click(butt, e);
                    }
                }
                else if (secondbutt == true) /// troop transfer
                {
                    Button Player_Butt = this.Controls.Find("C1", true).FirstOrDefault() as Button;
                    for (int i = 0; i < Player_Countries[Player].Count(); i++)
                    {
                        string buttname = "C" + Player_Countries[Player][i].ToString();
                        Player_Butt = this.Controls.Find(buttname, true).FirstOrDefault() as Button;
                        if (Player_Butt.BackColor == Color.BurlyWood)
                        {
                            break;
                        }
                    }
                    if (ButtUpDown1.Value >= Convert.ToInt32(Player_Butt.Text))
                    {
                        MessageBox.Show("You cannot transfer more troops than are on the tile");
                    }
                    else
                    {
                        butt.Text = Convert.ToString(Convert.ToInt32(butt.Text) + ButtUpDown1.Value);
                        Player_Butt.Text = Convert.ToString(Convert.ToInt32(Player_Butt.Text) - ButtUpDown1.Value);

                        Grey_Buttons(Player, ref Player_Countries, true, false);
                        Button bt = this.Controls.Find("-1", true).FirstOrDefault() as Button;
                        for (int i = 0; i < Player_Countries[Player].Count(); i++)
                        {
                            string ButtonName = "C" + Player_Countries[Player][i].ToString();
                            bt = this.Controls.Find(ButtonName, true).FirstOrDefault() as Button;
                            if (bt.Text == "1")
                            {
                                Individual_Button_Grey(false, Player_Countries[Player][i]);
                            }
                        }
                        firstbutt = true;
                        secondbutt = false;
                        Color Current_player_colour = Player_colour_from_number(Player);
                        Player_Butt.BackColor = Current_player_colour;
                        Next_Player_Button.Enabled = true;
                        ButtUpDown1.Enabled = false;
                    }
                }
            }
            else if (GameState.Text == "Fortifying")
            {
                if (firstbutt == true)
                {
                    Turn_Complete_Button.Enabled = false;
                    butt.BackColor = Color.BurlyWood;
                    int buttt = -1;
                    for (int i = 1; i < 43; i++)
                    {
                        string b2 = "C" + i.ToString();
                        Button initialbutt = this.Controls.Find(b2, true).FirstOrDefault() as Button;
                        if (initialbutt.BackColor == Color.BurlyWood)
                        {
                            buttt = i;
                            break;
                        }
                    }

                    firstbutt = false;
                    Grey_Buttons(Player, ref Player_Countries, false, true);
                    for (int i = 1; i < 43; i++)
                    {
                        string b1 = "C" + i.ToString();
                        Button PlayersColor = this.Controls.Find(b1, true).FirstOrDefault() as Button;
                        if (AdjacencyMatrix[buttt, i] == true && PlayersColor.BackColor == Player_colour_from_number(Player))
                        {
                            Individual_Button_Grey(true, i);
                        }
                    }
                }
                else if (firstbutt == false && secondbutt == false)
                {
                    int start = -1;
                    Button Start_Button;
                    int end = -1;
                    Button End_Button = this.Controls.Find("-1", true).FirstOrDefault() as Button;

                    butt.BackColor = Color.Chocolate;

                    for (int i = 1; i < 43; i++)
                    {
                        string b1 = "C" + i.ToString();
                        Button PlayersColor = this.Controls.Find(b1, true).FirstOrDefault() as Button;
                        if (PlayersColor.BackColor == Color.BurlyWood)
                        {
                            start = i;
                            Start_Button = PlayersColor;
                        }
                        else if (PlayersColor.BackColor == Color.Chocolate)
                        {
                            end = i;
                            End_Button = PlayersColor;
                        }
                    }

                    if (AdjacencyMatrix[start, end] == true) /// this is actually entered
                    {
                        secondbutt = true;

                        MessageBox.Show("Please enter the amount of troops you wish to transfer into the box on the left and click the country again");
                        Grey_Buttons(1, ref Player_Countries, false, true);

                        ButtUpDown1.Enabled = true;
                        End_Button.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Please select two countries connected by other owned countries. Thank you!");
                        for (int i = 0; i < Player_Countries[Player].Count(); i++)
                        {
                            Button_Colour(Player, Player_Countries[Player][i]);
                        }
                        firstbutt = true;
                    }

                }
                else if (secondbutt == true)
                {
                    ///Button Player_Butt = this.Controls.Find("C1", true).FirstOrDefault() as Button;                              ///default value 
                    ///bool founddd = false;
                    ///for (int i = 0; i < Player_Countries[Player].Count(); i++)                                                   ///
                    ///{                                        ///
                    ///    Player_Butt = this.Controls.Find("C"+Player_Countries[Player][i].ToString(), true).FirstOrDefault() as Button;                             ///
                    ///    if (Player_Butt.BackColor == Color.BurlyWood)                                                            /// 
                    ///    {                                                                                                        ///
                    ///        founddd = true;
                    ///        break;                                                                                               ///finds the button selected last time
                    ///    }                                                                                                        ///
                    ///}    
                    bool founddd = false;
                    Button Player_Butt = this.Controls.Find("-1", true).FirstOrDefault() as Button;
                    for (int i = 0; i < Player_Countries[Player].Count(); i++)
                    {
                        string ButtonName = "C" + Player_Countries[Player][i].ToString();
                        Player_Butt = this.Controls.Find(ButtonName, true).FirstOrDefault() as Button;
                        if (Player_Butt.BackColor == Color.BurlyWood)
                        {
                            founddd = true;
                            break;
                        }
                    }
                    if (founddd == false)
                    {
                        MessageBox.Show("you're code is dumb");
                    }
                    if (ButtUpDown1.Value >= Convert.ToInt32(Player_Butt.Text))                                                  ///
                    {                                                                                                            ///
                        MessageBox.Show("You cannot transfer more troops than are on the tile");                                 ///checks if the player is trying to move too many troops

                    }                                                                                                            ///
                    else                                                                                                         /// 
                    {                                                                                                            ///
                        butt.Text = Convert.ToString(Convert.ToInt32(butt.Text) + ButtUpDown1.Value);                            ///new button value = current val + val from uppy downy input thing
                        Player_Butt.Text = Convert.ToString(Convert.ToInt32(Player_Butt.Text) - ButtUpDown1.Value);              ///new button value = current val - val from uppy downy input thing
                        for (int i = 0; i < Player_Countries[Player].Count(); i++)
                        {
                            Button_Colour(Player, Player_Countries[Player][i]);
                        }
                        butt.Enabled = false;
                        firstbutt = true;
                        secondbutt = false;
                        Turn_Complete_Button.Enabled = true;
                    }
                }
            }
        } /// Country tile click logic

        private int Player_number_from_colour(Color Player_colour)
        {
            int player_num = -1;
            if (Player_colour == Color.White)
            {
                player_num = 0;
            }
            if (Player_colour == Color.HotPink)
            {
                player_num = 1;
            }
            if (Player_colour == Color.Red)
            {
                player_num = 2;
            }
            if (Player_colour == Color.Green)
            {
                player_num = 3;
            }
            if (Player_colour == Color.Blue)
            {
                player_num = 4;
            }
            if (Player_colour == Color.Orange)
            {
                player_num = 5;
            }
            return player_num;
        }

        private Color Player_colour_from_number(int player_num)
        {

            Color colour = Color.Empty;
            switch (player_num)
            {
                case 0:
                    colour = Color.White;
                    break;
                case 1:
                    colour = Color.HotPink;
                    break;
                case 2:
                    colour = Color.Red;
                    break;
                case 3:
                    colour = Color.Green;
                    break;
                case 4:
                    colour = Color.Blue;
                    break;
                case 5:
                    colour = Color.Orange;
                    break;
            }
            return colour;
        } /// Gets the player color from the player number

        private int button_player(int button_num)
        {
            string ButtonName = "C" + button_num.ToString();
            Button butt = this.Controls.Find(ButtonName, true).FirstOrDefault() as Button;
            int opposing_player = -1;
            if (butt.BackColor == Color.White)
            {
                opposing_player = 0;
            }
            else if (butt.BackColor == Color.HotPink)
            {
                opposing_player = 1;
            }
            else if (butt.BackColor == Color.Red)
            {
                opposing_player = 2;
            }
            else if (butt.BackColor == Color.Green)
            {
                opposing_player = 3;
            }
            else if (butt.BackColor == Color.Blue)
            {
                opposing_player = 4;
            }
            else if (butt.BackColor == Color.Orange)
            {
                opposing_player = 5;
            } /// gets the player number of the button owner
            return opposing_player;
        } /// Gets the player number from the color of the tile

        private void Individual_Button_Grey(bool Enable, int buttonint)
        {
            for (int i = 0; i < Player_Countries[Player].Count; i++)
            {
                string ButtonName = "C" + (buttonint).ToString();
                Button butt = this.Controls.Find(ButtonName, true).FirstOrDefault() as Button;
                butt.Enabled = Enable;
            }
        } /// Greys one button at a time

        List<int> checked_nodes = new List<int>();

        private bool DJ_algo_start(ref bool[,] matrix, int start, int end)
        {
            List<int> Connected = new List<int>();

            for (int i = 1; i < 43; i++)
            {
                if (AdjacencyMatrix[start, i] == true && Player_Countries[Player].Contains(i) == true) /// i don't think this bit works, it never returns true now that I added the second half of this line.
                {
                    if (i == end)
                        return true; /// if end node is found returns true
                    else if (ownercheck(i) == true)
                    {
                        Connected.Add(i); /// finds all connected nodes
                    }
                }
            }
            for (int i = 0; i < Connected.Count; i++)
            {
                if (checked_nodes.Contains(Connected[i]) == false)
                {
                    checked_nodes.Add(Connected[i]);
                    bool Next_level = DJ_algo_start(ref matrix, Connected[i], end);
                    if (Next_level == true)
                    {
                        return true; /// escape condition
                    }
                }
            }

            return false; /// failiure condition
        }

        private bool DJ_algo(ref bool[,] matrix, int start, int end)
        {
            bool output = DJ_algo_start(ref matrix, start, end);
            checked_nodes.Clear();
            return output;
        } /// this basically just resets the 'global' checked_nodes variable before moving on, I can't be bothered to find a better solution yet

        private bool ownercheck(int tile)
        {
            if (Player_Countries[Player].Contains(tile) == true)
                return true;
            else
                return false;
        }

        private void Next_Player_Button_Click(object sender, EventArgs e)
        {
            if (GameState.Text == "Allocate Your Troops")
            {
                GameState.Text = "Attacking";

                if (Round == 1)
                {
                    MessageBox.Show("Please enter the next turn to allow all players to allocate their troops");
                    Grey_Buttons(1, ref Player_Countries, false, true);
                }

                else
                {
                    Button bt = this.Controls.Find("-1", true).FirstOrDefault() as Button;
                    for (int i = 0; i < Player_Countries[Player].Count(); i++)
                    {
                        string ButtonName = "C" + Player_Countries[Player][i].ToString();
                        bt = this.Controls.Find(ButtonName, true).FirstOrDefault() as Button;
                        if (bt.Text == "1")
                        {
                            Individual_Button_Grey(false, Player_Countries[Player][i]);
                        }
                    }
                }
                ///List<int> current_countries = Player_Countries[Player];
                ///Grey_Buttons(1, ref Player_Countries, true, true); /// makes all buttons enabled
                ///
                ///for (int i = 0; i < Player_Countries[Player].Count(); i++) /// 0->len
                ///{
                ///    for (int j = 1; j < 43; j++) ///entire matrix
                ///    {
                ///        if (AdjacencyMatrix[Player_Countries[Player][i],j] == true)
                ///        {
                ///            Grey_Buttons(Player, ref Player_Countries, false, false); /// greys current players buttons
                ///        }
                ///    }
                ///}


            }

            else if (GameState.Text == "Attacking")
            {
                Turn_Complete_Button.Enabled = true;
                Next_Player_Button.Enabled = false;


                GameState.Text = "Fortifying";

                Grey_Buttons(1, ref Player_Countries, false, true);
                Grey_Buttons(Player, ref Player_Countries, true, false);


            }

            else if (GameState.Text == "Fortifying")
            {
                GameState.Text = "Allocate Your Troops";

                if (Round == 1)
                {
                    AvailableTroops.Text = Convert.ToString(initial_armies); /// do starting amount on first go
                }
                else /// else recalculate
                {
                    NewArmy();
                }

                /// do stuff to make the map look good
                PlayerTurn.Text = "Player " + Convert.ToString(Player + 1);
                Grey_Buttons(1, ref Player_Countries, false, true);
                Grey_Buttons(Player, ref Player_Countries, true, false);
                Colour_Hold(Player);
            }
        } /// This does a lot of stuff, it increments the round too early, in the last player's fortify stage it says its the round above what it should be.

        private void Button_Colour(int currentplayer, int CurrentButton)
        {
            string ButtonName = "C" + CurrentButton;
            Button butt = this.Controls.Find(ButtonName, true).FirstOrDefault() as Button;
            butt.ForeColor = Color.Black;
            switch (currentplayer)
            {
                case 0:
                    butt.BackColor = Color.White;
                    break;
                case 1:
                    butt.BackColor = Color.HotPink;
                    break;
                case 2:
                    butt.BackColor = Color.Red;
                    break;
                case 3:
                    butt.BackColor = Color.Green;
                    break;
                case 4:
                    butt.BackColor = Color.Blue;
                    break;
                case 5:
                    butt.BackColor = Color.Orange;
                    break;
            }
        } /// Changes the color of an individual Button

        private void Grey_Buttons(int currentplayer, ref List<List<int>> OwnedCountries, bool Enable, bool all)
        {
            List<List<int>> usedlist = new List<List<int>>();
            List<int> alllist = new List<int>();

            for (int i = 1; i < 43; i++)
            {
                alllist.Add(i);
            }

            List<List<int>> listofalllist = new List<List<int>>();
            listofalllist.Add(alllist);

            if (all == true)
            {
                usedlist = listofalllist;
                currentplayer = 0;
            }

            else
            {
                usedlist = OwnedCountries;
            }

            for (int i = 0; i < usedlist[currentplayer].Count; i++)
            {
                string ButtonName = "C" + (usedlist[currentplayer][i]).ToString();
                Button butt = this.Controls.Find(ButtonName, true).FirstOrDefault() as Button;
                butt.Enabled = Enable;
            }
        }

        bool round_over;

        private void Turn_Complete_Button_Click(object sender, EventArgs e)
        {
            round_over = true;
            Next_Player_Button.Enabled = true;

            /// round increment
            if (Player == max - 1)
            {
                Player = 0;
                Round += 1;
                Round_Count.Text = "Round " + Round.ToString() + ":";
            }
            else
            {
                Player += 1;
            }

            Turn_Complete_Button.Enabled = false;
            ButtUpDown1.Enabled = false;
            ButtUpDown1.Value = 0;
            Next_Player_Button_Click(Turn_Complete_Button, e);
        }

        private void Cancel_butt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Player_Countries[Player].Count(); i++)
            {
                Button_Colour(Player, Player_Countries[Player][i]);
            }
            firstbutt = true;
            secondbutt = false;
            if (GameState.Text == "Fortifying")
            {
                Turn_Complete_Button_Click(Cancel_butt, e);
            }
            else
            {
                Next_Player_Button_Click(Cancel_butt, e);
            }
            
        }

        /// Greys a list of buttons
    }
}

