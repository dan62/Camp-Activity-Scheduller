namespace iCamp_v1._0
{
    partial class Update_activity
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.search_activity_button = new System.Windows.Forms.Button();
            this.save_update_button = new System.Windows.Forms.Button();
            this.description_retreived = new System.Windows.Forms.RichTextBox();
            this.date_retreived = new System.Windows.Forms.DateTimePicker();
            this.participant_max_retreived = new System.Windows.Forms.TextBox();
            this.advisor_retreived = new System.Windows.Forms.TextBox();
            this.activity_name_retreived = new System.Windows.Forms.TextBox();
            this.activity_image = new System.Windows.Forms.PictureBox();
            this.seperator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.activity_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperator)).BeginInit();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.Indigo;
            this.heading.Location = new System.Drawing.Point(28, 20);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(263, 30);
            this.heading.TabIndex = 1;
            this.heading.Text = "Update An Existing Activity";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(30, 50);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(273, 16);
            this.instruction.TabIndex = 2;
            this.instruction.Text = "Start by entering your Activity name and Date";
            // 
            // Activity_name
            // 
            this.Activity_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_name.Location = new System.Drawing.Point(33, 83);
            this.Activity_name.Name = "Activity_name";
            this.Activity_name.Size = new System.Drawing.Size(153, 22);
            this.Activity_name.TabIndex = 3;
            this.Activity_name.Text = "Activity Name";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(205, 83);
            this.date.MinDate = new System.DateTime(2017, 10, 20, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(153, 22);
            this.date.TabIndex = 6;
            // 
            // search_activity_button
            // 
            this.search_activity_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.search_activity_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_activity_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_activity_button.ForeColor = System.Drawing.Color.White;
            this.search_activity_button.Location = new System.Drawing.Point(374, 75);
            this.search_activity_button.Name = "search_activity_button";
            this.search_activity_button.Size = new System.Drawing.Size(106, 30);
            this.search_activity_button.TabIndex = 13;
            this.search_activity_button.Text = "Search Activity";
            this.search_activity_button.UseVisualStyleBackColor = false;
            this.search_activity_button.Click += new System.EventHandler(this.search_activity_button_Click);
            // 
            // save_update_button
            // 
            this.save_update_button.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.save_update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_update_button.ForeColor = System.Drawing.Color.White;
            this.save_update_button.Location = new System.Drawing.Point(374, 272);
            this.save_update_button.Name = "save_update_button";
            this.save_update_button.Size = new System.Drawing.Size(106, 28);
            this.save_update_button.TabIndex = 21;
            this.save_update_button.Text = "Save Update";
            this.save_update_button.UseVisualStyleBackColor = false;
            this.save_update_button.Click += new System.EventHandler(this.save_update_button_Click);
            // 
            // description_retreived
            // 
            this.description_retreived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_retreived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_retreived.Location = new System.Drawing.Point(374, 169);
            this.description_retreived.Name = "description_retreived";
            this.description_retreived.Size = new System.Drawing.Size(189, 93);
            this.description_retreived.TabIndex = 20;
            this.description_retreived.Text = "Describe the activity and how it shall be conducted.";
            // 
            // date_retreived
            // 
            this.date_retreived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_retreived.Location = new System.Drawing.Point(197, 278);
            this.date_retreived.MinDate = new System.DateTime(2017, 10, 20, 0, 0, 0, 0);
            this.date_retreived.Name = "date_retreived";
            this.date_retreived.Size = new System.Drawing.Size(153, 22);
            this.date_retreived.TabIndex = 19;
            // 
            // participant_max_retreived
            // 
            this.participant_max_retreived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participant_max_retreived.Location = new System.Drawing.Point(197, 240);
            this.participant_max_retreived.Name = "participant_max_retreived";
            this.participant_max_retreived.Size = new System.Drawing.Size(153, 22);
            this.participant_max_retreived.TabIndex = 18;
            this.participant_max_retreived.Text = "Number of seats";
            // 
            // advisor_retreived
            // 
            this.advisor_retreived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advisor_retreived.Location = new System.Drawing.Point(197, 203);
            this.advisor_retreived.Name = "advisor_retreived";
            this.advisor_retreived.Size = new System.Drawing.Size(153, 22);
            this.advisor_retreived.TabIndex = 17;
            this.advisor_retreived.Text = "Advisors Name";
            // 
            // activity_name_retreived
            // 
            this.activity_name_retreived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activity_name_retreived.Location = new System.Drawing.Point(197, 167);
            this.activity_name_retreived.Name = "activity_name_retreived";
            this.activity_name_retreived.Size = new System.Drawing.Size(153, 22);
            this.activity_name_retreived.TabIndex = 16;
            this.activity_name_retreived.Text = "Activity Name";
            // 
            // activity_image
            // 
            this.activity_image.BackColor = System.Drawing.Color.White;
            this.activity_image.BackgroundImage = global::iCamp_v1._0.Properties.Resources.jsut_logo;
            this.activity_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activity_image.Location = new System.Drawing.Point(12, 167);
            this.activity_image.Name = "activity_image";
            this.activity_image.Size = new System.Drawing.Size(162, 133);
            this.activity_image.TabIndex = 15;
            this.activity_image.TabStop = false;
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.Color.Indigo;
            this.seperator.Location = new System.Drawing.Point(32, 130);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(530, 3);
            this.seperator.TabIndex = 14;
            this.seperator.TabStop = false;
            // 
            // Update_activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 385);
            this.Controls.Add(this.save_update_button);
            this.Controls.Add(this.description_retreived);
            this.Controls.Add(this.date_retreived);
            this.Controls.Add(this.participant_max_retreived);
            this.Controls.Add(this.advisor_retreived);
            this.Controls.Add(this.activity_name_retreived);
            this.Controls.Add(this.activity_image);
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.search_activity_button);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Activity_name);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_activity";
            this.Text = "Update_activity";
            this.Load += new System.EventHandler(this.Update_activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activity_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seperator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.TextBox Activity_name;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button search_activity_button;
        private System.Windows.Forms.PictureBox seperator;
        private System.Windows.Forms.PictureBox activity_image;
        private System.Windows.Forms.Button save_update_button;
        private System.Windows.Forms.RichTextBox description_retreived;
        private System.Windows.Forms.DateTimePicker date_retreived;
        private System.Windows.Forms.TextBox participant_max_retreived;
        private System.Windows.Forms.TextBox advisor_retreived;
        private System.Windows.Forms.TextBox activity_name_retreived;
    }
}