using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UninstallTaskmanager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Opacity = .5;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }
    }
}
