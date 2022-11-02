namespace WindowsFormsApplication1
{
    partial class heat_exchanger_scada
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(heat_exchanger_scada));
            this.ShowOPC = new System.Windows.Forms.Button();
            this.ListServeurs = new System.Windows.Forms.ListBox();
            this.nomServeur = new System.Windows.Forms.Label();
            this.etatServeur = new System.Windows.Forms.Label();
            this.heureServeur = new System.Windows.Forms.Label();
            this.DisconnectServer = new System.Windows.Forms.Button();
            this.StartServer = new System.Windows.Forms.Button();
            this.ledFEED = new System.Windows.Forms.Label();
            this.steamFEED = new System.Windows.Forms.Label();
            this.feed_valve_title = new System.Windows.Forms.Label();
            this.flush_valve_title = new System.Windows.Forms.Label();
            this.steam_valve_title = new System.Windows.Forms.Label();
            this.steam_temp_title = new System.Windows.Forms.Label();
            this.tank_temp_title = new System.Windows.Forms.Label();
            this.feed_flow_value = new System.Windows.Forms.TextBox();
            this.tank_temp_value = new System.Windows.Forms.TextBox();
            this.waterRempli = new System.Windows.Forms.Label();
            this.waterEmpty = new System.Windows.Forms.Label();
            this.tank_level_title = new System.Windows.Forms.Label();
            this.tank_level_value = new System.Windows.Forms.TextBox();
            this.steam_temp_value = new System.Windows.Forms.TextBox();
            this.feed_flow_title = new System.Windows.Forms.Label();
            this.pipe_Steam = new System.Windows.Forms.Label();
            this.flush_flow_value = new System.Windows.Forms.TextBox();
            this.flush_flow_title = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1_2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Label();
            this.feedSWITCH = new System.Windows.Forms.Button();
            this.steamSWITCH = new System.Windows.Forms.Button();
            this.flushSWITCH = new System.Windows.Forms.Button();
            this.titreSCADA = new System.Windows.Forms.Label();
            this.pipe_Feed_fixe = new System.Windows.Forms.Label();
            this.pipe_Flush_fixe = new System.Windows.Forms.Label();
            this.listAlarmesBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Label();
            this.titreALARMS = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1_1 = new System.Windows.Forms.Label();
            this.panel1_3 = new System.Windows.Forms.Label();
            this.universiteImage = new System.Windows.Forms.PictureBox();
            this.polytechImage = new System.Windows.Forms.PictureBox();
            this.realisepar1 = new System.Windows.Forms.Label();
            this.realisepar3 = new System.Windows.Forms.Label();
            this.realisepar2 = new System.Windows.Forms.Label();
            this.logoHeatImage = new System.Windows.Forms.PictureBox();
            this.pipe_Feed = new System.Windows.Forms.Label();
            this.pipe_Flush = new System.Windows.Forms.Label();
            this.pipe_Steam_fixe = new System.Windows.Forms.Label();
            this.flushFEED = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universiteImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polytechImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHeatImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowOPC
            // 
            this.ShowOPC.BackColor = System.Drawing.Color.Yellow;
            this.ShowOPC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowOPC.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowOPC.Location = new System.Drawing.Point(145, 32);
            this.ShowOPC.Name = "ShowOPC";
            this.ShowOPC.Size = new System.Drawing.Size(238, 32);
            this.ShowOPC.TabIndex = 0;
            this.ShowOPC.Text = "Show OPC Servers";
            this.ShowOPC.UseVisualStyleBackColor = false;
            this.ShowOPC.Click += new System.EventHandler(this.ShowOPC_click);
            // 
            // ListServeurs
            // 
            this.ListServeurs.BackColor = System.Drawing.Color.GhostWhite;
            this.ListServeurs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListServeurs.FormattingEnabled = true;
            this.ListServeurs.Location = new System.Drawing.Point(146, 68);
            this.ListServeurs.Name = "ListServeurs";
            this.ListServeurs.Size = new System.Drawing.Size(237, 43);
            this.ListServeurs.TabIndex = 1;
            this.ListServeurs.SelectedIndexChanged += new System.EventHandler(this.ListServeurs_SelectedIndexChanged);
            // 
            // nomServeur
            // 
            this.nomServeur.AutoSize = true;
            this.nomServeur.BackColor = System.Drawing.Color.Yellow;
            this.nomServeur.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomServeur.Location = new System.Drawing.Point(145, 155);
            this.nomServeur.Name = "nomServeur";
            this.nomServeur.Size = new System.Drawing.Size(97, 13);
            this.nomServeur.TabIndex = 2;
            this.nomServeur.Text = "Nom du Serveur : ";
            // 
            // etatServeur
            // 
            this.etatServeur.AutoSize = true;
            this.etatServeur.BackColor = System.Drawing.Color.Yellow;
            this.etatServeur.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etatServeur.Location = new System.Drawing.Point(145, 174);
            this.etatServeur.Name = "etatServeur";
            this.etatServeur.Size = new System.Drawing.Size(89, 13);
            this.etatServeur.TabIndex = 3;
            this.etatServeur.Text = "Etat du Serveur :";
            // 
            // heureServeur
            // 
            this.heureServeur.AutoSize = true;
            this.heureServeur.BackColor = System.Drawing.Color.Yellow;
            this.heureServeur.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heureServeur.Location = new System.Drawing.Point(145, 193);
            this.heureServeur.Name = "heureServeur";
            this.heureServeur.Size = new System.Drawing.Size(99, 13);
            this.heureServeur.TabIndex = 4;
            this.heureServeur.Text = "Heure du Serveur :";
            // 
            // DisconnectServer
            // 
            this.DisconnectServer.BackColor = System.Drawing.Color.Yellow;
            this.DisconnectServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisconnectServer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectServer.Location = new System.Drawing.Point(261, 115);
            this.DisconnectServer.Name = "DisconnectServer";
            this.DisconnectServer.Size = new System.Drawing.Size(122, 34);
            this.DisconnectServer.TabIndex = 5;
            this.DisconnectServer.Text = "Disconnect Server";
            this.DisconnectServer.UseVisualStyleBackColor = false;
            this.DisconnectServer.Click += new System.EventHandler(this.DisconnectServer_Click);
            // 
            // StartServer
            // 
            this.StartServer.BackColor = System.Drawing.Color.Yellow;
            this.StartServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartServer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartServer.Location = new System.Drawing.Point(145, 115);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(112, 34);
            this.StartServer.TabIndex = 8;
            this.StartServer.Text = "Start server";
            this.StartServer.UseVisualStyleBackColor = false;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // ledFEED
            // 
            this.ledFEED.AutoSize = true;
            this.ledFEED.BackColor = System.Drawing.Color.Red;
            this.ledFEED.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledFEED.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ledFEED.Location = new System.Drawing.Point(80, 280);
            this.ledFEED.Name = "ledFEED";
            this.ledFEED.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.ledFEED.Size = new System.Drawing.Size(50, 36);
            this.ledFEED.TabIndex = 9;
            // 
            // steamFEED
            // 
            this.steamFEED.AutoSize = true;
            this.steamFEED.BackColor = System.Drawing.Color.Red;
            this.steamFEED.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamFEED.ForeColor = System.Drawing.SystemColors.ControlText;
            this.steamFEED.Location = new System.Drawing.Point(75, 501);
            this.steamFEED.Name = "steamFEED";
            this.steamFEED.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.steamFEED.Size = new System.Drawing.Size(50, 36);
            this.steamFEED.TabIndex = 11;
            // 
            // feed_valve_title
            // 
            this.feed_valve_title.AutoSize = true;
            this.feed_valve_title.BackColor = System.Drawing.Color.Yellow;
            this.feed_valve_title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feed_valve_title.Location = new System.Drawing.Point(98, 334);
            this.feed_valve_title.Name = "feed_valve_title";
            this.feed_valve_title.Size = new System.Drawing.Size(62, 13);
            this.feed_valve_title.TabIndex = 12;
            this.feed_valve_title.Text = "Feed Valve";
            // 
            // flush_valve_title
            // 
            this.flush_valve_title.AutoSize = true;
            this.flush_valve_title.BackColor = System.Drawing.Color.Yellow;
            this.flush_valve_title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.flush_valve_title.Location = new System.Drawing.Point(379, 446);
            this.flush_valve_title.Name = "flush_valve_title";
            this.flush_valve_title.Size = new System.Drawing.Size(65, 13);
            this.flush_valve_title.TabIndex = 13;
            this.flush_valve_title.Text = "Flush Valve";
            // 
            // steam_valve_title
            // 
            this.steam_valve_title.AutoSize = true;
            this.steam_valve_title.BackColor = System.Drawing.Color.Yellow;
            this.steam_valve_title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.steam_valve_title.Location = new System.Drawing.Point(95, 446);
            this.steam_valve_title.Name = "steam_valve_title";
            this.steam_valve_title.Size = new System.Drawing.Size(69, 13);
            this.steam_valve_title.TabIndex = 14;
            this.steam_valve_title.Text = "Steam Valve";
            // 
            // steam_temp_title
            // 
            this.steam_temp_title.AutoSize = true;
            this.steam_temp_title.BackColor = System.Drawing.Color.Yellow;
            this.steam_temp_title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.steam_temp_title.Location = new System.Drawing.Point(20, 446);
            this.steam_temp_title.Name = "steam_temp_title";
            this.steam_temp_title.Size = new System.Drawing.Size(70, 13);
            this.steam_temp_title.TabIndex = 15;
            this.steam_temp_title.Text = "Steam Temp";
            // 
            // tank_temp_title
            // 
            this.tank_temp_title.AutoSize = true;
            this.tank_temp_title.BackColor = System.Drawing.Color.Yellow;
            this.tank_temp_title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tank_temp_title.Location = new System.Drawing.Point(275, 529);
            this.tank_temp_title.Name = "tank_temp_title";
            this.tank_temp_title.Size = new System.Drawing.Size(62, 13);
            this.tank_temp_title.TabIndex = 16;
            this.tank_temp_title.Text = "Tank Temp";
            // 
            // feed_flow_value
            // 
            this.feed_flow_value.BackColor = System.Drawing.Color.Yellow;
            this.feed_flow_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feed_flow_value.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.feed_flow_value.Location = new System.Drawing.Point(38, 353);
            this.feed_flow_value.Name = "feed_flow_value";
            this.feed_flow_value.Size = new System.Drawing.Size(51, 22);
            this.feed_flow_value.TabIndex = 17;
            // 
            // tank_temp_value
            // 
            this.tank_temp_value.BackColor = System.Drawing.Color.Yellow;
            this.tank_temp_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tank_temp_value.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tank_temp_value.Location = new System.Drawing.Point(274, 545);
            this.tank_temp_value.Name = "tank_temp_value";
            this.tank_temp_value.Size = new System.Drawing.Size(63, 22);
            this.tank_temp_value.TabIndex = 18;
            // 
            // waterRempli
            // 
            this.waterRempli.AutoSize = true;
            this.waterRempli.BackColor = System.Drawing.Color.DarkCyan;
            this.waterRempli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterRempli.Location = new System.Drawing.Point(169, 256);
            this.waterRempli.Name = "waterRempli";
            this.waterRempli.Padding = new System.Windows.Forms.Padding(100, 300, 100, 0);
            this.waterRempli.Size = new System.Drawing.Size(202, 315);
            this.waterRempli.TabIndex = 19;
            // 
            // waterEmpty
            // 
            this.waterEmpty.AutoSize = true;
            this.waterEmpty.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.waterEmpty.Location = new System.Drawing.Point(170, 256);
            this.waterEmpty.Name = "waterEmpty";
            this.waterEmpty.Padding = new System.Windows.Forms.Padding(100, 130, 100, 0);
            this.waterEmpty.Size = new System.Drawing.Size(200, 143);
            this.waterEmpty.TabIndex = 20;
            // 
            // tank_level_title
            // 
            this.tank_level_title.AutoSize = true;
            this.tank_level_title.BackColor = System.Drawing.Color.Yellow;
            this.tank_level_title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tank_level_title.Location = new System.Drawing.Point(203, 529);
            this.tank_level_title.Name = "tank_level_title";
            this.tank_level_title.Size = new System.Drawing.Size(61, 13);
            this.tank_level_title.TabIndex = 21;
            this.tank_level_title.Text = "Tank Level";
            // 
            // tank_level_value
            // 
            this.tank_level_value.BackColor = System.Drawing.Color.Yellow;
            this.tank_level_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tank_level_value.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tank_level_value.Location = new System.Drawing.Point(201, 545);
            this.tank_level_value.Name = "tank_level_value";
            this.tank_level_value.Size = new System.Drawing.Size(65, 22);
            this.tank_level_value.TabIndex = 22;
            // 
            // steam_temp_value
            // 
            this.steam_temp_value.BackColor = System.Drawing.Color.Yellow;
            this.steam_temp_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.steam_temp_value.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.steam_temp_value.Location = new System.Drawing.Point(32, 468);
            this.steam_temp_value.Name = "steam_temp_value";
            this.steam_temp_value.Size = new System.Drawing.Size(51, 22);
            this.steam_temp_value.TabIndex = 24;
            // 
            // feed_flow_title
            // 
            this.feed_flow_title.AutoSize = true;
            this.feed_flow_title.BackColor = System.Drawing.Color.Yellow;
            this.feed_flow_title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.feed_flow_title.Location = new System.Drawing.Point(34, 334);
            this.feed_flow_title.Name = "feed_flow_title";
            this.feed_flow_title.Size = new System.Drawing.Size(60, 13);
            this.feed_flow_title.TabIndex = 23;
            this.feed_flow_title.Text = "Feed Flow";
            // 
            // pipe_Steam
            // 
            this.pipe_Steam.AutoSize = true;
            this.pipe_Steam.BackColor = System.Drawing.Color.DarkGray;
            this.pipe_Steam.Location = new System.Drawing.Point(31, 510);
            this.pipe_Steam.Name = "pipe_Steam";
            this.pipe_Steam.Padding = new System.Windows.Forms.Padding(75, 2, 60, 2);
            this.pipe_Steam.Size = new System.Drawing.Size(135, 17);
            this.pipe_Steam.TabIndex = 26;
            // 
            // flush_flow_value
            // 
            this.flush_flow_value.BackColor = System.Drawing.Color.Yellow;
            this.flush_flow_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flush_flow_value.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.flush_flow_value.Location = new System.Drawing.Point(452, 467);
            this.flush_flow_value.Name = "flush_flow_value";
            this.flush_flow_value.Size = new System.Drawing.Size(57, 22);
            this.flush_flow_value.TabIndex = 29;
            // 
            // flush_flow_title
            // 
            this.flush_flow_title.AutoSize = true;
            this.flush_flow_title.BackColor = System.Drawing.Color.Yellow;
            this.flush_flow_title.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.flush_flow_title.Location = new System.Drawing.Point(450, 446);
            this.flush_flow_title.Name = "flush_flow_title";
            this.flush_flow_title.Size = new System.Drawing.Size(63, 13);
            this.flush_flow_title.TabIndex = 28;
            this.flush_flow_title.Text = "Flush Flow";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(168, 256);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(100, 304, 103, 0);
            this.label20.Size = new System.Drawing.Size(203, 317);
            this.label20.TabIndex = 30;
            // 
            // panel1_2
            // 
            this.panel1_2.AutoSize = true;
            this.panel1_2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel1_2.Location = new System.Drawing.Point(138, 2);
            this.panel1_2.Name = "panel1_2";
            this.panel1_2.Padding = new System.Windows.Forms.Padding(0, 200, 255, 0);
            this.panel1_2.Size = new System.Drawing.Size(255, 213);
            this.panel1_2.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Location = new System.Drawing.Point(1, 218);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 349, 525, 0);
            this.panel2.Size = new System.Drawing.Size(525, 362);
            this.panel2.TabIndex = 34;
            // 
            // feedSWITCH
            // 
            this.feedSWITCH.BackColor = System.Drawing.Color.Yellow;
            this.feedSWITCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.feedSWITCH.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.feedSWITCH.Location = new System.Drawing.Point(99, 353);
            this.feedSWITCH.Margin = new System.Windows.Forms.Padding(2);
            this.feedSWITCH.Name = "feedSWITCH";
            this.feedSWITCH.Size = new System.Drawing.Size(59, 22);
            this.feedSWITCH.TabIndex = 36;
            this.feedSWITCH.Text = "SWITCH";
            this.feedSWITCH.UseVisualStyleBackColor = false;
            this.feedSWITCH.Click += new System.EventHandler(this.feedSWITCH_Click);
            // 
            // steamSWITCH
            // 
            this.steamSWITCH.BackColor = System.Drawing.Color.Yellow;
            this.steamSWITCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.steamSWITCH.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.steamSWITCH.Location = new System.Drawing.Point(99, 468);
            this.steamSWITCH.Margin = new System.Windows.Forms.Padding(2);
            this.steamSWITCH.Name = "steamSWITCH";
            this.steamSWITCH.Size = new System.Drawing.Size(59, 22);
            this.steamSWITCH.TabIndex = 39;
            this.steamSWITCH.Text = "SWITCH";
            this.steamSWITCH.UseVisualStyleBackColor = false;
            this.steamSWITCH.Click += new System.EventHandler(this.steamSWITCH_Click);
            // 
            // flushSWITCH
            // 
            this.flushSWITCH.BackColor = System.Drawing.Color.Yellow;
            this.flushSWITCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flushSWITCH.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.flushSWITCH.Location = new System.Drawing.Point(380, 466);
            this.flushSWITCH.Margin = new System.Windows.Forms.Padding(2);
            this.flushSWITCH.Name = "flushSWITCH";
            this.flushSWITCH.Size = new System.Drawing.Size(59, 23);
            this.flushSWITCH.TabIndex = 41;
            this.flushSWITCH.Text = "SWITCH";
            this.flushSWITCH.UseVisualStyleBackColor = false;
            this.flushSWITCH.Click += new System.EventHandler(this.flushSWITCH_Click);
            // 
            // titreSCADA
            // 
            this.titreSCADA.AutoSize = true;
            this.titreSCADA.BackColor = System.Drawing.Color.Yellow;
            this.titreSCADA.Font = new System.Drawing.Font("SWRomnt", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreSCADA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.titreSCADA.Location = new System.Drawing.Point(155, 9);
            this.titreSCADA.Name = "titreSCADA";
            this.titreSCADA.Size = new System.Drawing.Size(214, 17);
            this.titreSCADA.TabIndex = 47;
            this.titreSCADA.Text = "Heat Exchanger SCADA";
            // 
            // pipe_Feed_fixe
            // 
            this.pipe_Feed_fixe.AutoSize = true;
            this.pipe_Feed_fixe.BackColor = System.Drawing.Color.DarkCyan;
            this.pipe_Feed_fixe.Location = new System.Drawing.Point(33, 288);
            this.pipe_Feed_fixe.Name = "pipe_Feed_fixe";
            this.pipe_Feed_fixe.Padding = new System.Windows.Forms.Padding(30, 2, 60, 2);
            this.pipe_Feed_fixe.Size = new System.Drawing.Size(90, 17);
            this.pipe_Feed_fixe.TabIndex = 49;
            // 
            // pipe_Flush_fixe
            // 
            this.pipe_Flush_fixe.AutoSize = true;
            this.pipe_Flush_fixe.BackColor = System.Drawing.Color.DarkCyan;
            this.pipe_Flush_fixe.Location = new System.Drawing.Point(371, 510);
            this.pipe_Flush_fixe.Name = "pipe_Flush_fixe";
            this.pipe_Flush_fixe.Padding = new System.Windows.Forms.Padding(75, 2, 60, 2);
            this.pipe_Flush_fixe.Size = new System.Drawing.Size(135, 17);
            this.pipe_Flush_fixe.TabIndex = 50;
            // 
            // listAlarmesBox
            // 
            this.listAlarmesBox.BackColor = System.Drawing.Color.Yellow;
            this.listAlarmesBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.listAlarmesBox.ForeColor = System.Drawing.Color.Red;
            this.listAlarmesBox.FormattingEnabled = true;
            this.listAlarmesBox.Location = new System.Drawing.Point(6, 611);
            this.listAlarmesBox.Margin = new System.Windows.Forms.Padding(2);
            this.listAlarmesBox.Name = "listAlarmesBox";
            this.listAlarmesBox.Size = new System.Drawing.Size(519, 30);
            this.listAlarmesBox.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel3.Location = new System.Drawing.Point(3, 582);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 50, 525, 0);
            this.panel3.Size = new System.Drawing.Size(525, 63);
            this.panel3.TabIndex = 54;
            // 
            // titreALARMS
            // 
            this.titreALARMS.AutoSize = true;
            this.titreALARMS.BackColor = System.Drawing.Color.Yellow;
            this.titreALARMS.Font = new System.Drawing.Font("SWRomnt", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreALARMS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.titreALARMS.Location = new System.Drawing.Point(194, 590);
            this.titreALARMS.Name = "titreALARMS";
            this.titreALARMS.Size = new System.Drawing.Size(139, 17);
            this.titreALARMS.TabIndex = 55;
            this.titreALARMS.Text = "List of Alarms";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.ForestGreen;
            this.label24.Location = new System.Drawing.Point(0, -1);
            this.label24.Name = "label24";
            this.label24.Padding = new System.Windows.Forms.Padding(520, 0, 0, 640);
            this.label24.Size = new System.Drawing.Size(530, 653);
            this.label24.TabIndex = 56;
            this.label24.Text = " ";
            // 
            // panel1_1
            // 
            this.panel1_1.AutoSize = true;
            this.panel1_1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel1_1.Location = new System.Drawing.Point(3, 2);
            this.panel1_1.Name = "panel1_1";
            this.panel1_1.Padding = new System.Windows.Forms.Padding(0, 200, 132, 0);
            this.panel1_1.Size = new System.Drawing.Size(132, 213);
            this.panel1_1.TabIndex = 57;
            // 
            // panel1_3
            // 
            this.panel1_3.AutoSize = true;
            this.panel1_3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panel1_3.Location = new System.Drawing.Point(395, 2);
            this.panel1_3.Name = "panel1_3";
            this.panel1_3.Padding = new System.Windows.Forms.Padding(0, 200, 132, 0);
            this.panel1_3.Size = new System.Drawing.Size(132, 213);
            this.panel1_3.TabIndex = 58;
            // 
            // universiteImage
            // 
            this.universiteImage.BackColor = System.Drawing.Color.YellowGreen;
            this.universiteImage.Image = ((System.Drawing.Image)(resources.GetObject("universiteImage.Image")));
            this.universiteImage.Location = new System.Drawing.Point(17, 67);
            this.universiteImage.Name = "universiteImage";
            this.universiteImage.Size = new System.Drawing.Size(100, 68);
            this.universiteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.universiteImage.TabIndex = 59;
            this.universiteImage.TabStop = false;
            // 
            // polytechImage
            // 
            this.polytechImage.BackColor = System.Drawing.Color.YellowGreen;
            this.polytechImage.Image = ((System.Drawing.Image)(resources.GetObject("polytechImage.Image")));
            this.polytechImage.Location = new System.Drawing.Point(17, 6);
            this.polytechImage.Name = "polytechImage";
            this.polytechImage.Size = new System.Drawing.Size(100, 68);
            this.polytechImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.polytechImage.TabIndex = 60;
            this.polytechImage.TabStop = false;
            // 
            // realisepar1
            // 
            this.realisepar1.AutoSize = true;
            this.realisepar1.BackColor = System.Drawing.Color.YellowGreen;
            this.realisepar1.Font = new System.Drawing.Font("SWRomnt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realisepar1.Location = new System.Drawing.Point(40, 153);
            this.realisepar1.Name = "realisepar1";
            this.realisepar1.Size = new System.Drawing.Size(54, 14);
            this.realisepar1.TabIndex = 61;
            this.realisepar1.Text = "Réalisé";
            // 
            // realisepar3
            // 
            this.realisepar3.AutoSize = true;
            this.realisepar3.BackColor = System.Drawing.Color.YellowGreen;
            this.realisepar3.Font = new System.Drawing.Font("SWRomnt", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realisepar3.Location = new System.Drawing.Point(8, 192);
            this.realisepar3.Name = "realisepar3";
            this.realisepar3.Size = new System.Drawing.Size(120, 14);
            this.realisepar3.TabIndex = 62;
            this.realisepar3.Text = "Ayoub EL ASRI";
            // 
            // realisepar2
            // 
            this.realisepar2.AutoSize = true;
            this.realisepar2.BackColor = System.Drawing.Color.YellowGreen;
            this.realisepar2.Font = new System.Drawing.Font("SWRomnt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realisepar2.Location = new System.Drawing.Point(52, 171);
            this.realisepar2.Name = "realisepar2";
            this.realisepar2.Size = new System.Drawing.Size(30, 14);
            this.realisepar2.TabIndex = 63;
            this.realisepar2.Text = "par";
            // 
            // logoHeatImage
            // 
            this.logoHeatImage.BackColor = System.Drawing.Color.YellowGreen;
            this.logoHeatImage.Image = ((System.Drawing.Image)(resources.GetObject("logoHeatImage.Image")));
            this.logoHeatImage.Location = new System.Drawing.Point(395, 5);
            this.logoHeatImage.Name = "logoHeatImage";
            this.logoHeatImage.Size = new System.Drawing.Size(129, 209);
            this.logoHeatImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoHeatImage.TabIndex = 64;
            this.logoHeatImage.TabStop = false;
            // 
            // pipe_Feed
            // 
            this.pipe_Feed.AutoSize = true;
            this.pipe_Feed.BackColor = System.Drawing.Color.DarkGray;
            this.pipe_Feed.Location = new System.Drawing.Point(127, 288);
            this.pipe_Feed.Name = "pipe_Feed";
            this.pipe_Feed.Padding = new System.Windows.Forms.Padding(1, 2, 40, 2);
            this.pipe_Feed.Size = new System.Drawing.Size(41, 17);
            this.pipe_Feed.TabIndex = 65;
            // 
            // pipe_Flush
            // 
            this.pipe_Flush.AutoSize = true;
            this.pipe_Flush.BackColor = System.Drawing.Color.DarkGray;
            this.pipe_Flush.Location = new System.Drawing.Point(466, 510);
            this.pipe_Flush.Name = "pipe_Flush";
            this.pipe_Flush.Padding = new System.Windows.Forms.Padding(1, 2, 40, 2);
            this.pipe_Flush.Size = new System.Drawing.Size(41, 17);
            this.pipe_Flush.TabIndex = 66;
            // 
            // pipe_Steam_fixe
            // 
            this.pipe_Steam_fixe.AutoSize = true;
            this.pipe_Steam_fixe.BackColor = System.Drawing.Color.DarkCyan;
            this.pipe_Steam_fixe.Location = new System.Drawing.Point(78, 510);
            this.pipe_Steam_fixe.Name = "pipe_Steam_fixe";
            this.pipe_Steam_fixe.Padding = new System.Windows.Forms.Padding(30, 2, 60, 2);
            this.pipe_Steam_fixe.Size = new System.Drawing.Size(90, 17);
            this.pipe_Steam_fixe.TabIndex = 67;
            // 
            // flushFEED
            // 
            this.flushFEED.AutoSize = true;
            this.flushFEED.BackColor = System.Drawing.Color.Red;
            this.flushFEED.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flushFEED.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flushFEED.Location = new System.Drawing.Point(418, 500);
            this.flushFEED.Name = "flushFEED";
            this.flushFEED.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.flushFEED.Size = new System.Drawing.Size(50, 36);
            this.flushFEED.TabIndex = 68;
            // 
            // heat_exchanger_scada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 648);
            this.Controls.Add(this.flushFEED);
            this.Controls.Add(this.steamFEED);
            this.Controls.Add(this.pipe_Steam_fixe);
            this.Controls.Add(this.ledFEED);
            this.Controls.Add(this.pipe_Flush);
            this.Controls.Add(this.pipe_Feed);
            this.Controls.Add(this.logoHeatImage);
            this.Controls.Add(this.realisepar2);
            this.Controls.Add(this.realisepar3);
            this.Controls.Add(this.realisepar1);
            this.Controls.Add(this.polytechImage);
            this.Controls.Add(this.universiteImage);
            this.Controls.Add(this.panel1_3);
            this.Controls.Add(this.panel1_1);
            this.Controls.Add(this.listAlarmesBox);
            this.Controls.Add(this.titreALARMS);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tank_temp_title);
            this.Controls.Add(this.tank_temp_value);
            this.Controls.Add(this.titreSCADA);
            this.Controls.Add(this.flushSWITCH);
            this.Controls.Add(this.steamSWITCH);
            this.Controls.Add(this.feedSWITCH);
            this.Controls.Add(this.flush_flow_value);
            this.Controls.Add(this.flush_flow_title);
            this.Controls.Add(this.steam_temp_value);
            this.Controls.Add(this.tank_level_value);
            this.Controls.Add(this.tank_level_title);
            this.Controls.Add(this.waterEmpty);
            this.Controls.Add(this.waterRempli);
            this.Controls.Add(this.feed_flow_value);
            this.Controls.Add(this.steam_temp_title);
            this.Controls.Add(this.steam_valve_title);
            this.Controls.Add(this.flush_valve_title);
            this.Controls.Add(this.feed_valve_title);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.DisconnectServer);
            this.Controls.Add(this.heureServeur);
            this.Controls.Add(this.etatServeur);
            this.Controls.Add(this.nomServeur);
            this.Controls.Add(this.ListServeurs);
            this.Controls.Add(this.ShowOPC);
            this.Controls.Add(this.pipe_Steam);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.feed_flow_title);
            this.Controls.Add(this.panel1_2);
            this.Controls.Add(this.pipe_Feed_fixe);
            this.Controls.Add(this.pipe_Flush_fixe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label24);
            this.Name = "heat_exchanger_scada";
            this.Text = "Heat Exchanger SCADA";
            ((System.ComponentModel.ISupportInitialize)(this.universiteImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polytechImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHeatImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowOPC;
        private System.Windows.Forms.ListBox ListServeurs;
        private System.Windows.Forms.Label nomServeur;
        private System.Windows.Forms.Label etatServeur;
        private System.Windows.Forms.Label heureServeur;
        private System.Windows.Forms.Button DisconnectServer;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.Label ledFEED;
        private System.Windows.Forms.Label steamFEED;
        private System.Windows.Forms.Label feed_valve_title;
        private System.Windows.Forms.Label flush_valve_title;
        private System.Windows.Forms.Label steam_valve_title;
        private System.Windows.Forms.Label steam_temp_title;
        private System.Windows.Forms.Label tank_temp_title;
        private System.Windows.Forms.TextBox feed_flow_value;
        private System.Windows.Forms.TextBox tank_temp_value;
        private System.Windows.Forms.Label waterRempli;
        private System.Windows.Forms.Label waterEmpty;
        private System.Windows.Forms.Label tank_level_title;
        private System.Windows.Forms.TextBox tank_level_value;
        private System.Windows.Forms.TextBox steam_temp_value;
        private System.Windows.Forms.Label feed_flow_title;
        private System.Windows.Forms.Label pipe_Steam;
        private System.Windows.Forms.TextBox flush_flow_value;
        private System.Windows.Forms.Label flush_flow_title;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label panel1_2;
        private System.Windows.Forms.Label panel2;
        private System.Windows.Forms.Button feedSWITCH;
        private System.Windows.Forms.Button steamSWITCH;
        private System.Windows.Forms.Button flushSWITCH;
        private System.Windows.Forms.Label titreSCADA;
        private System.Windows.Forms.Label pipe_Feed_fixe;
        private System.Windows.Forms.Label pipe_Flush_fixe;
        private System.Windows.Forms.ListBox listAlarmesBox;
        private System.Windows.Forms.Label panel3;
        private System.Windows.Forms.Label titreALARMS;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label panel1_1;
        private System.Windows.Forms.Label panel1_3;
        private System.Windows.Forms.PictureBox universiteImage;
        private System.Windows.Forms.PictureBox polytechImage;
        private System.Windows.Forms.Label realisepar1;
        private System.Windows.Forms.Label realisepar3;
        private System.Windows.Forms.Label realisepar2;
        private System.Windows.Forms.PictureBox logoHeatImage;
        private System.Windows.Forms.Label pipe_Feed;
        private System.Windows.Forms.Label pipe_Flush;
        private System.Windows.Forms.Label pipe_Steam_fixe;
        private System.Windows.Forms.Label flushFEED;
    }
}

