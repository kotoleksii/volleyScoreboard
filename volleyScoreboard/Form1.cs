using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace volleyScoreboard
{
    [Serializable]
    public class Team
    {
        public string Name { get; set; }
        public string Score { get; set; }
        public string Set { get; set; }

        public Team()
        { }

        public Team(string name, string score, string set)
        {
            Name = name;
            Score = score;
            Set = set;
        }
    }

        public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();           
        }

        private async void frmMain_Load(object sender, EventArgs e)
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

            if ((Convert.ToInt32(lblScore1st.Text) >= 21))
            {
                MessageBox.Show($"{lblFirstTeam.Text} WIN!");
                lblScore1st.Text = "00";
                btnNeg1st.Enabled = false;
                lblSet1st.Text = (Convert.ToInt32(lblSet1st.Text) + 1).ToString();

                if (lblSet1st.Text == "2")
                    MessageBox.Show($"Game Over\n{lblFirstTeam.Text} {lblSet1st.Text}:{lblSet2nd.Text} {lblSecondTeam.Text}");

               
            }
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
        }        

        private void lblScore1st_Leave(object sender, EventArgs e)
        {
            
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

            if ((Convert.ToInt32(lblScore2nd.Text) >= 21))
            {
                MessageBox.Show($"{lblSecondTeam.Text} WIN!");

                lblScore2nd.Text = "00";
                btnNeg2nd.Enabled = false;
                lblSet2nd.Text = (Convert.ToInt32(lblSet2nd.Text) + 1).ToString();

                if (lblSet2nd.Text == "2")
                    MessageBox.Show($"Game Over\n{lblFirstTeam.Text} {lblSet1st.Text}:{lblSet2nd.Text} {lblSecondTeam.Text}");
            }
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
        }

        private void lblSet1st_Leave(object sender, EventArgs e)
        {
            
        }

        private void lblSet1st_Enter(object sender, EventArgs e)
        {
            
        }

        private async void btnTimeOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timeout!");

            //Team team1 = new Team(lblFirstTeam.Text, lblScore1st.Text, lblSet1st.Text);
            //Team team2 = new Team(lblSecondTeam.Text, lblScore2nd.Text, lblSet2nd.Text);
            //Team[] teams = new Team[] { team1, team2 };


            //XmlSerializer formatter = new XmlSerializer(typeof(Team[]));

            //using (FileStream fs = new FileStream("teams.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, teams);
            //}

            using (FileStream fs = new FileStream("user.json", FileMode.Append))
            {
                Team team1 = new Team(lblFirstTeam.Text, lblScore1st.Text, lblSet1st.Text);
                Team team2 = new Team(lblSecondTeam.Text, lblScore2nd.Text, lblSet2nd.Text);
                Team[] teams = new Team[] { team1, team2 };

                await System.Text.Json.JsonSerializer.SerializeAsync<Team[]>(fs, teams);
            }
        }
    }
}
