﻿using Engine;
using System;
using System.Windows.Forms;

namespace SimpleRPG
{
    public partial class SimpleRPG : Form
    {
        private Player player1 = new Player(20, 20, 0, 30, 30, 0, 1);
        private Location location = new Location(1, "Home", "This is your home.");

        public SimpleRPG()
        {
            InitializeComponent();

            // player1.Location = "Home";

            GoldValue.Text = player1.Money.ToString();
            HealthValue.Text = player1.CurrentHP.ToString() + " / " + player1.MaxHP.ToString();
            CharLevelValue.Text = player1.Level.ToString();
            ManaValue.Text = player1.CurrentMP.ToString() + " / " + player1.MaxMP.ToString();
            LocationValue.Text = location.Name;

            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your home.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void CharStats_Click(object sender, EventArgs e)
        {
        }

        private void SimpleRPG_Load(object sender, EventArgs e)
        {
        }

        private void Money_Click(object sender, EventArgs e)
        {
        }

        private void MoneyValue_Click(object sender, EventArgs e)
        {
        }

        private void CharLevelValue_Click(object sender, EventArgs e)
        {
        }
    }
}