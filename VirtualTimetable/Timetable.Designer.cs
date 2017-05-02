﻿namespace VirtualTimetable
{
    partial class Timetable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listResults = new System.Windows.Forms.ListBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTimetable = new System.Windows.Forms.Label();
            this.cBoxFrom = new System.Windows.Forms.ComboBox();
            this.cBoxTo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listResults
            // 
            this.listResults.BackColor = System.Drawing.Color.LightGray;
            this.listResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listResults.FormattingEnabled = true;
            this.listResults.Location = new System.Drawing.Point(0, 150);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(515, 210);
            this.listResults.TabIndex = 10;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(3, 110);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 84);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From:";
            // 
            // lblTimetable
            // 
            this.lblTimetable.AutoSize = true;
            this.lblTimetable.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimetable.Location = new System.Drawing.Point(144, 11);
            this.lblTimetable.Name = "lblTimetable";
            this.lblTimetable.Size = new System.Drawing.Size(117, 26);
            this.lblTimetable.TabIndex = 11;
            this.lblTimetable.Text = "Timetable";
            // 
            // cBoxFrom
            // 
            this.cBoxFrom.FormattingEnabled = true;
            this.cBoxFrom.Location = new System.Drawing.Point(46, 81);
            this.cBoxFrom.Name = "cBoxFrom";
            this.cBoxFrom.Size = new System.Drawing.Size(100, 21);
            this.cBoxFrom.TabIndex = 0;
            this.cBoxFrom.TextUpdate += new System.EventHandler(this.cBoxFrom_TextUpdate);
            // 
            // cBoxTo
            // 
            this.cBoxTo.FormattingEnabled = true;
            this.cBoxTo.Location = new System.Drawing.Point(46, 107);
            this.cBoxTo.Name = "cBoxTo";
            this.cBoxTo.Size = new System.Drawing.Size(100, 21);
            this.cBoxTo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBoxTo);
            this.Controls.Add(this.cBoxFrom);
            this.Controls.Add(this.lblTimetable);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "Timetable";
            this.Size = new System.Drawing.Size(528, 375);
            this.Load += new System.EventHandler(this.Timetable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTimetable;
        private System.Windows.Forms.ComboBox cBoxFrom;
        private System.Windows.Forms.ComboBox cBoxTo;
        private System.Windows.Forms.Button button1;
    }
}
