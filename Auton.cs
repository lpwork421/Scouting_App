using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Scouting_App
{
    public partial class Auton : Form
    {
        public Auton()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            //Saves in App_Data Static Class
            App_Data.setAutonData(
            crossedLine() ,
            placeGear(),
            inputLHitCount.Text,
            inputLMissCount.Text,
            inputHHitCount.Text,
            inputHMissCount.Text,
            activateHopper()
            );
            //Write to debuger
            System.Diagnostics.Debug.WriteLine(App_Data.CrossedLine);
            System.Diagnostics.Debug.WriteLine(App_Data.GearPlaced);
            System.Diagnostics.Debug.WriteLine("Auton High Hit Count " + App_Data.AutoHighHit);
            System.Diagnostics.Debug.WriteLine("Auton High Miss Count " + App_Data.AutoHighMiss);
            System.Diagnostics.Debug.WriteLine("Auton Low Hit Count " + App_Data.AutoLowHit);
            System.Diagnostics.Debug.WriteLine("Auton Low Miss Count " + App_Data.AutoLowMiss);
            System.Diagnostics.Debug.WriteLine(App_Data.ActivateHopper);
            // Next window Auton To Tele-Op



            if(!inputPlacedGear.Checked && !inputMissedGear.Checked)
            {
                
                MessageBox.Show("Please Recheck What You Input", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tele_Op tele = new Tele_Op();
                tele.Show();
                this.Close();
            }


        }

        private void Auton_Load(object sender, EventArgs e)
        {
            if(App_Data.GearPlaced == "1")
            {
                inputPlacedGear.Checked = true;
            }
            else if (App_Data.GearPlaced == "0")
            {
                inputMissedGear.Checked = false;
            }

            if (App_Data.CrossedLine == "1")
            {
                inputCrossedLine.Checked = true;
            }
            else if (App_Data.CrossedLine == "0")
            {
                inputCrossedLine.Checked = false;
            }

            if (App_Data.ActivateHopper == "1")
            {
                inputHopperAcitvated.Checked = true;
            }
            else if (App_Data.ActivateHopper == "0")
            {
                inputHopperAcitvated.Checked = false;
            }

            inputLHitCount.Text = App_Data.AutoLowHit;

            inputLMissCount.Text = App_Data.AutoLowMiss;

            inputHHitCount.Text = App_Data.AutoHighHit;

            inputHMissCount.Text = App_Data.AutoHighMiss;

        }

        //Back Button Click
        private void backButton_Click(object sender, EventArgs e)
        {
            PreMatch back = new PreMatch();
            back.Show();
            this.Close();
        }





        //Cross line vaule for auton
        private string crossedLine()
        {
            if(inputCrossedLine.Checked)
            {
                return "1";
            }
            else
            {
                return "0";
            }
            
        }

        // Placed gear vaule for auton
        private string placeGear()
        {
            if(inputPlacedGear.Checked)
            {
                return "1";
            }
            else
            {
                return "0";
            }
            
        }
        // activate hopper vaule for auton
        private string activateHopper()
        {
            if(inputHopperAcitvated.Checked)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        //Close button for auton
        private void flatClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    lowMissCounter = lowMissCounter  + 20;
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
