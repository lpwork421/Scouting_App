using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scouting_App
{
    public partial class gameSummary : Form
    {
        public gameSummary()
        {
            InitializeComponent();
        }
        //finish button and taking back to prematch
        private void finish_Click(object sender, EventArgs e)
        {
            //wrtiing to static class
            App_Data.setMatchSummaryData(

            inputBoilerPoints.Text,
            inputGearPoints.Text,
            inputClimbingPoints.Text,
            inputPenaltyPoints.Text,
            inputRankingPoints.Text
            


           );
            App_Data.writeToCsv();

            App_Data.clear();

            //closes and opens prematch
            if(String.IsNullOrEmpty(inputBoilerPoints.Text) && String.IsNullOrEmpty(inputGearPoints.Text) &&
                String.IsNullOrEmpty(inputClimbingPoints.Text) && String.IsNullOrEmpty(inputPenaltyPoints.Text) &&
                String.IsNullOrEmpty(inputRankingPoints.Text))
            {
                MessageBox.Show("Please Recheck What You Input", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
                PreMatch restart = new PreMatch();
                restart.Show();
                restart.clearStartingPosToggle();

            }

        }
        // Close button for game Summary
        private void flatClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //back button to go back to end match form
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            End_Match back = new End_Match();
            back.Show();

        }
        
        private void gameSummary_Load(object sender, EventArgs e)
        {
            boilerLbl.Text = "How many boiler points did " + App_Data.Alliancecolor + " alliance make?";
            gearLbl.Text = "How many gear points did " + App_Data.Alliancecolor + " alliance make?";
            climbingLbl.Text = "How many climbing points did " + App_Data.Alliancecolor + " alliance make?";
            penaltyLbl.Text = "How many penalty points did " + App_Data.Alliancecolor + " alliance make?";
            rankingLbl.Text = "How many ranking points did " + App_Data.Alliancecolor + " alliance make?";
        }

    }
}
