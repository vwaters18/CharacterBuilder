namespace CharacterBuilder
{
    partial class NewCharacterMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StrNum = new System.Windows.Forms.NumericUpDown();
            this.StrLabel = new System.Windows.Forms.Label();
            this.ChaLabel = new System.Windows.Forms.Label();
            this.ChaNum = new System.Windows.Forms.NumericUpDown();
            this.WisLabel = new System.Windows.Forms.Label();
            this.WisNum = new System.Windows.Forms.NumericUpDown();
            this.IntLabel = new System.Windows.Forms.Label();
            this.IntNum = new System.Windows.Forms.NumericUpDown();
            this.ConLabel = new System.Windows.Forms.Label();
            this.ConNum = new System.Windows.Forms.NumericUpDown();
            this.DexLabel = new System.Windows.Forms.Label();
            this.DexNum = new System.Windows.Forms.NumericUpDown();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotValLabel = new System.Windows.Forms.Label();
            this.GenChoiceInfo = new System.Windows.Forms.Label();
            this.RollButton = new System.Windows.Forms.Button();
            this.RollLabel = new System.Windows.Forms.Label();
            this.PointLabel = new System.Windows.Forms.Label();
            this.PointButton = new System.Windows.Forms.Button();
            this.PointAvailLabel = new System.Windows.Forms.Label();
            this.RerollButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FinalCha = new System.Windows.Forms.Label();
            this.FinalWis = new System.Windows.Forms.Label();
            this.FinalInt = new System.Windows.Forms.Label();
            this.FinalCon = new System.Windows.Forms.Label();
            this.FinalDex = new System.Windows.Forms.Label();
            this.FinalStr = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.FinStatButton = new System.Windows.Forms.Button();
            this.RaceBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.StrNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChaNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WisNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexNum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StrNum
            // 
            this.StrNum.Location = new System.Drawing.Point(115, 46);
            this.StrNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.StrNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StrNum.Name = "StrNum";
            this.StrNum.Size = new System.Drawing.Size(35, 20);
            this.StrNum.TabIndex = 0;
            this.StrNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StrNum.ValueChanged += new System.EventHandler(this.StrNum_ValueChanged);
            // 
            // StrLabel
            // 
            this.StrLabel.AutoSize = true;
            this.StrLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StrLabel.Location = new System.Drawing.Point(52, 53);
            this.StrLabel.Name = "StrLabel";
            this.StrLabel.Size = new System.Drawing.Size(47, 13);
            this.StrLabel.TabIndex = 1;
            this.StrLabel.Text = "Strength";
            // 
            // ChaLabel
            // 
            this.ChaLabel.AutoSize = true;
            this.ChaLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ChaLabel.Location = new System.Drawing.Point(49, 178);
            this.ChaLabel.Name = "ChaLabel";
            this.ChaLabel.Size = new System.Drawing.Size(50, 13);
            this.ChaLabel.TabIndex = 3;
            this.ChaLabel.Text = "Charisma";
            // 
            // ChaNum
            // 
            this.ChaNum.Location = new System.Drawing.Point(115, 176);
            this.ChaNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ChaNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChaNum.Name = "ChaNum";
            this.ChaNum.Size = new System.Drawing.Size(35, 20);
            this.ChaNum.TabIndex = 2;
            this.ChaNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChaNum.ValueChanged += new System.EventHandler(this.ChaNum_ValueChanged);
            // 
            // WisLabel
            // 
            this.WisLabel.AutoSize = true;
            this.WisLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.WisLabel.Location = new System.Drawing.Point(54, 156);
            this.WisLabel.Name = "WisLabel";
            this.WisLabel.Size = new System.Drawing.Size(45, 13);
            this.WisLabel.TabIndex = 5;
            this.WisLabel.Text = "Wisdom";
            // 
            // WisNum
            // 
            this.WisNum.Location = new System.Drawing.Point(115, 150);
            this.WisNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.WisNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WisNum.Name = "WisNum";
            this.WisNum.Size = new System.Drawing.Size(35, 20);
            this.WisNum.TabIndex = 4;
            this.WisNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WisNum.ValueChanged += new System.EventHandler(this.WisNum_ValueChanged);
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.IntLabel.Location = new System.Drawing.Point(36, 131);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(63, 13);
            this.IntLabel.TabIndex = 7;
            this.IntLabel.Text = "Intelegence";
            // 
            // IntNum
            // 
            this.IntNum.Location = new System.Drawing.Point(115, 124);
            this.IntNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.IntNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntNum.Name = "IntNum";
            this.IntNum.Size = new System.Drawing.Size(35, 20);
            this.IntNum.TabIndex = 6;
            this.IntNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntNum.ValueChanged += new System.EventHandler(this.IntNum_ValueChanged);
            // 
            // ConLabel
            // 
            this.ConLabel.AutoSize = true;
            this.ConLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ConLabel.Location = new System.Drawing.Point(37, 104);
            this.ConLabel.Name = "ConLabel";
            this.ConLabel.Size = new System.Drawing.Size(62, 13);
            this.ConLabel.TabIndex = 9;
            this.ConLabel.Text = "Constitution";
            // 
            // ConNum
            // 
            this.ConNum.Location = new System.Drawing.Point(115, 98);
            this.ConNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ConNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ConNum.Name = "ConNum";
            this.ConNum.Size = new System.Drawing.Size(35, 20);
            this.ConNum.TabIndex = 8;
            this.ConNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ConNum.ValueChanged += new System.EventHandler(this.ConNum_ValueChanged);
            // 
            // DexLabel
            // 
            this.DexLabel.AutoSize = true;
            this.DexLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DexLabel.Location = new System.Drawing.Point(51, 77);
            this.DexLabel.Name = "DexLabel";
            this.DexLabel.Size = new System.Drawing.Size(48, 13);
            this.DexLabel.TabIndex = 11;
            this.DexLabel.Text = "Dexterity";
            // 
            // DexNum
            // 
            this.DexNum.Location = new System.Drawing.Point(115, 72);
            this.DexNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.DexNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DexNum.Name = "DexNum";
            this.DexNum.Size = new System.Drawing.Size(35, 20);
            this.DexNum.TabIndex = 10;
            this.DexNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DexNum.ValueChanged += new System.EventHandler(this.DexNum_ValueChanged);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TotalLabel.Location = new System.Drawing.Point(75, 206);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = "Total:";
            // 
            // TotValLabel
            // 
            this.TotValLabel.AutoSize = true;
            this.TotValLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TotValLabel.Location = new System.Drawing.Point(115, 206);
            this.TotValLabel.Name = "TotValLabel";
            this.TotValLabel.Size = new System.Drawing.Size(27, 13);
            this.TotValLabel.TabIndex = 13;
            this.TotValLabel.Text = "num";
            // 
            // GenChoiceInfo
            // 
            this.GenChoiceInfo.AutoSize = true;
            this.GenChoiceInfo.Location = new System.Drawing.Point(264, 46);
            this.GenChoiceInfo.Name = "GenChoiceInfo";
            this.GenChoiceInfo.Size = new System.Drawing.Size(169, 13);
            this.GenChoiceInfo.TabIndex = 14;
            this.GenChoiceInfo.Text = "Select a method to generate stats.";
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(267, 72);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(75, 23);
            this.RollButton.TabIndex = 15;
            this.RollButton.Text = "Roll Stats";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // RollLabel
            // 
            this.RollLabel.AutoSize = true;
            this.RollLabel.Location = new System.Drawing.Point(349, 72);
            this.RollLabel.Name = "RollLabel";
            this.RollLabel.Size = new System.Drawing.Size(156, 13);
            this.RollLabel.TabIndex = 16;
            this.RollLabel.Text = "Roll 4d6 and select the highest.";
            // 
            // PointLabel
            // 
            this.PointLabel.AutoSize = true;
            this.PointLabel.Location = new System.Drawing.Point(349, 104);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(131, 13);
            this.PointLabel.TabIndex = 18;
            this.PointLabel.Text = "Assign points to each stat.";
            // 
            // PointButton
            // 
            this.PointButton.Location = new System.Drawing.Point(267, 104);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(75, 23);
            this.PointButton.TabIndex = 17;
            this.PointButton.Text = "Point Buy";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click_1);
            // 
            // PointAvailLabel
            // 
            this.PointAvailLabel.AutoSize = true;
            this.PointAvailLabel.Location = new System.Drawing.Point(267, 134);
            this.PointAvailLabel.Name = "PointAvailLabel";
            this.PointAvailLabel.Size = new System.Drawing.Size(87, 13);
            this.PointAvailLabel.TabIndex = 20;
            this.PointAvailLabel.Text = "Points available: ";
            this.PointAvailLabel.Visible = false;
            // 
            // RerollButton
            // 
            this.RerollButton.Location = new System.Drawing.Point(267, 156);
            this.RerollButton.Name = "RerollButton";
            this.RerollButton.Size = new System.Drawing.Size(75, 23);
            this.RerollButton.TabIndex = 21;
            this.RerollButton.Text = "Reroll Stats";
            this.RerollButton.UseVisualStyleBackColor = true;
            this.RerollButton.Visible = false;
            this.RerollButton.Click += new System.EventHandler(this.RerollButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 13);
            this.NameLabel.TabIndex = 22;
            this.NameLabel.Text = "Character Name:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(115, 9);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(318, 20);
            this.NameBox.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.FinalCha);
            this.panel1.Controls.Add(this.FinalWis);
            this.panel1.Controls.Add(this.FinalInt);
            this.panel1.Controls.Add(this.FinalCon);
            this.panel1.Controls.Add(this.FinalDex);
            this.panel1.Controls.Add(this.FinalStr);
            this.panel1.Location = new System.Drawing.Point(35, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 186);
            this.panel1.TabIndex = 24;
            // 
            // FinalCha
            // 
            this.FinalCha.AutoSize = true;
            this.FinalCha.Location = new System.Drawing.Point(121, 141);
            this.FinalCha.Name = "FinalCha";
            this.FinalCha.Size = new System.Drawing.Size(48, 13);
            this.FinalCha.TabIndex = 33;
            this.FinalCha.Text = "FinalCha";
            this.FinalCha.Visible = false;
            // 
            // FinalWis
            // 
            this.FinalWis.AutoSize = true;
            this.FinalWis.Location = new System.Drawing.Point(121, 114);
            this.FinalWis.Name = "FinalWis";
            this.FinalWis.Size = new System.Drawing.Size(47, 13);
            this.FinalWis.TabIndex = 32;
            this.FinalWis.Text = "FinalWis";
            this.FinalWis.Visible = false;
            // 
            // FinalInt
            // 
            this.FinalInt.AutoSize = true;
            this.FinalInt.Location = new System.Drawing.Point(121, 89);
            this.FinalInt.Name = "FinalInt";
            this.FinalInt.Size = new System.Drawing.Size(41, 13);
            this.FinalInt.TabIndex = 31;
            this.FinalInt.Text = "FinalInt";
            this.FinalInt.Visible = false;
            // 
            // FinalCon
            // 
            this.FinalCon.AutoSize = true;
            this.FinalCon.Location = new System.Drawing.Point(121, 62);
            this.FinalCon.Name = "FinalCon";
            this.FinalCon.Size = new System.Drawing.Size(48, 13);
            this.FinalCon.TabIndex = 30;
            this.FinalCon.Text = "FinalCon";
            this.FinalCon.Visible = false;
            // 
            // FinalDex
            // 
            this.FinalDex.AutoSize = true;
            this.FinalDex.Location = new System.Drawing.Point(121, 35);
            this.FinalDex.Name = "FinalDex";
            this.FinalDex.Size = new System.Drawing.Size(48, 13);
            this.FinalDex.TabIndex = 29;
            this.FinalDex.Text = "FinalDex";
            this.FinalDex.Visible = false;
            // 
            // FinalStr
            // 
            this.FinalStr.AutoSize = true;
            this.FinalStr.Location = new System.Drawing.Point(121, 11);
            this.FinalStr.Name = "FinalStr";
            this.FinalStr.Size = new System.Drawing.Size(42, 13);
            this.FinalStr.TabIndex = 28;
            this.FinalStr.Text = "FinalStr";
            this.FinalStr.Visible = false;
            // 
            // FinishButton
            // 
            this.FinishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinishButton.Location = new System.Drawing.Point(824, 12);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 25;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(15, 248);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(79, 13);
            this.RaceLabel.TabIndex = 26;
            this.RaceLabel.Text = "Choose a race:";
            this.RaceLabel.Visible = false;
            // 
            // FinStatButton
            // 
            this.FinStatButton.Location = new System.Drawing.Point(267, 186);
            this.FinStatButton.Name = "FinStatButton";
            this.FinStatButton.Size = new System.Drawing.Size(75, 23);
            this.FinStatButton.TabIndex = 27;
            this.FinStatButton.Text = "Finish Stats";
            this.FinStatButton.UseVisualStyleBackColor = true;
            this.FinStatButton.Visible = false;
            this.FinStatButton.Click += new System.EventHandler(this.FinStatButton_Click);
            // 
            // RaceBox
            // 
            this.RaceBox.FormattingEnabled = true;
            this.RaceBox.Items.AddRange(new object[] {
            "null"});
            this.RaceBox.Location = new System.Drawing.Point(101, 248);
            this.RaceBox.Name = "RaceBox";
            this.RaceBox.Size = new System.Drawing.Size(120, 56);
            this.RaceBox.TabIndex = 28;
            this.RaceBox.Visible = false;
            this.RaceBox.SelectedIndexChanged += new System.EventHandler(this.RaceBox_SelectedIndexChanged);
            // 
            // NewCharacterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.RaceBox);
            this.Controls.Add(this.FinStatButton);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RerollButton);
            this.Controls.Add(this.PointAvailLabel);
            this.Controls.Add(this.PointLabel);
            this.Controls.Add(this.PointButton);
            this.Controls.Add(this.RollLabel);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.GenChoiceInfo);
            this.Controls.Add(this.TotValLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DexLabel);
            this.Controls.Add(this.DexNum);
            this.Controls.Add(this.ConLabel);
            this.Controls.Add(this.ConNum);
            this.Controls.Add(this.IntLabel);
            this.Controls.Add(this.IntNum);
            this.Controls.Add(this.WisLabel);
            this.Controls.Add(this.WisNum);
            this.Controls.Add(this.ChaLabel);
            this.Controls.Add(this.ChaNum);
            this.Controls.Add(this.StrLabel);
            this.Controls.Add(this.StrNum);
            this.Controls.Add(this.panel1);
            this.Name = "NewCharacterMenu";
            this.Text = "NewCharacterMenu";
            this.Load += new System.EventHandler(this.NewCharacterMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StrNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChaNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WisNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown StrNum;
        private System.Windows.Forms.Label StrLabel;
        private System.Windows.Forms.Label ChaLabel;
        private System.Windows.Forms.NumericUpDown ChaNum;
        private System.Windows.Forms.Label WisLabel;
        private System.Windows.Forms.NumericUpDown WisNum;
        private System.Windows.Forms.Label IntLabel;
        private System.Windows.Forms.NumericUpDown IntNum;
        private System.Windows.Forms.Label ConLabel;
        private System.Windows.Forms.NumericUpDown ConNum;
        private System.Windows.Forms.Label DexLabel;
        private System.Windows.Forms.NumericUpDown DexNum;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotValLabel;
        private System.Windows.Forms.Label GenChoiceInfo;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label RollLabel;
        private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Label PointAvailLabel;
        private System.Windows.Forms.Button RerollButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Button FinStatButton;
        private System.Windows.Forms.Label FinalCha;
        private System.Windows.Forms.Label FinalWis;
        private System.Windows.Forms.Label FinalInt;
        private System.Windows.Forms.Label FinalCon;
        private System.Windows.Forms.Label FinalDex;
        private System.Windows.Forms.Label FinalStr;
        private System.Windows.Forms.ListBox RaceBox;
    }
}