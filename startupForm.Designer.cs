﻿namespace FriendFileForm
{
    partial class startupForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.friendFileButton = new System.Windows.Forms.Button();
            this.form3Button = new System.Windows.Forms.Button();
            this.arrayProcessingButton = new System.Windows.Forms.Button();
            this.binarySearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 69);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // friendFileButton
            // 
            this.friendFileButton.Location = new System.Drawing.Point(12, 12);
            this.friendFileButton.Name = "friendFileButton";
            this.friendFileButton.Size = new System.Drawing.Size(101, 23);
            this.friendFileButton.TabIndex = 1;
            this.friendFileButton.Text = "Friend File";
            this.friendFileButton.UseVisualStyleBackColor = true;
            this.friendFileButton.Click += new System.EventHandler(this.friendFileButton_Click);
            // 
            // form3Button
            // 
            this.form3Button.Location = new System.Drawing.Point(119, 12);
            this.form3Button.Name = "form3Button";
            this.form3Button.Size = new System.Drawing.Size(97, 23);
            this.form3Button.TabIndex = 2;
            this.form3Button.Text = "Pay and Bonus";
            this.form3Button.UseVisualStyleBackColor = true;
            this.form3Button.Click += new System.EventHandler(this.form3Button_Click);
            // 
            // arrayProcessingButton
            // 
            this.arrayProcessingButton.Location = new System.Drawing.Point(12, 40);
            this.arrayProcessingButton.Name = "arrayProcessingButton";
            this.arrayProcessingButton.Size = new System.Drawing.Size(101, 23);
            this.arrayProcessingButton.TabIndex = 3;
            this.arrayProcessingButton.Text = "Array Process";
            this.arrayProcessingButton.UseVisualStyleBackColor = true;
            this.arrayProcessingButton.Click += new System.EventHandler(this.arrayProcessingButton_Click);
            // 
            // binarySearchButton
            // 
            this.binarySearchButton.Location = new System.Drawing.Point(119, 40);
            this.binarySearchButton.Name = "binarySearchButton";
            this.binarySearchButton.Size = new System.Drawing.Size(97, 23);
            this.binarySearchButton.TabIndex = 4;
            this.binarySearchButton.Text = "Binary Search";
            this.binarySearchButton.UseVisualStyleBackColor = true;
            this.binarySearchButton.Click += new System.EventHandler(this.binarySearchButton_Click);
            // 
            // startupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 95);
            this.Controls.Add(this.binarySearchButton);
            this.Controls.Add(this.arrayProcessingButton);
            this.Controls.Add(this.form3Button);
            this.Controls.Add(this.friendFileButton);
            this.Controls.Add(this.exitButton);
            this.Name = "startupForm";
            this.Text = "C# Concepts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button friendFileButton;
        private System.Windows.Forms.Button form3Button;
        private System.Windows.Forms.Button arrayProcessingButton;
        private System.Windows.Forms.Button binarySearchButton;
    }
}