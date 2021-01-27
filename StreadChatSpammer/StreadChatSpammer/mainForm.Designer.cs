namespace StreadChatSpammer
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.xuıObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.timerSpammer = new System.Windows.Forms.Timer(this.components);
            this.sliderPanel = new System.Windows.Forms.Panel();
            this.infoButtonSlide = new System.Windows.Forms.Button();
            this.settingsButtonSlide = new System.Windows.Forms.Button();
            this.homeButtonSlide = new System.Windows.Forms.Button();
            this.infoSelector = new System.Windows.Forms.PictureBox();
            this.settingsSelector = new System.Windows.Forms.PictureBox();
            this.homeSelector = new System.Windows.Forms.PictureBox();
            this.infoButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.labelText = new System.Windows.Forms.Label();
            this.methodGroup = new System.Windows.Forms.GroupBox();
            this.methodWrite = new XanderUI.XUIRadio();
            this.methodCopyPaste = new XanderUI.XUIRadio();
            this.selectSpeedGroup = new System.Windows.Forms.GroupBox();
            this.customSpeed = new System.Windows.Forms.Button();
            this.highSpeed = new XanderUI.XUIRadio();
            this.normalSpeed = new XanderUI.XUIRadio();
            this.lowSpeed = new XanderUI.XUIRadio();
            this.spamTextBox = new System.Windows.Forms.RichTextBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.customSpeedGroup = new System.Windows.Forms.GroupBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.labelSpeedValue = new System.Windows.Forms.Label();
            this.textSpeedValue = new System.Windows.Forms.TextBox();
            this.groupTheme = new System.Windows.Forms.GroupBox();
            this.selectThemeLabel = new System.Windows.Forms.Label();
            this.radioLight = new XanderUI.XUIRadio();
            this.radioDark = new XanderUI.XUIRadio();
            this.copyPasteMethod = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.warnText1 = new System.Windows.Forms.Label();
            this.warnText2 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.sliderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.methodGroup.SuspendLayout();
            this.selectSpeedGroup.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.customSpeedGroup.SuspendLayout();
            this.groupTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.headerLabel);
            this.topPanel.Controls.Add(this.pictureBox);
            this.topPanel.Location = new System.Drawing.Point(97, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(785, 65);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(706, 16);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 32);
            this.minimizeButton.TabIndex = 9;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(742, 16);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 32);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(289, 24);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(149, 16);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Stread Chat Spammer";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(223, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(60, 65);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // xuıObjectEllipse1
            // 
            this.xuıObjectEllipse1.CornerRadius = 15;
            this.xuıObjectEllipse1.EffectedControl = this;
            this.xuıObjectEllipse1.EffectedForm = this;
            // 
            // timerSpammer
            // 
            this.timerSpammer.Tick += new System.EventHandler(this.timerSpammer_Tick);
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sliderPanel.Controls.Add(this.infoButtonSlide);
            this.sliderPanel.Controls.Add(this.settingsButtonSlide);
            this.sliderPanel.Controls.Add(this.homeButtonSlide);
            this.sliderPanel.Controls.Add(this.infoSelector);
            this.sliderPanel.Controls.Add(this.settingsSelector);
            this.sliderPanel.Controls.Add(this.homeSelector);
            this.sliderPanel.Controls.Add(this.infoButton);
            this.sliderPanel.Controls.Add(this.settingsButton);
            this.sliderPanel.Controls.Add(this.homeButton);
            this.sliderPanel.Controls.Add(this.menuButton);
            this.sliderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliderPanel.Location = new System.Drawing.Point(0, 0);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(99, 464);
            this.sliderPanel.TabIndex = 8;
            this.sliderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sliderPanel_Paint);
            // 
            // infoButtonSlide
            // 
            this.infoButtonSlide.FlatAppearance.BorderSize = 0;
            this.infoButtonSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButtonSlide.Location = new System.Drawing.Point(87, 306);
            this.infoButtonSlide.Name = "infoButtonSlide";
            this.infoButtonSlide.Size = new System.Drawing.Size(63, 43);
            this.infoButtonSlide.TabIndex = 9;
            this.infoButtonSlide.Text = "Info";
            this.infoButtonSlide.UseVisualStyleBackColor = true;
            this.infoButtonSlide.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // settingsButtonSlide
            // 
            this.settingsButtonSlide.FlatAppearance.BorderSize = 0;
            this.settingsButtonSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButtonSlide.Location = new System.Drawing.Point(87, 212);
            this.settingsButtonSlide.Name = "settingsButtonSlide";
            this.settingsButtonSlide.Size = new System.Drawing.Size(63, 43);
            this.settingsButtonSlide.TabIndex = 9;
            this.settingsButtonSlide.Text = "Settings";
            this.settingsButtonSlide.UseVisualStyleBackColor = true;
            this.settingsButtonSlide.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // homeButtonSlide
            // 
            this.homeButtonSlide.FlatAppearance.BorderSize = 0;
            this.homeButtonSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButtonSlide.Location = new System.Drawing.Point(87, 116);
            this.homeButtonSlide.Name = "homeButtonSlide";
            this.homeButtonSlide.Size = new System.Drawing.Size(63, 43);
            this.homeButtonSlide.TabIndex = 9;
            this.homeButtonSlide.Text = "Home";
            this.homeButtonSlide.UseVisualStyleBackColor = true;
            this.homeButtonSlide.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // infoSelector
            // 
            this.infoSelector.Location = new System.Drawing.Point(7, 294);
            this.infoSelector.Name = "infoSelector";
            this.infoSelector.Size = new System.Drawing.Size(10, 64);
            this.infoSelector.TabIndex = 2;
            this.infoSelector.TabStop = false;
            this.infoSelector.Click += new System.EventHandler(this.infoSelector_Click);
            // 
            // settingsSelector
            // 
            this.settingsSelector.Location = new System.Drawing.Point(7, 200);
            this.settingsSelector.Name = "settingsSelector";
            this.settingsSelector.Size = new System.Drawing.Size(10, 64);
            this.settingsSelector.TabIndex = 2;
            this.settingsSelector.TabStop = false;
            // 
            // homeSelector
            // 
            this.homeSelector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homeSelector.Location = new System.Drawing.Point(7, 106);
            this.homeSelector.Name = "homeSelector";
            this.homeSelector.Size = new System.Drawing.Size(10, 64);
            this.homeSelector.TabIndex = 2;
            this.homeSelector.TabStop = false;
            this.homeSelector.Click += new System.EventHandler(this.homeSelector_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.Location = new System.Drawing.Point(17, 294);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(64, 64);
            this.infoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.infoButton.TabIndex = 1;
            this.infoButton.TabStop = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(17, 200);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(64, 64);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.settingsButton.TabIndex = 1;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(17, 106);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(64, 64);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homeButton.TabIndex = 1;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(0, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(99, 65);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // timerSlider
            // 
            this.timerSlider.Interval = 1;
            this.timerSlider.Tick += new System.EventHandler(this.timerSlider_Tick);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(314, 94);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(41, 19);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Text";
            this.labelText.Click += new System.EventHandler(this.labelText_Click);
            // 
            // methodGroup
            // 
            this.methodGroup.Controls.Add(this.methodWrite);
            this.methodGroup.Controls.Add(this.methodCopyPaste);
            this.methodGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodGroup.ForeColor = System.Drawing.Color.White;
            this.methodGroup.Location = new System.Drawing.Point(540, 158);
            this.methodGroup.Name = "methodGroup";
            this.methodGroup.Size = new System.Drawing.Size(200, 61);
            this.methodGroup.TabIndex = 6;
            this.methodGroup.TabStop = false;
            this.methodGroup.Text = "Select Method";
            // 
            // methodWrite
            // 
            this.methodWrite.Checked = true;
            this.methodWrite.ForeColor = System.Drawing.Color.White;
            this.methodWrite.Location = new System.Drawing.Point(121, 26);
            this.methodWrite.Name = "methodWrite";
            this.methodWrite.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.methodWrite.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.methodWrite.RadioStyle = XanderUI.XUIRadio.Style.Android;
            this.methodWrite.Size = new System.Drawing.Size(64, 17);
            this.methodWrite.TabIndex = 5;
            this.methodWrite.Text = "Write";
            this.methodWrite.Click += new System.EventHandler(this.methodWrite_Click);
            // 
            // methodCopyPaste
            // 
            this.methodCopyPaste.Checked = false;
            this.methodCopyPaste.Enabled = false;
            this.methodCopyPaste.ForeColor = System.Drawing.Color.White;
            this.methodCopyPaste.Location = new System.Drawing.Point(15, 26);
            this.methodCopyPaste.Name = "methodCopyPaste";
            this.methodCopyPaste.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.methodCopyPaste.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.methodCopyPaste.RadioStyle = XanderUI.XUIRadio.Style.Android;
            this.methodCopyPaste.Size = new System.Drawing.Size(100, 17);
            this.methodCopyPaste.TabIndex = 5;
            this.methodCopyPaste.Text = "Copy&Paste";
            this.methodCopyPaste.Click += new System.EventHandler(this.methodCopyPaste_Click);
            // 
            // selectSpeedGroup
            // 
            this.selectSpeedGroup.Controls.Add(this.customSpeed);
            this.selectSpeedGroup.Controls.Add(this.highSpeed);
            this.selectSpeedGroup.Controls.Add(this.normalSpeed);
            this.selectSpeedGroup.Controls.Add(this.lowSpeed);
            this.selectSpeedGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSpeedGroup.ForeColor = System.Drawing.Color.White;
            this.selectSpeedGroup.Location = new System.Drawing.Point(540, 242);
            this.selectSpeedGroup.Name = "selectSpeedGroup";
            this.selectSpeedGroup.Size = new System.Drawing.Size(292, 63);
            this.selectSpeedGroup.TabIndex = 7;
            this.selectSpeedGroup.TabStop = false;
            this.selectSpeedGroup.Text = "Select Speed";
            this.selectSpeedGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // customSpeed
            // 
            this.customSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.customSpeed.FlatAppearance.BorderSize = 0;
            this.customSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customSpeed.Location = new System.Drawing.Point(206, 28);
            this.customSpeed.Name = "customSpeed";
            this.customSpeed.Size = new System.Drawing.Size(61, 20);
            this.customSpeed.TabIndex = 12;
            this.customSpeed.Text = "Custom";
            this.customSpeed.UseVisualStyleBackColor = false;
            this.customSpeed.Click += new System.EventHandler(this.customSpeed_Click);
            // 
            // highSpeed
            // 
            this.highSpeed.Checked = false;
            this.highSpeed.ForeColor = System.Drawing.Color.White;
            this.highSpeed.Location = new System.Drawing.Point(139, 28);
            this.highSpeed.Name = "highSpeed";
            this.highSpeed.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.highSpeed.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.highSpeed.RadioStyle = XanderUI.XUIRadio.Style.Android;
            this.highSpeed.Size = new System.Drawing.Size(61, 17);
            this.highSpeed.TabIndex = 5;
            this.highSpeed.Text = "High";
            this.highSpeed.Click += new System.EventHandler(this.highSpeed_Click);
            // 
            // normalSpeed
            // 
            this.normalSpeed.Checked = true;
            this.normalSpeed.ForeColor = System.Drawing.Color.White;
            this.normalSpeed.Location = new System.Drawing.Point(69, 28);
            this.normalSpeed.Name = "normalSpeed";
            this.normalSpeed.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.normalSpeed.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.normalSpeed.RadioStyle = XanderUI.XUIRadio.Style.Android;
            this.normalSpeed.Size = new System.Drawing.Size(64, 17);
            this.normalSpeed.TabIndex = 5;
            this.normalSpeed.Text = "Normal";
            this.normalSpeed.Click += new System.EventHandler(this.normalSpeed_Click);
            // 
            // lowSpeed
            // 
            this.lowSpeed.Checked = false;
            this.lowSpeed.ForeColor = System.Drawing.Color.White;
            this.lowSpeed.Location = new System.Drawing.Point(7, 28);
            this.lowSpeed.Name = "lowSpeed";
            this.lowSpeed.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lowSpeed.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.lowSpeed.RadioStyle = XanderUI.XUIRadio.Style.Android;
            this.lowSpeed.Size = new System.Drawing.Size(56, 17);
            this.lowSpeed.TabIndex = 5;
            this.lowSpeed.Text = "Low";
            this.lowSpeed.Click += new System.EventHandler(this.lowSpeed_Click);
            // 
            // spamTextBox
            // 
            this.spamTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.spamTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spamTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.spamTextBox.Location = new System.Drawing.Point(192, 116);
            this.spamTextBox.MaxLength = 3000;
            this.spamTextBox.Name = "spamTextBox";
            this.spamTextBox.Size = new System.Drawing.Size(300, 270);
            this.spamTextBox.TabIndex = 1;
            this.spamTextBox.Text = "";
            this.spamTextBox.TextChanged += new System.EventHandler(this.spamTextBox_TextChanged);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.customSpeedGroup);
            this.settingsPanel.Controls.Add(this.groupTheme);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.Location = new System.Drawing.Point(97, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(786, 464);
            this.settingsPanel.TabIndex = 9;
            this.settingsPanel.Visible = false;
            this.settingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // customSpeedGroup
            // 
            this.customSpeedGroup.Controls.Add(this.applyButton);
            this.customSpeedGroup.Controls.Add(this.labelSpeedValue);
            this.customSpeedGroup.Controls.Add(this.textSpeedValue);
            this.customSpeedGroup.ForeColor = System.Drawing.Color.White;
            this.customSpeedGroup.Location = new System.Drawing.Point(49, 94);
            this.customSpeedGroup.Name = "customSpeedGroup";
            this.customSpeedGroup.Size = new System.Drawing.Size(324, 87);
            this.customSpeedGroup.TabIndex = 8;
            this.customSpeedGroup.TabStop = false;
            this.customSpeedGroup.Text = "Custom Speed";
            this.customSpeedGroup.Enter += new System.EventHandler(this.groupTheme_Enter);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.applyButton.FlatAppearance.BorderSize = 0;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Location = new System.Drawing.Point(187, 22);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 43);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // labelSpeedValue
            // 
            this.labelSpeedValue.AutoSize = true;
            this.labelSpeedValue.Location = new System.Drawing.Point(37, 37);
            this.labelSpeedValue.Name = "labelSpeedValue";
            this.labelSpeedValue.Size = new System.Drawing.Size(38, 14);
            this.labelSpeedValue.TabIndex = 6;
            this.labelSpeedValue.Text = "Speed";
            // 
            // textSpeedValue
            // 
            this.textSpeedValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textSpeedValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSpeedValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpeedValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textSpeedValue.Location = new System.Drawing.Point(81, 37);
            this.textSpeedValue.MaxLength = 10;
            this.textSpeedValue.Name = "textSpeedValue";
            this.textSpeedValue.Size = new System.Drawing.Size(100, 16);
            this.textSpeedValue.TabIndex = 5;
            this.textSpeedValue.TextChanged += new System.EventHandler(this.textSpeedValue_TextChanged);
            // 
            // groupTheme
            // 
            this.groupTheme.Controls.Add(this.selectThemeLabel);
            this.groupTheme.Controls.Add(this.radioLight);
            this.groupTheme.Controls.Add(this.radioDark);
            this.groupTheme.ForeColor = System.Drawing.Color.White;
            this.groupTheme.Location = new System.Drawing.Point(49, 187);
            this.groupTheme.Name = "groupTheme";
            this.groupTheme.Size = new System.Drawing.Size(324, 87);
            this.groupTheme.TabIndex = 8;
            this.groupTheme.TabStop = false;
            this.groupTheme.Text = "Theme";
            this.groupTheme.Enter += new System.EventHandler(this.groupTheme_Enter);
            // 
            // selectThemeLabel
            // 
            this.selectThemeLabel.AutoSize = true;
            this.selectThemeLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.selectThemeLabel.Location = new System.Drawing.Point(52, 39);
            this.selectThemeLabel.Name = "selectThemeLabel";
            this.selectThemeLabel.Size = new System.Drawing.Size(83, 15);
            this.selectThemeLabel.TabIndex = 8;
            this.selectThemeLabel.Text = "Select Theme";
            // 
            // radioLight
            // 
            this.radioLight.Checked = false;
            this.radioLight.ForeColor = System.Drawing.Color.White;
            this.radioLight.Location = new System.Drawing.Point(212, 38);
            this.radioLight.Name = "radioLight";
            this.radioLight.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioLight.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.radioLight.RadioStyle = XanderUI.XUIRadio.Style.Android;
            this.radioLight.Size = new System.Drawing.Size(64, 17);
            this.radioLight.TabIndex = 6;
            this.radioLight.Text = "Light";
            this.radioLight.Click += new System.EventHandler(this.radioLight_Click);
            // 
            // radioDark
            // 
            this.radioDark.Checked = true;
            this.radioDark.ForeColor = System.Drawing.Color.White;
            this.radioDark.Location = new System.Drawing.Point(147, 38);
            this.radioDark.Name = "radioDark";
            this.radioDark.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioDark.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.radioDark.RadioStyle = XanderUI.XUIRadio.Style.Android;
            this.radioDark.Size = new System.Drawing.Size(59, 17);
            this.radioDark.TabIndex = 7;
            this.radioDark.Text = "Dark";
            this.radioDark.Click += new System.EventHandler(this.radioDark_Click);
            // 
            // copyPasteMethod
            // 
            this.copyPasteMethod.AutoSize = true;
            this.copyPasteMethod.ForeColor = System.Drawing.Color.IndianRed;
            this.copyPasteMethod.Location = new System.Drawing.Point(547, 223);
            this.copyPasteMethod.Name = "copyPasteMethod";
            this.copyPasteMethod.Size = new System.Drawing.Size(168, 14);
            this.copyPasteMethod.TabIndex = 10;
            this.copyPasteMethod.Text = "Copy Paste Method Coming Soon!";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(540, 343);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 43);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(540, 343);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 43);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            this.stopButton.MouseEnter += new System.EventHandler(this.stopButton_MouseEnter);
            this.stopButton.MouseLeave += new System.EventHandler(this.stopButton_MouseLeave);
            // 
            // warnText1
            // 
            this.warnText1.AutoSize = true;
            this.warnText1.Font = new System.Drawing.Font("Arial", 12F);
            this.warnText1.ForeColor = System.Drawing.Color.IndianRed;
            this.warnText1.Location = new System.Drawing.Point(312, 422);
            this.warnText1.Name = "warnText1";
            this.warnText1.Size = new System.Drawing.Size(258, 18);
            this.warnText1.TabIndex = 12;
            this.warnText1.Text = "All responsibility belongs to the user.";
            // 
            // warnText2
            // 
            this.warnText2.AutoSize = true;
            this.warnText2.Font = new System.Drawing.Font("Arial", 12F);
            this.warnText2.ForeColor = System.Drawing.Color.IndianRed;
            this.warnText2.Location = new System.Drawing.Point(312, 422);
            this.warnText2.Name = "warnText2";
            this.warnText2.Size = new System.Drawing.Size(258, 18);
            this.warnText2.TabIndex = 12;
            this.warnText2.Text = "All responsibility belongs to the user.";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(883, 464);
            this.Controls.Add(this.warnText2);
            this.Controls.Add(this.sliderPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.spamTextBox);
            this.Controls.Add(this.selectSpeedGroup);
            this.Controls.Add(this.methodGroup);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.copyPasteMethod);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.warnText1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stread Chat Spammer";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.sliderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.methodGroup.ResumeLayout(false);
            this.selectSpeedGroup.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.customSpeedGroup.ResumeLayout(false);
            this.customSpeedGroup.PerformLayout();
            this.groupTheme.ResumeLayout(false);
            this.groupTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label headerLabel;
        private XanderUI.XUIObjectEllipse xuıObjectEllipse1;
        public System.Windows.Forms.Timer timerSpammer;
        private System.Windows.Forms.Panel sliderPanel;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.PictureBox infoButton;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox settingsSelector;
        private System.Windows.Forms.PictureBox homeSelector;
        private System.Windows.Forms.Timer timerSlider;
        public System.Windows.Forms.GroupBox selectSpeedGroup;
        public XanderUI.XUIRadio highSpeed;
        public XanderUI.XUIRadio normalSpeed;
        public XanderUI.XUIRadio lowSpeed;
        private System.Windows.Forms.GroupBox methodGroup;
        private XanderUI.XUIRadio methodWrite;
        private XanderUI.XUIRadio methodCopyPaste;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label labelSpeedValue;
        private System.Windows.Forms.TextBox textSpeedValue;
        private System.Windows.Forms.GroupBox groupTheme;
        private System.Windows.Forms.Label selectThemeLabel;
        private XanderUI.XUIRadio radioLight;
        private XanderUI.XUIRadio radioDark;
        private System.Windows.Forms.Label copyPasteMethod;
        private System.Windows.Forms.GroupBox customSpeedGroup;
        public System.Windows.Forms.PictureBox infoSelector;
        public System.Windows.Forms.RichTextBox spamTextBox;
        private System.Windows.Forms.Button infoButtonSlide;
        private System.Windows.Forms.Button settingsButtonSlide;
        private System.Windows.Forms.Button homeButtonSlide;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button customSpeed;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label warnText1;
        private System.Windows.Forms.Label warnText2;
    }
}

