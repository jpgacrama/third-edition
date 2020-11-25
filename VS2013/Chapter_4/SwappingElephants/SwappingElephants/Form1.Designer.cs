﻿namespace SwappingElephants
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
             this.LloydButton = new System.Windows.Forms.Button();
             this.LucindaButton = new System.Windows.Forms.Button();
             this.SwapButton = new System.Windows.Forms.Button();
             this.button4 = new System.Windows.Forms.Button();
             this.SuspendLayout();
             // 
             // LloydButton
             // 
             this.LloydButton.Location = new System.Drawing.Point(40, 12);
             this.LloydButton.Name = "LloydButton";
             this.LloydButton.Size = new System.Drawing.Size(75, 23);
             this.LloydButton.TabIndex = 0;
             this.LloydButton.Text = "Lloyd";
             this.LloydButton.UseVisualStyleBackColor = true;
             this.LloydButton.Click += new System.EventHandler(this.LloydButton_Click);
             // 
             // LucindaButton
             // 
             this.LucindaButton.Location = new System.Drawing.Point(40, 41);
             this.LucindaButton.Name = "LucindaButton";
             this.LucindaButton.Size = new System.Drawing.Size(75, 23);
             this.LucindaButton.TabIndex = 1;
             this.LucindaButton.Text = "Lucinda";
             this.LucindaButton.UseVisualStyleBackColor = true;
             this.LucindaButton.Click += new System.EventHandler(this.LucindaButton_Click);
             // 
             // SwapButton
             // 
             this.SwapButton.Location = new System.Drawing.Point(40, 70);
             this.SwapButton.Name = "SwapButton";
             this.SwapButton.Size = new System.Drawing.Size(75, 23);
             this.SwapButton.TabIndex = 2;
             this.SwapButton.Text = "Swap!";
             this.SwapButton.UseVisualStyleBackColor = true;
             this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
             // 
             // button4
             // 
             this.button4.Location = new System.Drawing.Point(40, 99);
             this.button4.Name = "button4";
             this.button4.Size = new System.Drawing.Size(75, 23);
             this.button4.TabIndex = 3;
             this.button4.Text = "button4";
             this.button4.UseVisualStyleBackColor = true;
             this.button4.Click += new System.EventHandler(this.button4_Click);
             // 
             // Form1
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(162, 135);
             this.Controls.Add(this.button4);
             this.Controls.Add(this.SwapButton);
             this.Controls.Add(this.LucindaButton);
             this.Controls.Add(this.LloydButton);
             this.MaximizeBox = false;
             this.MinimizeBox = false;
             this.Name = "Form1";
             this.Text = "Swap";
             this.ResumeLayout(false);

         }

         #endregion

         private System.Windows.Forms.Button LloydButton;
         private System.Windows.Forms.Button LucindaButton;
         private System.Windows.Forms.Button SwapButton;
         private System.Windows.Forms.Button button4;
     }
 }
