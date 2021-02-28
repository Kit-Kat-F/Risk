namespace Risk
{
    partial class Risk_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Risk_Home));
            this.logoname = new System.Windows.Forms.Label();
            this.StartButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoname
            // 
            this.logoname.AutoSize = true;
            this.logoname.BackColor = System.Drawing.Color.Red;
            this.logoname.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoname.Location = new System.Drawing.Point(302, 31);
            this.logoname.Name = "logoname";
            this.logoname.Size = new System.Drawing.Size(204, 117);
            this.logoname.TabIndex = 0;
            this.logoname.Text = "Risk";
            this.logoname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButt
            // 
            this.StartButt.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButt.Location = new System.Drawing.Point(160, 379);
            this.StartButt.Name = "StartButt";
            this.StartButt.Size = new System.Drawing.Size(481, 40);
            this.StartButt.TabIndex = 1;
            this.StartButt.Text = "Start";
            this.StartButt.UseVisualStyleBackColor = true;
            this.StartButt.Click += new System.EventHandler(this.StartButt_Click);
            // 
            // Risk_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartButt);
            this.Controls.Add(this.logoname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Risk_Home";
            this.Text = "Risk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoname;
        private System.Windows.Forms.Button StartButt;
    }
}

