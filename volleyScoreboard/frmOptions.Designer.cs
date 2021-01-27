
namespace volleyScoreboard
{
    partial class frmOptions
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
            this.txtTeamFirstOpt = new System.Windows.Forms.TextBox();
            this.txtTeamSecondOpt = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.clrDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColorFirst = new System.Windows.Forms.Button();
            this.btnColorSecond = new System.Windows.Forms.Button();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTeamFirstOpt
            // 
            this.txtTeamFirstOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTeamFirstOpt.Location = new System.Drawing.Point(33, 29);
            this.txtTeamFirstOpt.MaxLength = 20;
            this.txtTeamFirstOpt.Name = "txtTeamFirstOpt";
            this.txtTeamFirstOpt.Size = new System.Drawing.Size(333, 40);
            this.txtTeamFirstOpt.TabIndex = 0;
            // 
            // txtTeamSecondOpt
            // 
            this.txtTeamSecondOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTeamSecondOpt.Location = new System.Drawing.Point(33, 102);
            this.txtTeamSecondOpt.MaxLength = 20;
            this.txtTeamSecondOpt.Name = "txtTeamSecondOpt";
            this.txtTeamSecondOpt.Size = new System.Drawing.Size(333, 40);
            this.txtTeamSecondOpt.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(114, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 34);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Confirm";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(216, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnColorFirst
            // 
            this.btnColorFirst.Location = new System.Drawing.Point(392, 30);
            this.btnColorFirst.Name = "btnColorFirst";
            this.btnColorFirst.Size = new System.Drawing.Size(55, 39);
            this.btnColorFirst.TabIndex = 4;
            this.btnColorFirst.UseVisualStyleBackColor = true;
            this.btnColorFirst.Click += new System.EventHandler(this.btnColorFirst_Click);
            // 
            // btnColorSecond
            // 
            this.btnColorSecond.Location = new System.Drawing.Point(392, 103);
            this.btnColorSecond.Name = "btnColorSecond";
            this.btnColorSecond.Size = new System.Drawing.Size(55, 39);
            this.btnColorSecond.TabIndex = 5;
            this.btnColorSecond.UseVisualStyleBackColor = true;
            this.btnColorSecond.Click += new System.EventHandler(this.btnColorSecond_Click);
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeam1.Location = new System.Drawing.Point(30, 8);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(64, 18);
            this.lblTeam1.TabIndex = 6;
            this.lblTeam1.Text = "Team 1";
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeam2.Location = new System.Drawing.Point(30, 81);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(64, 18);
            this.lblTeam2.TabIndex = 7;
            this.lblTeam2.Text = "Team 2";
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor1.Location = new System.Drawing.Point(389, 8);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(64, 18);
            this.lblColor1.TabIndex = 8;
            this.lblColor1.Text = "Color 1";
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor2.Location = new System.Drawing.Point(389, 81);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(64, 18);
            this.lblColor2.TabIndex = 9;
            this.lblColor2.Text = "Color 2";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 206);
            this.Controls.Add(this.lblColor2);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.btnColorSecond);
            this.Controls.Add(this.btnColorFirst);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTeamSecondOpt);
            this.Controls.Add(this.txtTeamFirstOpt);
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox txtTeamFirstOpt;
        protected internal System.Windows.Forms.TextBox txtTeamSecondOpt;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColorDialog clrDialog1;
        protected internal System.Windows.Forms.Button btnColorFirst;
        protected internal System.Windows.Forms.Button btnColorSecond;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.Label lblColor2;
    }
}