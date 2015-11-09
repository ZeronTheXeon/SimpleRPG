using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using System.Windows.Forms;

namespace SimpleRPG
{
    public partial class SimpleRPG : Form
    {
        private Player player1 = new Player(); 
        public SimpleRPG()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CharStats_Click(object sender, EventArgs e)
        {
            MoneyValue.Text = "1";
        }

        private void SimpleRPG_Load(object sender, EventArgs e)
        {

        }
    }
}
