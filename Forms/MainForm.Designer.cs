namespace Forms
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this._stopButton = new System.Windows.Forms.Button();
      this._startButton = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.scrollableTextBox = new System.Windows.Forms.TextBox();
      this._samplePanel = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
      this.panel1.SuspendLayout();
      this._samplePanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(0, 0);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(233, 95);
      this.listBox1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Top;
      this.button1.Location = new System.Drawing.Point(0, 155);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(233, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Add";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.textBox1.Location = new System.Drawing.Point(0, 135);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(233, 20);
      this.textBox1.TabIndex = 2;
      // 
      // textBox2
      // 
      this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.textBox2.Location = new System.Drawing.Point(0, 115);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(233, 20);
      this.textBox2.TabIndex = 3;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
      this.dateTimePicker1.Location = new System.Drawing.Point(0, 95);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
      this.dateTimePicker1.TabIndex = 4;
      // 
      // progressBar
      // 
      this.progressBar.Location = new System.Drawing.Point(12, 415);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(776, 23);
      this.progressBar.TabIndex = 5;
      // 
      // _stopButton
      // 
      this._stopButton.Location = new System.Drawing.Point(632, 386);
      this._stopButton.Name = "_stopButton";
      this._stopButton.Size = new System.Drawing.Size(75, 23);
      this._stopButton.TabIndex = 6;
      this._stopButton.Text = "Stop";
      this._stopButton.UseVisualStyleBackColor = true;
      this._stopButton.Click += new System.EventHandler(this._stopButton_Click);
      // 
      // _startButton
      // 
      this._startButton.Location = new System.Drawing.Point(713, 386);
      this._startButton.Name = "_startButton";
      this._startButton.Size = new System.Drawing.Size(75, 23);
      this._startButton.TabIndex = 7;
      this._startButton.Text = "Start";
      this._startButton.UseVisualStyleBackColor = true;
      this._startButton.Click += new System.EventHandler(this._startButton_Click);
      // 
      // panel1
      // 
      this.panel1.AutoScroll = true;
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.textBox2);
      this.panel1.Controls.Add(this.dateTimePicker1);
      this.panel1.Controls.Add(this.listBox1);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(250, 98);
      this.panel1.TabIndex = 8;
      // 
      // scrollableTextBox
      // 
      this.scrollableTextBox.Location = new System.Drawing.Point(268, 12);
      this.scrollableTextBox.Multiline = true;
      this.scrollableTextBox.Name = "scrollableTextBox";
      this.scrollableTextBox.Size = new System.Drawing.Size(194, 189);
      this.scrollableTextBox.TabIndex = 9;
      // 
      // _samplePanel
      // 
      this._samplePanel.Controls.Add(this.label5);
      this._samplePanel.Controls.Add(this.label4);
      this._samplePanel.Controls.Add(this.label3);
      this._samplePanel.Controls.Add(this.label2);
      this._samplePanel.Controls.Add(this.label1);
      this._samplePanel.Location = new System.Drawing.Point(302, 287);
      this._samplePanel.Name = "_samplePanel";
      this._samplePanel.Size = new System.Drawing.Size(200, 80);
      this._samplePanel.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(3, 97);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(100, 23);
      this.label5.TabIndex = 4;
      this.label5.Text = "label5";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(3, 77);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(100, 23);
      this.label4.TabIndex = 3;
      this.label4.Text = "label4";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(3, 56);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 23);
      this.label3.TabIndex = 2;
      this.label3.Text = "label3";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(3, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 23);
      this.label2.TabIndex = 1;
      this.label2.Text = "label2";
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(3, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      // 
      // vScrollBar1
      // 
      this.vScrollBar1.Location = new System.Drawing.Point(519, 287);
      this.vScrollBar1.Name = "vScrollBar1";
      this.vScrollBar1.Size = new System.Drawing.Size(56, 80);
      this.vScrollBar1.TabIndex = 11;
      this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.vScrollBar1);
      this.Controls.Add(this._samplePanel);
      this.Controls.Add(this.scrollableTextBox);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this._startButton);
      this.Controls.Add(this._stopButton);
      this.Controls.Add(this.progressBar);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this._samplePanel.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.VScrollBar vScrollBar1;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Panel _samplePanel;

    private System.Windows.Forms.TextBox scrollableTextBox;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button _stopButton;
    private System.Windows.Forms.Button _startButton;

    private System.Windows.Forms.ProgressBar progressBar;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.ListBox listBox1;

    #endregion
  }
}

