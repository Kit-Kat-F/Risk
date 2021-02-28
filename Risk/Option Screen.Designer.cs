namespace Risk
{
    partial class Option_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option_Screen));
            this.New_GAme = new System.Windows.Forms.Button();
            this.Load_GAme = new System.Windows.Forms.Button();
            this.Quite_GAme = new System.Windows.Forms.Button();
            this.Option_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // New_GAme
            // 
            this.New_GAme.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_GAme.Location = new System.Drawing.Point(12, 216);
            this.New_GAme.Name = "New_GAme";
            this.New_GAme.Size = new System.Drawing.Size(153, 73);
            this.New_GAme.TabIndex = 0;
            this.New_GAme.Text = "New Game";
            this.New_GAme.UseVisualStyleBackColor = true;
            this.New_GAme.Click += new System.EventHandler(this.New_GAme_Click);
            // 
            // Load_GAme
            // 
            this.Load_GAme.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_GAme.Location = new System.Drawing.Point(635, 216);
            this.Load_GAme.Name = "Load_GAme";
            this.Load_GAme.Size = new System.Drawing.Size(153, 73);
            this.Load_GAme.TabIndex = 1;
            this.Load_GAme.Text = "Load Game";
            this.Load_GAme.UseVisualStyleBackColor = true;
            this.Load_GAme.Click += new System.EventHandler(this.Load_GAme_Click);
            // 
            // Quite_GAme
            // 
            this.Quite_GAme.Location = new System.Drawing.Point(357, 384);
            this.Quite_GAme.Name = "Quite_GAme";
            this.Quite_GAme.Size = new System.Drawing.Size(108, 31);
            this.Quite_GAme.TabIndex = 2;
            this.Quite_GAme.Text = "Quit";
            this.Quite_GAme.UseVisualStyleBackColor = true;
            this.Quite_GAme.Click += new System.EventHandler(this.Quite_GAme_Click);
            // 
            // Option_title
            // 
            this.Option_title.AutoSize = true;
            this.Option_title.BackColor = System.Drawing.Color.Transparent;
            this.Option_title.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Option_title.Location = new System.Drawing.Point(237, 9);
            this.Option_title.Name = "Option_title";
            this.Option_title.Size = new System.Drawing.Size(317, 117);
            this.Option_title.TabIndex = 3;
            this.Option_title.Text = "Options";
            // 
            // Option_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Option_title);
            this.Controls.Add(this.Quite_GAme);
            this.Controls.Add(this.Load_GAme);
            this.Controls.Add(this.New_GAme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Option_Screen";
            this.Text = "Risk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New_GAme;
        private System.Windows.Forms.Button Load_GAme;
        private System.Windows.Forms.Button Quite_GAme;
        private System.Windows.Forms.Label Option_title;
    }
}