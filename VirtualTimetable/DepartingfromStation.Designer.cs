namespace VirtualTimetable
{
    partial class DepartingfromStation
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.listResults = new System.Windows.Forms.ListBox();
            this.lblTimetable = new System.Windows.Forms.Label();
            this.cBoxFrom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 84);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 9;
            this.lblFrom.Text = "From:";
            // 
            // listResults
            // 
            this.listResults.BackColor = System.Drawing.Color.LightGray;
            this.listResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listResults.FormattingEnabled = true;
            this.listResults.Location = new System.Drawing.Point(0, 150);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(515, 210);
            this.listResults.TabIndex = 11;
            // 
            // lblTimetable
            // 
            this.lblTimetable.AutoSize = true;
            this.lblTimetable.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimetable.Location = new System.Drawing.Point(86, 16);
            this.lblTimetable.Name = "lblTimetable";
            this.lblTimetable.Size = new System.Drawing.Size(261, 26);
            this.lblTimetable.TabIndex = 12;
            this.lblTimetable.Text = "Departing from Station";
            // 
            // cBoxFrom
            // 
            this.cBoxFrom.FormattingEnabled = true;
            this.cBoxFrom.Location = new System.Drawing.Point(46, 81);
            this.cBoxFrom.Name = "cBoxFrom";
            this.cBoxFrom.Size = new System.Drawing.Size(100, 21);
            this.cBoxFrom.TabIndex = 0;
            // 
            // DepartingfromStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBoxFrom);
            this.Controls.Add(this.lblTimetable);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.lblFrom);
            this.Name = "DepartingfromStation";
            this.Size = new System.Drawing.Size(528, 375);
            this.Load += new System.EventHandler(this.DepartingfromStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.Label lblTimetable;
        private System.Windows.Forms.ComboBox cBoxFrom;
    }
}
