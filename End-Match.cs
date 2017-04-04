using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Scouting_App
{
    public partial class End_Match : Form
    {
        public End_Match()
        {
            InitializeComponent();
        }
        //Next button 
        private void next_Click(object sender, EventArgs e)
        {
            //writing data into app data class
            App_Data.setEndGameData(
                chassisBot,
                shootingBot,
                gearBot,
                allAroundBot,
                inputGeneralComments.Text,
                ballsFromGround,
                ballsFromHopper,
                ballsFromNotGround,
                gearFromGround,
                gearFromNotGround,
                inputRobotSpeed.Value.ToString(),
                inputDriverCapailities.Value.ToString(),
                inputBallCapacitySlider.Value.ToString()
                );

            //open next form and closes this open

            if(String.IsNullOrEmpty(inputGeneralComments.Text))
            {
                MessageBox.Show("Please Recheck Your General Comments. If Your Robot Did Nothing Fill in How it Broke.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gameSummary EndForm = new gameSummary();
                EndForm.Show();
                this.Close();
            }


            // writing to the debugger to check for data write
            System.Diagnostics.Debug.WriteLine(App_Data.GeneralComments);

            System.Diagnostics.Debug.WriteLine(App_Data.ChasisBot);
            System.Diagnostics.Debug.WriteLine(App_Data.ShootingBot);
            System.Diagnostics.Debug.WriteLine(App_Data.GearBot);
            System.Diagnostics.Debug.WriteLine(App_Data.AllAroundBot);
           
            System.Diagnostics.Debug.WriteLine(App_Data.CanCollectBallGround);
            System.Diagnostics.Debug.WriteLine(App_Data.CanCollectBallHopper);
            System.Diagnostics.Debug.WriteLine(App_Data.CanCollectGearGround);
            System.Diagnostics.Debug.WriteLine(App_Data.CanCollectGearLoadingStation);


            



         

        }
        // close button for end match

        private void flatClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // back button
        private void Back_Click(object sender, EventArgs e)
        {
            Tele_Op back = new Tele_Op();
            back.Show();
            this.Close();
        }

      


        //Robot Capabilities buttons

        String chassisBot = "0";
        String shootingBot = "0";
        String gearBot = "0";
        String allAroundBot = "0";

        private void capabilitiesToggleChassisBot_Click(object sender, EventArgs e)
        {
            if(capabilitiesToggleChassisBot.TextColor == Color.White)
            {
                capabilitiesToggleChassisBot.TextColor = Color.Black;
                chassisBot = "1";
            }
            else if(capabilitiesToggleChassisBot.TextColor == Color.Black)
            {
                capabilitiesToggleChassisBot.TextColor = Color.White;
                chassisBot = "0";
            }

        }

        private void capabilitiesToggleShootingBot_Click(object sender, EventArgs e)
        {
            if(capabilitiesToggleShootingBot.TextColor == Color.White)
            {
                capabilitiesToggleShootingBot.TextColor = Color.Black;
                shootingBot = "1";
            }
            else if(capabilitiesToggleShootingBot.TextColor == Color.Black)
            {
                capabilitiesToggleShootingBot.TextColor = Color.White;
                shootingBot = "0";
            }
        }

        private void capabilitiesToggleGearBot_Click(object sender, EventArgs e)
        {
            if(capabilitiesToggleGearBot.TextColor == Color.White)
            {
                capabilitiesToggleGearBot.TextColor = Color.Black;
                gearBot = "1";
            }
            else if(capabilitiesToggleGearBot.TextColor == Color.Black)
            {
                capabilitiesToggleGearBot.TextColor = Color.White;
                gearBot = "0";
    
            }

        }

        private void capabilitiesToggleAllAroundBot_Click(object sender, EventArgs e)
        {
            if(capabilitiesToggleAllAroundBot.TextColor == Color.White)
            {
                capabilitiesToggleAllAroundBot.TextColor = Color.Black;
                allAroundBot = "1";
            }
            else if(capabilitiesToggleAllAroundBot.TextColor == Color.Black)
            {
                capabilitiesToggleAllAroundBot.TextColor = Color.White;
                allAroundBot = "0";
            }

        }

        //Robot Collection Abilities buttons

        String ballsFromGround;
        String ballsFromNotGround;
        String ballsFromHopper;
        String gearFromGround;
        String gearFromNotGround;

        private void fuelFromGround_Click(object sender, EventArgs e)
        {
            if (fuelFromGround.TextColor == Color.White)
            {
                fuelFromGround.TextColor = Color.Black;
                ballsFromGround = "1";
            }
            else if(fuelFromGround.TextColor == Color.Black)
            {
                fuelFromGround.TextColor = Color.White;
                ballsFromGround = "0";
            }
        }

        private void inputCanCollectBallFromHopper_Click(object sender, EventArgs e)
        {
            if (inputCanCollectBallFromHopper.TextColor == Color.White)
            {
                inputCanCollectBallFromHopper.TextColor = Color.Black;
                ballsFromHopper = "1";
            }
            else if (inputCanCollectBallFromHopper.TextColor == Color.Black)
            {
                inputCanCollectBallFromHopper.TextColor = Color.White;
                ballsFromHopper = "0";
            }

        }

        private void fuelFromHP_Click(object sender, EventArgs e)
        {
            if (fuelFromHP.TextColor == Color.White)
            {
                fuelFromHP.TextColor = Color.Black;
                ballsFromNotGround = "1";
            }
            else if (fuelFromHP.TextColor == Color.Black)
            {
                fuelFromHP.TextColor = Color.White;
                ballsFromNotGround = "0";
            }


        }

        private void gearsFromGround_Click(object sender, EventArgs e)
        {
            if (gearsFromGround.TextColor == Color.White)
            {
                gearsFromGround.TextColor = Color.Black;
                ballsFromGround = "1";
            }
            else if (gearsFromGround.TextColor == Color.Black)
            {
                gearsFromGround.TextColor = Color.White;
                gearFromGround = "0";
            }

        }

        private void gearsFromHP_Click(object sender, EventArgs e)
        {
            if (gearsFromHP.TextColor == Color.White)
            {
                gearsFromHP.TextColor = Color.Black;
                gearFromNotGround = "1";

            }
            else if(gearsFromHP.TextColor == Color.Black)
            {
                gearsFromHP.TextColor = Color.White;
                gearFromNotGround = "0";
            }


        }

        //Slider bars

        private void inputDriverCapailities_Scroll(object sender)
        {
            string driverCap = Convert.ToString(inputDriverCapailities.Value);
            if (inputDriverCapailities.Value == 1)
            {
                label5.Text = driverCap + "%";
            }
            else
            {
                label5.Text = driverCap + "%";

            }
        }

        private void inputRobotSpeed_Scroll(object sender)
        {
            string robotSpeed = Convert.ToString(inputRobotSpeed.Value);
            if (inputRobotSpeed.Value == 1)
            {
                label10.Text = robotSpeed;
            }
            else
            {
                label10.Text = robotSpeed;
            }
        }

        private void inputBallCapacitySlider_Scroll(object sender)
        {
            string ballval = Convert.ToString(inputBallCapacitySlider.Value);
            if (inputBallCapacitySlider.Value == 1)
            {
                label8.Text = ballval + " Balls";
            }
            else
            {
                label8.Text = ballval + " Balls";
            }
        }


    }
}
