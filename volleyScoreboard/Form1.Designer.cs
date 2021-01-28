
namespace volleyScoreboard
{
    partial class frmMain
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
            this.lblFirstTeam = new System.Windows.Forms.Label();
            this.lblSecondTeam = new System.Windows.Forms.Label();
            this.lblScore1st = new System.Windows.Forms.Label();
            this.lblScore2nd = new System.Windows.Forms.Label();
            this.lblSet1st = new System.Windows.Forms.Label();
            this.lblSet2nd = new System.Windows.Forms.Label();
            this.btnPlus1st = new System.Windows.Forms.Button();
            this.btnPlus2nd = new System.Windows.Forms.Button();
            this.btnNeg1st = new System.Windows.Forms.Button();
            this.btnNeg2nd = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSetBall1st = new System.Windows.Forms.Button();
            this.btnMatchBall1st = new System.Windows.Forms.Button();
            this.btnSetBall2nd = new System.Windows.Forms.Button();
            this.btnMatchBall2nd = new System.Windows.Forms.Button();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblColor1st = new System.Windows.Forms.Label();
            this.lblColor2nd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstTeam
            // 
            this.lblFirstTeam.Font = new System.Drawing.Font("Galiver Sans Obliques", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstTeam.Location = new System.Drawing.Point(42, 56);
            this.lblFirstTeam.Name = "lblFirstTeam";
            this.lblFirstTeam.Size = new System.Drawing.Size(180, 85);
            this.lblFirstTeam.TabIndex = 0;
            this.lblFirstTeam.Text = "1st Team";
            // 
            // lblSecondTeam
            // 
            this.lblSecondTeam.Font = new System.Drawing.Font("Galiver Sans Obliques", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondTeam.Location = new System.Drawing.Point(450, 56);
            this.lblSecondTeam.Name = "lblSecondTeam";
            this.lblSecondTeam.Size = new System.Drawing.Size(180, 85);
            this.lblSecondTeam.TabIndex = 1;
            this.lblSecondTeam.Text = "2nd Team";
            // 
            // lblScore1st
            // 
            this.lblScore1st.Font = new System.Drawing.Font("Galiver Sans Obliques", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore1st.Location = new System.Drawing.Point(211, 180);
            this.lblScore1st.Name = "lblScore1st";
            this.lblScore1st.Size = new System.Drawing.Size(120, 94);
            this.lblScore1st.TabIndex = 2;
            this.lblScore1st.Text = "0";
            this.lblScore1st.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore1st.Click += new System.EventHandler(this.lblScore1st_Click);
            // 
            // lblScore2nd
            // 
            this.lblScore2nd.Font = new System.Drawing.Font("Galiver Sans Obliques", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore2nd.Location = new System.Drawing.Point(340, 180);
            this.lblScore2nd.Name = "lblScore2nd";
            this.lblScore2nd.Size = new System.Drawing.Size(120, 94);
            this.lblScore2nd.TabIndex = 3;
            this.lblScore2nd.Text = "0";
            this.lblScore2nd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet1st
            // 
            this.lblSet1st.Font = new System.Drawing.Font("Galiver Sans Obliques", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSet1st.Location = new System.Drawing.Point(246, 47);
            this.lblSet1st.Name = "lblSet1st";
            this.lblSet1st.Size = new System.Drawing.Size(85, 94);
            this.lblSet1st.TabIndex = 4;
            this.lblSet1st.Text = "0";
            this.lblSet1st.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSet2nd
            // 
            this.lblSet2nd.Font = new System.Drawing.Font("Galiver Sans Obliques", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSet2nd.Location = new System.Drawing.Point(340, 47);
            this.lblSet2nd.Name = "lblSet2nd";
            this.lblSet2nd.Size = new System.Drawing.Size(85, 94);
            this.lblSet2nd.TabIndex = 5;
            this.lblSet2nd.Text = "0";
            this.lblSet2nd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlus1st
            // 
            this.btnPlus1st.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlus1st.FlatAppearance.BorderSize = 0;
            this.btnPlus1st.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus1st.Font = new System.Drawing.Font("Galiver Sans Obliques", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus1st.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPlus1st.Location = new System.Drawing.Point(90, 209);
            this.btnPlus1st.Name = "btnPlus1st";
            this.btnPlus1st.Size = new System.Drawing.Size(47, 43);
            this.btnPlus1st.TabIndex = 6;
            this.btnPlus1st.Text = "+";
            this.btnPlus1st.UseVisualStyleBackColor = false;
            this.btnPlus1st.Click += new System.EventHandler(this.btnPlus1st_Click);
            // 
            // btnPlus2nd
            // 
            this.btnPlus2nd.FlatAppearance.BorderSize = 0;
            this.btnPlus2nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus2nd.Font = new System.Drawing.Font("Galiver Sans Obliques", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus2nd.Location = new System.Drawing.Point(480, 208);
            this.btnPlus2nd.Name = "btnPlus2nd";
            this.btnPlus2nd.Size = new System.Drawing.Size(47, 43);
            this.btnPlus2nd.TabIndex = 7;
            this.btnPlus2nd.Text = "+";
            this.btnPlus2nd.UseVisualStyleBackColor = true;
            this.btnPlus2nd.Click += new System.EventHandler(this.btnPlus2nd_Click);
            // 
            // btnNeg1st
            // 
            this.btnNeg1st.FlatAppearance.BorderSize = 0;
            this.btnNeg1st.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeg1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNeg1st.Location = new System.Drawing.Point(143, 209);
            this.btnNeg1st.Name = "btnNeg1st";
            this.btnNeg1st.Size = new System.Drawing.Size(47, 43);
            this.btnNeg1st.TabIndex = 8;
            this.btnNeg1st.Text = "-";
            this.btnNeg1st.UseVisualStyleBackColor = true;
            this.btnNeg1st.Click += new System.EventHandler(this.btnNeg1st_Click);
            // 
            // btnNeg2nd
            // 
            this.btnNeg2nd.FlatAppearance.BorderSize = 0;
            this.btnNeg2nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeg2nd.Font = new System.Drawing.Font("Galiver Sans Obliques", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNeg2nd.Location = new System.Drawing.Point(533, 208);
            this.btnNeg2nd.Name = "btnNeg2nd";
            this.btnNeg2nd.Size = new System.Drawing.Size(47, 43);
            this.btnNeg2nd.TabIndex = 9;
            this.btnNeg2nd.Text = "-";
            this.btnNeg2nd.UseVisualStyleBackColor = true;
            this.btnNeg2nd.Click += new System.EventHandler(this.btnNeg2nd_Click);
            // 
            // btnGame
            // 
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Font = new System.Drawing.Font("Galiver Sans Obliques", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame.Location = new System.Drawing.Point(283, 4);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(110, 40);
            this.btnGame.TabIndex = 10;
            this.btnGame.Text = "Game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnSet
            // 
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Galiver Sans Obliques", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSet.Location = new System.Drawing.Point(308, 144);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(65, 33);
            this.btnSet.TabIndex = 11;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnSetBall1st
            // 
            this.btnSetBall1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetBall1st.Location = new System.Drawing.Point(76, 294);
            this.btnSetBall1st.Name = "btnSetBall1st";
            this.btnSetBall1st.Size = new System.Drawing.Size(146, 34);
            this.btnSetBall1st.TabIndex = 12;
            this.btnSetBall1st.Text = "Set ball";
            this.btnSetBall1st.UseVisualStyleBackColor = true;
            // 
            // btnMatchBall1st
            // 
            this.btnMatchBall1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMatchBall1st.Location = new System.Drawing.Point(76, 341);
            this.btnMatchBall1st.Name = "btnMatchBall1st";
            this.btnMatchBall1st.Size = new System.Drawing.Size(146, 34);
            this.btnMatchBall1st.TabIndex = 13;
            this.btnMatchBall1st.Text = "Match ball";
            this.btnMatchBall1st.UseVisualStyleBackColor = true;
            // 
            // btnSetBall2nd
            // 
            this.btnSetBall2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetBall2nd.Location = new System.Drawing.Point(406, 294);
            this.btnSetBall2nd.Name = "btnSetBall2nd";
            this.btnSetBall2nd.Size = new System.Drawing.Size(146, 34);
            this.btnSetBall2nd.TabIndex = 14;
            this.btnSetBall2nd.Text = "Set ball";
            this.btnSetBall2nd.UseVisualStyleBackColor = true;
            // 
            // btnMatchBall2nd
            // 
            this.btnMatchBall2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMatchBall2nd.Location = new System.Drawing.Point(406, 341);
            this.btnMatchBall2nd.Name = "btnMatchBall2nd";
            this.btnMatchBall2nd.Size = new System.Drawing.Size(146, 34);
            this.btnMatchBall2nd.TabIndex = 15;
            this.btnMatchBall2nd.Text = "Match ball";
            this.btnMatchBall2nd.UseVisualStyleBackColor = true;
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTimeOut.Location = new System.Drawing.Point(247, 294);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(146, 34);
            this.btnTimeOut.TabIndex = 16;
            this.btnTimeOut.Text = "Time Out";
            this.btnTimeOut.UseVisualStyleBackColor = true;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Galiver Sans Obliques", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.Location = new System.Drawing.Point(3, 180);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 68);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = ">";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblColor1st
            // 
            this.lblColor1st.Location = new System.Drawing.Point(12, 56);
            this.lblColor1st.Name = "lblColor1st";
            this.lblColor1st.Size = new System.Drawing.Size(23, 85);
            this.lblColor1st.TabIndex = 18;
            // 
            // lblColor2nd
            // 
            this.lblColor2nd.Location = new System.Drawing.Point(636, 56);
            this.lblColor2nd.Name = "lblColor2nd";
            this.lblColor2nd.Size = new System.Drawing.Size(23, 85);
            this.lblColor2nd.TabIndex = 19;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 411);
            this.Controls.Add(this.lblColor2nd);
            this.Controls.Add(this.lblColor1st);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.btnMatchBall2nd);
            this.Controls.Add(this.btnSetBall2nd);
            this.Controls.Add(this.btnMatchBall1st);
            this.Controls.Add(this.btnSetBall1st);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnNeg2nd);
            this.Controls.Add(this.btnNeg1st);
            this.Controls.Add(this.btnPlus2nd);
            this.Controls.Add(this.btnPlus1st);
            this.Controls.Add(this.lblSet2nd);
            this.Controls.Add(this.lblSet1st);
            this.Controls.Add(this.lblScore2nd);
            this.Controls.Add(this.lblScore1st);
            this.Controls.Add(this.lblSecondTeam);
            this.Controls.Add(this.lblFirstTeam);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VolleyScore";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstTeam;
        private System.Windows.Forms.Label lblSecondTeam;
        private System.Windows.Forms.Label lblScore1st;
        private System.Windows.Forms.Label lblScore2nd;
        private System.Windows.Forms.Label lblSet1st;
        private System.Windows.Forms.Label lblSet2nd;
        private System.Windows.Forms.Button btnPlus1st;
        private System.Windows.Forms.Button btnPlus2nd;
        private System.Windows.Forms.Button btnNeg1st;
        private System.Windows.Forms.Button btnNeg2nd;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSetBall1st;
        private System.Windows.Forms.Button btnMatchBall1st;
        private System.Windows.Forms.Button btnSetBall2nd;
        private System.Windows.Forms.Button btnMatchBall2nd;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblColor1st;
        private System.Windows.Forms.Label lblColor2nd;
    }
}