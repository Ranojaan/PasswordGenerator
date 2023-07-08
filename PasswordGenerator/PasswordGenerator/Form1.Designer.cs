using System;

namespace PasswordGenerator
{
    partial class Form1
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLengthLabel = new System.Windows.Forms.Label();
            this.PasswordLengthSlider = new System.Windows.Forms.TrackBar();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Fugaz One", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(106, 56);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(582, 62);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Label1";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLengthLabel
            // 
            this.PasswordLengthLabel.Font = new System.Drawing.Font("Fugaz One", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLengthLabel.Location = new System.Drawing.Point(201, 197);
            this.PasswordLengthLabel.Name = "PasswordLengthLabel";
            this.PasswordLengthLabel.Size = new System.Drawing.Size(409, 62);
            this.PasswordLengthLabel.TabIndex = 1;
            this.PasswordLengthLabel.Text = "Password Length : 5";
            this.PasswordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordLengthLabel.Click += new System.EventHandler(this.PasswordLengthLabel_Click);
            // 
            // PasswordLengthSlider
            // 
            this.PasswordLengthSlider.Location = new System.Drawing.Point(211, 262);
            this.PasswordLengthSlider.Name = "PasswordLengthSlider";
            this.PasswordLengthSlider.Size = new System.Drawing.Size(409, 56);
            this.PasswordLengthSlider.TabIndex = 2;
            this.PasswordLengthSlider.Scroll += new System.EventHandler(this.PasswordLengthSlider_Scroll);
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.BackColor = System.Drawing.Color.White;
            this.CopyPasswordButton.Font = new System.Drawing.Font("Fugaz One", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPasswordButton.Location = new System.Drawing.Point(211, 347);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(399, 66);
            this.CopyPasswordButton.TabIndex = 3;
            this.CopyPasswordButton.Text = "Copy Password";
            this.CopyPasswordButton.UseVisualStyleBackColor = false;
            this.CopyPasswordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(788, 425);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.PasswordLengthSlider);
            this.Controls.Add(this.PasswordLengthLabel);
            this.Controls.Add(this.PasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PasswordLengthLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label PasswordLengthLabel;
        private System.Windows.Forms.TrackBar PasswordLengthSlider;
        private System.Windows.Forms.Button CopyPasswordButton;
    }
}

