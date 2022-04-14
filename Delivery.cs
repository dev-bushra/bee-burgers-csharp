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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Home().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Menu().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Payment().Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new About_Us().Show();
        }
    }
}
