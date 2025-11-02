namespace Furfrou.WinForms;

    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
        GB_Connection = new GroupBox();
        TB_Status = new TextBox();
        L_Status = new Label();
        B_Disconnect = new Button();
        B_Connect = new Button();
        L_SwitchIP = new Label();
        TB_SwitchIP = new TextBox();
        GB_SAVInfo = new GroupBox();
        L_SID = new Label();
        L_TID = new Label();
        TB_SID = new TextBox();
        TB_TID = new TextBox();
        B_ReadPlayerB1S1 = new Button();
        B_ReadTrade = new Button();
        B_WritePlayerB1S1 = new Button();
        B_WriteEntireBox = new Button();
        TB_RAM = new TextBox();
        L_Size = new Label();
        TB_IVs = new TextBox();
        L_IVs = new Label();
        TB_Nature = new TextBox();
        L_Nature = new Label();
        TB_OT = new TextBox();
        L_OT = new Label();
        TB_Gender = new TextBox();
        L_Gender = new Label();
        TB_Species = new TextBox();
        L_Species = new Label();
        TB_PID = new TextBox();
        L_PID = new Label();
        TB_EC = new TextBox();
        L_EC = new Label();
        TB_InfoSID = new TextBox();
        L_InfoSID = new Label();
        TB_InfoTID = new TextBox();
        L_InfoTID = new Label();
        TB_PartnerOT = new TextBox();
        L_PartnerOT = new Label();
        T_NID = new TextBox();
        L_NID = new Label();
        TB_PartnerSID = new TextBox();
        L_PartnerSID = new Label();
        TB_PartnerTID = new TextBox();
        L_PartnerTID = new Label();
        B_Save = new Button();
        B_Load = new Button();
        CB_Target = new ComboBox();
        B_Spe_Max = new Button();
        B_Spe_Min = new Button();
        L_Spe = new Label();
        L_SpeSpacer = new Label();
        NUD_Spe_Max = new NumericUpDown();
        NUD_Spe_Min = new NumericUpDown();
        B_SpD_Max = new Button();
        B_SpD_Min = new Button();
        L_SpD = new Label();
        L_SpDSpacer = new Label();
        NUD_SpD_Max = new NumericUpDown();
        NUD_SpD_Min = new NumericUpDown();
        B_SpA_Max = new Button();
        B_SpA_Min = new Button();
        L_SpA = new Label();
        L_SpASpacer = new Label();
        NUD_SpA_Max = new NumericUpDown();
        NUD_SpA_Min = new NumericUpDown();
        B_Def_Max = new Button();
        B_Def_Min = new Button();
        L_Def = new Label();
        L_DefSpacer = new Label();
        NUD_Def_Max = new NumericUpDown();
        NUD_Def_Min = new NumericUpDown();
        B_Atk_Max = new Button();
        B_Atk_Min = new Button();
        L_Atk = new Label();
        L_AtkSpacer = new Label();
        NUD_Atk_Max = new NumericUpDown();
        NUD_Atk_Min = new NumericUpDown();
        B_HP_Max = new Button();
        B_HP_Min = new Button();
        L_HP = new Label();
        L_HPSpacer = new Label();
        NUD_HP_Max = new NumericUpDown();
        NUD_HP_Min = new NumericUpDown();
        L_Target = new Label();
        L_TargetNature = new Label();
        TB_Natures = new TextBox();
        B_Reset = new Button();
        B_ShinyStash = new Button();
        GB_Connection.SuspendLayout();
        GB_SAVInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Spe_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Spe_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpD_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpD_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpA_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpA_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Def_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Def_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Atk_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Atk_Min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_HP_Max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NUD_HP_Min).BeginInit();
        SuspendLayout();
        // 
        // GB_Connection
        // 
        GB_Connection.Controls.Add(TB_Status);
        GB_Connection.Controls.Add(L_Status);
        GB_Connection.Controls.Add(B_Disconnect);
        GB_Connection.Controls.Add(B_Connect);
        GB_Connection.Controls.Add(L_SwitchIP);
        GB_Connection.Controls.Add(TB_SwitchIP);
        GB_Connection.Location = new Point(0, -8);
        GB_Connection.Margin = new Padding(3, 0, 3, 3);
        GB_Connection.Name = "GB_Connection";
        GB_Connection.RightToLeft = RightToLeft.No;
        GB_Connection.Size = new Size(212, 83);
        GB_Connection.TabIndex = 2;
        GB_Connection.TabStop = false;
        // 
        // TB_Status
        // 
        TB_Status.BackColor = SystemColors.Control;
        TB_Status.BorderStyle = BorderStyle.None;
        TB_Status.Location = new Point(74, 64);
        TB_Status.Name = "TB_Status";
        TB_Status.ReadOnly = true;
        TB_Status.RightToLeft = RightToLeft.No;
        TB_Status.Size = new Size(132, 16);
        TB_Status.TabIndex = 18;
        TB_Status.TabStop = false;
        TB_Status.Text = "wwwwwwwwwwwwww";
        TB_Status.TextAlign = HorizontalAlignment.Right;
        // 
        // L_Status
        // 
        L_Status.AutoSize = true;
        L_Status.Location = new Point(11, 64);
        L_Status.Name = "L_Status";
        L_Status.Size = new Size(42, 15);
        L_Status.TabIndex = 17;
        L_Status.Text = "Status:";
        // 
        // B_Disconnect
        // 
        B_Disconnect.Enabled = false;
        B_Disconnect.Location = new Point(109, 36);
        B_Disconnect.Name = "B_Disconnect";
        B_Disconnect.Size = new Size(97, 25);
        B_Disconnect.TabIndex = 2;
        B_Disconnect.Text = "Disconnect";
        B_Disconnect.UseVisualStyleBackColor = true;
        B_Disconnect.Click += B_Disconnect_Click;
        // 
        // B_Connect
        // 
        B_Connect.Location = new Point(11, 36);
        B_Connect.Name = "B_Connect";
        B_Connect.Size = new Size(97, 25);
        B_Connect.TabIndex = 1;
        B_Connect.Text = "Connect";
        B_Connect.UseVisualStyleBackColor = true;
        B_Connect.Click += B_Connect_Click;
        // 
        // L_SwitchIP
        // 
        L_SwitchIP.AutoSize = true;
        L_SwitchIP.Location = new Point(11, 17);
        L_SwitchIP.Name = "L_SwitchIP";
        L_SwitchIP.Size = new Size(58, 15);
        L_SwitchIP.TabIndex = 12;
        L_SwitchIP.Text = "Switch IP:";
        // 
        // TB_SwitchIP
        // 
        TB_SwitchIP.CharacterCasing = CharacterCasing.Lower;
        TB_SwitchIP.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_SwitchIP.Location = new Point(95, 12);
        TB_SwitchIP.MaxLength = 15;
        TB_SwitchIP.Name = "TB_SwitchIP";
        TB_SwitchIP.Size = new Size(111, 22);
        TB_SwitchIP.TabIndex = 0;
        TB_SwitchIP.Text = "123.123.123.123";
        TB_SwitchIP.TextChanged += TB_SwitchIP_TextChanged;
        // 
        // GB_SAVInfo
        // 
        GB_SAVInfo.Controls.Add(L_SID);
        GB_SAVInfo.Controls.Add(L_TID);
        GB_SAVInfo.Controls.Add(TB_SID);
        GB_SAVInfo.Controls.Add(TB_TID);
        GB_SAVInfo.Location = new Point(0, 65);
        GB_SAVInfo.Name = "GB_SAVInfo";
        GB_SAVInfo.Size = new Size(212, 48);
        GB_SAVInfo.TabIndex = 4;
        GB_SAVInfo.TabStop = false;
        // 
        // L_SID
        // 
        L_SID.AutoSize = true;
        L_SID.Location = new Point(132, 18);
        L_SID.Name = "L_SID";
        L_SID.Size = new Size(27, 15);
        L_SID.TabIndex = 20;
        L_SID.Text = "SID:";
        // 
        // L_TID
        // 
        L_TID.AutoSize = true;
        L_TID.Location = new Point(25, 18);
        L_TID.Name = "L_TID";
        L_TID.Size = new Size(27, 15);
        L_TID.TabIndex = 19;
        L_TID.Text = "TID:";
        // 
        // TB_SID
        // 
        TB_SID.CharacterCasing = CharacterCasing.Upper;
        TB_SID.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_SID.Location = new Point(165, 16);
        TB_SID.MaxLength = 5;
        TB_SID.Name = "TB_SID";
        TB_SID.Size = new Size(41, 22);
        TB_SID.TabIndex = 3;
        TB_SID.Text = "54321";
        TB_SID.TextChanged += TB_SID_TextChanged;
        // 
        // TB_TID
        // 
        TB_TID.CharacterCasing = CharacterCasing.Upper;
        TB_TID.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TB_TID.Location = new Point(71, 16);
        TB_TID.MaxLength = 5;
        TB_TID.Name = "TB_TID";
        TB_TID.Size = new Size(41, 22);
        TB_TID.TabIndex = 2;
        TB_TID.Text = "12345";
        TB_TID.TextChanged += TB_TID_TextChanged;
        // 
        // B_ReadPlayerB1S1
        // 
        B_ReadPlayerB1S1.Location = new Point(218, 4);
        B_ReadPlayerB1S1.Name = "B_ReadPlayerB1S1";
        B_ReadPlayerB1S1.Size = new Size(200, 25);
        B_ReadPlayerB1S1.TabIndex = 5;
        B_ReadPlayerB1S1.Text = "Read Player B1S1 to Data";
        B_ReadPlayerB1S1.UseVisualStyleBackColor = true;
        B_ReadPlayerB1S1.Click += B_ReadPlayerB1S1_Click;
        // 
        // B_ReadTrade
        // 
        B_ReadTrade.Location = new Point(218, 31);
        B_ReadTrade.Name = "B_ReadTrade";
        B_ReadTrade.Size = new Size(200, 25);
        B_ReadTrade.TabIndex = 7;
        B_ReadTrade.Text = "Read Trade Pokémon to Data";
        B_ReadTrade.UseVisualStyleBackColor = true;
        B_ReadTrade.Click += B_ReadTrade_Click;
        // 
        // B_WritePlayerB1S1
        // 
        B_WritePlayerB1S1.Location = new Point(218, 62);
        B_WritePlayerB1S1.Name = "B_WritePlayerB1S1";
        B_WritePlayerB1S1.Size = new Size(200, 25);
        B_WritePlayerB1S1.TabIndex = 8;
        B_WritePlayerB1S1.Text = "Write Data to Player B1S1";
        B_WritePlayerB1S1.UseVisualStyleBackColor = true;
        B_WritePlayerB1S1.Click += B_WritePlayerB1S1_Click;
        // 
        // B_WriteEntireBox
        // 
        B_WriteEntireBox.Location = new Point(218, 89);
        B_WriteEntireBox.Name = "B_WriteEntireBox";
        B_WriteEntireBox.Size = new Size(200, 25);
        B_WriteEntireBox.TabIndex = 9;
        B_WriteEntireBox.Text = "Write Data to Entire Box 1";
        B_WriteEntireBox.UseVisualStyleBackColor = true;
        B_WriteEntireBox.Click += B_WriteEntireBox_Click;
        // 
        // TB_RAM
        // 
        TB_RAM.BackColor = Color.FromArgb(49, 51, 56);
        TB_RAM.BorderStyle = BorderStyle.FixedSingle;
        TB_RAM.Font = new Font("Consolas", 9F);
        TB_RAM.ForeColor = Color.FromArgb(255, 128, 128);
        TB_RAM.Location = new Point(424, 5);
        TB_RAM.Multiline = true;
        TB_RAM.Name = "TB_RAM";
        TB_RAM.ScrollBars = ScrollBars.Horizontal;
        TB_RAM.Size = new Size(342, 342);
        TB_RAM.TabIndex = 10;
        TB_RAM.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
        TB_RAM.TextChanged += TB_RAM_TextChanged;
        // 
        // L_Size
        // 
        L_Size.AutoSize = true;
        L_Size.Location = new Point(424, 350);
        L_Size.Name = "L_Size";
        L_Size.Size = new Size(33, 15);
        L_Size.TabIndex = 11;
        L_Size.Text = "Size: ";
        // 
        // TB_IVs
        // 
        TB_IVs.Font = new Font("Consolas", 9F);
        TB_IVs.Location = new Point(147, 259);
        TB_IVs.Margin = new Padding(4, 3, 4, 3);
        TB_IVs.Name = "TB_IVs";
        TB_IVs.ReadOnly = true;
        TB_IVs.Size = new Size(271, 22);
        TB_IVs.TabIndex = 122;
        // 
        // L_IVs
        // 
        L_IVs.AutoSize = true;
        L_IVs.Location = new Point(115, 261);
        L_IVs.Name = "L_IVs";
        L_IVs.Size = new Size(25, 15);
        L_IVs.TabIndex = 121;
        L_IVs.Text = "IVs:";
        L_IVs.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_Nature
        // 
        TB_Nature.Font = new Font("Consolas", 9F);
        TB_Nature.Location = new Point(321, 287);
        TB_Nature.Margin = new Padding(4, 3, 4, 3);
        TB_Nature.Name = "TB_Nature";
        TB_Nature.ReadOnly = true;
        TB_Nature.Size = new Size(97, 22);
        TB_Nature.TabIndex = 116;
        // 
        // L_Nature
        // 
        L_Nature.AutoSize = true;
        L_Nature.Location = new Point(268, 294);
        L_Nature.Name = "L_Nature";
        L_Nature.Size = new Size(46, 15);
        L_Nature.TabIndex = 115;
        L_Nature.Text = "Nature:";
        L_Nature.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_OT
        // 
        TB_OT.Font = new Font("Consolas", 9F);
        TB_OT.Location = new Point(147, 343);
        TB_OT.Margin = new Padding(4, 3, 4, 3);
        TB_OT.Name = "TB_OT";
        TB_OT.ReadOnly = true;
        TB_OT.Size = new Size(271, 22);
        TB_OT.TabIndex = 114;
        // 
        // L_OT
        // 
        L_OT.AutoSize = true;
        L_OT.Location = new Point(116, 345);
        L_OT.Name = "L_OT";
        L_OT.Size = new Size(24, 15);
        L_OT.TabIndex = 113;
        L_OT.Text = "OT:";
        L_OT.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_Gender
        // 
        TB_Gender.Font = new Font("Consolas", 9F);
        TB_Gender.Location = new Point(147, 287);
        TB_Gender.Margin = new Padding(4, 3, 4, 3);
        TB_Gender.Name = "TB_Gender";
        TB_Gender.ReadOnly = true;
        TB_Gender.Size = new Size(95, 22);
        TB_Gender.TabIndex = 112;
        // 
        // L_Gender
        // 
        L_Gender.AutoSize = true;
        L_Gender.Location = new Point(92, 289);
        L_Gender.Name = "L_Gender";
        L_Gender.Size = new Size(48, 15);
        L_Gender.TabIndex = 111;
        L_Gender.Text = "Gender:";
        L_Gender.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_Species
        // 
        TB_Species.Font = new Font("Consolas", 9F);
        TB_Species.Location = new Point(147, 231);
        TB_Species.Margin = new Padding(4, 3, 4, 3);
        TB_Species.Name = "TB_Species";
        TB_Species.ReadOnly = true;
        TB_Species.Size = new Size(271, 22);
        TB_Species.TabIndex = 124;
        // 
        // L_Species
        // 
        L_Species.AutoSize = true;
        L_Species.Location = new Point(91, 233);
        L_Species.Name = "L_Species";
        L_Species.Size = new Size(49, 15);
        L_Species.TabIndex = 123;
        L_Species.Text = "Species:";
        L_Species.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_PID
        // 
        TB_PID.Font = new Font("Consolas", 9F);
        TB_PID.Location = new Point(321, 203);
        TB_PID.Margin = new Padding(4, 3, 4, 3);
        TB_PID.Name = "TB_PID";
        TB_PID.ReadOnly = true;
        TB_PID.Size = new Size(97, 22);
        TB_PID.TabIndex = 128;
        // 
        // L_PID
        // 
        L_PID.AutoSize = true;
        L_PID.Location = new Point(286, 205);
        L_PID.Name = "L_PID";
        L_PID.Size = new Size(28, 15);
        L_PID.TabIndex = 127;
        L_PID.Text = "PID:";
        L_PID.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_EC
        // 
        TB_EC.Font = new Font("Consolas", 9F);
        TB_EC.Location = new Point(147, 203);
        TB_EC.Margin = new Padding(4, 3, 4, 3);
        TB_EC.Name = "TB_EC";
        TB_EC.ReadOnly = true;
        TB_EC.Size = new Size(95, 22);
        TB_EC.TabIndex = 126;
        // 
        // L_EC
        // 
        L_EC.AutoSize = true;
        L_EC.Location = new Point(116, 205);
        L_EC.Name = "L_EC";
        L_EC.Size = new Size(24, 15);
        L_EC.TabIndex = 125;
        L_EC.Text = "EC:";
        L_EC.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_InfoSID
        // 
        TB_InfoSID.Font = new Font("Consolas", 9F);
        TB_InfoSID.Location = new Point(321, 315);
        TB_InfoSID.Margin = new Padding(4, 3, 4, 3);
        TB_InfoSID.Name = "TB_InfoSID";
        TB_InfoSID.ReadOnly = true;
        TB_InfoSID.Size = new Size(97, 22);
        TB_InfoSID.TabIndex = 120;
        // 
        // L_InfoSID
        // 
        L_InfoSID.AutoSize = true;
        L_InfoSID.Location = new Point(287, 317);
        L_InfoSID.Name = "L_InfoSID";
        L_InfoSID.Size = new Size(27, 15);
        L_InfoSID.TabIndex = 119;
        L_InfoSID.Text = "SID:";
        L_InfoSID.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_InfoTID
        // 
        TB_InfoTID.Font = new Font("Consolas", 9F);
        TB_InfoTID.Location = new Point(147, 315);
        TB_InfoTID.Margin = new Padding(4, 3, 4, 3);
        TB_InfoTID.Name = "TB_InfoTID";
        TB_InfoTID.ReadOnly = true;
        TB_InfoTID.Size = new Size(95, 22);
        TB_InfoTID.TabIndex = 118;
        // 
        // L_InfoTID
        // 
        L_InfoTID.AutoSize = true;
        L_InfoTID.Location = new Point(113, 317);
        L_InfoTID.Name = "L_InfoTID";
        L_InfoTID.Size = new Size(27, 15);
        L_InfoTID.TabIndex = 117;
        L_InfoTID.Text = "TID:";
        L_InfoTID.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_PartnerOT
        // 
        TB_PartnerOT.Font = new Font("Consolas", 9F);
        TB_PartnerOT.Location = new Point(146, 119);
        TB_PartnerOT.Margin = new Padding(4, 3, 4, 3);
        TB_PartnerOT.Name = "TB_PartnerOT";
        TB_PartnerOT.ReadOnly = true;
        TB_PartnerOT.Size = new Size(272, 22);
        TB_PartnerOT.TabIndex = 130;
        // 
        // L_PartnerOT
        // 
        L_PartnerOT.AutoSize = true;
        L_PartnerOT.Location = new Point(43, 121);
        L_PartnerOT.Name = "L_PartnerOT";
        L_PartnerOT.Size = new Size(96, 15);
        L_PartnerOT.TabIndex = 129;
        L_PartnerOT.Text = "Trade Partner OT:";
        L_PartnerOT.TextAlign = ContentAlignment.MiddleRight;
        // 
        // T_NID
        // 
        T_NID.Font = new Font("Consolas", 9F);
        T_NID.Location = new Point(146, 147);
        T_NID.Margin = new Padding(4, 3, 4, 3);
        T_NID.Name = "T_NID";
        T_NID.ReadOnly = true;
        T_NID.Size = new Size(272, 22);
        T_NID.TabIndex = 132;
        // 
        // L_NID
        // 
        L_NID.AutoSize = true;
        L_NID.Location = new Point(37, 149);
        L_NID.Name = "L_NID";
        L_NID.Size = new Size(102, 15);
        L_NID.TabIndex = 131;
        L_NID.Text = "Trade Partner NID:";
        L_NID.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_PartnerSID
        // 
        TB_PartnerSID.Font = new Font("Consolas", 9F);
        TB_PartnerSID.Location = new Point(321, 175);
        TB_PartnerSID.Margin = new Padding(4, 3, 4, 3);
        TB_PartnerSID.Name = "TB_PartnerSID";
        TB_PartnerSID.ReadOnly = true;
        TB_PartnerSID.Size = new Size(97, 22);
        TB_PartnerSID.TabIndex = 136;
        // 
        // L_PartnerSID
        // 
        L_PartnerSID.AutoSize = true;
        L_PartnerSID.Location = new Point(252, 177);
        L_PartnerSID.Name = "L_PartnerSID";
        L_PartnerSID.Size = new Size(62, 15);
        L_PartnerSID.TabIndex = 135;
        L_PartnerSID.Text = "Trader SID:";
        L_PartnerSID.TextAlign = ContentAlignment.MiddleRight;
        // 
        // TB_PartnerTID
        // 
        TB_PartnerTID.Font = new Font("Consolas", 9F);
        TB_PartnerTID.Location = new Point(147, 175);
        TB_PartnerTID.Margin = new Padding(4, 3, 4, 3);
        TB_PartnerTID.Name = "TB_PartnerTID";
        TB_PartnerTID.ReadOnly = true;
        TB_PartnerTID.Size = new Size(95, 22);
        TB_PartnerTID.TabIndex = 134;
        // 
        // L_PartnerTID
        // 
        L_PartnerTID.AutoSize = true;
        L_PartnerTID.Location = new Point(77, 177);
        L_PartnerTID.Name = "L_PartnerTID";
        L_PartnerTID.Size = new Size(62, 15);
        L_PartnerTID.TabIndex = 133;
        L_PartnerTID.Text = "Trader TID:";
        L_PartnerTID.TextAlign = ContentAlignment.MiddleRight;
        // 
        // B_Save
        // 
        B_Save.Location = new Point(11, 312);
        B_Save.Name = "B_Save";
        B_Save.Size = new Size(75, 25);
        B_Save.TabIndex = 137;
        B_Save.Text = "Save Bytes";
        B_Save.UseVisualStyleBackColor = true;
        B_Save.Click += B_Save_Click;
        // 
        // B_Load
        // 
        B_Load.Location = new Point(11, 340);
        B_Load.Name = "B_Load";
        B_Load.Size = new Size(75, 25);
        B_Load.TabIndex = 138;
        B_Load.Text = "Load File";
        B_Load.UseVisualStyleBackColor = true;
        B_Load.Click += B_Load_Click;
        // 
        // CB_Target
        // 
        CB_Target.FormattingEnabled = true;
        CB_Target.Items.AddRange(new object[] { "Xerneas", "Yveltal", "Zygarde" });
        CB_Target.Location = new Point(834, 6);
        CB_Target.Name = "CB_Target";
        CB_Target.Size = new Size(138, 23);
        CB_Target.TabIndex = 139;
        // 
        // B_Spe_Max
        // 
        B_Spe_Max.Location = new Point(945, 189);
        B_Spe_Max.Name = "B_Spe_Max";
        B_Spe_Max.Size = new Size(27, 25);
        B_Spe_Max.TabIndex = 164;
        B_Spe_Max.Text = "31";
        B_Spe_Max.UseVisualStyleBackColor = true;
        B_Spe_Max.Click += B_IV_Max_Click;
        // 
        // B_Spe_Min
        // 
        B_Spe_Min.Location = new Point(916, 189);
        B_Spe_Min.Name = "B_Spe_Min";
        B_Spe_Min.Size = new Size(27, 25);
        B_Spe_Min.TabIndex = 163;
        B_Spe_Min.Text = "0";
        B_Spe_Min.UseVisualStyleBackColor = true;
        B_Spe_Min.Click += B_IV_Min_Click;
        // 
        // L_Spe
        // 
        L_Spe.AutoSize = true;
        L_Spe.Location = new Point(772, 192);
        L_Spe.Name = "L_Spe";
        L_Spe.Size = new Size(29, 15);
        L_Spe.TabIndex = 176;
        L_Spe.Text = "Spe:";
        L_Spe.Click += IV_Label_Click;
        // 
        // L_SpeSpacer
        // 
        L_SpeSpacer.AutoSize = true;
        L_SpeSpacer.Location = new Point(867, 192);
        L_SpeSpacer.Name = "L_SpeSpacer";
        L_SpeSpacer.Size = new Size(12, 15);
        L_SpeSpacer.TabIndex = 171;
        L_SpeSpacer.Text = "-";
        // 
        // NUD_Spe_Max
        // 
        NUD_Spe_Max.Location = new Point(879, 190);
        NUD_Spe_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Spe_Max.Name = "NUD_Spe_Max";
        NUD_Spe_Max.Size = new Size(32, 23);
        NUD_Spe_Max.TabIndex = 152;
        NUD_Spe_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_Spe_Min
        // 
        NUD_Spe_Min.Location = new Point(834, 190);
        NUD_Spe_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Spe_Min.Name = "NUD_Spe_Min";
        NUD_Spe_Min.Size = new Size(32, 23);
        NUD_Spe_Min.TabIndex = 151;
        // 
        // B_SpD_Max
        // 
        B_SpD_Max.Location = new Point(945, 164);
        B_SpD_Max.Name = "B_SpD_Max";
        B_SpD_Max.Size = new Size(27, 25);
        B_SpD_Max.TabIndex = 162;
        B_SpD_Max.Text = "31";
        B_SpD_Max.UseVisualStyleBackColor = true;
        B_SpD_Max.Click += B_IV_Max_Click;
        // 
        // B_SpD_Min
        // 
        B_SpD_Min.Location = new Point(916, 164);
        B_SpD_Min.Name = "B_SpD_Min";
        B_SpD_Min.Size = new Size(27, 25);
        B_SpD_Min.TabIndex = 161;
        B_SpD_Min.Text = "0";
        B_SpD_Min.UseVisualStyleBackColor = true;
        B_SpD_Min.Click += B_IV_Min_Click;
        // 
        // L_SpD
        // 
        L_SpD.AutoSize = true;
        L_SpD.Location = new Point(772, 167);
        L_SpD.Name = "L_SpD";
        L_SpD.Size = new Size(31, 15);
        L_SpD.TabIndex = 175;
        L_SpD.Text = "SpD:";
        L_SpD.Click += IV_Label_Click;
        // 
        // L_SpDSpacer
        // 
        L_SpDSpacer.AutoSize = true;
        L_SpDSpacer.Location = new Point(867, 167);
        L_SpDSpacer.Name = "L_SpDSpacer";
        L_SpDSpacer.Size = new Size(12, 15);
        L_SpDSpacer.TabIndex = 170;
        L_SpDSpacer.Text = "-";
        // 
        // NUD_SpD_Max
        // 
        NUD_SpD_Max.Location = new Point(879, 165);
        NUD_SpD_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpD_Max.Name = "NUD_SpD_Max";
        NUD_SpD_Max.Size = new Size(32, 23);
        NUD_SpD_Max.TabIndex = 150;
        NUD_SpD_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_SpD_Min
        // 
        NUD_SpD_Min.Location = new Point(834, 165);
        NUD_SpD_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpD_Min.Name = "NUD_SpD_Min";
        NUD_SpD_Min.Size = new Size(32, 23);
        NUD_SpD_Min.TabIndex = 149;
        // 
        // B_SpA_Max
        // 
        B_SpA_Max.Location = new Point(945, 139);
        B_SpA_Max.Name = "B_SpA_Max";
        B_SpA_Max.Size = new Size(27, 25);
        B_SpA_Max.TabIndex = 160;
        B_SpA_Max.Text = "31";
        B_SpA_Max.UseVisualStyleBackColor = true;
        B_SpA_Max.Click += B_IV_Max_Click;
        // 
        // B_SpA_Min
        // 
        B_SpA_Min.Location = new Point(916, 139);
        B_SpA_Min.Name = "B_SpA_Min";
        B_SpA_Min.Size = new Size(27, 25);
        B_SpA_Min.TabIndex = 159;
        B_SpA_Min.Text = "0";
        B_SpA_Min.UseVisualStyleBackColor = true;
        B_SpA_Min.Click += B_IV_Min_Click;
        // 
        // L_SpA
        // 
        L_SpA.AutoSize = true;
        L_SpA.Location = new Point(772, 142);
        L_SpA.Name = "L_SpA";
        L_SpA.Size = new Size(31, 15);
        L_SpA.TabIndex = 174;
        L_SpA.Text = "SpA:";
        L_SpA.Click += IV_Label_Click;
        // 
        // L_SpASpacer
        // 
        L_SpASpacer.AutoSize = true;
        L_SpASpacer.Location = new Point(867, 142);
        L_SpASpacer.Name = "L_SpASpacer";
        L_SpASpacer.Size = new Size(12, 15);
        L_SpASpacer.TabIndex = 169;
        L_SpASpacer.Text = "-";
        // 
        // NUD_SpA_Max
        // 
        NUD_SpA_Max.Location = new Point(879, 140);
        NUD_SpA_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpA_Max.Name = "NUD_SpA_Max";
        NUD_SpA_Max.Size = new Size(32, 23);
        NUD_SpA_Max.TabIndex = 148;
        NUD_SpA_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_SpA_Min
        // 
        NUD_SpA_Min.Location = new Point(834, 140);
        NUD_SpA_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_SpA_Min.Name = "NUD_SpA_Min";
        NUD_SpA_Min.Size = new Size(32, 23);
        NUD_SpA_Min.TabIndex = 147;
        // 
        // B_Def_Max
        // 
        B_Def_Max.Location = new Point(945, 114);
        B_Def_Max.Name = "B_Def_Max";
        B_Def_Max.Size = new Size(27, 25);
        B_Def_Max.TabIndex = 158;
        B_Def_Max.Text = "31";
        B_Def_Max.UseVisualStyleBackColor = true;
        B_Def_Max.Click += B_IV_Max_Click;
        // 
        // B_Def_Min
        // 
        B_Def_Min.Location = new Point(916, 114);
        B_Def_Min.Name = "B_Def_Min";
        B_Def_Min.Size = new Size(27, 25);
        B_Def_Min.TabIndex = 157;
        B_Def_Min.Text = "0";
        B_Def_Min.UseVisualStyleBackColor = true;
        B_Def_Min.Click += B_IV_Min_Click;
        // 
        // L_Def
        // 
        L_Def.AutoSize = true;
        L_Def.Location = new Point(772, 117);
        L_Def.Name = "L_Def";
        L_Def.Size = new Size(28, 15);
        L_Def.TabIndex = 173;
        L_Def.Text = "Def:";
        L_Def.Click += IV_Label_Click;
        // 
        // L_DefSpacer
        // 
        L_DefSpacer.AutoSize = true;
        L_DefSpacer.Location = new Point(867, 117);
        L_DefSpacer.Name = "L_DefSpacer";
        L_DefSpacer.Size = new Size(12, 15);
        L_DefSpacer.TabIndex = 166;
        L_DefSpacer.Text = "-";
        // 
        // NUD_Def_Max
        // 
        NUD_Def_Max.Location = new Point(879, 115);
        NUD_Def_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Def_Max.Name = "NUD_Def_Max";
        NUD_Def_Max.Size = new Size(32, 23);
        NUD_Def_Max.TabIndex = 146;
        NUD_Def_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_Def_Min
        // 
        NUD_Def_Min.Location = new Point(834, 115);
        NUD_Def_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Def_Min.Name = "NUD_Def_Min";
        NUD_Def_Min.Size = new Size(32, 23);
        NUD_Def_Min.TabIndex = 145;
        // 
        // B_Atk_Max
        // 
        B_Atk_Max.Location = new Point(945, 89);
        B_Atk_Max.Name = "B_Atk_Max";
        B_Atk_Max.Size = new Size(27, 25);
        B_Atk_Max.TabIndex = 156;
        B_Atk_Max.Text = "31";
        B_Atk_Max.UseVisualStyleBackColor = true;
        B_Atk_Max.Click += B_IV_Max_Click;
        // 
        // B_Atk_Min
        // 
        B_Atk_Min.Location = new Point(916, 89);
        B_Atk_Min.Name = "B_Atk_Min";
        B_Atk_Min.Size = new Size(27, 25);
        B_Atk_Min.TabIndex = 155;
        B_Atk_Min.Text = "0";
        B_Atk_Min.UseVisualStyleBackColor = true;
        B_Atk_Min.Click += B_IV_Min_Click;
        // 
        // L_Atk
        // 
        L_Atk.AutoSize = true;
        L_Atk.Location = new Point(772, 92);
        L_Atk.Name = "L_Atk";
        L_Atk.Size = new Size(28, 15);
        L_Atk.TabIndex = 172;
        L_Atk.Text = "Atk:";
        L_Atk.Click += IV_Label_Click;
        // 
        // L_AtkSpacer
        // 
        L_AtkSpacer.AutoSize = true;
        L_AtkSpacer.Location = new Point(867, 92);
        L_AtkSpacer.Name = "L_AtkSpacer";
        L_AtkSpacer.Size = new Size(12, 15);
        L_AtkSpacer.TabIndex = 165;
        L_AtkSpacer.Text = "-";
        // 
        // NUD_Atk_Max
        // 
        NUD_Atk_Max.Location = new Point(879, 90);
        NUD_Atk_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Atk_Max.Name = "NUD_Atk_Max";
        NUD_Atk_Max.Size = new Size(32, 23);
        NUD_Atk_Max.TabIndex = 144;
        NUD_Atk_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_Atk_Min
        // 
        NUD_Atk_Min.Location = new Point(834, 90);
        NUD_Atk_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_Atk_Min.Name = "NUD_Atk_Min";
        NUD_Atk_Min.Size = new Size(32, 23);
        NUD_Atk_Min.TabIndex = 143;
        // 
        // B_HP_Max
        // 
        B_HP_Max.Location = new Point(945, 64);
        B_HP_Max.Name = "B_HP_Max";
        B_HP_Max.Size = new Size(27, 25);
        B_HP_Max.TabIndex = 154;
        B_HP_Max.Text = "31";
        B_HP_Max.UseVisualStyleBackColor = true;
        B_HP_Max.Click += B_IV_Max_Click;
        // 
        // B_HP_Min
        // 
        B_HP_Min.Location = new Point(916, 64);
        B_HP_Min.Name = "B_HP_Min";
        B_HP_Min.Size = new Size(27, 25);
        B_HP_Min.TabIndex = 153;
        B_HP_Min.Text = "0";
        B_HP_Min.UseVisualStyleBackColor = true;
        B_HP_Min.Click += B_IV_Min_Click;
        // 
        // L_HP
        // 
        L_HP.AutoSize = true;
        L_HP.Location = new Point(772, 67);
        L_HP.Name = "L_HP";
        L_HP.Size = new Size(26, 15);
        L_HP.TabIndex = 168;
        L_HP.Text = "HP:";
        L_HP.Click += IV_Label_Click;
        // 
        // L_HPSpacer
        // 
        L_HPSpacer.AutoSize = true;
        L_HPSpacer.Location = new Point(867, 67);
        L_HPSpacer.Name = "L_HPSpacer";
        L_HPSpacer.Size = new Size(12, 15);
        L_HPSpacer.TabIndex = 167;
        L_HPSpacer.Text = "-";
        // 
        // NUD_HP_Max
        // 
        NUD_HP_Max.Location = new Point(879, 65);
        NUD_HP_Max.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_HP_Max.Name = "NUD_HP_Max";
        NUD_HP_Max.Size = new Size(32, 23);
        NUD_HP_Max.TabIndex = 142;
        NUD_HP_Max.Value = new decimal(new int[] { 31, 0, 0, 0 });
        // 
        // NUD_HP_Min
        // 
        NUD_HP_Min.Location = new Point(834, 65);
        NUD_HP_Min.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
        NUD_HP_Min.Name = "NUD_HP_Min";
        NUD_HP_Min.Size = new Size(32, 23);
        NUD_HP_Min.TabIndex = 141;
        // 
        // L_Target
        // 
        L_Target.AutoSize = true;
        L_Target.Location = new Point(772, 9);
        L_Target.Name = "L_Target";
        L_Target.Size = new Size(42, 15);
        L_Target.TabIndex = 177;
        L_Target.Text = "Target:";
        // 
        // L_TargetNature
        // 
        L_TargetNature.AutoSize = true;
        L_TargetNature.Location = new Point(772, 36);
        L_TargetNature.Name = "L_TargetNature";
        L_TargetNature.Size = new Size(59, 15);
        L_TargetNature.TabIndex = 178;
        L_TargetNature.Text = "Nature(s):";
        // 
        // TB_Natures
        // 
        TB_Natures.Location = new Point(834, 33);
        TB_Natures.Name = "TB_Natures";
        TB_Natures.Size = new Size(138, 23);
        TB_Natures.TabIndex = 179;
        // 
        // B_Reset
        // 
        B_Reset.Location = new Point(772, 219);
        B_Reset.Name = "B_Reset";
        B_Reset.Size = new Size(200, 25);
        B_Reset.TabIndex = 180;
        B_Reset.Text = "Reset Encounter";
        B_Reset.UseVisualStyleBackColor = true;
        B_Reset.Click += B_Reset_Click;
        // 
        // B_ShinyStash
        // 
        B_ShinyStash.Location = new Point(772, 250);
        B_ShinyStash.Name = "B_ShinyStash";
        B_ShinyStash.Size = new Size(200, 25);
        B_ShinyStash.TabIndex = 181;
        B_ShinyStash.Text = "Read Shiny Stash";
        B_ShinyStash.UseVisualStyleBackColor = true;
        B_ShinyStash.Click += B_ShinyStash_Click;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(978, 370);
        Controls.Add(B_ShinyStash);
        Controls.Add(B_Reset);
        Controls.Add(TB_Natures);
        Controls.Add(L_TargetNature);
        Controls.Add(L_Target);
        Controls.Add(B_Spe_Max);
        Controls.Add(B_Spe_Min);
        Controls.Add(L_Spe);
        Controls.Add(L_SpeSpacer);
        Controls.Add(NUD_Spe_Max);
        Controls.Add(NUD_Spe_Min);
        Controls.Add(B_SpD_Max);
        Controls.Add(B_SpD_Min);
        Controls.Add(L_SpD);
        Controls.Add(L_SpDSpacer);
        Controls.Add(NUD_SpD_Max);
        Controls.Add(NUD_SpD_Min);
        Controls.Add(B_SpA_Max);
        Controls.Add(B_SpA_Min);
        Controls.Add(L_SpA);
        Controls.Add(L_SpASpacer);
        Controls.Add(NUD_SpA_Max);
        Controls.Add(NUD_SpA_Min);
        Controls.Add(B_Def_Max);
        Controls.Add(B_Def_Min);
        Controls.Add(L_Def);
        Controls.Add(L_DefSpacer);
        Controls.Add(NUD_Def_Max);
        Controls.Add(NUD_Def_Min);
        Controls.Add(B_Atk_Max);
        Controls.Add(B_Atk_Min);
        Controls.Add(L_Atk);
        Controls.Add(L_AtkSpacer);
        Controls.Add(NUD_Atk_Max);
        Controls.Add(NUD_Atk_Min);
        Controls.Add(B_HP_Max);
        Controls.Add(B_HP_Min);
        Controls.Add(L_HP);
        Controls.Add(L_HPSpacer);
        Controls.Add(NUD_HP_Max);
        Controls.Add(NUD_HP_Min);
        Controls.Add(CB_Target);
        Controls.Add(B_Load);
        Controls.Add(B_Save);
        Controls.Add(TB_PartnerSID);
        Controls.Add(L_PartnerSID);
        Controls.Add(TB_PartnerTID);
        Controls.Add(L_PartnerTID);
        Controls.Add(T_NID);
        Controls.Add(L_NID);
        Controls.Add(TB_PartnerOT);
        Controls.Add(L_PartnerOT);
        Controls.Add(TB_PID);
        Controls.Add(L_PID);
        Controls.Add(TB_EC);
        Controls.Add(L_EC);
        Controls.Add(TB_Species);
        Controls.Add(L_Species);
        Controls.Add(TB_IVs);
        Controls.Add(L_IVs);
        Controls.Add(TB_InfoSID);
        Controls.Add(L_InfoSID);
        Controls.Add(TB_InfoTID);
        Controls.Add(L_InfoTID);
        Controls.Add(TB_Nature);
        Controls.Add(L_Nature);
        Controls.Add(TB_OT);
        Controls.Add(L_OT);
        Controls.Add(TB_Gender);
        Controls.Add(L_Gender);
        Controls.Add(L_Size);
        Controls.Add(TB_RAM);
        Controls.Add(B_WriteEntireBox);
        Controls.Add(B_WritePlayerB1S1);
        Controls.Add(B_ReadTrade);
        Controls.Add(B_ReadPlayerB1S1);
        Controls.Add(GB_Connection);
        Controls.Add(GB_SAVInfo);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MainWindow";
        FormClosing += MainWindow_FormClosing;
        Load += MainWindow_Load;
        GB_Connection.ResumeLayout(false);
        GB_Connection.PerformLayout();
        GB_SAVInfo.ResumeLayout(false);
        GB_SAVInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NUD_Spe_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Spe_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpD_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpD_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpA_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_SpA_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Def_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Def_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Atk_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_Atk_Min).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_HP_Max).EndInit();
        ((System.ComponentModel.ISupportInitialize)NUD_HP_Min).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox GB_Connection;
    private TextBox TB_Status;
    private Label L_Status;
    private Button B_Disconnect;
    private Button B_Connect;
    private Label L_SwitchIP;
    private TextBox TB_SwitchIP;
    private GroupBox GB_SAVInfo;
    private Label L_SID;
    private Label L_TID;
    public TextBox TB_SID;
    public TextBox TB_TID;
    private Button B_ReadPlayerB1S1;
    private Button B_ReadTrade;
    private Button B_WritePlayerB1S1;
    private Button B_WriteEntireBox;
    private TextBox TB_RAM;
    private Label L_Size;
    private TextBox TB_IVs;
    private Label L_IVs;
    private TextBox TB_Nature;
    private Label L_Nature;
    private TextBox TB_OT;
    private Label L_OT;
    private TextBox TB_Gender;
    private Label L_Gender;
    private TextBox TB_Species;
    private Label L_Species;
    private TextBox TB_PID;
    private Label L_PID;
    private TextBox TB_EC;
    private Label L_EC;
    private TextBox TB_InfoSID;
    private Label L_InfoSID;
    private TextBox TB_InfoTID;
    private Label L_InfoTID;
    private TextBox TB_PartnerOT;
    private Label L_PartnerOT;
    private TextBox T_NID;
    private Label L_NID;
    private TextBox TB_PartnerSID;
    private Label L_PartnerSID;
    private TextBox TB_PartnerTID;
    private Label L_PartnerTID;
    private Button B_Save;
    private Button B_Load;
    private ComboBox CB_Target;
    private Button B_Spe_Max;
    private Button B_Spe_Min;
    private Label L_Spe;
    private Label L_SpeSpacer;
    private NumericUpDown NUD_Spe_Max;
    private NumericUpDown NUD_Spe_Min;
    private Button B_SpD_Max;
    private Button B_SpD_Min;
    private Label L_SpD;
    private Label L_SpDSpacer;
    private NumericUpDown NUD_SpD_Max;
    private NumericUpDown NUD_SpD_Min;
    private Button B_SpA_Max;
    private Button B_SpA_Min;
    private Label L_SpA;
    private Label L_SpASpacer;
    private NumericUpDown NUD_SpA_Max;
    private NumericUpDown NUD_SpA_Min;
    private Button B_Def_Max;
    private Button B_Def_Min;
    private Label L_Def;
    private Label L_DefSpacer;
    private NumericUpDown NUD_Def_Max;
    private NumericUpDown NUD_Def_Min;
    private Button B_Atk_Max;
    private Button B_Atk_Min;
    private Label L_Atk;
    private Label L_AtkSpacer;
    private NumericUpDown NUD_Atk_Max;
    private NumericUpDown NUD_Atk_Min;
    private Button B_HP_Max;
    private Button B_HP_Min;
    private Label L_HP;
    private Label L_HPSpacer;
    private NumericUpDown NUD_HP_Max;
    private NumericUpDown NUD_HP_Min;
    private Label L_Target;
    private Label L_TargetNature;
    private TextBox TB_Natures;
    private Button B_Reset;
    private Button B_ShinyStash;
}

