namespace coIT.Clockodo.QuickActions.Einstellungen
{
    partial class EinstellungenControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EinstellungenControl));
            groupBox6 = new GroupBox();
            btnLexofficeEinstellungenSpeichern = new Button();
            gbxDatengrundlagenKonfigurieren = new GroupBox();
            gbxLexofficeKonfigurieren = new GroupBox();
            lblLexofficeApiToken = new Label();
            tbxLexofficeApiToken = new TextBox();
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            tbxClockodoEmail = new TextBox();
            groupBox2 = new GroupBox();
            tbxClockodoApiKey = new TextBox();
            groupBox4 = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            lnkClockodo = new LinkLabel();
            label1 = new Label();
            btnClockdoEinstellungenSpeichern = new Button();
            tbcEinstellungen = new TabControl();
            tbpClockodo = new TabPage();
            tbpLexoffice = new TabPage();
            groupBox5 = new GroupBox();
            label2 = new Label();
            dlgKundenstamm = new OpenFileDialog();
            dlgUmsatzkonten = new OpenFileDialog();
            dlgMitarbeiter = new OpenFileDialog();
            label6 = new Label();
            tbxDatengrundlageConnectionString = new TextBox();
            groupBox6.SuspendLayout();
            gbxDatengrundlagenKonfigurieren.SuspendLayout();
            gbxLexofficeKonfigurieren.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            tbcEinstellungen.SuspendLayout();
            tbpClockodo.SuspendLayout();
            tbpLexoffice.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnLexofficeEinstellungenSpeichern);
            groupBox6.Controls.Add(gbxDatengrundlagenKonfigurieren);
            groupBox6.Controls.Add(gbxLexofficeKonfigurieren);
            groupBox6.Location = new Point(6, 11);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1130, 337);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Zugänge konfigurieren";
            // 
            // btnLexofficeEinstellungenSpeichern
            // 
            btnLexofficeEinstellungenSpeichern.BackColor = Color.FromArgb(255, 192, 128);
            btnLexofficeEinstellungenSpeichern.Location = new Point(863, 262);
            btnLexofficeEinstellungenSpeichern.Name = "btnLexofficeEinstellungenSpeichern";
            btnLexofficeEinstellungenSpeichern.Size = new Size(247, 57);
            btnLexofficeEinstellungenSpeichern.TabIndex = 14;
            btnLexofficeEinstellungenSpeichern.Text = "Einstellungen speichern";
            btnLexofficeEinstellungenSpeichern.UseVisualStyleBackColor = false;
            btnLexofficeEinstellungenSpeichern.Click += btnLexofficeEinstellungenSpeichern_Click;
            // 
            // gbxDatengrundlagenKonfigurieren
            // 
            gbxDatengrundlagenKonfigurieren.Controls.Add(tbxDatengrundlageConnectionString);
            gbxDatengrundlagenKonfigurieren.Controls.Add(label6);
            gbxDatengrundlagenKonfigurieren.Location = new Point(553, 29);
            gbxDatengrundlagenKonfigurieren.Name = "gbxDatengrundlagenKonfigurieren";
            gbxDatengrundlagenKonfigurieren.Size = new Size(557, 227);
            gbxDatengrundlagenKonfigurieren.TabIndex = 12;
            gbxDatengrundlagenKonfigurieren.TabStop = false;
            gbxDatengrundlagenKonfigurieren.Text = "Datengrundlagen Konfigurieren";
            // 
            // gbxLexofficeKonfigurieren
            // 
            gbxLexofficeKonfigurieren.Controls.Add(lblLexofficeApiToken);
            gbxLexofficeKonfigurieren.Controls.Add(tbxLexofficeApiToken);
            gbxLexofficeKonfigurieren.Location = new Point(13, 29);
            gbxLexofficeKonfigurieren.Name = "gbxLexofficeKonfigurieren";
            gbxLexofficeKonfigurieren.Size = new Size(534, 227);
            gbxLexofficeKonfigurieren.TabIndex = 7;
            gbxLexofficeKonfigurieren.TabStop = false;
            gbxLexofficeKonfigurieren.Text = "Lexoffice konfigurieren";
            // 
            // lblLexofficeApiToken
            // 
            lblLexofficeApiToken.AutoSize = true;
            lblLexofficeApiToken.Location = new Point(28, 45);
            lblLexofficeApiToken.Name = "lblLexofficeApiToken";
            lblLexofficeApiToken.Size = new Size(361, 23);
            lblLexofficeApiToken.TabIndex = 7;
            lblLexofficeApiToken.Text = "Lexoffice Api Token (wird automatisch gesetzt)";
            // 
            // tbxLexofficeApiToken
            // 
            tbxLexofficeApiToken.Location = new Point(28, 71);
            tbxLexofficeApiToken.Name = "tbxLexofficeApiToken";
            tbxLexofficeApiToken.Size = new Size(378, 30);
            tbxLexofficeApiToken.TabIndex = 6;
            tbxLexofficeApiToken.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Location = new Point(6, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(386, 221);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Zugänge konfigurieren";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxClockodoEmail);
            groupBox1.Location = new Point(25, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 66);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deine E-Mail-Adresse";
            // 
            // tbxClockodoEmail
            // 
            tbxClockodoEmail.Location = new Point(6, 30);
            tbxClockodoEmail.Name = "tbxClockodoEmail";
            tbxClockodoEmail.Size = new Size(303, 30);
            tbxClockodoEmail.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbxClockodoApiKey);
            groupBox2.Location = new Point(25, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 67);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dein API-Key";
            // 
            // tbxClockodoApiKey
            // 
            tbxClockodoApiKey.Location = new Point(6, 30);
            tbxClockodoApiKey.Name = "tbxClockodoApiKey";
            tbxClockodoApiKey.Size = new Size(303, 30);
            tbxClockodoApiKey.TabIndex = 6;
            tbxClockodoApiKey.UseSystemPasswordChar = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(lnkClockodo);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(409, 15);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(699, 221);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Anleitung";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 168);
            label5.Name = "label5";
            label5.Size = new Size(429, 23);
            label5.TabIndex = 5;
            label5.Text = "3. Füge den Api-Key Links in der Konfiguration links ein";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 122);
            label3.Name = "label3";
            label3.Size = new Size(436, 23);
            label3.TabIndex = 3;
            label3.Text = "2. Füge die E-Mail-Adresse in der Konfiguration links ein";
            // 
            // lnkClockodo
            // 
            lnkClockodo.AutoSize = true;
            lnkClockodo.Location = new Point(41, 73);
            lnkClockodo.Name = "lnkClockodo";
            lnkClockodo.Size = new Size(339, 23);
            lnkClockodo.TabIndex = 1;
            lnkClockodo.TabStop = true;
            lnkClockodo.Text = "https://my.clockodo.com/de/users/editself/";
            lnkClockodo.LinkClicked += lnkClockodo_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 38);
            label1.Name = "label1";
            label1.Size = new Size(613, 23);
            label1.TabIndex = 0;
            label1.Text = "1. Öffne den folgenden Link um zu deinen Clockodo Einstellungen zu gelangen";
            // 
            // btnClockdoEinstellungenSpeichern
            // 
            btnClockdoEinstellungenSpeichern.BackColor = Color.FromArgb(255, 192, 128);
            btnClockdoEinstellungenSpeichern.Location = new Point(861, 253);
            btnClockdoEinstellungenSpeichern.Name = "btnClockdoEinstellungenSpeichern";
            btnClockdoEinstellungenSpeichern.Size = new Size(247, 57);
            btnClockdoEinstellungenSpeichern.TabIndex = 13;
            btnClockdoEinstellungenSpeichern.Text = "Einstellungen speichern";
            btnClockdoEinstellungenSpeichern.UseVisualStyleBackColor = false;
            btnClockdoEinstellungenSpeichern.Click += btnClockdoEinstellungenSpeichern_Click;
            // 
            // tbcEinstellungen
            // 
            tbcEinstellungen.Controls.Add(tbpClockodo);
            tbcEinstellungen.Controls.Add(tbpLexoffice);
            tbcEinstellungen.Dock = DockStyle.Fill;
            tbcEinstellungen.Location = new Point(0, 0);
            tbcEinstellungen.Name = "tbcEinstellungen";
            tbcEinstellungen.SelectedIndex = 0;
            tbcEinstellungen.Size = new Size(1163, 757);
            tbcEinstellungen.TabIndex = 11;
            // 
            // tbpClockodo
            // 
            tbpClockodo.Controls.Add(groupBox3);
            tbpClockodo.Controls.Add(groupBox4);
            tbpClockodo.Controls.Add(btnClockdoEinstellungenSpeichern);
            tbpClockodo.Location = new Point(4, 32);
            tbpClockodo.Name = "tbpClockodo";
            tbpClockodo.Padding = new Padding(3);
            tbpClockodo.Size = new Size(1155, 721);
            tbpClockodo.TabIndex = 0;
            tbpClockodo.Text = "Clockodo";
            tbpClockodo.UseVisualStyleBackColor = true;
            // 
            // tbpLexoffice
            // 
            tbpLexoffice.Controls.Add(groupBox5);
            tbpLexoffice.Controls.Add(groupBox6);
            tbpLexoffice.Location = new Point(4, 32);
            tbpLexoffice.Name = "tbpLexoffice";
            tbpLexoffice.Padding = new Padding(3);
            tbpLexoffice.Size = new Size(1155, 721);
            tbpLexoffice.TabIndex = 1;
            tbpLexoffice.Text = "Lexoffice";
            tbpLexoffice.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label2);
            groupBox5.Location = new Point(6, 354);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1130, 113);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Anleitung";
            // 
            // label2
            // 
            label2.Location = new Point(13, 42);
            label2.Name = "label2";
            label2.Size = new Size(1042, 55);
            label2.TabIndex = 5;
            label2.Text = resources.GetString("label2.Text");
            // 
            // dlgKundenstamm
            // 
            dlgKundenstamm.FileName = "Kundenstamm";
            dlgKundenstamm.Filter = "json Files|*.json";
            // 
            // dlgUmsatzkonten
            // 
            dlgUmsatzkonten.FileName = "openFileDialog2";
            dlgUmsatzkonten.Filter = "json Files|*.json";
            // 
            // dlgMitarbeiter
            // 
            dlgMitarbeiter.FileName = "openFileDialog3";
            dlgMitarbeiter.Filter = "json Files|*.json";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 45);
            label6.Name = "label6";
            label6.Size = new Size(492, 23);
            label6.TabIndex = 0;
            label6.Text = "Datengrundlagen Connection String (wird automatisch gesetzt)";
            // 
            // tbxDatengrundlageConnectionString
            // 
            tbxDatengrundlageConnectionString.Location = new Point(20, 71);
            tbxDatengrundlageConnectionString.Name = "tbxDatengrundlageConnectionString";
            tbxDatengrundlageConnectionString.Size = new Size(492, 30);
            tbxDatengrundlageConnectionString.TabIndex = 1;
            // 
            // EinstellungenControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcEinstellungen);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EinstellungenControl";
            Size = new Size(1163, 757);
            groupBox6.ResumeLayout(false);
            gbxDatengrundlagenKonfigurieren.ResumeLayout(false);
            gbxDatengrundlagenKonfigurieren.PerformLayout();
            gbxLexofficeKonfigurieren.ResumeLayout(false);
            gbxLexofficeKonfigurieren.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tbcEinstellungen.ResumeLayout(false);
            tbpClockodo.ResumeLayout(false);
            tbpLexoffice.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox6;
        private GroupBox gbxLexofficeKonfigurieren;
        private TextBox tbxLexofficeApiToken;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private TextBox tbxClockodoEmail;
        private GroupBox groupBox2;
        private TextBox tbxClockodoApiKey;
        private GroupBox groupBox4;
        private Label label5;
        private Label label3;
        private LinkLabel lnkClockodo;
        private Label label1;
        private Button btnClockdoEinstellungenSpeichern;
        private TabControl tbcEinstellungen;
        private TabPage tbpClockodo;
        private TabPage tbpLexoffice;
        private GroupBox groupBox5;
        private Label label2;
        private GroupBox gbxDatengrundlagenKonfigurieren;
        private Label lblLexofficeApiToken;
        private OpenFileDialog dlgKundenstamm;
        private OpenFileDialog dlgUmsatzkonten;
        private OpenFileDialog dlgMitarbeiter;
        private Button btnLexofficeEinstellungenSpeichern;
        private TextBox tbxDatengrundlageConnectionString;
        private Label label6;
    }
}
