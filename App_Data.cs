using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scouting_App
{
    public static class App_Data
    {

        public static string startingPosButtonRemember;

 //start info      
        
        private static string matchId;
        private static string teamNum;
        private static string allianceColor;
        private static string scoreKeeper;
        private static string startingPos;
        private static string hasBall;
        private static string hasGear;

        public static string MatchId { get { return matchId; } set { matchId = value; } } //
        public static string TeamNum { get { return teamNum; } set {teamNum = value;} } //
        public static string Alliancecolor { get {return allianceColor;} set {allianceColor = value;} } //
        public static string ScoreKeeper { get {return scoreKeeper;} set {scoreKeeper = value;} }
        public static string StartingPos { get {return startingPos;} set {startingPos = value;} }
        public static string HasBalls { get {return hasBall; } set {hasBall = value; } }
        public static string HasGear { get {return hasGear; } set {hasGear = value; } }


//auton

        private static string crossedLine;
        private static string gearPlaced;
        private static string autoLowHit;
        private static string autoLowMiss;
        private static string autoHighHit;
        private static string autoHighMiss;
        private static string activateHopper;

        public static string CrossedLine { get {return crossedLine; } set {crossedLine = value; } }
        public static string GearPlaced { get { return gearPlaced;}  set { gearPlaced = value; } }
        public static string AutoLowHit { get { return autoLowHit; } set { autoLowHit = value; } }
        public static string AutoLowMiss { get { return autoLowMiss; } set { autoLowMiss = value; } }
        public static string AutoHighHit { get { return autoHighHit; } set { autoHighHit = value; } }
        public static string AutoHighMiss { get { return autoHighMiss; } set {autoHighMiss = value; } }
        public static string ActivateHopper { get { return activateHopper; } set { activateHopper = value; } }

//tele-op 
        private static string gearsCollected;
        private static string breakDown;
        private static string climbCheck;
        private static string teleLowHit;
        private static string teleLowMiss;
        private static string teleHighHit;
        private static string teleHighMiss;

        public static string GearsCollected { get { return gearsCollected; } set { gearsCollected = value; } }
        public static string BreakDown { get { return breakDown; } set { breakDown = value; } }
        public static string ClimbCheck { get { return climbCheck; } set { climbCheck = value; } }
        public static string TeleLowHit { get { return teleLowHit; } set { teleLowHit = value; } }
        public static string TeleLowMiss { get { return teleLowMiss; } set { teleLowMiss = value; } }
        public static string TeleHighHit { get { return teleHighHit; } set { teleHighHit = value; } }
        public static string TeleHighMiss { get { return teleHighMiss; } set { teleHighMiss = value; } }
//end game

        
        private static string chasisBot;
        private static string shootingBot;
        private static string gearBot;
        private static string allAroundBot;
        private static string generalComments;
        private static string canCollectBallGound;
        private static string canCollectBallHopper;
        private static string canCollectBallLoadingStation;
        private static string canCollectGearGround;
        private static string canCollectGearLoadingStation;
        private static string robotSpeed;
        private static string driverCapailities;
        private static string ballCapacity;

        
       
        public static string ChasisBot { get { return chasisBot; }  set { chasisBot = value; } }
        public static string ShootingBot { get { return shootingBot; } set { shootingBot = value; } }
        public static string GearBot { get { return gearBot; } set { gearBot = value; } }
        public static string AllAroundBot { get { return allAroundBot; } set { allAroundBot = value; } }
        public static string GeneralComments { get { return generalComments; } set { generalComments = value; } }
        public static string CanCollectBallGround { get { return canCollectBallGound; } set { canCollectBallGound = value; } }
        public static string CanCollectBallHopper { get { return canCollectBallHopper; } set { canCollectBallHopper = value; } }
        public static string CanCollectBallLoadingStation { get{ return canCollectBallLoadingStation; } set { canCollectBallLoadingStation = value; } }
        public static string CanCollectGearGround { get { return canCollectGearGround; } set { canCollectGearGround = value; } }
        public static string CanCollectGearLoadingStation { get { return canCollectGearLoadingStation; } set { canCollectGearLoadingStation = value; } }
        public static string RobotSpeed { get { return robotSpeed; } set { robotSpeed = value; } }
        public static string DriverCapailities { get { return driverCapailities; } set { driverCapailities = value; } }
        public static string BallCapacity { get { return ballCapacity; } set { ballCapacity = value; } }


//match summary

        private static string boilerPoints;
        private static string gearPoints;
        private static string climbingPoints;
        private static string pentalyPoints;
        private static string rankingPoints;

        public static string BoilerPonits { get { return boilerPoints; } set { boilerPoints = value; } }
        public static string GearPonits { get { return gearPoints; } set { gearPoints = value; } }
        public static string ClimbingPoints { get { return climbingPoints; } set { climbingPoints = value; } }
        public static string PentalyPoints { get { return pentalyPoints; } set { pentalyPoints = value; } }
        public static string RankingPoints { get { return rankingPoints; } set { rankingPoints = value; } }



        //set data method for pre game 
        public static void setPregameData(string var_matchId, string var_teamNum, string var_allianceColor, string var_scoreKeeper,
            string var_startingPos, string var_hasBalls, string var_hasGear )
        {
            //set
            App_Data.MatchId = var_matchId;
            App_Data.TeamNum = var_teamNum;
            App_Data.Alliancecolor = var_allianceColor;
            App_Data.ScoreKeeper = var_scoreKeeper;
            App_Data.StartingPos = var_startingPos;
            App_Data.HasBalls = var_hasBalls;
            App_Data.HasGear = var_hasGear;

        }
        //set data method for auton
        public static void setAutonData(string var_crossedLine, string var_gearPlaced, string var_lowHit, string var_lowMiss, 
            string var_highHit, string var_highMiss, string var_activateHopper)
        {
            //set
            App_Data.CrossedLine = var_crossedLine;
            App_Data.GearPlaced = var_gearPlaced;
            App_Data.AutoLowHit = var_lowHit;
            App_Data.AutoLowMiss = var_lowMiss;
            App_Data.AutoHighHit = var_highHit;
            App_Data.AutoHighMiss = var_highMiss;
            App_Data.ActivateHopper = var_activateHopper;
        }
        //set data method for tele op
        public static void setTeleOpData(string var_gearCollected, string var_breakDown, string var_climbCheck,
            string var_teleHighHit, string var_teleHighMiss, string var_teleLowHit, string var_teleLowMiss)
        {
            //set
            App_Data.GearsCollected = var_gearCollected;
            App_Data.BreakDown = var_breakDown;
            App_Data.ClimbCheck = var_climbCheck;
            App_Data.TeleHighHit = var_teleHighHit;
            App_Data.TeleHighMiss = var_teleHighMiss;
            App_Data.TeleLowHit = var_teleLowHit;
            App_Data.teleLowMiss = var_teleLowMiss;
        }
        //set data method for end game
        public static void setEndGameData(string var_chasisBot, string var_shootingBot, string var_gearBot,
            string var_allAroundBot, string var_genralComments, string var_canCollectBallGround, string var_canCollectBallHopper,
            string var_canCollectBallLoadingStation, string var_canCollectGearGround,
            string var_canCollectGearLoadingStation, string var_ballCapacity, string var_driverCapailities, string var_robotSpeed)//parmaters
        {
            //set
            
            App_Data.ChasisBot = var_chasisBot;
            App_Data.ShootingBot = var_shootingBot;
            App_Data.GearBot = var_gearBot;
            App_Data.AllAroundBot = var_allAroundBot;
            App_Data.GeneralComments = var_genralComments;
            App_Data.CanCollectBallGround = var_canCollectBallGround;
            App_Data.CanCollectBallHopper = var_canCollectBallHopper;
            App_Data.CanCollectGearLoadingStation = var_canCollectBallLoadingStation;
            App_Data.CanCollectGearGround = var_canCollectGearGround;
            App_Data.CanCollectGearLoadingStation = var_canCollectGearLoadingStation;
            App_Data.BallCapacity = var_ballCapacity;
            App_Data.DriverCapailities = var_driverCapailities;
            App_Data.RobotSpeed = var_robotSpeed;
            


        }
        //set data methdo for match summary
        public static void setMatchSummaryData(string var_boilerPoints, 
            string var_gearPoints, string var_climbingPoints, string var_pentalyPoints, string var_rankingPoints)
        {
            App_Data.BoilerPonits = var_boilerPoints;
            App_Data.GearPonits = var_gearPoints;
            App_Data.ClimbingPoints = var_climbingPoints;
            App_Data.PentalyPoints = var_pentalyPoints;
            App_Data.RankingPoints = var_rankingPoints;
        }



        public static void clear()
        {
            App_Data.MatchId = null;
            App_Data.TeamNum = null;
            App_Data.Alliancecolor = null;
            App_Data.ScoreKeeper = null;
            App_Data.StartingPos = null;
            App_Data.HasBalls = null; 
            App_Data.HasGear = null;

            App_Data.CrossedLine = null;
            App_Data.GearPlaced = null;
            App_Data.AutoLowHit = null;
            App_Data.AutoLowMiss = null;
            App_Data.AutoHighHit = null;
            App_Data.AutoHighMiss = null;
            App_Data.ActivateHopper = null;

            App_Data.GearsCollected = null;
            App_Data.BreakDown = null;
            App_Data.ClimbCheck = null;
            App_Data.TeleHighHit = null;
            App_Data.TeleHighMiss = null;
            App_Data.TeleLowHit = null;
            App_Data.teleLowMiss = null;

            App_Data.ChasisBot = null;
            App_Data.ShootingBot = null;
            App_Data.GearBot = null;
            App_Data.AllAroundBot = null;
            App_Data.GeneralComments = null;
            App_Data.CanCollectBallGround = null;
            App_Data.CanCollectBallHopper = null;
            App_Data.CanCollectGearLoadingStation = null;
            App_Data.CanCollectGearGround = null;
            App_Data.CanCollectGearLoadingStation = null;
            App_Data.BallCapacity = null;
            App_Data.DriverCapailities = null;
            App_Data.RobotSpeed = null;

            App_Data.BoilerPonits = null;
            App_Data.GearPonits = null;
            App_Data.ClimbingPoints = null;
            App_Data.PentalyPoints = null;
            App_Data.RankingPoints = null;

        }





       // main method to write all of the csv
        public static void writeToCsv()
        {
            //pre game write csv
            string writePreGameToCsv;
            writePreGameToCsv = "0"  + ',' +
                                App_Data.MatchId  + ',' +
                                App_Data.TeamNum  + ',' +
                                '"' + App_Data.Alliancecolor + '"' + ',' +
                                '"' + App_Data.ScoreKeeper + '"' + ',' +
                                '"' + App_Data.StartingPos + '"' + ',' +
                                '"' + App_Data.HasBalls + '"' + ',' +
                                '"' + App_Data.HasGear + '"';
            //auton write to csv
            string writeAutonToCsv;
            writeAutonToCsv = "0" + ',' +
                              App_Data.MatchId + ',' +
                              App_Data.TeamNum + ',' +
                              '"' + App_Data.Alliancecolor + '"' + ',' +
                              '"' + App_Data.GearPlaced + '"' + ',' +
                              '"' + App_Data.CrossedLine + '"' + ',' +
                              App_Data.AutoHighHit + ',' +
                              App_Data.AutoHighMiss + ',' +
                              App_Data.AutoLowHit + ',' +
                              App_Data.AutoLowMiss + ',' +
                              '"' + App_Data.ActivateHopper + '"';
            //tele op write to csv
            string writeTeleToCsv;
            writeTeleToCsv = "0" + ',' +
                             App_Data.MatchId + ',' +
                             App_Data.TeamNum + ',' +
                             '"' + App_Data.Alliancecolor + '"' + ',' +
                             App_Data.GearsCollected + ',' +
                             App_Data.BreakDown + ',' +
                             '"' + App_Data.ClimbCheck + '"' + ',' +
                             App_Data.TeleHighHit + ',' +
                             App_Data.TeleHighMiss + ',' +
                             App_Data.TeleLowHit + ',' +
                             App_Data.TeleLowMiss ;
            // end game write to csv
            string writeEndToCsv;
            writeEndToCsv = "0"  + ',' +
                            App_Data.MatchId + ',' +
                            App_Data.TeamNum + ',' +
                            '"' + App_Data.Alliancecolor + '"' + ',' +
                            '"' + App_Data.GeneralComments + '"' + ',' +
                            '"' + App_Data.ChasisBot + '"' + ',' +
                            '"' + App_Data.GearBot + '"' + ',' +
                            '"' + App_Data.ShootingBot + '"' + ',' +
                            '"' + App_Data.AllAroundBot + '"' + ',' +
                            '"' + App_Data.CanCollectGearGround + '"' + ',' +
                            '"' + App_Data.CanCollectBallHopper + '"' + ',' +
                            '"' + App_Data.canCollectBallLoadingStation + '"' + ','+
                            '"' + App_Data.CanCollectGearGround + '"' + ',' +
                            '"' + App_Data.CanCollectGearLoadingStation + '"' + ',' +
                            App_Data.BallCapacity + ',' +
                            App_Data.DriverCapailities + ',' +
                            App_Data.RobotSpeed 
                            ;
            //game sum write to csv
            string writeGameSumToCsv;
            writeGameSumToCsv = "0" + ',' +
                            App_Data.MatchId + ',' +
                      '"' + App_Data.Alliancecolor + '"' + ',' +
                            App_Data.BoilerPonits + ',' +
                            App_Data.GearPonits + ',' +
                            App_Data.ClimbingPoints + ',' +
                            App_Data.PentalyPoints + ',' +
                            App_Data.RankingPoints + ',';




            string writeTableau;
            writeTableau = "0" + ',' +
                                App_Data.MatchId + ',' +
                                App_Data.TeamNum + ',' +
                                '"' + App_Data.Alliancecolor + '"' + ',' +
                                '"' + App_Data.ScoreKeeper + '"' + ',' +
                                '"' + App_Data.StartingPos + '"' + ',' +
                                '"' + App_Data.HasBalls + '"' + ',' +
                                '"' + App_Data.HasGear + '"' +
                                '"' + App_Data.GearPlaced + '"' + ',' +
                                '"' + App_Data.CrossedLine + '"' + ',' +
                                      App_Data.AutoHighHit + ',' +
                                      App_Data.AutoHighMiss + ',' +
                                      App_Data.AutoLowHit + ',' +
                                      App_Data.AutoLowMiss + ',' +
                               '"' + App_Data.ActivateHopper + '"' +
                              App_Data.GearsCollected + ',' +
                             App_Data.BreakDown + ',' +
                             '"' + App_Data.ClimbCheck + '"' + ',' +
                             App_Data.TeleHighHit + ',' +
                             App_Data.TeleHighMiss + ',' +
                             App_Data.TeleLowHit + ',' +
                             App_Data.TeleLowMiss +
                              '"' + App_Data.GeneralComments + '"' + ',' +
                            '"' + App_Data.ChasisBot + '"' + ',' +
                            '"' + App_Data.GearBot + '"' + ',' +
                            '"' + App_Data.ShootingBot + '"' + ',' +
                            '"' + App_Data.AllAroundBot + '"' + ',' +
                            '"' + App_Data.CanCollectGearGround + '"' + ',' +
                            '"' + App_Data.CanCollectBallHopper + '"' + ',' +
                            '"' + App_Data.canCollectBallLoadingStation + '"' + ',' +
                            '"' + App_Data.CanCollectGearGround + '"' + ',' +
                            '"' + App_Data.CanCollectGearLoadingStation + '"' + ',' +
                            App_Data.BallCapacity + ',' +
                            App_Data.DriverCapailities + ',' +
                            App_Data.RobotSpeed +
                            App_Data.BoilerPonits + ',' +
                            App_Data.GearPonits + ',' +
                            App_Data.ClimbingPoints + ',' +
                            App_Data.PentalyPoints + ',' +
                            App_Data.RankingPoints + ',';



            // streamwriter method for pre game
            StreamWriter sw = new StreamWriter(@"C:\Users\WIRED\Desktop\MainCsv\PregameCSV\" + App_Data.MatchId + "-" + App_Data.TeamNum + ".csv");

            sw.WriteLine("gameinfoid, "+"matchid, " + "teamnum, " + "alliancecolor, " + "scorekeeper, " + "startingpos, " + "hasball, " + "hasgear");

            sw.WriteLine(writePreGameToCsv);
            sw.Close();
            sw = null;


            // streamwriter method for auton
            sw = new StreamWriter(@"C:\Users\WIRED\Desktop\MainCsv\AutonCSV\" + App_Data.MatchId + "-" + App_Data.TeamNum + ".csv");

       sw.WriteLine("autoninfoid, " + "matchid, " + "teamnum, " + "alliancecolor, " + "crossedline, " + "gearplaced, " + "highhit, " + "highmiss, " + "lowhit, " + "lowmiss, " + "activatehopper ");

            sw.WriteLine(writeAutonToCsv);
            sw.Close();
            sw = null;


            // streamwriter method for tele op csv
            sw = new StreamWriter(@"C:\Users\WIRED\Desktop\MainCsv\TeleOpCSV\" + App_Data.MatchId + "-" + App_Data.TeamNum + ".csv");

            sw.WriteLine("teleopinfoid, " + "matchid, " + "teamnum, " + "alliancecolor, " + "gearscollected, " + "breakdown, " + "climbed, " + "highhit, " + "highmiss, " + "lowhit, " + "lowmiss, " );

            sw.WriteLine(writeTeleToCsv);
            sw.Close();
            sw = null;


            // streamwriter method for end game
            sw = new StreamWriter(@"C:\Users\WIRED\Desktop\MainCsv\EndGameCSV\" + App_Data.MatchId + "-" + App_Data.TeamNum + ".csv");

            sw.WriteLine("endinfoid, " + "matchid, " + "teamnum, " + "alliancecolor, " + "generalcomments, " + "chassisbot, " + "gearbot, " + "shootingbot, " + "allaroundgoodbot, " + "cancollectballsground, "
                + "cancollectballshopper, " + "cancollectballsloadingstation, " + "cancollectgearground, " + "cancollectgearloadingstation, "
                + "robotSpeed, " + "drivercapabilities, " + "maximumballcapacity, " );


            sw.WriteLine(writeEndToCsv);
            sw.Close();
            sw = null;

            // streamwriter method for game sum
            sw = new StreamWriter(@"C:\Users\WIRED\Desktop\MainCsv\GameSumCSV\" + App_Data.MatchId +"-"+ App_Data.TeamNum + ".csv");

            sw.WriteLine("summaryinfoid, " + "matchid, " + "alliancecolor, " + "boilerpoints, " + "gearpoints, " + "climbpoint, " + "penaltypoints, " + "rankingpoints, " );

            sw.WriteLine(writeGameSumToCsv);
            sw.Close();
            sw = null;

            sw = new StreamWriter(@"C:\Users\WIRED\Desktop\MainCsv\Tableau.csv");

            sw.WriteLine("gameinfoid, " + "matchid, " + "teamnum, " + "alliancecolor, " + "scorekeeper, " + "startingpos, " + "hasball, " + "hasgear" +
                "autoninfoid, " + "matchid, " + "teamnum, " + "alliancecolor, " + "crossedline, " + "gearplaced, " + "highhit, " + "highmiss, " + "lowhit, " + "lowmiss, " + "activatehopper "+
                "teleopinfoid, " + "matchid, " + "teamnum, " + "alliancecolor, " + "gearscollected, " + "breakdown, " + "climbed, " + "highhit, " + "highmiss, " + "lowhit, " + "lowmiss, " +
                "endinfoid, " + "matchid, " + "teamnum, " + "alliancecolor, " + "generalcomments, " + "chassisbot, " + "gearbot, " + "shootingbot, " + "allaroundgoodbot, " + "cancollectballsground, "
                + "cancollectballshopper, " + "cancollectballsloadingstation, " + "cancollectgearground, " + "cancollectgearloadingstation, "
                + "robotSpeed, " + "drivercapabilities, " + "maximumballcapacity, " + "summaryinfoid, " + "matchid, " + "alliancecolor, " + "boilerpoints, " + "gearpoints, " + "climbpoint, " + "penaltypoints, " + "rankingpoints, "
                    );

            sw.WriteLine(writeTableau);
            sw.Close();
            sw = null;

        }


    }
}
