﻿namespace Decryptor
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
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedEndpointTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(12, 12);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(459, 20);
            this.FilePathTextBox.TabIndex = 0;
            this.FilePathTextBox.Text = "C:\\ProgramData\\4sIT\\SCC\\.SCC\\endpoints.bin";
            // 
            // EncryptedEndpointTextBox
            // 
            this.EncryptedEndpointTextBox.Location = new System.Drawing.Point(12, 38);
            this.EncryptedEndpointTextBox.Multiline = true;
            this.EncryptedEndpointTextBox.Name = "EncryptedEndpointTextBox";
            this.EncryptedEndpointTextBox.Size = new System.Drawing.Size(459, 211);
            this.EncryptedEndpointTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Decrypt File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EncryptedEndpointTextBox);
            this.Controls.Add(this.FilePathTextBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Decrypt Endpoint v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.TextBox EncryptedEndpointTextBox;
        private System.Windows.Forms.Button button1;
    }
}
