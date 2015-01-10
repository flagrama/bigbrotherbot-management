namespace BigBrotherBot_Management
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnRun = new System.Windows.Forms.Button();
            this.ofdExecutable = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseExecutable = new System.Windows.Forms.Button();
            this.lblExecutable = new System.Windows.Forms.Label();
            this.lblConfig = new System.Windows.Forms.Label();
            this.btnBrowseConfig = new System.Windows.Forms.Button();
            this.ofdConfig = new System.Windows.Forms.OpenFileDialog();
            this.chkRestart = new System.Windows.Forms.CheckBox();
            this.tabConfiguration = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.btnLogFile = new System.Windows.Forms.Button();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblParser = new System.Windows.Forms.Label();
            this.cmbParser = new System.Windows.Forms.ComboBox();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.lblLogLevel = new System.Windows.Forms.Label();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.cmbTimeZone = new System.Windows.Forms.ComboBox();
            this.lblTimeFormat = new System.Windows.Forms.Label();
            this.cmbTimeFormat = new System.Windows.Forms.ComboBox();
            this.txtBotPrefix = new System.Windows.Forms.TextBox();
            this.lblBotPrefix = new System.Windows.Forms.Label();
            this.txtBotName = new System.Windows.Forms.TextBox();
            this.lblBotName = new System.Windows.Forms.Label();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.lblGameLog = new System.Windows.Forms.Label();
            this.lblPunkbuster = new System.Windows.Forms.Label();
            this.lblLinesSec = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblRconIp = new System.Windows.Forms.Label();
            this.lblPublicIp = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.lblRconPassword = new System.Windows.Forms.Label();
            this.cmbPunkbuster = new System.Windows.Forms.ComboBox();
            this.btnBrowseGameLog = new System.Windows.Forms.Button();
            this.txtGameLog = new System.Windows.Forms.TextBox();
            this.txtLinesSec = new System.Windows.Forms.TextBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.txtRconIp = new System.Windows.Forms.TextBox();
            this.txtPublicIp = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtRconPassword = new System.Windows.Forms.TextBox();
            this.tabAutodoc = new System.Windows.Forms.TabPage();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblMaxLevel = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.txtMaxLevel = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.lblChannel = new System.Windows.Forms.Label();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.lblUnbanned = new System.Windows.Forms.Label();
            this.lblUnbannedBy = new System.Windows.Forms.Label();
            this.lblTempBanned = new System.Windows.Forms.Label();
            this.lblTempBannedBy = new System.Windows.Forms.Label();
            this.lblBanned = new System.Windows.Forms.Label();
            this.lblBannedBy = new System.Windows.Forms.Label();
            this.lblKicked = new System.Windows.Forms.Label();
            this.lblKickedBy = new System.Windows.Forms.Label();
            this.txtUnbanned = new System.Windows.Forms.TextBox();
            this.txtUnbannedBy = new System.Windows.Forms.TextBox();
            this.txtTempBanned = new System.Windows.Forms.TextBox();
            this.txtTempBannedBy = new System.Windows.Forms.TextBox();
            this.txtBanned = new System.Windows.Forms.TextBox();
            this.txtBannedBy = new System.Windows.Forms.TextBox();
            this.txtKicked = new System.Windows.Forms.TextBox();
            this.txtKickedBy = new System.Windows.Forms.TextBox();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.lblPlugins = new System.Windows.Forms.Label();
            this.ofdGameLog = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.sfdConfig = new System.Windows.Forms.SaveFileDialog();
            this.lblVersion = new System.Windows.Forms.Label();
            this.fbdLogFile = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdAutodoc = new System.Windows.Forms.FolderBrowserDialog();
            this.tabConfiguration.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.tabAutodoc.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabMessages.SuspendLayout();
            this.tabPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            resources.ApplyResources(this.btnRun, "btnRun");
            this.btnRun.Name = "btnRun";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // ofdExecutable
            // 
            this.ofdExecutable.DefaultExt = "py";
            this.ofdExecutable.FileName = "b3_run.py";
            resources.ApplyResources(this.ofdExecutable, "ofdExecutable");
            // 
            // btnBrowseExecutable
            // 
            resources.ApplyResources(this.btnBrowseExecutable, "btnBrowseExecutable");
            this.btnBrowseExecutable.Name = "btnBrowseExecutable";
            this.btnBrowseExecutable.UseVisualStyleBackColor = true;
            this.btnBrowseExecutable.Click += new System.EventHandler(this.btnBrowseExecutable_Click);
            // 
            // lblExecutable
            // 
            resources.ApplyResources(this.lblExecutable, "lblExecutable");
            this.lblExecutable.AutoEllipsis = true;
            this.lblExecutable.Name = "lblExecutable";
            // 
            // lblConfig
            // 
            resources.ApplyResources(this.lblConfig, "lblConfig");
            this.lblConfig.AutoEllipsis = true;
            this.lblConfig.Name = "lblConfig";
            // 
            // btnBrowseConfig
            // 
            resources.ApplyResources(this.btnBrowseConfig, "btnBrowseConfig");
            this.btnBrowseConfig.Name = "btnBrowseConfig";
            this.btnBrowseConfig.UseVisualStyleBackColor = true;
            this.btnBrowseConfig.Click += new System.EventHandler(this.btnBrowseConfig_Click);
            // 
            // ofdConfig
            // 
            this.ofdConfig.DefaultExt = "xml";
            this.ofdConfig.FileName = "b3.xml";
            resources.ApplyResources(this.ofdConfig, "ofdConfig");
            // 
            // chkRestart
            // 
            resources.ApplyResources(this.chkRestart, "chkRestart");
            this.chkRestart.Name = "chkRestart";
            this.chkRestart.UseVisualStyleBackColor = true;
            // 
            // tabConfiguration
            // 
            resources.ApplyResources(this.tabConfiguration, "tabConfiguration");
            this.tabConfiguration.Controls.Add(this.tabGeneral);
            this.tabConfiguration.Controls.Add(this.tabServer);
            this.tabConfiguration.Controls.Add(this.tabAutodoc);
            this.tabConfiguration.Controls.Add(this.tabUpdate);
            this.tabConfiguration.Controls.Add(this.tabMessages);
            this.tabConfiguration.Controls.Add(this.tabPlugins);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.SelectedIndex = 0;
            // 
            // tabGeneral
            // 
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.Controls.Add(this.btnLogFile);
            this.tabGeneral.Controls.Add(this.lblDatabase);
            this.tabGeneral.Controls.Add(this.txtDatabase);
            this.tabGeneral.Controls.Add(this.lblParser);
            this.tabGeneral.Controls.Add(this.cmbParser);
            this.tabGeneral.Controls.Add(this.lblLogFile);
            this.tabGeneral.Controls.Add(this.txtLogFile);
            this.tabGeneral.Controls.Add(this.lblLogLevel);
            this.tabGeneral.Controls.Add(this.cmbLogLevel);
            this.tabGeneral.Controls.Add(this.lblTimeZone);
            this.tabGeneral.Controls.Add(this.cmbTimeZone);
            this.tabGeneral.Controls.Add(this.lblTimeFormat);
            this.tabGeneral.Controls.Add(this.cmbTimeFormat);
            this.tabGeneral.Controls.Add(this.txtBotPrefix);
            this.tabGeneral.Controls.Add(this.lblBotPrefix);
            this.tabGeneral.Controls.Add(this.txtBotName);
            this.tabGeneral.Controls.Add(this.lblBotName);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // btnLogFile
            // 
            resources.ApplyResources(this.btnLogFile, "btnLogFile");
            this.btnLogFile.Name = "btnLogFile";
            this.btnLogFile.UseVisualStyleBackColor = true;
            this.btnLogFile.Click += new System.EventHandler(this.btnLogFile_Click);
            // 
            // lblDatabase
            // 
            resources.ApplyResources(this.lblDatabase, "lblDatabase");
            this.lblDatabase.Name = "lblDatabase";
            // 
            // txtDatabase
            // 
            resources.ApplyResources(this.txtDatabase, "txtDatabase");
            this.txtDatabase.Name = "txtDatabase";
            // 
            // lblParser
            // 
            resources.ApplyResources(this.lblParser, "lblParser");
            this.lblParser.Name = "lblParser";
            // 
            // cmbParser
            // 
            resources.ApplyResources(this.cmbParser, "cmbParser");
            this.cmbParser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParser.FormattingEnabled = true;
            this.cmbParser.Items.AddRange(new object[] {
            resources.GetString("cmbParser.Items"),
            resources.GetString("cmbParser.Items1"),
            resources.GetString("cmbParser.Items2"),
            resources.GetString("cmbParser.Items3"),
            resources.GetString("cmbParser.Items4"),
            resources.GetString("cmbParser.Items5"),
            resources.GetString("cmbParser.Items6"),
            resources.GetString("cmbParser.Items7"),
            resources.GetString("cmbParser.Items8"),
            resources.GetString("cmbParser.Items9"),
            resources.GetString("cmbParser.Items10"),
            resources.GetString("cmbParser.Items11"),
            resources.GetString("cmbParser.Items12"),
            resources.GetString("cmbParser.Items13"),
            resources.GetString("cmbParser.Items14"),
            resources.GetString("cmbParser.Items15"),
            resources.GetString("cmbParser.Items16"),
            resources.GetString("cmbParser.Items17"),
            resources.GetString("cmbParser.Items18"),
            resources.GetString("cmbParser.Items19"),
            resources.GetString("cmbParser.Items20"),
            resources.GetString("cmbParser.Items21"),
            resources.GetString("cmbParser.Items22"),
            resources.GetString("cmbParser.Items23"),
            resources.GetString("cmbParser.Items24")});
            this.cmbParser.Name = "cmbParser";
            // 
            // lblLogFile
            // 
            resources.ApplyResources(this.lblLogFile, "lblLogFile");
            this.lblLogFile.Name = "lblLogFile";
            // 
            // txtLogFile
            // 
            resources.ApplyResources(this.txtLogFile, "txtLogFile");
            this.txtLogFile.Name = "txtLogFile";
            // 
            // lblLogLevel
            // 
            resources.ApplyResources(this.lblLogLevel, "lblLogLevel");
            this.lblLogLevel.Name = "lblLogLevel";
            // 
            // cmbLogLevel
            // 
            resources.ApplyResources(this.cmbLogLevel, "cmbLogLevel");
            this.cmbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Items.AddRange(new object[] {
            resources.GetString("cmbLogLevel.Items"),
            resources.GetString("cmbLogLevel.Items1"),
            resources.GetString("cmbLogLevel.Items2"),
            resources.GetString("cmbLogLevel.Items3"),
            resources.GetString("cmbLogLevel.Items4"),
            resources.GetString("cmbLogLevel.Items5"),
            resources.GetString("cmbLogLevel.Items6"),
            resources.GetString("cmbLogLevel.Items7"),
            resources.GetString("cmbLogLevel.Items8")});
            this.cmbLogLevel.Name = "cmbLogLevel";
            // 
            // lblTimeZone
            // 
            resources.ApplyResources(this.lblTimeZone, "lblTimeZone");
            this.lblTimeZone.Name = "lblTimeZone";
            // 
            // cmbTimeZone
            // 
            resources.ApplyResources(this.cmbTimeZone, "cmbTimeZone");
            this.cmbTimeZone.FormattingEnabled = true;
            this.cmbTimeZone.Name = "cmbTimeZone";
            // 
            // lblTimeFormat
            // 
            resources.ApplyResources(this.lblTimeFormat, "lblTimeFormat");
            this.lblTimeFormat.Name = "lblTimeFormat";
            // 
            // cmbTimeFormat
            // 
            resources.ApplyResources(this.cmbTimeFormat, "cmbTimeFormat");
            this.cmbTimeFormat.FormattingEnabled = true;
            this.cmbTimeFormat.Items.AddRange(new object[] {
            resources.GetString("cmbTimeFormat.Items")});
            this.cmbTimeFormat.Name = "cmbTimeFormat";
            // 
            // txtBotPrefix
            // 
            resources.ApplyResources(this.txtBotPrefix, "txtBotPrefix");
            this.txtBotPrefix.Name = "txtBotPrefix";
            // 
            // lblBotPrefix
            // 
            resources.ApplyResources(this.lblBotPrefix, "lblBotPrefix");
            this.lblBotPrefix.Name = "lblBotPrefix";
            // 
            // txtBotName
            // 
            resources.ApplyResources(this.txtBotName, "txtBotName");
            this.txtBotName.Name = "txtBotName";
            // 
            // lblBotName
            // 
            resources.ApplyResources(this.lblBotName, "lblBotName");
            this.lblBotName.Name = "lblBotName";
            // 
            // tabServer
            // 
            resources.ApplyResources(this.tabServer, "tabServer");
            this.tabServer.Controls.Add(this.lblGameLog);
            this.tabServer.Controls.Add(this.lblPunkbuster);
            this.tabServer.Controls.Add(this.lblLinesSec);
            this.tabServer.Controls.Add(this.lblDelay);
            this.tabServer.Controls.Add(this.lblRconIp);
            this.tabServer.Controls.Add(this.lblPublicIp);
            this.tabServer.Controls.Add(this.lblServerPort);
            this.tabServer.Controls.Add(this.lblRconPassword);
            this.tabServer.Controls.Add(this.cmbPunkbuster);
            this.tabServer.Controls.Add(this.btnBrowseGameLog);
            this.tabServer.Controls.Add(this.txtGameLog);
            this.tabServer.Controls.Add(this.txtLinesSec);
            this.tabServer.Controls.Add(this.txtDelay);
            this.tabServer.Controls.Add(this.txtRconIp);
            this.tabServer.Controls.Add(this.txtPublicIp);
            this.tabServer.Controls.Add(this.txtServerPort);
            this.tabServer.Controls.Add(this.txtRconPassword);
            this.tabServer.Name = "tabServer";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // lblGameLog
            // 
            resources.ApplyResources(this.lblGameLog, "lblGameLog");
            this.lblGameLog.Name = "lblGameLog";
            // 
            // lblPunkbuster
            // 
            resources.ApplyResources(this.lblPunkbuster, "lblPunkbuster");
            this.lblPunkbuster.Name = "lblPunkbuster";
            // 
            // lblLinesSec
            // 
            resources.ApplyResources(this.lblLinesSec, "lblLinesSec");
            this.lblLinesSec.Name = "lblLinesSec";
            // 
            // lblDelay
            // 
            resources.ApplyResources(this.lblDelay, "lblDelay");
            this.lblDelay.Name = "lblDelay";
            // 
            // lblRconIp
            // 
            resources.ApplyResources(this.lblRconIp, "lblRconIp");
            this.lblRconIp.Name = "lblRconIp";
            // 
            // lblPublicIp
            // 
            resources.ApplyResources(this.lblPublicIp, "lblPublicIp");
            this.lblPublicIp.Name = "lblPublicIp";
            // 
            // lblServerPort
            // 
            resources.ApplyResources(this.lblServerPort, "lblServerPort");
            this.lblServerPort.Name = "lblServerPort";
            // 
            // lblRconPassword
            // 
            resources.ApplyResources(this.lblRconPassword, "lblRconPassword");
            this.lblRconPassword.Name = "lblRconPassword";
            // 
            // cmbPunkbuster
            // 
            resources.ApplyResources(this.cmbPunkbuster, "cmbPunkbuster");
            this.cmbPunkbuster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPunkbuster.FormattingEnabled = true;
            this.cmbPunkbuster.Items.AddRange(new object[] {
            resources.GetString("cmbPunkbuster.Items"),
            resources.GetString("cmbPunkbuster.Items1")});
            this.cmbPunkbuster.Name = "cmbPunkbuster";
            // 
            // btnBrowseGameLog
            // 
            resources.ApplyResources(this.btnBrowseGameLog, "btnBrowseGameLog");
            this.btnBrowseGameLog.Name = "btnBrowseGameLog";
            this.btnBrowseGameLog.UseVisualStyleBackColor = true;
            this.btnBrowseGameLog.Click += new System.EventHandler(this.btnBrowseGameLog_Click);
            // 
            // txtGameLog
            // 
            resources.ApplyResources(this.txtGameLog, "txtGameLog");
            this.txtGameLog.Name = "txtGameLog";
            // 
            // txtLinesSec
            // 
            resources.ApplyResources(this.txtLinesSec, "txtLinesSec");
            this.txtLinesSec.Name = "txtLinesSec";
            // 
            // txtDelay
            // 
            resources.ApplyResources(this.txtDelay, "txtDelay");
            this.txtDelay.Name = "txtDelay";
            // 
            // txtRconIp
            // 
            resources.ApplyResources(this.txtRconIp, "txtRconIp");
            this.txtRconIp.Name = "txtRconIp";
            // 
            // txtPublicIp
            // 
            resources.ApplyResources(this.txtPublicIp, "txtPublicIp");
            this.txtPublicIp.Name = "txtPublicIp";
            // 
            // txtServerPort
            // 
            resources.ApplyResources(this.txtServerPort, "txtServerPort");
            this.txtServerPort.Name = "txtServerPort";
            // 
            // txtRconPassword
            // 
            resources.ApplyResources(this.txtRconPassword, "txtRconPassword");
            this.txtRconPassword.Name = "txtRconPassword";
            this.txtRconPassword.UseSystemPasswordChar = true;
            // 
            // tabAutodoc
            // 
            resources.ApplyResources(this.tabAutodoc, "tabAutodoc");
            this.tabAutodoc.Controls.Add(this.lblDestination);
            this.tabAutodoc.Controls.Add(this.lblMaxLevel);
            this.tabAutodoc.Controls.Add(this.lblType);
            this.tabAutodoc.Controls.Add(this.txtDestination);
            this.tabAutodoc.Controls.Add(this.btnBrowseDestination);
            this.tabAutodoc.Controls.Add(this.txtMaxLevel);
            this.tabAutodoc.Controls.Add(this.cmbType);
            this.tabAutodoc.Name = "tabAutodoc";
            this.tabAutodoc.UseVisualStyleBackColor = true;
            // 
            // lblDestination
            // 
            resources.ApplyResources(this.lblDestination, "lblDestination");
            this.lblDestination.Name = "lblDestination";
            // 
            // lblMaxLevel
            // 
            resources.ApplyResources(this.lblMaxLevel, "lblMaxLevel");
            this.lblMaxLevel.Name = "lblMaxLevel";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // txtDestination
            // 
            resources.ApplyResources(this.txtDestination, "txtDestination");
            this.txtDestination.Name = "txtDestination";
            // 
            // btnBrowseDestination
            // 
            resources.ApplyResources(this.btnBrowseDestination, "btnBrowseDestination");
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // txtMaxLevel
            // 
            resources.ApplyResources(this.txtMaxLevel, "txtMaxLevel");
            this.txtMaxLevel.Name = "txtMaxLevel";
            // 
            // cmbType
            // 
            resources.ApplyResources(this.cmbType, "cmbType");
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            resources.GetString("cmbType.Items"),
            resources.GetString("cmbType.Items1"),
            resources.GetString("cmbType.Items2")});
            this.cmbType.Name = "cmbType";
            // 
            // tabUpdate
            // 
            resources.ApplyResources(this.tabUpdate, "tabUpdate");
            this.tabUpdate.Controls.Add(this.lblChannel);
            this.tabUpdate.Controls.Add(this.cmbChannel);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // lblChannel
            // 
            resources.ApplyResources(this.lblChannel, "lblChannel");
            this.lblChannel.Name = "lblChannel";
            // 
            // cmbChannel
            // 
            resources.ApplyResources(this.cmbChannel, "cmbChannel");
            this.cmbChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Items.AddRange(new object[] {
            resources.GetString("cmbChannel.Items"),
            resources.GetString("cmbChannel.Items1"),
            resources.GetString("cmbChannel.Items2")});
            this.cmbChannel.Name = "cmbChannel";
            // 
            // tabMessages
            // 
            resources.ApplyResources(this.tabMessages, "tabMessages");
            this.tabMessages.Controls.Add(this.lblUnbanned);
            this.tabMessages.Controls.Add(this.lblUnbannedBy);
            this.tabMessages.Controls.Add(this.lblTempBanned);
            this.tabMessages.Controls.Add(this.lblTempBannedBy);
            this.tabMessages.Controls.Add(this.lblBanned);
            this.tabMessages.Controls.Add(this.lblBannedBy);
            this.tabMessages.Controls.Add(this.lblKicked);
            this.tabMessages.Controls.Add(this.lblKickedBy);
            this.tabMessages.Controls.Add(this.txtUnbanned);
            this.tabMessages.Controls.Add(this.txtUnbannedBy);
            this.tabMessages.Controls.Add(this.txtTempBanned);
            this.tabMessages.Controls.Add(this.txtTempBannedBy);
            this.tabMessages.Controls.Add(this.txtBanned);
            this.tabMessages.Controls.Add(this.txtBannedBy);
            this.tabMessages.Controls.Add(this.txtKicked);
            this.tabMessages.Controls.Add(this.txtKickedBy);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // lblUnbanned
            // 
            resources.ApplyResources(this.lblUnbanned, "lblUnbanned");
            this.lblUnbanned.Name = "lblUnbanned";
            // 
            // lblUnbannedBy
            // 
            resources.ApplyResources(this.lblUnbannedBy, "lblUnbannedBy");
            this.lblUnbannedBy.Name = "lblUnbannedBy";
            // 
            // lblTempBanned
            // 
            resources.ApplyResources(this.lblTempBanned, "lblTempBanned");
            this.lblTempBanned.Name = "lblTempBanned";
            // 
            // lblTempBannedBy
            // 
            resources.ApplyResources(this.lblTempBannedBy, "lblTempBannedBy");
            this.lblTempBannedBy.Name = "lblTempBannedBy";
            // 
            // lblBanned
            // 
            resources.ApplyResources(this.lblBanned, "lblBanned");
            this.lblBanned.Name = "lblBanned";
            // 
            // lblBannedBy
            // 
            resources.ApplyResources(this.lblBannedBy, "lblBannedBy");
            this.lblBannedBy.Name = "lblBannedBy";
            // 
            // lblKicked
            // 
            resources.ApplyResources(this.lblKicked, "lblKicked");
            this.lblKicked.Name = "lblKicked";
            // 
            // lblKickedBy
            // 
            resources.ApplyResources(this.lblKickedBy, "lblKickedBy");
            this.lblKickedBy.Name = "lblKickedBy";
            // 
            // txtUnbanned
            // 
            resources.ApplyResources(this.txtUnbanned, "txtUnbanned");
            this.txtUnbanned.Name = "txtUnbanned";
            // 
            // txtUnbannedBy
            // 
            resources.ApplyResources(this.txtUnbannedBy, "txtUnbannedBy");
            this.txtUnbannedBy.Name = "txtUnbannedBy";
            // 
            // txtTempBanned
            // 
            resources.ApplyResources(this.txtTempBanned, "txtTempBanned");
            this.txtTempBanned.Name = "txtTempBanned";
            // 
            // txtTempBannedBy
            // 
            resources.ApplyResources(this.txtTempBannedBy, "txtTempBannedBy");
            this.txtTempBannedBy.Name = "txtTempBannedBy";
            // 
            // txtBanned
            // 
            resources.ApplyResources(this.txtBanned, "txtBanned");
            this.txtBanned.Name = "txtBanned";
            // 
            // txtBannedBy
            // 
            resources.ApplyResources(this.txtBannedBy, "txtBannedBy");
            this.txtBannedBy.Name = "txtBannedBy";
            // 
            // txtKicked
            // 
            resources.ApplyResources(this.txtKicked, "txtKicked");
            this.txtKicked.Name = "txtKicked";
            // 
            // txtKickedBy
            // 
            resources.ApplyResources(this.txtKickedBy, "txtKickedBy");
            this.txtKickedBy.Name = "txtKickedBy";
            // 
            // tabPlugins
            // 
            this.tabPlugins.Controls.Add(this.lblPlugins);
            resources.ApplyResources(this.tabPlugins, "tabPlugins");
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.UseVisualStyleBackColor = true;
            // 
            // lblPlugins
            // 
            resources.ApplyResources(this.lblPlugins, "lblPlugins");
            this.lblPlugins.Name = "lblPlugins";
            // 
            // ofdGameLog
            // 
            this.ofdGameLog.FileName = "games_mp.log";
            // 
            // btnSaveConfig
            // 
            resources.ApplyResources(this.btnSaveConfig, "btnSaveConfig");
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // sfdConfig
            // 
            this.sfdConfig.DefaultExt = "xml";
            resources.ApplyResources(this.sfdConfig, "sfdConfig");
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnRun;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.tabConfiguration);
            this.Controls.Add(this.chkRestart);
            this.Controls.Add(this.btnBrowseConfig);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.lblExecutable);
            this.Controls.Add(this.btnBrowseExecutable);
            this.Controls.Add(this.btnRun);
            this.Name = "FormMain";
            this.tabConfiguration.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabServer.ResumeLayout(false);
            this.tabServer.PerformLayout();
            this.tabAutodoc.ResumeLayout(false);
            this.tabAutodoc.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabMessages.ResumeLayout(false);
            this.tabMessages.PerformLayout();
            this.tabPlugins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.OpenFileDialog ofdExecutable;
        private System.Windows.Forms.Button btnBrowseExecutable;
        private System.Windows.Forms.Label lblExecutable;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Button btnBrowseConfig;
        private System.Windows.Forms.OpenFileDialog ofdConfig;
        private System.Windows.Forms.CheckBox chkRestart;
        private System.Windows.Forms.TabControl tabConfiguration;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.TabPage tabAutodoc;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.TabPage tabPlugins;
        private System.Windows.Forms.Label lblBotName;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.Label lblLogLevel;
        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.Label lblTimeFormat;
        private System.Windows.Forms.Label lblBotPrefix;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblParser;
        private System.Windows.Forms.Button btnLogFile;
        private System.Windows.Forms.Label lblGameLog;
        private System.Windows.Forms.Label lblPunkbuster;
        private System.Windows.Forms.Label lblLinesSec;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblRconIp;
        private System.Windows.Forms.Label lblPublicIp;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.Label lblRconPassword;
        private System.Windows.Forms.Button btnBrowseGameLog;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblMaxLevel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblUnbanned;
        private System.Windows.Forms.Label lblUnbannedBy;
        private System.Windows.Forms.Label lblTempBanned;
        private System.Windows.Forms.Label lblTempBannedBy;
        private System.Windows.Forms.Label lblBanned;
        private System.Windows.Forms.Label lblBannedBy;
        private System.Windows.Forms.Label lblKicked;
        private System.Windows.Forms.Label lblKickedBy;
        private System.Windows.Forms.OpenFileDialog ofdGameLog;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label lblPlugins;
        private System.Windows.Forms.SaveFileDialog sfdConfig;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.FolderBrowserDialog fbdLogFile;
        private System.Windows.Forms.FolderBrowserDialog fbdAutodoc;
        public System.Windows.Forms.TextBox txtBotName;
        public System.Windows.Forms.TextBox txtLogFile;
        public System.Windows.Forms.ComboBox cmbLogLevel;
        public System.Windows.Forms.ComboBox cmbTimeZone;
        public System.Windows.Forms.ComboBox cmbTimeFormat;
        public System.Windows.Forms.TextBox txtBotPrefix;
        public System.Windows.Forms.TextBox txtDatabase;
        public System.Windows.Forms.ComboBox cmbParser;
        public System.Windows.Forms.ComboBox cmbPunkbuster;
        public System.Windows.Forms.TextBox txtGameLog;
        public System.Windows.Forms.TextBox txtLinesSec;
        public System.Windows.Forms.TextBox txtDelay;
        public System.Windows.Forms.TextBox txtRconIp;
        public System.Windows.Forms.TextBox txtPublicIp;
        public System.Windows.Forms.TextBox txtServerPort;
        public System.Windows.Forms.TextBox txtRconPassword;
        public System.Windows.Forms.TextBox txtDestination;
        public System.Windows.Forms.TextBox txtMaxLevel;
        public System.Windows.Forms.ComboBox cmbType;
        public System.Windows.Forms.ComboBox cmbChannel;
        public System.Windows.Forms.TextBox txtUnbanned;
        public System.Windows.Forms.TextBox txtUnbannedBy;
        public System.Windows.Forms.TextBox txtTempBanned;
        public System.Windows.Forms.TextBox txtTempBannedBy;
        public System.Windows.Forms.TextBox txtBanned;
        public System.Windows.Forms.TextBox txtBannedBy;
        public System.Windows.Forms.TextBox txtKicked;
        public System.Windows.Forms.TextBox txtKickedBy;
    }
}

