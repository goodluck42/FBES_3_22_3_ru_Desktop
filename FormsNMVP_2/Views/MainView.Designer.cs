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
            this._loginButton = new System.Windows.Forms.Button();
            this._registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _loginButton
            // 
            this._loginButton.Location = new System.Drawing.Point(632, 415);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(75, 23);
            this._loginButton.TabIndex = 0;
            this._loginButton.Text = "Login";
            this._loginButton.UseVisualStyleBackColor = true;
            this._loginButton.Click += new System.EventHandler(this._loginButton_Click);
            // 
            // _registerButton
            // 
            this._registerButton.Location = new System.Drawing.Point(713, 415);
            this._registerButton.Name = "_registerButton";
            this._registerButton.Size = new System.Drawing.Size(75, 23);
            this._registerButton.TabIndex = 1;
            this._registerButton.Text = "Register";
            this._registerButton.UseVisualStyleBackColor = true;
            this._registerButton.Click += new System.EventHandler(this._registerButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._registerButton);
            this.Controls.Add(this._loginButton);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button _registerButton;

        private System.Windows.Forms.Button _loginButton;

        #endregion
    }
}