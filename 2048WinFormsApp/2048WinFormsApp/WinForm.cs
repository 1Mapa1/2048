using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class WinForm : Form
    {
        public bool menu;
        public bool restart;
        public WinForm()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            menu = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            restart = true;
            this.Close();
        }
    }
}
