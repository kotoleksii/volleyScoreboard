
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetBall1st = new System.Windows.Forms.Button();
            this.btnMatchBall1st = new System.Windows.Forms.Button();
            this.btnSetBall2nd = new System.Windows.Forms.Button();
            this.btnMatchBall2nd = new System.Windows.Forms.Button();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstTeam
            // 
            this.lblFirstTeam.AutoSize = true;
            this.lblFirstTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstTeam.Location = new System.Drawing.Point(26, 69);
            this.lblFirstTeam.Name = "lblFirstTeam";
            this.lblFirstTeam.Size = new System.Drawing.Size(170, 39);
            this.lblFirstTeam.TabIndex = 0;
            this.lblFirstTeam.Text = "1st Team";
            // 
            // lblSecondTeam
            // 
            this.lblSecondTeam.AutoSize = true;
            this.lblSecondTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondTeam.Location = new System.Drawing.Point(409, 69);
            this.lblSecondTeam.Name = "lblSecondTeam";
            this.lblSecondTeam.Size = new System.Drawing.Size(180, 39);
            this.lblSecondTeam.TabIndex = 1;
            this.lblSecondTeam.Text = "2nd Team";
            // 
            // lblScore1st
            // 
            this.lblScore1st.AutoSize = true;
            this.lblScore1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore1st.Location = new System.Drawing.Point(198, 167);
            this.lblScore1st.Name = "lblScore1st";
            this.lblScore1st.Size = new System.Drawing.Size(104, 73);
            this.lblScore1st.TabIndex = 2;
            this.lblScore1st.Text = "00";
            this.lblScore1st.Leave += new System.EventHandler(this.lblScore1st_Leave);
            // 
            // lblScore2nd
            // 
            this.lblScore2nd.AutoSize = true;
            this.lblScore2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore2nd.Location = new System.Drawing.Point(295, 167);
            this.lblScore2nd.Name = "lblScore2nd";
            this.lblScore2nd.Size = new System.Drawing.Size(104, 73);
            this.lblScore2nd.TabIndex = 3;
            this.lblScore2nd.Text = "00";
            // 
            // lblSet1st
            // 
            this.lblSet1st.AutoSize = true;
            this.lblSet1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSet1st.Location = new System.Drawing.Point(231, 55);
            this.lblSet1st.Name = "lblSet1st";
            this.lblSet1st.Size = new System.Drawing.Size(68, 73);
            this.lblSet1st.TabIndex = 4;
            this.lblSet1st.Text = "0";
            this.lblSet1st.Enter += new System.EventHandler(this.lblSet1st_Enter);
            this.lblSet1st.Leave += new System.EventHandler(this.lblSet1st_Leave);
            // 
            // lblSet2nd
            // 
            this.lblSet2nd.AutoSize = true;
            this.lblSet2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSet2nd.Location = new System.Drawing.Point(305, 55);
            this.lblSet2nd.Name = "lblSet2nd";
            this.lblSet2nd.Size = new System.Drawing.Size(68, 73);
            this.lblSet2nd.TabIndex = 5;
            this.lblSet2nd.Text = "0";
            // 
            // btnPlus1st
            // 
            this.btnPlus1st.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPlus1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus1st.Location = new System.Drawing.Point(86, 182);
            this.btnPlus1st.Name = "btnPlus1st";
            this.btnPlus1st.Size = new System.Drawing.Size(47, 43);
            this.btnPlus1st.TabIndex = 6;
            this.btnPlus1st.Text = "+";
            this.btnPlus1st.UseVisualStyleBackColor = true;
            this.btnPlus1st.Click += new System.EventHandler(this.btnPlus1st_Click);
            // 
            // btnPlus2nd
            // 
            this.btnPlus2nd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPlus2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus2nd.Location = new System.Drawing.Point(407, 182);
            this.btnPlus2nd.Name = "btnPlus2nd";
            this.btnPlus2nd.Size = new System.Drawing.Size(47, 43);
            this.btnPlus2nd.TabIndex = 7;
            this.btnPlus2nd.Text = "+";
            this.btnPlus2nd.UseVisualStyleBackColor = true;
            this.btnPlus2nd.Click += new System.EventHandler(this.btnPlus2nd_Click);
            // 
            // btnNeg1st
            // 
            this.btnNeg1st.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNeg1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNeg1st.Location = new System.Drawing.Point(139, 182);
            this.btnNeg1st.Name = "btnNeg1st";
            this.btnNeg1st.Size = new System.Drawing.Size(47, 43);
            this.btnNeg1st.TabIndex = 8;
            this.btnNeg1st.Text = "-";
            this.btnNeg1st.UseVisualStyleBackColor = true;
            this.btnNeg1st.Click += new System.EventHandler(this.btnNeg1st_Click);
            // 
            // btnNeg2nd
            // 
            this.btnNeg2nd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNeg2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNeg2nd.Location = new System.Drawing.Point(460, 182);
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
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame.Location = new System.Drawing.Point(244, 12);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(110, 40);
            this.btnGame.TabIndex = 10;
            this.btnGame.Text = "Game";
            this.btnGame.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(263, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSetBall1st
            // 
            this.btnSetBall1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetBall1st.Location = new System.Drawing.Point(56, 268);
            this.btnSetBall1st.Name = "btnSetBall1st";
            this.btnSetBall1st.Size = new System.Drawing.Size(146, 34);
            this.btnSetBall1st.TabIndex = 12;
            this.btnSetBall1st.Text = "Set ball";
            this.btnSetBall1st.UseVisualStyleBackColor = true;
            // 
            // btnMatchBall1st
            // 
            this.btnMatchBall1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMatchBall1st.Location = new System.Drawing.Point(56, 315);
            this.btnMatchBall1st.Name = "btnMatchBall1st";
            this.btnMatchBall1st.Size = new System.Drawing.Size(146, 34);
            this.btnMatchBall1st.TabIndex = 13;
            this.btnMatchBall1st.Text = "Match ball";
            this.btnMatchBall1st.UseVisualStyleBackColor = true;
            // 
            // btnSetBall2nd
            // 
            this.btnSetBall2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetBall2nd.Location = new System.Drawing.Point(386, 268);
            this.btnSetBall2nd.Name = "btnSetBall2nd";
            this.btnSetBall2nd.Size = new System.Drawing.Size(146, 34);
            this.btnSetBall2nd.TabIndex = 14;
            this.btnSetBall2nd.Text = "Set ball";
            this.btnSetBall2nd.UseVisualStyleBackColor = true;
            // 
            // btnMatchBall2nd
            // 
            this.btnMatchBall2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMatchBall2nd.Location = new System.Drawing.Point(386, 315);
            this.btnMatchBall2nd.Name = "btnMatchBall2nd";
            this.btnMatchBall2nd.Size = new System.Drawing.Size(146, 34);
            this.btnMatchBall2nd.TabIndex = 15;
            this.btnMatchBall2nd.Text = "Match ball";
            this.btnMatchBall2nd.UseVisualStyleBackColor = true;
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTimeOut.Location = new System.Drawing.Point(227, 268);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(146, 34);
            this.btnTimeOut.TabIndex = 16;
            this.btnTimeOut.Text = "Time Out";
            this.btnTimeOut.UseVisualStyleBackColor = true;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.Location = new System.Drawing.Point(3, 180);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 68);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = ">";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 370);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.btnMatchBall2nd);
            this.Controls.Add(this.btnSetBall2nd);
            this.Controls.Add(this.btnMatchBall1st);
            this.Controls.Add(this.btnSetBall1st);
            this.Controls.Add(this.button1);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetBall1st;
        private System.Windows.Forms.Button btnMatchBall1st;
        private System.Windows.Forms.Button btnSetBall2nd;
        private System.Windows.Forms.Button btnMatchBall2nd;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Button btnMenu;
    }
}

