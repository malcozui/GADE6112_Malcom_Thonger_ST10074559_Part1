namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    partial class TheGameForm
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
            this.gameLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameLbl
            // 
            this.gameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gameLbl.Location = new System.Drawing.Point(265, 96);
            this.gameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameLbl.Name = "gameLbl";
            this.gameLbl.Size = new System.Drawing.Size(274, 247);
            this.gameLbl.TabIndex = 0;
            this.gameLbl.Text = "XXXXXXXXXXXXXXX \r\nX......SC.....X \r\nX......SC.....X \r\nX.............X \r\nX....SC.S" +
    "C....X \r\nX.....SCH.....X \r\nX.............X \r\nXXXXXXXXXXXXXXX \r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TheGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(789, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TheGameForm";
            this.Text = "The Game!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameLbl;
        private System.Windows.Forms.Button button1;
    }
}

