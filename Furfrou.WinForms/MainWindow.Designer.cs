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
        components = new System.ComponentModel.Container();
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
        ResultsSource = new BindingSource(components);
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
        GB_Connection.SuspendLayout();
        GB_SAVInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ResultsSource).BeginInit();
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
        // 
        // ResultsSource
        // 
        ResultsSource.DataSource = typeof(Core.Interfaces.RadarContinuationFrame);
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
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(772, 370);
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
        Load += MainWindow_Load;
        GB_Connection.ResumeLayout(false);
        GB_Connection.PerformLayout();
        GB_SAVInfo.ResumeLayout(false);
        GB_SAVInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)ResultsSource).EndInit();
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
    private BindingSource ResultsSource;
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
}

