﻿namespace DinnerParty_first_version
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
             this.label1 = new System.Windows.Forms.Label();
             this.NumberOfPeopleListBox = new System.Windows.Forms.NumericUpDown();
             this.FancyDecorationsCheckbox = new System.Windows.Forms.CheckBox();
             this.HealthyOptionCheckbox = new System.Windows.Forms.CheckBox();
             this.costLabel = new System.Windows.Forms.Label();
             this.label2 = new System.Windows.Forms.Label();
             ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleListBox)).BeginInit();
             this.SuspendLayout();
             // 
             // label1
             // 
             this.label1.AutoSize = true;
             this.label1.Location = new System.Drawing.Point(12, 9);
             this.label1.Name = "label1";
             this.label1.Size = new System.Drawing.Size(92, 13);
             this.label1.TabIndex = 0;
             this.label1.Text = "Number of People";
             // 
             // NumberOfPeopleListBox
             // 
             this.NumberOfPeopleListBox.Location = new System.Drawing.Point(15, 25);
             this.NumberOfPeopleListBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
             this.NumberOfPeopleListBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
             this.NumberOfPeopleListBox.Name = "NumberOfPeopleListBox";
             this.NumberOfPeopleListBox.Size = new System.Drawing.Size(89, 20);
             this.NumberOfPeopleListBox.TabIndex = 1;
             this.NumberOfPeopleListBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
             this.NumberOfPeopleListBox.ValueChanged += new System.EventHandler(this.NumberOfPeopleListBox_ValueChanged);
             // 
             // FancyDecorationsCheckbox
             // 
             this.FancyDecorationsCheckbox.AutoSize = true;
             this.FancyDecorationsCheckbox.Checked = true;
             this.FancyDecorationsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
             this.FancyDecorationsCheckbox.Location = new System.Drawing.Point(15, 51);
             this.FancyDecorationsCheckbox.Name = "FancyDecorationsCheckbox";
             this.FancyDecorationsCheckbox.Size = new System.Drawing.Size(115, 17);
             this.FancyDecorationsCheckbox.TabIndex = 2;
             this.FancyDecorationsCheckbox.Text = "Fancy Decorations";
             this.FancyDecorationsCheckbox.UseVisualStyleBackColor = true;
             this.FancyDecorationsCheckbox.CheckedChanged += new System.EventHandler(this.FancyDecorationsCheckbox_CheckedChanged);
             // 
             // HealthyOptionCheckbox
             // 
             this.HealthyOptionCheckbox.AutoSize = true;
             this.HealthyOptionCheckbox.Location = new System.Drawing.Point(15, 74);
             this.HealthyOptionCheckbox.Name = "HealthyOptionCheckbox";
             this.HealthyOptionCheckbox.Size = new System.Drawing.Size(96, 17);
             this.HealthyOptionCheckbox.TabIndex = 3;
             this.HealthyOptionCheckbox.Text = "Healthy Option";
             this.HealthyOptionCheckbox.UseVisualStyleBackColor = true;
             this.HealthyOptionCheckbox.CheckedChanged += new System.EventHandler(this.HealthyOptionCheckbox_CheckedChanged);
             // 
             // costLabel
             // 
             this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
             this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.costLabel.Location = new System.Drawing.Point(50, 102);
             this.costLabel.Name = "costLabel";
             this.costLabel.Size = new System.Drawing.Size(71, 19);
             this.costLabel.TabIndex = 4;
             // 
             // label2
             // 
             this.label2.AutoSize = true;
             this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.label2.Location = new System.Drawing.Point(12, 103);
             this.label2.Name = "label2";
             this.label2.Size = new System.Drawing.Size(32, 13);
             this.label2.TabIndex = 5;
             this.label2.Text = "Cost";
             // 
             // Form1
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(167, 133);
             this.Controls.Add(this.label2);
             this.Controls.Add(this.costLabel);
             this.Controls.Add(this.HealthyOptionCheckbox);
             this.Controls.Add(this.FancyDecorationsCheckbox);
             this.Controls.Add(this.NumberOfPeopleListBox);
             this.Controls.Add(this.label1);
             this.MaximizeBox = false;
             this.MinimizeBox = false;
             this.Name = "Form1";
             this.Text = "Party Planner";
             ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleListBox)).EndInit();
             this.ResumeLayout(false);
             this.PerformLayout();

         }

         #endregion

         private System.Windows.Forms.Label label1;
         private System.Windows.Forms.NumericUpDown NumberOfPeopleListBox;
         private System.Windows.Forms.CheckBox FancyDecorationsCheckbox;
         private System.Windows.Forms.CheckBox HealthyOptionCheckbox;
         private System.Windows.Forms.Label costLabel;
         private System.Windows.Forms.Label label2;
     }
 }
