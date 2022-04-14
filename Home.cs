using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee_Burger
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            new About_Us().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Menu().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Delivery().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Payment().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
