using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinformsControls
{
    public partial class MainForm : Form
    {
        private System.Drawing.Color? _selectedColor = null;

        public MainForm()
        {
            InitializeComponent();

            richTextBox1.Text = "Hello world";
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            return;
            if (sender is MainForm form)
            {
                if (form == this)
                {
                    // ...
                }

                MessageBox.Show("The sender is form!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void testButton_Click(object sender, EventArgs e)
        {
            var checkBoxes = new List<CheckBox>();

            foreach (var control in Controls)
            {
                if (control is CheckBox c)
                {
                    checkBoxes.Add(c);
                }
            }

            var rnd = new Random();
            var randomCheckbox = checkBoxes[rnd.Next(0, checkBoxes.Count)];

            randomCheckbox.Checked = !randomCheckbox.Checked;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            xyLabel.Text = $"x: {e.X} y: {e.Y}";
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox box)
            {
                MessageBox.Show($"{box.Text}: {box.Checked}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textboxLabel.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled)
            {
                textBox1.Enabled = false;
                button1.Text = "Enable TextBox";
            }
            else
            {
                textBox1.Enabled = true;
                button1.Text = "Disable TextBox";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.ShowDialog();

                _selectedColor = colorDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_selectedColor != null)
            {
                richTextBox1.SelectionColor = _selectedColor.Value;
            }
        }
    }
}