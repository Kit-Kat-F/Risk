namespace Risk
{
    partial class Map_Form
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GameSTate = new System.Windows.Forms.Label();
            this.PlayerTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(312, 74);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(27, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 14);
            this.button1.TabIndex = 1;
            this.button1.Text = "^";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 13);
            this.button2.TabIndex = 2;
            this.button2.Text = "V";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GameSTate
            // 
            this.GameSTate.AutoSize = true;
            this.GameSTate.Location = new System.Drawing.Point(12, 428);
            this.GameSTate.Name = "GameSTate";
            this.GameSTate.Size = new System.Drawing.Size(0, 13);
            this.GameSTate.TabIndex = 3;
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.AutoSize = true;
            this.PlayerTurn.Location = new System.Drawing.Point(6, 415);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(0, 13);
            this.PlayerTurn.TabIndex = 4;
            // 
            // Map_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.GameSTate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Map_Form";
            this.Text = "Map_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Map_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label GameSTate;
        private System.Windows.Forms.Label PlayerTurn;
    }
}