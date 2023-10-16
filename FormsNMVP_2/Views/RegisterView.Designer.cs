using System.ComponentModel;

namespace FormsNMVP.Views
{
    partial class RegisterView
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
            this._loginTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._genderComboBox = new System.Windows.Forms.ComboBox();
            this._loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _loginTextBox
            // 
            this._loginTextBox.Location = new System.Drawing.Point(317, 209);
            this._loginTextBox.Name = "_loginTextBox";
            this._loginTextBox.Size = new System.Drawing.Size(100, 20);
            this._loginTextBox.TabIndex = 0;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(317, 235);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this._passwordTextBox.TabIndex = 1;
            // 
            // _genderComboBox
            // 
            this._genderComboBox.FormattingEnabled = true;
            this._genderComboBox.Location = new System.Drawing.Point(317, 261);
            this._genderComboBox.Name = "_genderComboBox";
            this._genderComboBox.Size = new System.Drawing.Size(100, 21);
            this._genderComboBox.TabIndex = 2;
            // 
            // _loginButton
            // 
            this._loginButton.Location = new System.Drawing.Point(331, 307);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(75, 23);
            this._loginButton.TabIndex = 3;
            this._loginButton.Text = "button1";
            this._loginButton.UseVisualStyleBackColor = true;
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this._genderComboBox);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._loginTextBox);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox _loginTextBox;
        private System.Windows.Forms.ComboBox _genderComboBox;
        private System.Windows.Forms.Button _loginButton;

        private System.Windows.Forms.TextBox _passwordTextBox;

        #endregion
    }
}