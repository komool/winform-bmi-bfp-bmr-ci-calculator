namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BMI = new System.Windows.Forms.TabPage();
            this.linkBMI = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBMIHeight = new System.Windows.Forms.MaskedTextBox();
            this.textBoxBMIWeight = new System.Windows.Forms.MaskedTextBox();
            this.labelBMIWeight = new System.Windows.Forms.Label();
            this.labelBMIHeight = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBMIResult = new System.Windows.Forms.TextBox();
            this.BMICalcBtn = new System.Windows.Forms.Button();
            this.BFP = new System.Windows.Forms.TabPage();
            this.linkBFP = new System.Windows.Forms.LinkLabel();
            this.groupBFPFemale = new System.Windows.Forms.GroupBox();
            this.BFPFemaleHip = new System.Windows.Forms.MaskedTextBox();
            this.BFPFemaleWaist = new System.Windows.Forms.MaskedTextBox();
            this.BFPFemaleNeck = new System.Windows.Forms.MaskedTextBox();
            this.BFPFemaleHeight = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BFPCalcBtn = new System.Windows.Forms.Button();
            this.BFPResult = new System.Windows.Forms.TextBox();
            this.groupBFPMale = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BFPMaleWaist = new System.Windows.Forms.MaskedTextBox();
            this.BFPMaleNeck = new System.Windows.Forms.MaskedTextBox();
            this.BFPMaleHeight = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBFPGender = new System.Windows.Forms.GroupBox();
            this.radioBFPFemale = new System.Windows.Forms.RadioButton();
            this.radioBFPGenderMale = new System.Windows.Forms.RadioButton();
            this.BMR = new System.Windows.Forms.TabPage();
            this.linkBMR = new System.Windows.Forms.LinkLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BMRCalcBtn = new System.Windows.Forms.Button();
            this.BMRResult = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BMRAge = new System.Windows.Forms.MaskedTextBox();
            this.BMRWeight = new System.Windows.Forms.MaskedTextBox();
            this.BMRHeight = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BMRGender = new System.Windows.Forms.GroupBox();
            this.BMRFemale = new System.Windows.Forms.RadioButton();
            this.BMRMale = new System.Windows.Forms.RadioButton();
            this.CI = new System.Windows.Forms.TabPage();
            this.linkCI = new System.Windows.Forms.LinkLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CIResult = new System.Windows.Forms.TextBox();
            this.CICalcBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CIBMR = new System.Windows.Forms.MaskedTextBox();
            this.CIActive = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.BMI.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BFP.SuspendLayout();
            this.groupBFPFemale.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBFPMale.SuspendLayout();
            this.groupBoxBFPGender.SuspendLayout();
            this.BMR.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.BMRGender.SuspendLayout();
            this.CI.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BMI);
            this.tabControl1.Controls.Add(this.BFP);
            this.tabControl1.Controls.Add(this.BMR);
            this.tabControl1.Controls.Add(this.CI);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // BMI
            // 
            this.BMI.Controls.Add(this.linkBMI);
            this.BMI.Controls.Add(this.groupBox2);
            this.BMI.Controls.Add(this.groupBox1);
            this.BMI.Location = new System.Drawing.Point(4, 22);
            this.BMI.Name = "BMI";
            this.BMI.Padding = new System.Windows.Forms.Padding(3);
            this.BMI.Size = new System.Drawing.Size(360, 381);
            this.BMI.TabIndex = 0;
            this.BMI.Text = "BMI";
            this.BMI.UseVisualStyleBackColor = true;
            // 
            // linkBMI
            // 
            this.linkBMI.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.linkBMI.AutoSize = true;
            this.linkBMI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkBMI.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkBMI.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkBMI.Location = new System.Drawing.Point(293, 366);
            this.linkBMI.Name = "linkBMI";
            this.linkBMI.Size = new System.Drawing.Size(63, 12);
            this.linkBMI.TabIndex = 9;
            this.linkBMI.TabStop = true;
            this.linkBMI.Text = "BMI계산기";
            this.linkBMI.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.linkBMI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBMI_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBMIHeight);
            this.groupBox2.Controls.Add(this.textBoxBMIWeight);
            this.groupBox2.Controls.Add(this.labelBMIWeight);
            this.groupBox2.Controls.Add(this.labelBMIHeight);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 50);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "신체 정보";
            // 
            // textBoxBMIHeight
            // 
            this.textBoxBMIHeight.Location = new System.Drawing.Point(179, 20);
            this.textBoxBMIHeight.Mask = "000.0";
            this.textBoxBMIHeight.Name = "textBoxBMIHeight";
            this.textBoxBMIHeight.Size = new System.Drawing.Size(100, 21);
            this.textBoxBMIHeight.TabIndex = 1;
            // 
            // textBoxBMIWeight
            // 
            this.textBoxBMIWeight.Location = new System.Drawing.Point(50, 20);
            this.textBoxBMIWeight.Mask = "00.0";
            this.textBoxBMIWeight.Name = "textBoxBMIWeight";
            this.textBoxBMIWeight.Size = new System.Drawing.Size(100, 21);
            this.textBoxBMIWeight.TabIndex = 1;
            // 
            // labelBMIWeight
            // 
            this.labelBMIWeight.AutoSize = true;
            this.labelBMIWeight.Location = new System.Drawing.Point(6, 23);
            this.labelBMIWeight.Name = "labelBMIWeight";
            this.labelBMIWeight.Size = new System.Drawing.Size(41, 12);
            this.labelBMIWeight.TabIndex = 0;
            this.labelBMIWeight.Text = "몸무게";
            // 
            // labelBMIHeight
            // 
            this.labelBMIHeight.AutoSize = true;
            this.labelBMIHeight.Location = new System.Drawing.Point(156, 25);
            this.labelBMIHeight.Name = "labelBMIHeight";
            this.labelBMIHeight.Size = new System.Drawing.Size(17, 12);
            this.labelBMIHeight.TabIndex = 2;
            this.labelBMIHeight.Text = "키";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBMIResult);
            this.groupBox1.Controls.Add(this.BMICalcBtn);
            this.groupBox1.Location = new System.Drawing.Point(8, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 58);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI";
            // 
            // textBoxBMIResult
            // 
            this.textBoxBMIResult.Enabled = false;
            this.textBoxBMIResult.Location = new System.Drawing.Point(6, 20);
            this.textBoxBMIResult.Multiline = true;
            this.textBoxBMIResult.Name = "textBoxBMIResult";
            this.textBoxBMIResult.ReadOnly = true;
            this.textBoxBMIResult.Size = new System.Drawing.Size(167, 29);
            this.textBoxBMIResult.TabIndex = 4;
            this.textBoxBMIResult.TabStop = false;
            this.textBoxBMIResult.WordWrap = false;
            // 
            // BMICalcBtn
            // 
            this.BMICalcBtn.Location = new System.Drawing.Point(192, 20);
            this.BMICalcBtn.Name = "BMICalcBtn";
            this.BMICalcBtn.Size = new System.Drawing.Size(75, 23);
            this.BMICalcBtn.TabIndex = 6;
            this.BMICalcBtn.Text = "BMI 계산";
            this.BMICalcBtn.UseVisualStyleBackColor = true;
            this.BMICalcBtn.Click += new System.EventHandler(this.BMICalcBtn_Click);
            // 
            // BFP
            // 
            this.BFP.Controls.Add(this.linkBFP);
            this.BFP.Controls.Add(this.groupBFPFemale);
            this.BFP.Controls.Add(this.groupBox3);
            this.BFP.Controls.Add(this.groupBFPMale);
            this.BFP.Controls.Add(this.groupBoxBFPGender);
            this.BFP.Location = new System.Drawing.Point(4, 22);
            this.BFP.Name = "BFP";
            this.BFP.Padding = new System.Windows.Forms.Padding(3);
            this.BFP.Size = new System.Drawing.Size(360, 381);
            this.BFP.TabIndex = 1;
            this.BFP.Text = "BFP";
            this.BFP.UseVisualStyleBackColor = true;
            // 
            // linkBFP
            // 
            this.linkBFP.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.linkBFP.AutoSize = true;
            this.linkBFP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkBFP.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkBFP.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkBFP.Location = new System.Drawing.Point(291, 366);
            this.linkBFP.Name = "linkBFP";
            this.linkBFP.Size = new System.Drawing.Size(64, 12);
            this.linkBFP.TabIndex = 10;
            this.linkBFP.TabStop = true;
            this.linkBFP.Text = "BFP계산기";
            this.linkBFP.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.linkBFP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBFP_LinkClicked);
            // 
            // groupBFPFemale
            // 
            this.groupBFPFemale.Controls.Add(this.BFPFemaleHip);
            this.groupBFPFemale.Controls.Add(this.BFPFemaleWaist);
            this.groupBFPFemale.Controls.Add(this.BFPFemaleNeck);
            this.groupBFPFemale.Controls.Add(this.BFPFemaleHeight);
            this.groupBFPFemale.Controls.Add(this.label7);
            this.groupBFPFemale.Controls.Add(this.label5);
            this.groupBFPFemale.Controls.Add(this.label6);
            this.groupBFPFemale.Controls.Add(this.label4);
            this.groupBFPFemale.Location = new System.Drawing.Point(8, 57);
            this.groupBFPFemale.Name = "groupBFPFemale";
            this.groupBFPFemale.Size = new System.Drawing.Size(230, 250);
            this.groupBFPFemale.TabIndex = 1;
            this.groupBFPFemale.TabStop = false;
            this.groupBFPFemale.Text = "여성 BFP";
            this.groupBFPFemale.Visible = false;
            // 
            // BFPFemaleHip
            // 
            this.BFPFemaleHip.Location = new System.Drawing.Point(113, 188);
            this.BFPFemaleHip.Mask = "00.0";
            this.BFPFemaleHip.Name = "BFPFemaleHip";
            this.BFPFemaleHip.Size = new System.Drawing.Size(100, 21);
            this.BFPFemaleHip.TabIndex = 11;
            // 
            // BFPFemaleWaist
            // 
            this.BFPFemaleWaist.Location = new System.Drawing.Point(113, 142);
            this.BFPFemaleWaist.Mask = "00.0";
            this.BFPFemaleWaist.Name = "BFPFemaleWaist";
            this.BFPFemaleWaist.Size = new System.Drawing.Size(100, 21);
            this.BFPFemaleWaist.TabIndex = 11;
            // 
            // BFPFemaleNeck
            // 
            this.BFPFemaleNeck.Location = new System.Drawing.Point(113, 94);
            this.BFPFemaleNeck.Mask = "00.0";
            this.BFPFemaleNeck.Name = "BFPFemaleNeck";
            this.BFPFemaleNeck.Size = new System.Drawing.Size(100, 21);
            this.BFPFemaleNeck.TabIndex = 11;
            // 
            // BFPFemaleHeight
            // 
            this.BFPFemaleHeight.Location = new System.Drawing.Point(113, 48);
            this.BFPFemaleHeight.Mask = "000.0";
            this.BFPFemaleHeight.Name = "BFPFemaleHeight";
            this.BFPFemaleHeight.Size = new System.Drawing.Size(100, 21);
            this.BFPFemaleHeight.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "엉덩이 둘레";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "허리 둘레";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "목 둘레";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "키";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BFPCalcBtn);
            this.groupBox3.Controls.Add(this.BFPResult);
            this.groupBox3.Location = new System.Drawing.Point(8, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 53);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BFP";
            // 
            // BFPCalcBtn
            // 
            this.BFPCalcBtn.Location = new System.Drawing.Point(138, 20);
            this.BFPCalcBtn.Name = "BFPCalcBtn";
            this.BFPCalcBtn.Size = new System.Drawing.Size(75, 23);
            this.BFPCalcBtn.TabIndex = 2;
            this.BFPCalcBtn.Text = "계산하기";
            this.BFPCalcBtn.UseVisualStyleBackColor = true;
            this.BFPCalcBtn.Click += new System.EventHandler(this.BFPCalcBtn_Click);
            // 
            // BFPResult
            // 
            this.BFPResult.Enabled = false;
            this.BFPResult.Location = new System.Drawing.Point(6, 20);
            this.BFPResult.Name = "BFPResult";
            this.BFPResult.ReadOnly = true;
            this.BFPResult.Size = new System.Drawing.Size(100, 21);
            this.BFPResult.TabIndex = 1;
            // 
            // groupBFPMale
            // 
            this.groupBFPMale.Controls.Add(this.label3);
            this.groupBFPMale.Controls.Add(this.BFPMaleWaist);
            this.groupBFPMale.Controls.Add(this.BFPMaleNeck);
            this.groupBFPMale.Controls.Add(this.BFPMaleHeight);
            this.groupBFPMale.Controls.Add(this.label2);
            this.groupBFPMale.Controls.Add(this.label1);
            this.groupBFPMale.Location = new System.Drawing.Point(8, 57);
            this.groupBFPMale.Name = "groupBFPMale";
            this.groupBFPMale.Size = new System.Drawing.Size(230, 203);
            this.groupBFPMale.TabIndex = 1;
            this.groupBFPMale.TabStop = false;
            this.groupBFPMale.Text = "남성 BFP";
            this.groupBFPMale.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "허리 둘레";
            // 
            // BFPMaleWaist
            // 
            this.BFPMaleWaist.Location = new System.Drawing.Point(113, 142);
            this.BFPMaleWaist.Mask = "00.0";
            this.BFPMaleWaist.Name = "BFPMaleWaist";
            this.BFPMaleWaist.Size = new System.Drawing.Size(100, 21);
            this.BFPMaleWaist.TabIndex = 11;
            // 
            // BFPMaleNeck
            // 
            this.BFPMaleNeck.Location = new System.Drawing.Point(113, 94);
            this.BFPMaleNeck.Mask = "00.0";
            this.BFPMaleNeck.Name = "BFPMaleNeck";
            this.BFPMaleNeck.Size = new System.Drawing.Size(100, 21);
            this.BFPMaleNeck.TabIndex = 11;
            // 
            // BFPMaleHeight
            // 
            this.BFPMaleHeight.Location = new System.Drawing.Point(113, 48);
            this.BFPMaleHeight.Mask = "000.0";
            this.BFPMaleHeight.Name = "BFPMaleHeight";
            this.BFPMaleHeight.Size = new System.Drawing.Size(100, 21);
            this.BFPMaleHeight.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "목 둘레";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "키";
            // 
            // groupBoxBFPGender
            // 
            this.groupBoxBFPGender.Controls.Add(this.radioBFPFemale);
            this.groupBoxBFPGender.Controls.Add(this.radioBFPGenderMale);
            this.groupBoxBFPGender.Location = new System.Drawing.Point(8, 6);
            this.groupBoxBFPGender.Name = "groupBoxBFPGender";
            this.groupBoxBFPGender.Size = new System.Drawing.Size(114, 45);
            this.groupBoxBFPGender.TabIndex = 0;
            this.groupBoxBFPGender.TabStop = false;
            this.groupBoxBFPGender.Text = "성별";
            // 
            // radioBFPFemale
            // 
            this.radioBFPFemale.AutoSize = true;
            this.radioBFPFemale.Location = new System.Drawing.Point(59, 20);
            this.radioBFPFemale.Name = "radioBFPFemale";
            this.radioBFPFemale.Size = new System.Drawing.Size(47, 16);
            this.radioBFPFemale.TabIndex = 0;
            this.radioBFPFemale.TabStop = true;
            this.radioBFPFemale.Text = "여성";
            this.radioBFPFemale.UseVisualStyleBackColor = true;
            this.radioBFPFemale.CheckedChanged += new System.EventHandler(this.radioBFPFemale_CheckedChanged);
            // 
            // radioBFPGenderMale
            // 
            this.radioBFPGenderMale.AutoSize = true;
            this.radioBFPGenderMale.Location = new System.Drawing.Point(6, 20);
            this.radioBFPGenderMale.Name = "radioBFPGenderMale";
            this.radioBFPGenderMale.Size = new System.Drawing.Size(47, 16);
            this.radioBFPGenderMale.TabIndex = 0;
            this.radioBFPGenderMale.TabStop = true;
            this.radioBFPGenderMale.Text = "남성";
            this.radioBFPGenderMale.UseVisualStyleBackColor = true;
            this.radioBFPGenderMale.CheckedChanged += new System.EventHandler(this.radioBFPGenderMale_CheckedChanged);
            // 
            // BMR
            // 
            this.BMR.Controls.Add(this.linkBMR);
            this.BMR.Controls.Add(this.groupBox5);
            this.BMR.Controls.Add(this.groupBox4);
            this.BMR.Controls.Add(this.BMRGender);
            this.BMR.Location = new System.Drawing.Point(4, 22);
            this.BMR.Name = "BMR";
            this.BMR.Padding = new System.Windows.Forms.Padding(3);
            this.BMR.Size = new System.Drawing.Size(360, 381);
            this.BMR.TabIndex = 2;
            this.BMR.Text = "BMR";
            this.BMR.UseVisualStyleBackColor = true;
            // 
            // linkBMR
            // 
            this.linkBMR.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.linkBMR.AutoSize = true;
            this.linkBMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkBMR.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkBMR.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkBMR.Location = new System.Drawing.Point(291, 366);
            this.linkBMR.Name = "linkBMR";
            this.linkBMR.Size = new System.Drawing.Size(68, 12);
            this.linkBMR.TabIndex = 10;
            this.linkBMR.TabStop = true;
            this.linkBMR.Text = "BMR계산기";
            this.linkBMR.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.linkBMR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBMR_LinkClicked);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BMRCalcBtn);
            this.groupBox5.Controls.Add(this.BMRResult);
            this.groupBox5.Location = new System.Drawing.Point(8, 234);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 53);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BMR";
            // 
            // BMRCalcBtn
            // 
            this.BMRCalcBtn.Location = new System.Drawing.Point(127, 20);
            this.BMRCalcBtn.Name = "BMRCalcBtn";
            this.BMRCalcBtn.Size = new System.Drawing.Size(75, 23);
            this.BMRCalcBtn.TabIndex = 2;
            this.BMRCalcBtn.Text = "계산하기";
            this.BMRCalcBtn.UseVisualStyleBackColor = true;
            this.BMRCalcBtn.Click += new System.EventHandler(this.BMRCalcBtn_Click);
            // 
            // BMRResult
            // 
            this.BMRResult.Enabled = false;
            this.BMRResult.Location = new System.Drawing.Point(6, 20);
            this.BMRResult.Name = "BMRResult";
            this.BMRResult.ReadOnly = true;
            this.BMRResult.Size = new System.Drawing.Size(100, 21);
            this.BMRResult.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BMRAge);
            this.groupBox4.Controls.Add(this.BMRWeight);
            this.groupBox4.Controls.Add(this.BMRHeight);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(8, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 171);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "신체정보";
            // 
            // BMRAge
            // 
            this.BMRAge.Location = new System.Drawing.Point(102, 123);
            this.BMRAge.Mask = "00";
            this.BMRAge.Name = "BMRAge";
            this.BMRAge.Size = new System.Drawing.Size(100, 21);
            this.BMRAge.TabIndex = 12;
            // 
            // BMRWeight
            // 
            this.BMRWeight.Location = new System.Drawing.Point(102, 75);
            this.BMRWeight.Mask = "00.0";
            this.BMRWeight.Name = "BMRWeight";
            this.BMRWeight.Size = new System.Drawing.Size(100, 21);
            this.BMRWeight.TabIndex = 12;
            // 
            // BMRHeight
            // 
            this.BMRHeight.Location = new System.Drawing.Point(102, 29);
            this.BMRHeight.Mask = "000.0";
            this.BMRHeight.Name = "BMRHeight";
            this.BMRHeight.Size = new System.Drawing.Size(100, 21);
            this.BMRHeight.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "나이";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "몸무게";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "키";
            // 
            // BMRGender
            // 
            this.BMRGender.Controls.Add(this.BMRFemale);
            this.BMRGender.Controls.Add(this.BMRMale);
            this.BMRGender.Location = new System.Drawing.Point(8, 6);
            this.BMRGender.Name = "BMRGender";
            this.BMRGender.Size = new System.Drawing.Size(114, 45);
            this.BMRGender.TabIndex = 1;
            this.BMRGender.TabStop = false;
            this.BMRGender.Text = "성별";
            // 
            // BMRFemale
            // 
            this.BMRFemale.AutoSize = true;
            this.BMRFemale.Location = new System.Drawing.Point(59, 20);
            this.BMRFemale.Name = "BMRFemale";
            this.BMRFemale.Size = new System.Drawing.Size(47, 16);
            this.BMRFemale.TabIndex = 0;
            this.BMRFemale.TabStop = true;
            this.BMRFemale.Text = "여성";
            this.BMRFemale.UseVisualStyleBackColor = true;
            // 
            // BMRMale
            // 
            this.BMRMale.AutoSize = true;
            this.BMRMale.Location = new System.Drawing.Point(6, 20);
            this.BMRMale.Name = "BMRMale";
            this.BMRMale.Size = new System.Drawing.Size(47, 16);
            this.BMRMale.TabIndex = 0;
            this.BMRMale.TabStop = true;
            this.BMRMale.Text = "남성";
            this.BMRMale.UseVisualStyleBackColor = true;
            // 
            // CI
            // 
            this.CI.Controls.Add(this.linkCI);
            this.CI.Controls.Add(this.groupBox7);
            this.CI.Controls.Add(this.groupBox6);
            this.CI.Location = new System.Drawing.Point(4, 22);
            this.CI.Name = "CI";
            this.CI.Padding = new System.Windows.Forms.Padding(3);
            this.CI.Size = new System.Drawing.Size(360, 381);
            this.CI.TabIndex = 3;
            this.CI.Text = "CI";
            this.CI.UseVisualStyleBackColor = true;
            // 
            // linkCI
            // 
            this.linkCI.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.linkCI.AutoSize = true;
            this.linkCI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCI.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCI.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkCI.Location = new System.Drawing.Point(293, 366);
            this.linkCI.Name = "linkCI";
            this.linkCI.Size = new System.Drawing.Size(53, 12);
            this.linkCI.TabIndex = 11;
            this.linkCI.TabStop = true;
            this.linkCI.Text = "CI계산기";
            this.linkCI.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.linkCI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCI_LinkClicked);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CIResult);
            this.groupBox7.Controls.Add(this.CICalcBtn);
            this.groupBox7.Location = new System.Drawing.Point(8, 63);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(339, 58);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CI";
            // 
            // CIResult
            // 
            this.CIResult.Enabled = false;
            this.CIResult.Location = new System.Drawing.Point(6, 20);
            this.CIResult.Multiline = true;
            this.CIResult.Name = "CIResult";
            this.CIResult.ReadOnly = true;
            this.CIResult.Size = new System.Drawing.Size(218, 29);
            this.CIResult.TabIndex = 4;
            this.CIResult.TabStop = false;
            this.CIResult.WordWrap = false;
            // 
            // CICalcBtn
            // 
            this.CICalcBtn.Location = new System.Drawing.Point(249, 20);
            this.CICalcBtn.Name = "CICalcBtn";
            this.CICalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CICalcBtn.TabIndex = 6;
            this.CICalcBtn.Text = "CI 계산";
            this.CICalcBtn.UseVisualStyleBackColor = true;
            this.CICalcBtn.Click += new System.EventHandler(this.CICalcBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CIBMR);
            this.groupBox6.Controls.Add(this.CIActive);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(339, 51);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "신체 정보";
            // 
            // CIBMR
            // 
            this.CIBMR.Location = new System.Drawing.Point(44, 20);
            this.CIBMR.Mask = "0000.0";
            this.CIBMR.Name = "CIBMR";
            this.CIBMR.Size = new System.Drawing.Size(100, 21);
            this.CIBMR.TabIndex = 13;
            // 
            // CIActive
            // 
            this.CIActive.FormattingEnabled = true;
            this.CIActive.Items.AddRange(new object[] {
            "Sedentary",
            "Lightly_Active",
            "Moderately_Active",
            "Very_Active",
            "Extra_Active"});
            this.CIActive.Location = new System.Drawing.Point(203, 20);
            this.CIActive.Name = "CIActive";
            this.CIActive.Size = new System.Drawing.Size(121, 20);
            this.CIActive.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "BMR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "활동량";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.BMI.ResumeLayout(false);
            this.BMI.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BFP.ResumeLayout(false);
            this.BFP.PerformLayout();
            this.groupBFPFemale.ResumeLayout(false);
            this.groupBFPFemale.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBFPMale.ResumeLayout(false);
            this.groupBFPMale.PerformLayout();
            this.groupBoxBFPGender.ResumeLayout(false);
            this.groupBoxBFPGender.PerformLayout();
            this.BMR.ResumeLayout(false);
            this.BMR.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.BMRGender.ResumeLayout(false);
            this.BMRGender.PerformLayout();
            this.CI.ResumeLayout(false);
            this.CI.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BMI;
        private System.Windows.Forms.TabPage BFP;
        private System.Windows.Forms.TabPage BMR;
        private System.Windows.Forms.TabPage CI;
        private System.Windows.Forms.Label labelBMIHeight;
        private System.Windows.Forms.Label labelBMIWeight;
        private System.Windows.Forms.TextBox textBoxBMIResult;
        private System.Windows.Forms.Button BMICalcBtn;
        private System.Windows.Forms.GroupBox groupBoxBFPGender;
        private System.Windows.Forms.RadioButton radioBFPFemale;
        private System.Windows.Forms.RadioButton radioBFPGenderMale;
        private System.Windows.Forms.GroupBox groupBFPMale;
        private System.Windows.Forms.GroupBox groupBFPFemale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox BFPResult;
        private System.Windows.Forms.Button BFPCalcBtn;
        private System.Windows.Forms.GroupBox BMRGender;
        private System.Windows.Forms.RadioButton BMRFemale;
        private System.Windows.Forms.RadioButton BMRMale;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BMRCalcBtn;
        private System.Windows.Forms.TextBox BMRResult;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CIActive;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox CIResult;
        private System.Windows.Forms.Button CICalcBtn;
        private System.Windows.Forms.LinkLabel linkBMI;
        private System.Windows.Forms.LinkLabel linkBFP;
        private System.Windows.Forms.LinkLabel linkBMR;
        private System.Windows.Forms.LinkLabel linkCI;
        private System.Windows.Forms.MaskedTextBox textBoxBMIWeight;
        private System.Windows.Forms.MaskedTextBox textBoxBMIHeight;
        private System.Windows.Forms.MaskedTextBox BFPFemaleHip;
        private System.Windows.Forms.MaskedTextBox BFPFemaleWaist;
        private System.Windows.Forms.MaskedTextBox BFPFemaleNeck;
        private System.Windows.Forms.MaskedTextBox BFPFemaleHeight;
        private System.Windows.Forms.MaskedTextBox BFPMaleWaist;
        private System.Windows.Forms.MaskedTextBox BFPMaleNeck;
        private System.Windows.Forms.MaskedTextBox BFPMaleHeight;
        private System.Windows.Forms.MaskedTextBox BMRAge;
        private System.Windows.Forms.MaskedTextBox BMRWeight;
        private System.Windows.Forms.MaskedTextBox BMRHeight;
        private System.Windows.Forms.MaskedTextBox CIBMR;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

