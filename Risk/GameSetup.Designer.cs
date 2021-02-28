namespace Risk
{
    partial class GameSetup
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
            this.PlayerCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerCount
            // 
            this.PlayerCount.FormattingEnabled = true;
            this.PlayerCount.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.PlayerCount.Location = new System.Drawing.Point(15, 25);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(157, 21);
            this.PlayerCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many players";
            // 
            // Start_but
            // 
            this.Start_but.Location = new System.Drawing.Point(55, 52);
            this.Start_but.Name = "Start_but";
            this.Start_but.Size = new System.Drawing.Size(75, 23);
            this.Start_but.TabIndex = 2;
            this.Start_but.Text = "Start Game";
            this.Start_but.UseVisualStyleBackColor = true;
            this.Start_but.Click += new System.EventHandler(this.Start_but_Click);
            // 
            // GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 81);
            this.Controls.Add(this.Start_but);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameSetup";
            this.Text = "GameSetup";
            this.Load += new System.EventHandler(this.GameSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PlayerCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_but;
    }
}