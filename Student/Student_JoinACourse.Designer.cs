namespace EasyTestApp.Student
{
    partial class Student_JoinACourse
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
            this.nullCode = new System.Windows.Forms.Label();
            this.invalidCode = new System.Windows.Forms.Label();
            this.validCode = new System.Windows.Forms.Label();
            this.joinCourseButton = new System.Windows.Forms.Button();
            this.examLinkInput = new System.Windows.Forms.TextBox();
            this.enterTheLinkTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nullCode
            // 
            this.nullCode.AutoSize = true;
            this.nullCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.nullCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.nullCode.Location = new System.Drawing.Point(206, 309);
            this.nullCode.Name = "nullCode";
            this.nullCode.Size = new System.Drawing.Size(188, 17);
            this.nullCode.TabIndex = 13;
            this.nullCode.Text = "Please enter the invite link.";
            // 
            // invalidCode
            // 
            this.invalidCode.AutoSize = true;
            this.invalidCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.invalidCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.invalidCode.Location = new System.Drawing.Point(169, 309);
            this.invalidCode.Name = "invalidCode";
            this.invalidCode.Size = new System.Drawing.Size(285, 17);
            this.invalidCode.TabIndex = 12;
            this.invalidCode.Text = "Your link is invalid! Please check the link.";
            // 
            // validCode
            // 
            this.validCode.AutoSize = true;
            this.validCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.validCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.validCode.Location = new System.Drawing.Point(120, 309);
            this.validCode.Name = "validCode";
            this.validCode.Size = new System.Drawing.Size(402, 17);
            this.validCode.TabIndex = 11;
            this.validCode.Text = "Your invitation was sent! Please wait for teacher\'s approval.";
            // 
            // joinCourseButton
            // 
            this.joinCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.joinCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.joinCourseButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.joinCourseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.joinCourseButton.Location = new System.Drawing.Point(253, 225);
            this.joinCourseButton.Name = "joinCourseButton";
            this.joinCourseButton.Size = new System.Drawing.Size(116, 35);
            this.joinCourseButton.TabIndex = 10;
            this.joinCourseButton.Text = "Join Course!";
            this.joinCourseButton.UseVisualStyleBackColor = false;
            // 
            // examLinkInput
            // 
            this.examLinkInput.Location = new System.Drawing.Point(123, 169);
            this.examLinkInput.Name = "examLinkInput";
            this.examLinkInput.Size = new System.Drawing.Size(384, 20);
            this.examLinkInput.TabIndex = 9;
            // 
            // enterTheLinkTitleLabel
            // 
            this.enterTheLinkTitleLabel.AutoSize = true;
            this.enterTheLinkTitleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.enterTheLinkTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(162)))), ((int)(((byte)(164)))));
            this.enterTheLinkTitleLabel.Location = new System.Drawing.Point(169, 109);
            this.enterTheLinkTitleLabel.Name = "enterTheLinkTitleLabel";
            this.enterTheLinkTitleLabel.Size = new System.Drawing.Size(291, 17);
            this.enterTheLinkTitleLabel.TabIndex = 8;
            this.enterTheLinkTitleLabel.Text = "Please enter the join course link invitation:";
            // 
            // Student_JoinACourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.nullCode);
            this.Controls.Add(this.invalidCode);
            this.Controls.Add(this.validCode);
            this.Controls.Add(this.joinCourseButton);
            this.Controls.Add(this.examLinkInput);
            this.Controls.Add(this.enterTheLinkTitleLabel);
            this.Name = "Student_JoinACourse";
            this.Size = new System.Drawing.Size(679, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nullCode;
        private System.Windows.Forms.Label invalidCode;
        private System.Windows.Forms.Label validCode;
        private System.Windows.Forms.Button joinCourseButton;
        private System.Windows.Forms.TextBox examLinkInput;
        private System.Windows.Forms.Label enterTheLinkTitleLabel;
    }
}
