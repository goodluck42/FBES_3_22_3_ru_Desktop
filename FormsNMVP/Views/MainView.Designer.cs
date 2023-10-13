using System.ComponentModel;

namespace FormsNMVP.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this._cityNameTextBox = new System.Windows.Forms.TextBox();
            this._cityNameLabel = new System.Windows.Forms.Label();
            this._byCityNameRadioButton = new System.Windows.Forms.RadioButton();
            this._byCoordinatesRadioButton = new System.Windows.Forms.RadioButton();
            this._latTextBox = new System.Windows.Forms.TextBox();
            this._lonTextBox = new System.Windows.Forms.TextBox();
            this._latLabel = new System.Windows.Forms.Label();
            this._lonLabel = new System.Windows.Forms.Label();
            this._getWeatherButton = new System.Windows.Forms.Button();
            this._tempLabel = new System.Windows.Forms.Label();
            this._feelsLikeLabel = new System.Windows.Forms.Label();
            this._windSpeedLabel = new System.Windows.Forms.Label();
            this._weatherLabel = new System.Windows.Forms.Label();
            this._descriptionLabel = new System.Windows.Forms.Label();
            this._descriptionLabelInfo = new System.Windows.Forms.Label();
            this._weatherLabelInfo = new System.Windows.Forms.Label();
            this._windSpeedLabelInfo = new System.Windows.Forms.Label();
            this._feelsLikeLabelInfo = new System.Windows.Forms.Label();
            this._tempLabelInfo = new System.Windows.Forms.Label();
            this._dataPanel = new System.Windows.Forms.Panel();
            this._byCoordsPanel = new System.Windows.Forms.Panel();
            this._byCityNamePanel = new System.Windows.Forms.Panel();
            this._cityLabel = new System.Windows.Forms.Label();
            this._cityLabelInfo = new System.Windows.Forms.Label();
            this._countryLabel = new System.Windows.Forms.Label();
            this._countryLabelInfo = new System.Windows.Forms.Label();
            this._dataPanel.SuspendLayout();
            this._byCoordsPanel.SuspendLayout();
            this._byCityNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cityNameTextBox
            // 
            this._cityNameTextBox.Location = new System.Drawing.Point(53, 12);
            this._cityNameTextBox.Name = "_cityNameTextBox";
            this._cityNameTextBox.Size = new System.Drawing.Size(100, 22);
            this._cityNameTextBox.TabIndex = 0;
            // 
            // _cityNameLabel
            // 
            this._cityNameLabel.AutoSize = true;
            this._cityNameLabel.Location = new System.Drawing.Point(12, 15);
            this._cityNameLabel.Name = "_cityNameLabel";
            this._cityNameLabel.Size = new System.Drawing.Size(35, 17);
            this._cityNameLabel.TabIndex = 1;
            this._cityNameLabel.Text = "City:";
            // 
            // _byCityNameRadioButton
            // 
            this._byCityNameRadioButton.Location = new System.Drawing.Point(12, 12);
            this._byCityNameRadioButton.Name = "_byCityNameRadioButton";
            this._byCityNameRadioButton.Size = new System.Drawing.Size(104, 24);
            this._byCityNameRadioButton.TabIndex = 2;
            this._byCityNameRadioButton.TabStop = true;
            this._byCityNameRadioButton.Text = "By City";
            this._byCityNameRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._byCityNameRadioButton.UseVisualStyleBackColor = true;
            this._byCityNameRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // _byCoordinatesRadioButton
            // 
            this._byCoordinatesRadioButton.Location = new System.Drawing.Point(204, 12);
            this._byCoordinatesRadioButton.Name = "_byCoordinatesRadioButton";
            this._byCoordinatesRadioButton.Size = new System.Drawing.Size(200, 24);
            this._byCoordinatesRadioButton.TabIndex = 3;
            this._byCoordinatesRadioButton.TabStop = true;
            this._byCoordinatesRadioButton.Text = "By Coordinates";
            this._byCoordinatesRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._byCoordinatesRadioButton.UseVisualStyleBackColor = true;
            this._byCoordinatesRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // _latTextBox
            // 
            this._latTextBox.Location = new System.Drawing.Point(87, 12);
            this._latTextBox.Name = "_latTextBox";
            this._latTextBox.Size = new System.Drawing.Size(100, 22);
            this._latTextBox.TabIndex = 4;
            // 
            // _lonTextBox
            // 
            this._lonTextBox.Location = new System.Drawing.Point(87, 40);
            this._lonTextBox.Name = "_lonTextBox";
            this._lonTextBox.Size = new System.Drawing.Size(100, 22);
            this._lonTextBox.TabIndex = 5;
            // 
            // _latLabel
            // 
            this._latLabel.AutoSize = true;
            this._latLabel.Location = new System.Drawing.Point(22, 15);
            this._latLabel.Name = "_latLabel";
            this._latLabel.Size = new System.Drawing.Size(59, 17);
            this._latLabel.TabIndex = 6;
            this._latLabel.Text = "Latitude";
            // 
            // _lonLabel
            // 
            this._lonLabel.AutoSize = true;
            this._lonLabel.Location = new System.Drawing.Point(10, 43);
            this._lonLabel.Name = "_lonLabel";
            this._lonLabel.Size = new System.Drawing.Size(71, 17);
            this._lonLabel.TabIndex = 7;
            this._lonLabel.Text = "Longitude";
            // 
            // _getWeatherButton
            // 
            this._getWeatherButton.Location = new System.Drawing.Point(602, 415);
            this._getWeatherButton.Name = "_getWeatherButton";
            this._getWeatherButton.Size = new System.Drawing.Size(186, 23);
            this._getWeatherButton.TabIndex = 8;
            this._getWeatherButton.Text = "Get Weather";
            this._getWeatherButton.UseVisualStyleBackColor = true;
            this._getWeatherButton.Click += new System.EventHandler(this._getWeatherButton_Click);
            // 
            // _tempLabel
            // 
            this._tempLabel.AutoSize = true;
            this._tempLabel.Location = new System.Drawing.Point(29, 12);
            this._tempLabel.Name = "_tempLabel";
            this._tempLabel.Size = new System.Drawing.Size(90, 17);
            this._tempLabel.TabIndex = 9;
            this._tempLabel.Text = "Temperature";
            // 
            // _feelsLikeLabel
            // 
            this._feelsLikeLabel.AutoSize = true;
            this._feelsLikeLabel.Location = new System.Drawing.Point(47, 43);
            this._feelsLikeLabel.Name = "_feelsLikeLabel";
            this._feelsLikeLabel.Size = new System.Drawing.Size(72, 17);
            this._feelsLikeLabel.TabIndex = 10;
            this._feelsLikeLabel.Text = "Feels Like";
            // 
            // _windSpeedLabel
            // 
            this._windSpeedLabel.AutoSize = true;
            this._windSpeedLabel.Location = new System.Drawing.Point(34, 70);
            this._windSpeedLabel.Name = "_windSpeedLabel";
            this._windSpeedLabel.Size = new System.Drawing.Size(85, 17);
            this._windSpeedLabel.TabIndex = 11;
            this._windSpeedLabel.Text = "Wind Speed";
            // 
            // _weatherLabel
            // 
            this._weatherLabel.AutoSize = true;
            this._weatherLabel.Location = new System.Drawing.Point(57, 101);
            this._weatherLabel.Name = "_weatherLabel";
            this._weatherLabel.Size = new System.Drawing.Size(62, 17);
            this._weatherLabel.TabIndex = 12;
            this._weatherLabel.Text = "Weather";
            // 
            // _descriptionLabel
            // 
            this._descriptionLabel.AutoSize = true;
            this._descriptionLabel.Location = new System.Drawing.Point(40, 134);
            this._descriptionLabel.Name = "_descriptionLabel";
            this._descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this._descriptionLabel.TabIndex = 13;
            this._descriptionLabel.Text = "Description";
            // 
            // _descriptionLabelInfo
            // 
            this._descriptionLabelInfo.AutoSize = true;
            this._descriptionLabelInfo.Location = new System.Drawing.Point(145, 134);
            this._descriptionLabelInfo.Name = "_descriptionLabelInfo";
            this._descriptionLabelInfo.Size = new System.Drawing.Size(0, 17);
            this._descriptionLabelInfo.TabIndex = 18;
            // 
            // _weatherLabelInfo
            // 
            this._weatherLabelInfo.AutoSize = true;
            this._weatherLabelInfo.Location = new System.Drawing.Point(162, 101);
            this._weatherLabelInfo.Name = "_weatherLabelInfo";
            this._weatherLabelInfo.Size = new System.Drawing.Size(0, 17);
            this._weatherLabelInfo.TabIndex = 17;
            // 
            // _windSpeedLabelInfo
            // 
            this._windSpeedLabelInfo.AutoSize = true;
            this._windSpeedLabelInfo.Location = new System.Drawing.Point(139, 70);
            this._windSpeedLabelInfo.Name = "_windSpeedLabelInfo";
            this._windSpeedLabelInfo.Size = new System.Drawing.Size(0, 17);
            this._windSpeedLabelInfo.TabIndex = 16;
            // 
            // _feelsLikeLabelInfo
            // 
            this._feelsLikeLabelInfo.AutoSize = true;
            this._feelsLikeLabelInfo.Location = new System.Drawing.Point(152, 43);
            this._feelsLikeLabelInfo.Name = "_feelsLikeLabelInfo";
            this._feelsLikeLabelInfo.Size = new System.Drawing.Size(0, 17);
            this._feelsLikeLabelInfo.TabIndex = 15;
            // 
            // _tempLabelInfo
            // 
            this._tempLabelInfo.AutoSize = true;
            this._tempLabelInfo.Location = new System.Drawing.Point(134, 12);
            this._tempLabelInfo.Name = "_tempLabelInfo";
            this._tempLabelInfo.Size = new System.Drawing.Size(0, 17);
            this._tempLabelInfo.TabIndex = 14;
            // 
            // _dataPanel
            // 
            this._dataPanel.Controls.Add(this._countryLabelInfo);
            this._dataPanel.Controls.Add(this._countryLabel);
            this._dataPanel.Controls.Add(this._cityLabelInfo);
            this._dataPanel.Controls.Add(this._cityLabel);
            this._dataPanel.Controls.Add(this._tempLabel);
            this._dataPanel.Controls.Add(this._descriptionLabelInfo);
            this._dataPanel.Controls.Add(this._feelsLikeLabel);
            this._dataPanel.Controls.Add(this._weatherLabelInfo);
            this._dataPanel.Controls.Add(this._windSpeedLabel);
            this._dataPanel.Controls.Add(this._windSpeedLabelInfo);
            this._dataPanel.Controls.Add(this._weatherLabel);
            this._dataPanel.Controls.Add(this._feelsLikeLabelInfo);
            this._dataPanel.Controls.Add(this._descriptionLabel);
            this._dataPanel.Controls.Add(this._tempLabelInfo);
            this._dataPanel.Location = new System.Drawing.Point(12, 162);
            this._dataPanel.Name = "_dataPanel";
            this._dataPanel.Size = new System.Drawing.Size(324, 276);
            this._dataPanel.TabIndex = 19;
            this._dataPanel.Visible = false;
            // 
            // _byCoordsPanel
            // 
            this._byCoordsPanel.Controls.Add(this._latLabel);
            this._byCoordsPanel.Controls.Add(this._latTextBox);
            this._byCoordsPanel.Controls.Add(this._lonTextBox);
            this._byCoordsPanel.Controls.Add(this._lonLabel);
            this._byCoordsPanel.Location = new System.Drawing.Point(12, 39);
            this._byCoordsPanel.Name = "_byCoordsPanel";
            this._byCoordsPanel.Size = new System.Drawing.Size(200, 100);
            this._byCoordsPanel.TabIndex = 20;
            // 
            // _byCityNamePanel
            // 
            this._byCityNamePanel.Controls.Add(this._cityNameLabel);
            this._byCityNamePanel.Controls.Add(this._cityNameTextBox);
            this._byCityNamePanel.Location = new System.Drawing.Point(12, 42);
            this._byCityNamePanel.Name = "_byCityNamePanel";
            this._byCityNamePanel.Size = new System.Drawing.Size(186, 100);
            this._byCityNamePanel.TabIndex = 21;
            // 
            // _cityLabel
            // 
            this._cityLabel.AutoSize = true;
            this._cityLabel.Location = new System.Drawing.Point(87, 165);
            this._cityLabel.Name = "_cityLabel";
            this._cityLabel.Size = new System.Drawing.Size(31, 17);
            this._cityLabel.TabIndex = 19;
            this._cityLabel.Text = "City";
            // 
            // _cityLabelInfo
            // 
            this._cityLabelInfo.AutoSize = true;
            this._cityLabelInfo.Location = new System.Drawing.Point(134, 165);
            this._cityLabelInfo.Name = "_cityLabelInfo";
            this._cityLabelInfo.Size = new System.Drawing.Size(0, 17);
            this._cityLabelInfo.TabIndex = 20;
            // 
            // _countryLabel
            // 
            this._countryLabel.AutoSize = true;
            this._countryLabel.Location = new System.Drawing.Point(61, 191);
            this._countryLabel.Name = "_countryLabel";
            this._countryLabel.Size = new System.Drawing.Size(57, 17);
            this._countryLabel.TabIndex = 21;
            this._countryLabel.Text = "Country";
            // 
            // _countryLabelInfo
            // 
            this._countryLabelInfo.AutoSize = true;
            this._countryLabelInfo.Location = new System.Drawing.Point(134, 191);
            this._countryLabelInfo.Name = "_countryLabelInfo";
            this._countryLabelInfo.Size = new System.Drawing.Size(0, 17);
            this._countryLabelInfo.TabIndex = 22;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._byCityNamePanel);
            this.Controls.Add(this._byCoordsPanel);
            this.Controls.Add(this._dataPanel);
            this.Controls.Add(this._getWeatherButton);
            this.Controls.Add(this._byCoordinatesRadioButton);
            this.Controls.Add(this._byCityNameRadioButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainView";
            this._dataPanel.ResumeLayout(false);
            this._dataPanel.PerformLayout();
            this._byCoordsPanel.ResumeLayout(false);
            this._byCoordsPanel.PerformLayout();
            this._byCityNamePanel.ResumeLayout(false);
            this._byCityNamePanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _cityLabel;
        private System.Windows.Forms.Label _cityLabelInfo;
        private System.Windows.Forms.Label _countryLabel;
        private System.Windows.Forms.Label _countryLabelInfo;

        private System.Windows.Forms.Panel _byCoordsPanel;
        private System.Windows.Forms.Panel _byCityNamePanel;

        private System.Windows.Forms.Panel _dataPanel;

        private System.Windows.Forms.Label _weatherLabel;
        private System.Windows.Forms.Label _descriptionLabel;
        private System.Windows.Forms.Label _descriptionLabelInfo;
        private System.Windows.Forms.Label _weatherLabelInfo;
        private System.Windows.Forms.Label _windSpeedLabelInfo;
        private System.Windows.Forms.Label _feelsLikeLabelInfo;
        private System.Windows.Forms.Label _tempLabelInfo;

        private System.Windows.Forms.Label _windSpeedLabel;

        private System.Windows.Forms.Label _tempLabel;

        private System.Windows.Forms.Label _feelsLikeLabel;

        private System.Windows.Forms.Button _getWeatherButton;

        private System.Windows.Forms.RadioButton _byCityNameRadioButton;
        private System.Windows.Forms.RadioButton _byCoordinatesRadioButton;
        private System.Windows.Forms.TextBox _latTextBox;
        private System.Windows.Forms.TextBox _lonTextBox;
        private System.Windows.Forms.Label _latLabel;
        private System.Windows.Forms.Label _lonLabel;

        private System.Windows.Forms.TextBox _cityNameTextBox;
        private System.Windows.Forms.Label _cityNameLabel;

        #endregion
    }
}