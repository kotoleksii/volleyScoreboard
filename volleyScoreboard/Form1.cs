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

            BackColor = lblFirstTeam.BackColor = lblSecondTeam.BackColor = Color.FromArgb(51, 153, 204);
            lblFirstTeam.ForeColor = lblSecondTeam.ForeColor = Color.White;

            lblSet1st.ForeColor = lblSet2nd.ForeColor = lblScore1st.ForeColor = lblScore2nd.ForeColor = Color.FromArgb(247, 147, 30);
            lblSet1st.BackColor = lblSet2nd.BackColor = lblScore1st.BackColor = lblScore2nd.BackColor = Color.White;

            btnGame.ForeColor = btnSet.ForeColor = btnPlus1st.ForeColor = btnNeg1st.ForeColor =
                btnPlus2nd.ForeColor = btnNeg2nd.ForeColor = btnMenu.ForeColor = Color.White;
            btnPlus1st.BackColor = btnNeg1st.BackColor = btnPlus2nd.BackColor = btnNeg2nd.BackColor =
                btnMenu.BackColor = Color.FromArgb(51, 153, 204);
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
                lblScore1st.Text = $"{(Convert.ToInt32(lblScore1st.Text) + 1).ToString()}";
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
            {
                firstTeamWinDialog();
            }
            if (secondScore - 2 == firstScore && firstScore >= 20)
            {
                secondTeamWinDialog();
            }

            if (firstScore >= 21 && secondScore < 20)
            {
                firstTeamWinDialog();
            }
            if (secondScore >= 21 && firstScore < 20)
            {
                secondTeamWinDialog();
            }
        }      

        private void firstTeamWinDialog()
        {
            MessageBox.Show($"{lblFirstTeam.Text} WIN SET!");

            lblScore1st.Text = "0";
            lblScore2nd.Text = "0";
            btnNeg1st.Enabled = false;
            btnNeg2nd.Enabled = false;
            lblSet1st.Text = (Convert.ToInt32(lblSet1st.Text) + 1).ToString();

            if (lblSet1st.Text == "2")
                MessageBox.Show($"Game Over\n{lblFirstTeam.Text} {lblSet1st.Text}:{lblSet2nd.Text} {lblSecondTeam.Text}");
        }

        private void secondTeamWinDialog()
        {
            MessageBox.Show($"{lblSecondTeam.Text} WIN SET!");

            lblScore2nd.Text = "0";
            lblScore1st.Text = "0";
            btnNeg1st.Enabled = false;
            btnNeg2nd.Enabled = false;
            lblSet2nd.Text = (Convert.ToInt32(lblSet2nd.Text) + 1).ToString();

            if (lblSet2nd.Text == "2")
                MessageBox.Show($"Game Over\n{lblFirstTeam.Text} {lblSet1st.Text}:{lblSet2nd.Text} {lblSecondTeam.Text}");
        }

        private void btnNeg1st_Click(object sender, EventArgs e)
        {                     
            if ((Convert.ToInt32(lblScore1st.Text) - 1) < 10)
            {
                lblScore1st.Text = $"{(Convert.ToInt32(lblScore1st.Text) - 1).ToString()}";             
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
                lblScore2nd.Text = $"{(Convert.ToInt32(lblScore2nd.Text) + 1).ToString()}";
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
                lblScore2nd.Text = $"{(Convert.ToInt32(lblScore2nd.Text) - 1).ToString()}";
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

            lblColor1st.BackColor = modal.btnColorFirst.BackColor;
            lblColor2nd.BackColor = modal.btnColorSecond.BackColor;
        }

        private void lblScore1st_Click(object sender, EventArgs e)
        {

        }
    }
}
