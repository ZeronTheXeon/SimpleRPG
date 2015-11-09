using Engine;
using System;
using System.Windows.Forms;

namespace SimpleRPG
{
    public partial class SimpleRPG : Form
    {
        private Player player1 = new Player();

        public SimpleRPG()
        {
            InitializeComponent();

            player1.CurrentHP = 100;
            player1.CurrentMP = 0;
            player1.Level = 1;
            player1.Location = "Home";
            player1.MaxHP = 100;
            player1.MaxMP = 100;
            player1.Money = 20;

            GoldValue.Text = player1.Money.ToString();
            HealthValue.Text = player1.CurrentHP.ToString() + " / " + player1.MaxHP.ToString();
            CharLevelValue.Text = player1.Level.ToString();
            ManaValue.Text = player1.CurrentMP.ToString() + " / " + player1.MaxMP.ToString();

            LocationValue.Text = player1.Location;
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