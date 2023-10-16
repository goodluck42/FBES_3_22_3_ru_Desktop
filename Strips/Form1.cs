using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolStripComboBox1.Items.Add("Item1");
            toolStripComboBox1.Items.Add("Item2");
            toolStripComboBox1.Items.Add("Item3");
        }
        
        private void ExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void mv(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var colorPicker = new FontDialog();

            colorPicker.ShowDialog();
        }
    }
}