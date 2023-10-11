using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.Models;
using Forms.Services;

namespace Forms
{
    public partial class MainForm : Form
    {
        private IPersonManager _manager;
        private Timer _timer;

        public MainForm(IPersonManager manager)
        {
            //MessageBox.Show("MainForm");
            _manager = manager;

            InitializeComponent();

            scrollableTextBox.ScrollBars = ScrollBars.Vertical; // Enable scroll for textbox
        }

        private static int s_Id = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            _manager.Add(new Person()
            {
                Id = s_Id++,
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                BirthDate = dateTimePicker1.Value
            });

            listBox1.DisplayMember = "FirstName";
            listBox1.Items.Clear();

            for (int i = 0; i < _manager.Count; i++)
            {
                listBox1.Items.Add(_manager[i]);
            }
        }

        private void _startButton_Click(object sender, EventArgs e)
        {
            if (_timer != null)
            {
                return;
            }

            _timer = new Timer()
            {
                Interval = 100
            };

            _timer.Tick += (o, args) =>
            {
                if (progressBar.Value + 1 >= 100)
                {
                    progressBar.Value += 1;

                    _timer.Stop();

                    return;
                }

                progressBar.Value += 1;
            };

            _timer.Start();
        }

        private void _stopButton_Click(object sender, EventArgs e)
        {
            _timer?.Stop();
            _timer = null;

            progressBar.Value = 0;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _samplePanel.VerticalScroll.Value = e.NewValue;
        }
    }
}