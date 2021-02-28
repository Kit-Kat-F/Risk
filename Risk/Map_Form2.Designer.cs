namespace Risk
{
    partial class Map_Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.GameState = new System.Windows.Forms.Label();
            this.PlayerTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameState
            // 
            this.GameState.AutoSize = true;
            this.GameState.Font = new System.Drawing.Font("Trajan Pro", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameState.Location = new System.Drawing.Point(12, 9);
            this.GameState.Name = "GameState";
            this.GameState.Size = new System.Drawing.Size(136, 27);
            this.GameState.TabIndex = 1;
            this.GameState.Text = "GameState";
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.AutoSize = true;
            this.PlayerTurn.Font = new System.Drawing.Font("Trajan Pro", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTurn.Location = new System.Drawing.Point(12, 45);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(157, 27);
            this.PlayerTurn.TabIndex = 2;
            this.PlayerTurn.Text = "Player Turn";
            // 
            // Map_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.GameState);
            this.Controls.Add(this.button1);
            this.Name = "Map_Form2";
            this.Text = "Map_Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GameState;
        private System.Windows.Forms.Label PlayerTurn;
    }
}