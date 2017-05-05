namespace VirtualTimetable
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
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTimetable = new System.Windows.Forms.Label();
            this.cBoxFrom = new System.Windows.Forms.ComboBox();
            this.cBoxTo = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listResultsTimetable = new System.Windows.Forms.ListView();
            this.dTPicker = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(3, 81);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 50);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From:";
            // 
            // lblTimetable
            // 
            this.lblTimetable.AutoSize = true;
            this.lblTimetable.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimetable.Location = new System.Drawing.Point(144, 0);
            this.lblTimetable.Name = "lblTimetable";
            this.lblTimetable.Size = new System.Drawing.Size(117, 26);
            this.lblTimetable.TabIndex = 11;
            this.lblTimetable.Text = "Timetable";
            // 
            // cBoxFrom
            // 
            this.cBoxFrom.FormattingEnabled = true;
            this.cBoxFrom.Location = new System.Drawing.Point(46, 47);
            this.cBoxFrom.Name = "cBoxFrom";
            this.cBoxFrom.Size = new System.Drawing.Size(132, 21);
            this.cBoxFrom.TabIndex = 0;
            this.cBoxFrom.TextUpdate += new System.EventHandler(this.cBoxFrom_TextUpdate);
            // 
            // cBoxTo
            // 
            this.cBoxTo.FormattingEnabled = true;
            this.cBoxTo.Location = new System.Drawing.Point(46, 73);
            this.cBoxTo.Name = "cBoxTo";
            this.cBoxTo.Size = new System.Drawing.Size(132, 21);
            this.cBoxTo.TabIndex = 1;
            this.cBoxTo.TextUpdate += new System.EventHandler(this.cBoxTo_TextUpdate);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(186, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listResultsTimetable
            // 
            this.listResultsTimetable.Location = new System.Drawing.Point(0, 150);
            this.listResultsTimetable.Name = "listResultsTimetable";
            this.listResultsTimetable.Size = new System.Drawing.Size(504, 210);
            this.listResultsTimetable.TabIndex = 14;
            this.listResultsTimetable.TabStop = false;
            this.listResultsTimetable.UseCompatibleStateImageBehavior = false;
            // 
            // dTPicker
            // 
            this.dTPicker.CustomFormat = "dd.MM.yyyy  || HH.mm";
            this.dTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPicker.Location = new System.Drawing.Point(46, 104);
            this.dTPicker.Name = "dTPicker";
            this.dTPicker.Size = new System.Drawing.Size(132, 20);
            this.dTPicker.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Date:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(185, 63);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dTPicker);
            this.Controls.Add(this.listResultsTimetable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cBoxTo);
            this.Controls.Add(this.cBoxFrom);
            this.Controls.Add(this.lblTimetable);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "Timetable";
            this.Size = new System.Drawing.Size(515, 375);
            this.Load += new System.EventHandler(this.Timetable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTimetable;
        private System.Windows.Forms.ComboBox cBoxFrom;
        private System.Windows.Forms.ComboBox cBoxTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listResultsTimetable;
        private System.Windows.Forms.DateTimePicker dTPicker;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnChange;
    }
}
