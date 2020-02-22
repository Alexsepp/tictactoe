using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe_alex
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MessageBox.Show("As you can see on the picture I Red-Lined how it could be, same can be as row and column");
        }

        private void Getit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
