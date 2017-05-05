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
            this.lblTimetable = new System.Windows.Forms.Label();
            this.cBoxFrom = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listResultsDfS = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 50);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 9;
            this.lblFrom.Text = "From:";
            // 
            // lblTimetable
            // 
            this.lblTimetable.AutoSize = true;
            this.lblTimetable.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimetable.Location = new System.Drawing.Point(144, 0);
            this.lblTimetable.Name = "lblTimetable";
            this.lblTimetable.Size = new System.Drawing.Size(261, 26);
            this.lblTimetable.TabIndex = 12;
            this.lblTimetable.Text = "Departing from Station";
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(186, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listResultsDfS
            // 
            this.listResultsDfS.Location = new System.Drawing.Point(0, 150);
            this.listResultsDfS.Name = "listResultsDfS";
            this.listResultsDfS.Size = new System.Drawing.Size(504, 210);
            this.listResultsDfS.TabIndex = 14;
            this.listResultsDfS.TabStop = false;
            this.listResultsDfS.UseCompatibleStateImageBehavior = false;
            // 
            // DepartingfromStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listResultsDfS);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cBoxFrom);
            this.Controls.Add(this.lblTimetable);
            this.Controls.Add(this.lblFrom);
            this.Name = "DepartingfromStation";
            this.Size = new System.Drawing.Size(515, 375);
            this.Load += new System.EventHandler(this.DepartingfromStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTimetable;
        private System.Windows.Forms.ComboBox cBoxFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listResultsDfS;
    }
}
