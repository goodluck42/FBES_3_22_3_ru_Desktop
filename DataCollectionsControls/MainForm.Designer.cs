namespace DataCollectionsControls
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
            this._itemsListBox = new System.Windows.Forms.ListBox();
            this._itemNameTextBox = new System.Windows.Forms.TextBox();
            this._addItemButton = new System.Windows.Forms.Button();
            this._itemsPanel = new System.Windows.Forms.Panel();
            this.itemsInfoPanel = new System.Windows.Forms.Panel();
            this._itemQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._categoryComboBox = new System.Windows.Forms.ComboBox();
            this._dataTreeView = new System.Windows.Forms.TreeView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this._itemsPanel.SuspendLayout();
            this.itemsInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._itemQuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _itemsListBox
            // 
            this._itemsListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._itemsListBox.FormattingEnabled = true;
            this._itemsListBox.Location = new System.Drawing.Point(5, 7);
            this._itemsListBox.Name = "_itemsListBox";
            this._itemsListBox.Size = new System.Drawing.Size(366, 368);
            this._itemsListBox.TabIndex = 0;
            // 
            // _itemNameTextBox
            // 
            this._itemNameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this._itemNameTextBox.Location = new System.Drawing.Point(0, 0);
            this._itemNameTextBox.Name = "_itemNameTextBox";
            this._itemNameTextBox.Size = new System.Drawing.Size(249, 20);
            this._itemNameTextBox.TabIndex = 1;
            // 
            // _addItemButton
            // 
            this._addItemButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._addItemButton.Location = new System.Drawing.Point(5, 398);
            this._addItemButton.Name = "_addItemButton";
            this._addItemButton.Size = new System.Drawing.Size(366, 23);
            this._addItemButton.TabIndex = 2;
            this._addItemButton.Text = "Add item";
            this._addItemButton.UseVisualStyleBackColor = true;
            this._addItemButton.Click += new System.EventHandler(this._addItemButton_Click);
            // 
            // _itemsPanel
            // 
            this._itemsPanel.Controls.Add(this._itemsListBox);
            this._itemsPanel.Controls.Add(this.itemsInfoPanel);
            this._itemsPanel.Controls.Add(this._addItemButton);
            this._itemsPanel.Location = new System.Drawing.Point(12, 12);
            this._itemsPanel.Name = "_itemsPanel";
            this._itemsPanel.Padding = new System.Windows.Forms.Padding(5);
            this._itemsPanel.Size = new System.Drawing.Size(376, 426);
            this._itemsPanel.TabIndex = 3;
            // 
            // itemsInfoPanel
            // 
            this.itemsInfoPanel.Controls.Add(this._itemQuantityNumericUpDown);
            this.itemsInfoPanel.Controls.Add(this._itemNameTextBox);
            this.itemsInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemsInfoPanel.Location = new System.Drawing.Point(5, 375);
            this.itemsInfoPanel.Name = "itemsInfoPanel";
            this.itemsInfoPanel.Size = new System.Drawing.Size(366, 23);
            this.itemsInfoPanel.TabIndex = 0;
            // 
            // _itemQuantityNumericUpDown
            // 
            this._itemQuantityNumericUpDown.Dock = System.Windows.Forms.DockStyle.Left;
            this._itemQuantityNumericUpDown.Location = new System.Drawing.Point(249, 0);
            this._itemQuantityNumericUpDown.Name = "_itemQuantityNumericUpDown";
            this._itemQuantityNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this._itemQuantityNumericUpDown.TabIndex = 4;
            // 
            // _categoryComboBox
            // 
            this._categoryComboBox.FormattingEnabled = true;
            this._categoryComboBox.Location = new System.Drawing.Point(392, 389);
            this._categoryComboBox.Name = "_categoryComboBox";
            this._categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this._categoryComboBox.TabIndex = 4;
            // 
            // _dataTreeView
            // 
            this._dataTreeView.Location = new System.Drawing.Point(664, 12);
            this._dataTreeView.Name = "_dataTreeView";
            this._dataTreeView.Size = new System.Drawing.Size(252, 426);
            this._dataTreeView.TabIndex = 5;
            this._dataTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._dataTreeView_NodeMouseDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(444, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this._dataTreeView);
            this.Controls.Add(this._categoryComboBox);
            this.Controls.Add(this._itemsPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._itemsPanel.ResumeLayout(false);
            this.itemsInfoPanel.ResumeLayout(false);
            this.itemsInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._itemQuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.TreeView _dataTreeView;

        private System.Windows.Forms.ComboBox _categoryComboBox;

        private System.Windows.Forms.NumericUpDown _itemQuantityNumericUpDown;

        private System.Windows.Forms.Panel itemsInfoPanel;

        private System.Windows.Forms.Panel _itemsPanel;

        private System.Windows.Forms.TextBox _itemNameTextBox;
        private System.Windows.Forms.Button _addItemButton;

        private System.Windows.Forms.ListBox _itemsListBox;

        #endregion
    }
}