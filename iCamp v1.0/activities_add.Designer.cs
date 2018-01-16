namespace iCamp_v1._0
{
    partial class activities_add
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
            this.heading = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.Activity_name = new System.Windows.Forms.TextBox();
            this.Advisor = new System.Windows.Forms.TextBox();
            this.participant_max = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.RichTextBox();
            this.seperator = new System.Windows.Forms.PictureBox();
            this.delete_activity_heading = new System.Windows.Forms.Label();
            this.activity_name_del = new System.Windows.Forms.TextBox();
            this.advisor_del = new System.Windows.Forms.TextBox();
            this.date_activity_del = new System.Windows.Forms.DateTimePicker();
            this.add_activity_button = new System.Windows.Forms.Button();
            this.delete_activity_button = new System.Windows.Forms.Button();
            this.instruction2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seperator)).BeginInit();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.Indigo;
            this.heading.Location = new System.Drawing.Point(37, 22);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(140, 30);
            this.heading.TabIndex = 0;
            this.heading.Text = "Add Activities";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(39, 56);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(369, 16);
            this.instruction.TabIndex = 1;
            this.instruction.Text = "Please fill in the details below to add and schedual an activity";
            // 
            // Activity_name
            // 
            this.Activity_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_name.Location = new System.Drawing.Point(42, 98);
            this.Activity_name.Name = "Activity_name";
            this.Activity_name.Size = new System.Drawing.Size(153, 22);
            this.Activity_name.TabIndex = 2;
            this.Activity_name.Text = "Activity Name";
            // 
            // Advisor
            // 
            this.Advisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor.Location = new System.Drawing.Point(42, 134);
            this.Advisor.Name = "Advisor";
            this.Advisor.Size = new System.Drawing.Size(153, 22);
            this.Advisor.TabIndex = 3;
            this.Advisor.Text = "Advisors Name";
            // 
            // participant_max
            // 
            this.participant_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant_max.Location = new System.Drawing.Point(42, 171);
            this.participant_max.Name = "participant_max";
            this.participant_max.Size = new System.Drawing.Size(153, 22);
            this.participant_max.TabIndex = 4;
            this.participant_max.Text = "Number of seats";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(42, 209);
            this.date.MinDate = new System.DateTime(2017, 10, 20, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(153, 22);
            this.date.TabIndex = 5;
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(219, 100);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(189, 93);
            this.description.TabIndex = 6;
            this.description.Text = "Describe the activity and how it shall be conducted.";
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.Color.Black;
            this.seperator.Location = new System.Drawing.Point(429, 32);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(2, 235);
            this.seperator.TabIndex = 7;
            this.seperator.TabStop = false;
            // 
            // delete_activity_heading
            // 
            this.delete_activity_heading.AutoSize = true;
            this.delete_activity_heading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_activity_heading.ForeColor = System.Drawing.Color.Indigo;
            this.delete_activity_heading.Location = new System.Drawing.Point(438, 22);
            this.delete_activity_heading.Name = "delete_activity_heading";
            this.delete_activity_heading.Size = new System.Drawing.Size(179, 30);
            this.delete_activity_heading.TabIndex = 8;
            this.delete_activity_heading.Text = "Delete An Activity";
            // 
            // activity_name_del
            // 
            this.activity_name_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activity_name_del.Location = new System.Drawing.Point(458, 98);
            this.activity_name_del.Name = "activity_name_del";
            this.activity_name_del.Size = new System.Drawing.Size(153, 22);
            this.activity_name_del.TabIndex = 9;
            this.activity_name_del.Text = "Activity Name";
            // 
            // advisor_del
            // 
            this.advisor_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisor_del.Location = new System.Drawing.Point(458, 134);
            this.advisor_del.Name = "advisor_del";
            this.advisor_del.Size = new System.Drawing.Size(153, 22);
            this.advisor_del.TabIndex = 10;
            this.advisor_del.Text = "Advisors Name";
            // 
            // date_activity_del
            // 
            this.date_activity_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_activity_del.Location = new System.Drawing.Point(458, 171);
            this.date_activity_del.MinDate = new System.DateTime(2017, 10, 20, 0, 0, 0, 0);
            this.date_activity_del.Name = "date_activity_del";
            this.date_activity_del.Size = new System.Drawing.Size(153, 22);
            this.date_activity_del.TabIndex = 11;
            // 
            // add_activity_button
            // 
            this.add_activity_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.add_activity_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_activity_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_activity_button.ForeColor = System.Drawing.Color.White;
            this.add_activity_button.Location = new System.Drawing.Point(219, 203);
            this.add_activity_button.Name = "add_activity_button";
            this.add_activity_button.Size = new System.Drawing.Size(113, 38);
            this.add_activity_button.TabIndex = 12;
            this.add_activity_button.Text = "Add Activity";
            this.add_activity_button.UseVisualStyleBackColor = false;
            this.add_activity_button.Click += new System.EventHandler(this.add_activity_button_Click);
            // 
            // delete_activity_button
            // 
            this.delete_activity_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.delete_activity_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_activity_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_activity_button.ForeColor = System.Drawing.Color.White;
            this.delete_activity_button.Location = new System.Drawing.Point(458, 203);
            this.delete_activity_button.Name = "delete_activity_button";
            this.delete_activity_button.Size = new System.Drawing.Size(125, 38);
            this.delete_activity_button.TabIndex = 13;
            this.delete_activity_button.Text = "Delete Activity";
            this.delete_activity_button.UseVisualStyleBackColor = false;
            this.delete_activity_button.Click += new System.EventHandler(this.delete_activity_button_Click);
            // 
            // instruction2
            // 
            this.instruction2.AutoSize = true;
            this.instruction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction2.Location = new System.Drawing.Point(440, 56);
            this.instruction2.Name = "instruction2";
            this.instruction2.Size = new System.Drawing.Size(207, 16);
            this.instruction2.TabIndex = 14;
            this.instruction2.Text = "Delete the activity you want below";
            // 
            // activities_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 345);
            this.Controls.Add(this.instruction2);
            this.Controls.Add(this.delete_activity_button);
            this.Controls.Add(this.add_activity_button);
            this.Controls.Add(this.date_activity_del);
            this.Controls.Add(this.advisor_del);
            this.Controls.Add(this.activity_name_del);
            this.Controls.Add(this.delete_activity_heading);
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.description);
            this.Controls.Add(this.date);
            this.Controls.Add(this.participant_max);
            this.Controls.Add(this.Advisor);
            this.Controls.Add(this.Activity_name);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "activities_add";
            this.Text = "activities_add";
            ((System.ComponentModel.ISupportInitialize)(this.seperator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.TextBox Activity_name;
        private System.Windows.Forms.TextBox Advisor;
        private System.Windows.Forms.TextBox participant_max;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.PictureBox seperator;
        private System.Windows.Forms.Label delete_activity_heading;
        private System.Windows.Forms.TextBox activity_name_del;
        private System.Windows.Forms.TextBox advisor_del;
        private System.Windows.Forms.DateTimePicker date_activity_del;
        private System.Windows.Forms.Button add_activity_button;
        private System.Windows.Forms.Button delete_activity_button;
        private System.Windows.Forms.Label instruction2;
    }
}