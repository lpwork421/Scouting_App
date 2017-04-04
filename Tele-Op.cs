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
    public partial class Tele_Op : Form
    {

        public Tele_Op()
        {
            InitializeComponent();
        }

        private void Tele_Op_Load(object sender, EventArgs e)
        {
            gearCounterText.Text = App_Data.GearsCollected;

            totalGearAtmCount.Text = teleTotalGearCount;

            gearMissCounterText.Text = teleMissGearCount;

            breakDownCounter.Text = App_Data.BreakDown;

            if(App_Data.ClimbCheck == "1")
            {
                inputClimbSuccess.Checked = true;
            }
            if(App_Data.ClimbCheck == "0")
            {
                inputClimbFailed.Checked = true;
            }
            inputHHitCount.Text = App_Data.TeleHighHit;

            inputHMissCount.Text = App_Data.TeleHighMiss;

            inputLHitCount.Text = App_Data.TeleLowHit;

            inputLMissCount.Text = App_Data.TeleLowMiss;

        }
        public string teleTotalGearCount;
        public string teleMissGearCount;

        private void next_Click(object sender, EventArgs e)
        {
            teleTotalGearCount = totalGearAtmCount.Text;
            teleMissGearCount = gearMissCounterText.Text;

            App_Data.setTeleOpData(
                 gearCounterText.Text,
                 breakDownCounter.Text,
                 climbRadio(),
                 inputHHitCount.Text,
                 inputHMissCount.Text,
                 inputLHitCount.Text,
                 inputLMissCount.Text
                 );

            System.Diagnostics.Debug.WriteLine(App_Data.GearsCollected);
            System.Diagnostics.Debug.WriteLine(App_Data.BreakDown);
            System.Diagnostics.Debug.WriteLine(App_Data.ClimbCheck);
            System.Diagnostics.Debug.WriteLine("Tele-Op High Hit Count " + App_Data.TeleHighHit);
            System.Diagnostics.Debug.WriteLine("Tele-Op High Miss Count " + App_Data.TeleHighMiss);
            System.Diagnostics.Debug.WriteLine("Tele-Op Low Hit Count " + App_Data.TeleLowHit);
            System.Diagnostics.Debug.WriteLine("Tele-Op Low Miss Count " + App_Data.TeleLowMiss);
           
            if(!inputClimbSuccess.Checked && !inputClimbFailed.Checked)
            {
                MessageBox.Show("Please Recheck What You Input", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                End_Match end = new End_Match();
                end.Show();
                this.Close();
            }
            


        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Auton back = new Auton();
            back.Show();
            this.Close();

        }

        private string climbRadio()
        {
            string checkedRadio;
            if (inputClimbSuccess.Checked)
            {
                checkedRadio = "1";
            }
            else
            {
                checkedRadio = "0";
            }
            return checkedRadio;
        }



        
        int gearCounterInt;
        int gearMissCounterInt;
        int totalGearAtmCountInt;

        private void inputGearToAirship_Click(object sender, EventArgs e)
        {
            //when the button is pressed add counter
            areYouSure.Visible = true;

            if (inputGearToAirship.Text == "Robot Places Gear On Airship")
            {
                inputGearToAirship.Text = "Undo";
            }
            else if(inputGearToAirship.Text == "Undo")
            {
                areYouSure.Visible = false;
                inputGearToAirship.Text = "Robot Places Gear On Airship";
            }

        }

        private void areYouSure_Click(object sender, EventArgs e)
        {
            if(inputGearToAirship.Text == "Undo")
            {

                inputGearToAirship.Text = "Robot Places Gear On Airship";
                areYouSure.Visible = false;

                gearCounterInt++;
                gearCounterText.Text = gearCounterInt.ToString();

                totalGearAtmCountInt++;
                totalGearAtmCount.Text = totalGearAtmCountInt.ToString();
            }


        }



        private void inputMissedGear_Click(object sender, EventArgs e)
        {
            missGearCheck.Visible = true;

            if (inputMissedGear.Text == "Gear Not Recived By Human Player")
            {
                inputMissedGear.Text = "Undo";
            }
            else if (inputMissedGear.Text == "Undo")
            {
                missGearCheck.Visible = false;
                inputMissedGear.Text = "Gear Not Recived By Human Player";
            }
        }

        private void missGearCheck_Click(object sender, EventArgs e)
        {
            if(inputMissedGear.Text == "Undo")
            {
                inputMissedGear.Text = "Gear Not Recived By Human Player";
                missGearCheck.Visible = false;

                gearMissCounterInt++;
                gearMissCounterText.Text = gearMissCounterInt.ToString();

                totalGearAtmCountInt++;
                totalGearAtmCount.Text = totalGearAtmCountInt.ToString();
            }

        }



        int breakDownInt;
        private void inputBrokeDown_Click(object sender, EventArgs e)
        {
            //change text to undo and adds one to breakDownInt for counter
            if (inputBrokeDown.Text == "Broken Down")
            {
                inputBrokeDown.Text = "Undo";
                breakDownInt++;
                inputFixed.Visible = true;
            }
             
            else if (inputBrokeDown.Text == "Undo")
            {
                inputFixed.Visible = false;
                inputBrokeDown.Text = "Broken Down";
                breakDownInt--;
                

            }
            
            breakDownCounter.Text = breakDownInt.ToString();
            
         }

        private void inputFixed_Click(object sender, EventArgs e)
        {
            inputBrokeDown.Text = "Broken Down";
            inputFixed.Visible = false;
        }


        //Counter for balls in high and low input text box

        //Variable for high hit input counter
        int highHitCounter = 0;
        //Variable for high miss input counter
        int highMissCounter = 0;
        //Varriable for low hit input counter
        int lowHitCounter = 0;
        //Varriable for low miss input counter
        int lowMissCounter = 0;


        //Plus button methods for high hit text box
        private void inputHPlusHit1_Click(object sender, EventArgs e)
        {
            highHitCounter++;
            inputHHitCount.Text = highHitCounter.ToString();
        }
        private void inputHPlusHit5_Click(object sender, EventArgs e)
        {
            highHitCounter = highHitCounter + 5;
            inputHHitCount.Text = highHitCounter.ToString();
        }

        private void inputHPlusHit10_Click(object sender, EventArgs e)
        {
            highHitCounter = highHitCounter + 10;
            inputHHitCount.Text = highHitCounter.ToString();
        }
        private void inputHPlusHit20_Click(object sender, EventArgs e)
        {
            highHitCounter = highHitCounter + 20;
            inputHHitCount.Text = highHitCounter.ToString();
        }

        //Minus buttons for auton
        private void inputHSubtractHit_Click1(object sender, EventArgs e)
        {
            highHitCounter--;
            inputHHitCount.Text = highHitCounter.ToString();
        }
        private void inputHSubtractHit5_Click(object sender, EventArgs e)
        {
            highHitCounter = highHitCounter - 5;
            inputHHitCount.Text = highHitCounter.ToString();
        }
        private void inputHSubtractHit10_Click(object sender, EventArgs e)
        {
            highHitCounter = highHitCounter - 10;
            inputHHitCount.Text = highHitCounter.ToString();
        }
        private void inputHSubtractHit20_Click(object sender, EventArgs e)
        {
            highHitCounter = highHitCounter - 20;
            inputHHitCount.Text = highHitCounter.ToString();
        }

        //Plus and minus button methods for high miss text box


        private void inputHSubtraceMiss1_Click(object sender, EventArgs e)
        {
            highMissCounter--;
            inputHMissCount.Text = highMissCounter.ToString();
        }
        private void inputHSubtraceMiss5_Click(object sender, EventArgs e)
        {
            highMissCounter = highMissCounter - 5;
            inputHMissCount.Text = highMissCounter.ToString();
        }
        private void inputHSubtraceMiss10_Click(object sender, EventArgs e)
        {
            highMissCounter = highMissCounter - 10;
            inputHMissCount.Text = highMissCounter.ToString();
        }
        private void inputHSubtraceMiss20_Click(object sender, EventArgs e)
        {
            highMissCounter = highMissCounter - 20;
            inputHMissCount.Text = highMissCounter.ToString();
        }



        private void inputHPlusMiss1_Click(object sender, EventArgs e)
        {
            highMissCounter++;
            inputHMissCount.Text = highMissCounter.ToString();
        }
        private void inputHPlusMiss5_Click(object sender, EventArgs e)
        {
            highMissCounter = highMissCounter + 5;
            inputHMissCount.Text = highMissCounter.ToString();
        }
        private void inputHPlusMiss10_Click(object sender, EventArgs e)
        {
            highMissCounter = highMissCounter + 10;
            inputHMissCount.Text = highMissCounter.ToString();
        }
        private void inputHPlusMiss20_Click(object sender, EventArgs e)
        {
            highMissCounter = highMissCounter + 20;
            inputHMissCount.Text = highMissCounter.ToString();
        }


        //Plus and minus button methods for low hit text box
        private void inputLPlusHit_Click_1(object sender, EventArgs e)
        {
            lowHitCounter++;
            inputLHitCount.Text = lowHitCounter.ToString();
        }

        private void inputLPlusHit5_Click(object sender, EventArgs e)
        {
            lowHitCounter = lowHitCounter + 5;
            inputLHitCount.Text = lowHitCounter.ToString();
        }

        private void inputLPlusHit10_Click(object sender, EventArgs e)
        {
            lowHitCounter = lowHitCounter + 10;
            inputLHitCount.Text = lowHitCounter.ToString();
        }

        private void inputLPlusHit20_Click(object sender, EventArgs e)
        {
            lowHitCounter = lowHitCounter + 20;
            inputLHitCount.Text = lowHitCounter.ToString();
        }

        private void inputLSubtractHit_Click_1(object sender, EventArgs e)
        {
            lowHitCounter--;
            inputLHitCount.Text = lowHitCounter.ToString();
        }
        private void inputLSubtractHit5_Click(object sender, EventArgs e)
        {
            lowHitCounter = lowHitCounter - 5;
            inputLHitCount.Text = lowHitCounter.ToString();

        }
        private void inputLSubtractHit10_Click(object sender, EventArgs e)
        {
            lowHitCounter = lowHitCounter - 10;
            inputLHitCount.Text = lowHitCounter.ToString();
        }
        private void inputLSubtractHit20_Click(object sender, EventArgs e)
        {
            lowHitCounter = lowHitCounter - 20;
            inputLHitCount.Text = lowHitCounter.ToString();
        }


        //Plus and minus button methods for low miss text box
        private void inputLPlusMiss_Click_1(object sender, EventArgs e)
        {
            lowMissCounter++;
            inputLMissCount.Text = lowMissCounter.ToString();
        }

        private void inputLPlusMiss5_Click(object sender, EventArgs e)
        {
            lowMissCounter = lowMissCounter + 5;
            inputLMissCount.Text = lowMissCounter.ToString();
        }

        private void inputLPlusMiss10_Click(object sender, EventArgs e)
        {
            lowMissCounter = lowMissCounter + 10;
            inputLMissCount.Text = lowMissCounter.ToString();
        }

        private void inputLPlusMiss20_Click(object sender, EventArgs e)
        {
            lowMissCounter = lowMissCounter + 20;
            inputLMissCount.Text = lowMissCounter.ToString();
        }



        private void inputLSubtractMiss_Click_1(object sender, EventArgs e)
        {
            lowMissCounter--;
            inputLMissCount.Text = lowMissCounter.ToString();
        }

        private void inputLSubtractMiss5_Click(object sender, EventArgs e)
        {
            lowMissCounter = lowMissCounter - 5;
            inputLMissCount.Text = lowMissCounter.ToString();
        }

        private void inputLSubtractMiss10_Click(object sender, EventArgs e)
        {
            lowMissCounter = lowMissCounter - 10;
            inputLMissCount.Text = lowMissCounter.ToString();
        }

        private void inputLSubtractMiss20_Click(object sender, EventArgs e)
        {
            lowMissCounter = lowMissCounter - 20;
            inputLMissCount.Text = lowMissCounter.ToString();
        }


    }
}
