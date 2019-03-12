using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CharacterBuilder
{
    public partial class NewCharacterMenu : Form
    {
        public NewCharacterMenu()
        {
            InitializeComponent();
        }

        private decimal[] Stats = { 1, 1, 1, 1, 1, 1 }; //Array used for stroing stats for calculation. Should be changed after race selection makes final change.
        private decimal pointsAvailable = 0; //Number of points available. Set to 12 for pointbuy, set to the sum of all stats if rolled to preserve stat values.
        private System.Collections.ArrayList RaceNames=new System.Collections.ArrayList();//Arraylist used to contain the race names. Used to populate the race selection box
        private XmlDocument RaceDocument; //Xml file containing race info
        private XmlNode RaceRoot; //Root node of races.xml. Might not be needed.
        private XmlNodeList Races; //All races from Races.xml
        private XmlNode selectedRace; //Currently selected race node. Starts as null

        /**
         * Methods used to update the number of points 
         * available and that stat values that are stored.
        **/
        private void StrNum_ValueChanged(object sender, EventArgs e)
        {
            pointsAvailable += Stats[0] - StrNum.Value;
            Stats[0] = StrNum.Value;
            updateTotal();
        }
        private void DexNum_ValueChanged(object sender, EventArgs e)
        {
            pointsAvailable += Stats[1] - DexNum.Value;
            Stats[1] = DexNum.Value;
            updateTotal();
        }
        private void ConNum_ValueChanged(object sender, EventArgs e)
        {
            pointsAvailable += Stats[2] - ConNum.Value;
            Stats[2] = ConNum.Value;
            updateTotal();
        }
        private void IntNum_ValueChanged(object sender, EventArgs e)
        {
            pointsAvailable += Stats[3] - IntNum.Value;
            Stats[3] = IntNum.Value;
            updateTotal();
        }
        private void WisNum_ValueChanged(object sender, EventArgs e)
        {
            pointsAvailable += Stats[4] - WisNum.Value;
            Stats[4] = WisNum.Value;
            updateTotal();
        }
        private void ChaNum_ValueChanged(object sender, EventArgs e)
        {
            pointsAvailable += Stats[5] - ChaNum.Value;
            Stats[5] = ChaNum.Value;
            updateTotal();
        }
       
        /**
         * On load of the menu, gets the race, class, and background xml data.
        **/
        private void NewCharacterMenu_Load(object sender, EventArgs e)
        {
            TotValLabel.Text = "0";

            //Race xml document
            RaceDocument = new XmlDocument();
            RaceDocument.Load("C:/Users/vwaters/Desktop/Visual_studio_stuff/Character Builder Git/CharacterBuilder/Races.xml");

            //Root node of races xml file
            RaceRoot = RaceDocument.SelectSingleNode("Races");
            
            
            //Contains all race nodes
            Races = RaceRoot.SelectNodes("Race");

            RaceBox.Items.Clear();

            foreach (XmlNode Race in Races)
            {
                RaceNames.Add(Race.SelectSingleNode("name").InnerText);
                RaceBox.Items.Add(Race.SelectSingleNode("name").InnerText);
            }

            
            
        }

        /**
         * updates the total points spend tracker. Kinda needs a way to show what it should be at.
        **/
        private void updateTotal()
        {
            decimal total = 0;
            foreach(decimal a in Stats)
            {
                total += a;
            }
            TotValLabel.Text = total.ToString();
            PointAvailLabel.Text = "Points available: " + pointsAvailable;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            //Hide the labels and buttons for selecting generation method.
            GenChoiceInfo.Visible = false;
            RollButton.Visible = false;
            RollLabel.Visible = false;
            PointButton.Visible = false;
            PointLabel.Visible = false;

            //Sets the number inside the stat boxes using the roll method
            fillStats(0);

            //Shows to controlls for finalizing stat generation
            PointAvailLabel.Visible = true;
            RerollButton.Visible = true;
            FinStatButton.Visible = true;
        }

        private void PointButton_Click_1(object sender, EventArgs e)
        {
            //Hide options for selecting generation method
            GenChoiceInfo.Visible = false;
            RollButton.Visible = false;
            RollLabel.Visible = false;
            PointButton.Visible = false;
            PointLabel.Visible = false;

            //Fill stats using the point buy method. Sets all to 8.
            fillStats(1);

            //shows the controlls for finishing generation using point buy method.
            FinStatButton.Visible = true;
            PointAvailLabel.Visible = true;
        }

        private void fillStats(int option)
        {
            //If using roll stats method.
            if(option==0)
            {
                //create random number generator
                Random gen = new Random();

                //for each of the 6 stats
                for(int a=0;a<6;a++)
                {

                    int[] Rolls = { 0, 0, 0, 0 }; //array to hold each roll

                    //Generate four random numbers between 1-6
                    for (int b=0;b<4;b++)
                    {
                        Rolls[b] = gen.Next(1, 6);
                    }
                    //set the current total to the sum of all the rolls minus the lowest roll.
                    //this is equivelent to the method of not including the lowest roll.
                    Stats[a] = Rolls.Sum() - Rolls.Min();
                }

                //sets each stat to the generated value
                StrNum.Value = Stats[0];
                DexNum.Value = Stats[1];
                ConNum.Value = Stats[2];
                IntNum.Value = Stats[3];
                WisNum.Value = Stats[4];
                ChaNum.Value = Stats[5];
                
                //Record that there are no more points available
                pointsAvailable = 0;
                PointAvailLabel.Text = PointAvailLabel.Text + 0;
            }

            //If using the point buy method
            else
            {
                //Set each stat to the default 8
                StrNum.Value = 8;
                DexNum.Value = 8;
                ConNum.Value = 8;
                IntNum.Value = 8;
                WisNum.Value = 8;
                ChaNum.Value = 8;

                //Give them 12 poitns to adjust stats.
                pointsAvailable = 12;
                PointAvailLabel.Text = PointAvailLabel.Text + 12;
            }
            
        }

        /**
         * Just fills the stats again using the random generation method.
        **/
        private void RerollButton_Click(object sender, EventArgs e)
        {
            fillStats(0);
        }

        /**
         * Sets the non-user-changable  values to the current stat values. Then hides
         * the old controls and shows the new controls for selecting race.
        **/
        private void FinStatButton_Click(object sender, EventArgs e)
        {
            //Assign stats to labels
            FinalStr.Text = Stats[0].ToString();
            FinalDex.Text = Stats[1].ToString();
            FinalCon.Text = Stats[2].ToString();
            FinalInt.Text = Stats[3].ToString();
            FinalWis.Text = Stats[4].ToString();
            FinalCha.Text = Stats[5].ToString();

            //Show final labels
            FinalStr.Visible = true;
            FinalDex.Visible = true;
            FinalCon.Visible = true;
            FinalInt.Visible = true;
            FinalWis.Visible = true;
            FinalCha.Visible = true;

            //Hide old sat changer
            StrNum.Visible = false;
            DexNum.Visible = false;
            ConNum.Visible = false;
            IntNum.Visible = false;
            WisNum.Visible = false;
            ChaNum.Visible = false;

            //Hide old controls and labels
            PointAvailLabel.Visible = false;
            FinStatButton.Visible = false;
            TotalLabel.Visible = false;
            TotValLabel.Visible = false;
            RerollButton.Visible = false;
            
            //show race menu
            toggleRaceMenu();
        }
        
        /**
         * Toggle the visibilty of the Menus for race selection.
        **/
        private void toggleRaceMenu()
        {
            RaceBox.Visible = !(RaceBox.Visible);
            RaceLabel.Visible = !(RaceLabel.Visible);
        }

        /**
         * Exits all windows
        **/
        private void FinishButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        /**
         * Changes stats and features based on the race selected by the user.
        **/
        private void RaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlNodeList stats;//Holds list of stats chagned by the race

            //If th user has previously selected a race and is now changing the selected race
            if(selectedRace!=null)
            {
                //Get the list of stats taht are affected
                stats = selectedRace.SelectNodes("features/stats/stat");

                //For each stat that is affected, reduce the affected stat by the ammount of bonus
                foreach (XmlNode stat in stats)
                {
                    switch (stat.SelectSingleNode("StatName").InnerText)
                    {
                        case "Str":
                            Stats[0] -= Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                            FinalStr.Text = Stats[0].ToString();
                            break;
                        case "Dex":
                            Stats[1] -= Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                            FinalDex.Text = Stats[1].ToString();
                            break;
                        case "Con":
                            Stats[2] -= Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                            FinalCon.Text = Stats[2].ToString();
                            break;
                        case "Int":
                            Stats[3] -= Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                            FinalInt.Text = Stats[3].ToString();
                            break;
                        case "Wis":
                            Stats[4] -= Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                            FinalWis.Text = Stats[4].ToString();
                            break;
                        case "Cha":
                            Stats[5] -= Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                            FinalCha.Text = Stats[5].ToString();
                            break;
                        default:
                            break;
                    }
                }
            }

            //Store the new race in the XML node for the selected race
            selectedRace = RaceRoot.SelectSingleNode("Race[name = \""+ RaceBox.SelectedItem.ToString() + "\"]");

            //Get the new list of affected stats
            stats = selectedRace.SelectNodes("features/stats/stat");

            //Apply the bonuses
            foreach (XmlNode stat in stats)
            {
                switch (stat.SelectSingleNode("StatName").InnerText)
                {
                    case "Str":
                        Stats[0] += Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                        FinalStr.Text = Stats[0].ToString();
                        break;
                    case "Dex":
                        Stats[1] += Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                        FinalDex.Text = Stats[1].ToString();
                        break;
                    case "Con":
                        Stats[2] += Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                        FinalCon.Text = Stats[2].ToString();
                        break;
                    case "Int":
                        Stats[3] += Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                        FinalInt.Text = Stats[3].ToString();
                        break;
                    case "Wis":
                        Stats[4] += Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                        FinalWis.Text = Stats[4].ToString();
                        break;
                    case "Cha":
                        Stats[5] += Decimal.Parse(stat.SelectSingleNode("bonus").InnerText);
                        FinalCha.Text = Stats[5].ToString();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
