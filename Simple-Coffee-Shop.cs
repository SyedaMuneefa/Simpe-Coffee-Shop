using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muneefa_15148
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
        
            int total = 0;

            if (chkEspresso.Checked)
                total += 3;

            if (chkLatte.Checked)
                total += 4;

            if (chkCappuccino.Checked)
                total += 5;

            lblTotal.Text = "Total: $" + total.ToString();
    }
    }
}
