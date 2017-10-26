namespace iCamp_v1._0
{
    partial class splash_screen
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
            this.components = new System.ComponentModel.Container();
            this.software_title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.preloader = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // software_title
            // 
            this.software_title.AutoSize = true;
            this.software_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.software_title.ForeColor = System.Drawing.Color.White;
            this.software_title.Location = new System.Drawing.Point(273, 217);
            this.software_title.Name = "software_title";
            this.software_title.Size = new System.Drawing.Size(163, 55);
            this.software_title.TabIndex = 0;
            this.software_title.Text = "iCamp";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.ForeColor = System.Drawing.Color.White;
            this.author.Location = new System.Drawing.Point(280, 272);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(119, 15);
            this.author.TabIndex = 1;
            this.author.Text = "By Daniel Goncalves";
            // 
            // preloader
            // 
            this.preloader.ForeColor = System.Drawing.Color.Black;
            this.preloader.Location = new System.Drawing.Point(-1, 494);
            this.preloader.Name = "preloader";
            this.preloader.Size = new System.Drawing.Size(719, 10);
            this.preloader.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::iCamp_v1._0.Properties.Resources.tent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(296, 70);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(113, 127);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.White;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(293, 344);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(106, 49);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // splash_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(718, 504);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.preloader);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.author);
            this.Controls.Add(this.software_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label software_title;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ProgressBar preloader;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_button;
    }
}

