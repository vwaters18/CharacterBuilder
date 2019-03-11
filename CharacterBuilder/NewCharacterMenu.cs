using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterBuilder
{
    public partial class NewCharacterMenu : Form
    {
        public NewCharacterMenu()
        {
            InitializeComponent();
        }

        private decimal[] Stats = { 1, 1, 1, 1, 1, 1 };
        private decimal pointsAvailable = 0;

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
        private void NewCharacterMenu_Load(object sender, EventArgs e)
        {
            TotValLabel.Text = "0";
        }
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
            GenChoiceInfo.Visible = false;
            RollButton.Visible = false;
            RollLabel.Visible = false;
            PointButton.Visible = false;
            PointLabel.Visible = false;
            fillStats(0);
            PointAvailLabel.Visible = true;
            RerollButton.Visible = true;
        }

    

        private void PointButton_Click_1(object sender, EventArgs e)
        {
            GenChoiceInfo.Visible = false;
            RollButton.Visible = false;
            RollLabel.Visible = false;
            PointButton.Visible = false;
            PointLabel.Visible = false;
            fillStats(1);
            PointAvailLabel.Visible = true;
        }
        private void fillStats(int option)
        {
            if(option==0)
            {
                Random gen = new Random();
                for(int a=0;a<6;a++)
                {
                    int[] Rolls = { 0, 0, 0, 0 };
                    for(int b=0;b<4;b++)
                    {
                        Rolls[b] = gen.Next(1, 6);
                    }
                    Stats[a] = Rolls.Sum() - Rolls.Min();
                }
                StrNum.Value = Stats[0];
                DexNum.Value = Stats[1];
                ConNum.Value = Stats[2];
                IntNum.Value = Stats[3];
                WisNum.Value = Stats[4];
                ChaNum.Value = Stats[5];
                pointsAvailable = 0;
                PointAvailLabel.Text = PointAvailLabel.Text + 0;
            }
            else
            {
                StrNum.Value = 8;
                DexNum.Value = 8;
                ConNum.Value = 8;
                IntNum.Value = 8;
                WisNum.Value = 8;
                ChaNum.Value = 8;
                pointsAvailable = 12;
                PointAvailLabel.Text = PointAvailLabel.Text + 12;
            }
            
        }

        private void RerollButton_Click(object sender, EventArgs e)
        {
            fillStats(0);
        }
    }
}
