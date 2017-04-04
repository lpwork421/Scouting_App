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
    public partial class PreMatch : Form
    {
        public PreMatch()
        {
            InitializeComponent();
            this.Focus();
        }



        private void next_Click(object sender, EventArgs e)
        {

            //Saves Data to static class
            App_Data.setPregameData(
                  inputMatchId.Text,
                  inputTeamNum.Text,
                  allianceColor,
                  inputScoreKeeper.Text,
                  startingPosLbl.Text,
                  getHasBall(),
                  getHasGear()
            );
            //writes to debugger to check

            System.Diagnostics.Debug.WriteLine("saved pre game data");
            System.Diagnostics.Debug.WriteLine(App_Data.MatchId);
            System.Diagnostics.Debug.WriteLine(App_Data.TeamNum);
            System.Diagnostics.Debug.WriteLine(App_Data.Alliancecolor);
            System.Diagnostics.Debug.WriteLine(App_Data.ScoreKeeper);
            System.Diagnostics.Debug.WriteLine(App_Data.StartingPos);
            System.Diagnostics.Debug.WriteLine(App_Data.HasBalls);
            System.Diagnostics.Debug.WriteLine(App_Data.HasGear);



            //Next window, from Pre-Match to Auton
            if (String.IsNullOrEmpty(inputMatchId.Text) || String.IsNullOrEmpty(inputScoreKeeper.Text) || String.IsNullOrEmpty(inputTeamNum.Text))
            {
                MessageBox.Show("Please Recheck What You Input", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Auton auto = new Auton();
                auto.Show();
                this.Hide();
            }





        }


        //Given vaule to id alliance color
        string allianceColor;
        public void inputRedAllyColor_Click(object sender, EventArgs e)
        {
            inputRedAllyColor.Visible = false;
            allianceColor = "Red";
            if (inputBlueAllyColor.Visible == false)
            {
                inputBlueAllyColor.Visible = true;
            }
            allianceColorLbl.Text = "Red";
        }
        public void inputBlueAllyColor_Click(object sender, EventArgs e)
        {

            inputBlueAllyColor.Visible = false;
            allianceColor = "Blue";
            if (inputRedAllyColor.Visible == false)
            {
                inputRedAllyColor.Visible = true;
            }
            allianceColorLbl.Text = "Blue";
        }

        //Vaule given to has ball toggle
        public string getHasBall()
        {
            if (inputHasBalls.Checked)
            {
                return "1";
            }
            else
            {
                return "0";
            }

        }
        //Vaule given to has gear toggle
        public string getHasGear()
        {
            if (inputHasGear.Checked)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }



        public static string startingButton;
        //Left side toggle buttons
        private void Right1_Click(object sender, EventArgs e)
        {
            clearStartingPosToggle();
            inputRight1.Hide();
            startingPosLbl.Text = "Right";
            App_Data.startingPosButtonRemember = "Right1";

        }

        private void Center1_Click(object sender, EventArgs e)
        {
            clearStartingPosToggle();
            inputCenter1.Hide();
            startingPosLbl.Text = "Center";
            App_Data.startingPosButtonRemember = "Center1";

        }

        private void Left1_Click(object sender, EventArgs e)
        {
            clearStartingPosToggle();
            inputLeft1.Hide();
            startingPosLbl.Text = "Left";
            App_Data.startingPosButtonRemember = "Left1";
        }


        //Right side toggle buttons

        private void Right2_Click(object sender, EventArgs e)
        {
            clearStartingPosToggle();
            inputRight2.Hide();
            startingPosLbl.Text = "Right";
            App_Data.startingPosButtonRemember = "Right2";
        }

        private void Center2_Click(object sender, EventArgs e)
        {
            clearStartingPosToggle();
            inputCenter2.Hide();
            startingPosLbl.Text = "Center";
            App_Data.startingPosButtonRemember = "Center2";
        }

        private void Left2_Click(object sender, EventArgs e)
        {
            clearStartingPosToggle();
            inputLeft2.Hide();
            startingPosLbl.Text = "Left";
            App_Data.startingPosButtonRemember = "Left2";
        }





        //Clear Meathod for button methods
        public void clearStartingPosToggle()
        {
            //toggle clear for left side buttons below match and team nums
            inputRight1.Show();
            inputRight1.Rounded = true;
            inputCenter1.Show();
            inputCenter1.Rounded = true;
            inputLeft1.Show();
            inputLeft1.Rounded = true;

            //toggle clear for right side buttons below team inputs
            inputRight2.Show();
            inputRight2.Rounded = true;
            inputCenter2.Show();
            inputCenter2.Rounded = true;
            inputLeft2.Show();
            inputRight2.Rounded = true;

        }


        //close button for pre match form
        private void flatClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void PreMatch_Load(object sender, EventArgs e)
        {
            inputMatchId.Text = App_Data.MatchId;
            inputTeamNum.Text = App_Data.TeamNum;
            allianceColor = App_Data.Alliancecolor;

            if (App_Data.Alliancecolor == "Red")
            {
                inputRedAllyColor.Visible = false;
                allianceColorLbl.Text = "Red";
            }
            else if (App_Data.Alliancecolor == "Blue")
            {
                inputBlueAllyColor.Visible = false;
                allianceColorLbl.Text = "Blue";
            }

            inputScoreKeeper.Text = App_Data.ScoreKeeper;

            startingPosLbl.Text = App_Data.StartingPos;
            if (App_Data.startingPosButtonRemember == "Right1")
            {
                inputRight1.Visible = false;
            }

            if (App_Data.startingPosButtonRemember == "Center1")
            {
                inputCenter1.Visible = false;
            }

            if (App_Data.startingPosButtonRemember == "Left1")
            {
                inputLeft1.Visible = false;
            }

            if (App_Data.startingPosButtonRemember == "Right2")
            {
                inputRight2.Visible = false;
            }

            if (App_Data.startingPosButtonRemember == "Center2")
            {
                inputCenter2.Visible = false;
            }

            if (App_Data.startingPosButtonRemember == "Left2")
            {
                inputLeft2.Visible = false;
            }

            if (App_Data.HasBalls == "1")
            {
                inputHasBalls.Checked = true;
            }
            if (App_Data.HasGear == "1")
            {
                inputHasGear.Checked = true;
            }


        }

        /*
        private void copyFolder(string sourceFile, string destinationFile)
        {
            string[] theDirectories = Directory.GetDirectories(sourceFile);
            foreach(string curDir in theDirectories)
            {
                if (!Directory.Exists(destinationFile.Substring(0,
                    destinationFile.IndexOf("\\")) +
                    curDir.Substring(curDir.IndexOf("\\"))))
                    {
                    Directory.CreateDirectory(destinationFile.Substring(0,
                        destinationFile.IndexOf("\\")) +
                        curDir.Substring(curDir.IndexOf("\\")));
                    }
                this.copyFolder(curDir, destinationFile.Substring(0,
                    destinationFile.IndexOf("\\")) +
                    curDir.Substring(curDir.IndexOf("\\")));
            }
            string[] theFilesInCurrentDir = Directory.GetFiles(sourceFile);
            foreach(string currentFile in theFilesInCurrentDir)
            {
                this.copyFolder(currentFile, destinationFile);
            }
        }

        private void copyFolder(string sourceFile, string destinationFile)
        {
            File.Copy(sourceFile, destinationFile + "\\" + Path.GetFileName(sourceFile));
        }
           copyFolder(@"C:\Users\admin\Documents\MainCsv\", @"F:\MainCsv\");
        */
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /* using (var fbd = new FolderBrowserDialog())
             {
                 DialogResult result = fbd.ShowDialog();
                 if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                 {
                     string[] files = Directory.GetFiles(fbd.SelectedPath);
                     System.Windows.Forms.MessageBox.Show("Files Found: " + files.Length.ToString(), "Message");
                 }
             }*/



            /* var dirs = Directory.GetDirectories(@"C:\Users\admin\Desktop", "*");
             for (int a = 0; a < dirs.Length; ++a)
             {
                 string filename1 = dirs[a].Substring(dirs[a].LastIndexOf("\\"));
                 if (!File.Exists(@"F:\MainCsv\DataRipTest\" + filename1))
                 {

                     var filedirs = Directory.GetDirectorie
                 }
             }*/
            bool completed = false;
            int filedifferint = 1;
            //var dirs = Directory.GetDirectories(@"F:\MainCsv\DataRipTest\", "*");
            //for (int a = 0; a < dirs.Length; ++a)
            //{
            do
            {
                string filediffer = Convert.ToString(filedifferint);
                if (!Directory.Exists(@"F:\MainCsv\DataRipTest\" + "MainCSV" + filediffer))
                {
                    System.Diagnostics.Debug.WriteLine("File MainCSV" + filediffer + " does not Exist!");
                    var createddir = Directory.CreateDirectory(@"F:\MainCsv\DataRipTest\" + "MainCSV" + filediffer);
                    string[] subdirs = Directory.GetDirectories(@"C:\Users\admin\Desktop\MainCSV\", "*");
                    for (int b = 0; b < subdirs.Length; ++b)
                    {
                        Directory.CreateDirectory(@"F:\MainCsv\DataRipTest\MainCSV" + filediffer + subdirs[b].Substring(subdirs[b].LastIndexOf("\\")));
                        string[] filesindir = Directory.GetFiles(@"C:\Users\admin\Desktop\MainCSV\" + subdirs[b].Substring(subdirs[b].LastIndexOf("\\")));
                        for (int c = 0; c < filesindir.Length; ++c)
                        {
                            string path1 = @"C:\Users\admin\Desktop\MainCSV\" + subdirs[b].Substring(subdirs[b].LastIndexOf("\\")) + filesindir[c].Substring(filesindir[c].LastIndexOf("\\"));
                            string path1a = @"F:\MainCsv\DataRipTest\MainCSV" + filediffer + "\\" + subdirs[b].Substring(subdirs[b].LastIndexOf("\\"));
                            string path2b = path1a + filesindir[c].Substring(filesindir[c].LastIndexOf("\\"));
                            File.Copy(path1, path2b);
                            completed = true;
                        }
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("File MainCSV" + filediffer + " Exists, adding +1 to the end!");
                    filedifferint = filedifferint + 1;
                }
            } while (completed == false);
        }


    }
}
