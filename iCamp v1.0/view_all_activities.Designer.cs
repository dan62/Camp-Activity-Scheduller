namespace iCamp_v1._0
{
    partial class view_all_activities
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.instruction = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.ComboBox();
            this.Search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.Indigo;
            this.heading.Location = new System.Drawing.Point(30, 23);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(146, 30);
            this.heading.TabIndex = 1;
            this.heading.Text = "View Activities";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 245);
            this.dataGridView1.TabIndex = 2;
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(32, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(288, 16);
            this.instruction.TabIndex = 3;
            this.instruction.Text = "Feel free to look at all activities registerd below ";
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.FormattingEnabled = true;
            this.search_box.Location = new System.Drawing.Point(366, 43);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(167, 23);
            this.search_box.TabIndex = 4;
            this.search_box.Text = "Search a particular Activity";
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.Indigo;
            this.Search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.Color.White;
            this.Search_button.Location = new System.Drawing.Point(539, 37);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 32);
            this.Search_button.TabIndex = 5;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // view_all_activities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 370);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view_all_activities";
            this.Text = "view_all_activities";
            this.Load += new System.EventHandler(this.view_all_activities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.ComboBox search_box;
        private System.Windows.Forms.Button Search_button;
    }
}