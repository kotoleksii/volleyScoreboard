using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace volleyScoreboard
{
    public partial class frmMain : Form
    {
        frmOptions modal = new frmOptions();
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnNeg1st.Enabled = false;
            btnNeg2nd.Enabled = false;

            
        }

        private void btnPlus1st_Click(object sender, EventArgs e)
        {


            if ((Convert.ToInt32(lblScore1st.Text) + 1) < 10)
            {
                lblScore1st.Text = $"0{(Convert.ToInt32(lblScore1st.Text) + 1).ToString()}";
                btnNeg1st.Enabled = true;
            }
            else
                lblScore1st.Text = (Convert.ToInt32(lblScore1st.Text) + 1).ToString();

            teamWinDialog();

            writeJSON();
        }     

        private void teamWinDialog()
        {
            int firstScore = (Convert.ToInt32(lblScore1st.Text));
            int secondScore = (Convert.ToInt32(lblScore2nd.Text));

            if (firstScore == 20 && secondScore == 20)
            {
                MessageBox.Show($"Граємо далі, коли одна з команд не набере +2");
            }
            if (firstScore - 2 == secondScore && secondScore >= 20)
                MessageBox.Show($"{lblFirstTeam.Text} WIN!");
            if (secondScore - 2 == firstScore && firstScore >= 20)
                MessageBox.Show($"{lblSecondTeam.Text} WIN!");



            //else
            //{
            //    if ((Convert.ToInt32(lblScore1st.Text) >= 21))
            //    {
            //        MessageBox.Show($"{lblFirstTeam.Text} WIN!");

            //        lblScore1st.Text = "00";
            //        lblScore2nd.Text = "00";
            //        btnNeg1st.Enabled = false;
            //        btnNeg2nd.Enabled = false;
            //        lblSet1st.Text = (Convert.ToInt32(lblSet1st.Text) + 1).ToString();

            //        if (lblSet1st.Text == "2")
            //            MessageBox.Show($"Game Over\n{lblFirstTeam.Text} {lblSet1st.Text}:{lblSet2nd.Text} {lblSecondTeam.Text}");
            //    }
            //    else if ((Convert.ToInt32(lblScore2nd.Text) >= 21))
            //    {
            //        MessageBox.Show($"{lblSecondTeam.Text} WIN!");

            //        lblScore2nd.Text = "00";
            //        lblScore1st.Text = "00";
            //        btnNeg1st.Enabled = false;
            //        btnNeg2nd.Enabled = false;
            //        lblSet2nd.Text = (Convert.ToInt32(lblSet2nd.Text) + 1).ToString();

            //        if (lblSet2nd.Text == "2")
            //            MessageBox.Show($"Game Over\n{lblFirstTeam.Text} {lblSet1st.Text}:{lblSet2nd.Text} {lblSecondTeam.Text}");
            //    }
            //}

        }

        private void btnNeg1st_Click(object sender, EventArgs e)
        {                     
            if ((Convert.ToInt32(lblScore1st.Text) - 1) < 10)
            {
                lblScore1st.Text = $"0{(Convert.ToInt32(lblScore1st.Text) - 1).ToString()}";             
            }
            else
                lblScore1st.Text = (Convert.ToInt32(lblScore1st.Text) - 1).ToString();

            if ((Convert.ToInt32(lblScore1st.Text)) <= 0)
                btnNeg1st.Enabled = false;

            writeJSON();
        }        

        private void btnPlus2nd_Click(object sender, EventArgs e)
        {           

            if ((Convert.ToInt32(lblScore2nd.Text) + 1) < 10)
            {
                lblScore2nd.Text = $"0{(Convert.ToInt32(lblScore2nd.Text) + 1).ToString()}";
                btnNeg2nd.Enabled = true;
            }
            else
                lblScore2nd.Text = (Convert.ToInt32(lblScore2nd.Text) + 1).ToString();

            teamWinDialog();

            writeJSON();
        }

        private void btnNeg2nd_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(lblScore2nd.Text) - 1) < 10)
            {
                lblScore2nd.Text = $"0{(Convert.ToInt32(lblScore2nd.Text) - 1).ToString()}";
            }
            else
                lblScore2nd.Text = (Convert.ToInt32(lblScore2nd.Text) - 1).ToString();

            if ((Convert.ToInt32(lblScore2nd.Text)) <= 0)
                btnNeg2nd.Enabled = false;

            writeJSON();
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timeout!");          
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            
        }

        private async void writeJSON()
        {
            try
            {
                using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
                {
                    Team team1 = new Team(modal.txtTeamFirstOpt.Text, lblScore1st.Text, lblSet1st.Text);
                    Team team2 = new Team(modal.txtTeamSecondOpt.Text, lblScore2nd.Text, lblSet2nd.Text);
                    Team[] teams = new Team[] { team1, team2 };

                    await JsonSerializer.SerializeAsync<Team[]>(fs, teams);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Повільніше, ковбою...");
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            modal.Location = new Point(Location.X + btnMenu.Width, btnMenu.Location.Y + btnMenu.Height + 20);

            if (modal.ShowDialog() == DialogResult.Cancel)
                return;

            string a = modal.txtTeamFirstOpt.Text.Replace("/", "\n");
            string b = modal.txtTeamSecondOpt.Text.Replace("/", "\n");


            lblFirstTeam.Text = a;
            lblSecondTeam.Text = b;

            lblFirstTeam.BackColor = modal.btnColorFirst.BackColor;
            lblSecondTeam.BackColor = modal.btnColorSecond.BackColor;
        }
    }
}
