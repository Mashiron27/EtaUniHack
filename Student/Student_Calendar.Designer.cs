namespace EasyTestApp
{
    partial class Student_Calendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.calendarMessageTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(181, 165);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // calendarMessageTitleLabel
            // 
            this.calendarMessageTitleLabel.AutoSize = true;
            this.calendarMessageTitleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.calendarMessageTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.calendarMessageTitleLabel.Location = new System.Drawing.Point(231, 74);
            this.calendarMessageTitleLabel.Name = "calendarMessageTitleLabel";
            this.calendarMessageTitleLabel.Size = new System.Drawing.Size(108, 17);
            this.calendarMessageTitleLabel.TabIndex = 3;
            this.calendarMessageTitleLabel.Text = "Your Schedule:";
            // 
            // Student_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.calendarMessageTitleLabel);
            this.Name = "Student_Calendar";
            this.Size = new System.Drawing.Size(679, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label calendarMessageTitleLabel;
    }
}
