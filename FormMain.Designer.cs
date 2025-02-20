namespace coIT.Toolkit.QuickActions
{
  sealed partial class FormMain
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
          tbpErfassen = new System.Windows.Forms.TabPage();
          splitContainer1 = new System.Windows.Forms.SplitContainer();
          ctrl_laufendeUhrAbfrage = new System.Windows.Forms.Button();
          ctrl_textboxLaufenderEintrag = new System.Windows.Forms.TextBox();
          ctrl_ZeigeSelektiertenMitarbeiter = new System.Windows.Forms.Label();
          ctrl_LadeDaten = new System.Windows.Forms.Button();
          ctrl_Zeiteintraege = new System.Windows.Forms.DataGridView();
          tbcForms = new System.Windows.Forms.TabControl();
          tbpClockodo = new System.Windows.Forms.TabPage();
          tbcClockodo = new System.Windows.Forms.TabControl();
          tbpClockodoSelbstkontrolle = new System.Windows.Forms.TabPage();
          dgvClockodoFehler = new System.Windows.Forms.DataGridView();
          btnFehlerAktualisieren = new System.Windows.Forms.Button();
          gbxZeitraumSchnellauswahl = new System.Windows.Forms.GroupBox();
          btnLetzteZweiWochenVormonat = new System.Windows.Forms.Button();
          btnLetzterMonat = new System.Windows.Forms.Button();
          btnErsteZweiWochenAktuellerMonat = new System.Windows.Forms.Button();
          gbxZeitraum = new System.Windows.Forms.GroupBox();
          lblStart = new System.Windows.Forms.Label();
          dtpZeitraumEnde = new System.Windows.Forms.DateTimePicker();
          lblEnde = new System.Windows.Forms.Label();
          dtpZeitraumStart = new System.Windows.Forms.DateTimePicker();
          tbpLexoffice = new System.Windows.Forms.TabPage();
          tabEinstellungen = new System.Windows.Forms.TabPage();
          tbpErfassen.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
          splitContainer1.Panel1.SuspendLayout();
          splitContainer1.Panel2.SuspendLayout();
          splitContainer1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)ctrl_Zeiteintraege).BeginInit();
          tbcForms.SuspendLayout();
          tbpClockodo.SuspendLayout();
          tbcClockodo.SuspendLayout();
          tbpClockodoSelbstkontrolle.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)dgvClockodoFehler).BeginInit();
          gbxZeitraumSchnellauswahl.SuspendLayout();
          gbxZeitraum.SuspendLayout();
          SuspendLayout();
          //
          // tbpErfassen
          //
          tbpErfassen.Controls.Add(splitContainer1);
          tbpErfassen.Location = new System.Drawing.Point(4, 32);
          tbpErfassen.Name = "tbpErfassen";
          tbpErfassen.Padding = new System.Windows.Forms.Padding(3);
          tbpErfassen.Size = new System.Drawing.Size(1279, 669);
          tbpErfassen.TabIndex = 0;
          tbpErfassen.Text = "Erfassen";
          tbpErfassen.UseVisualStyleBackColor = true;
          //
          // splitContainer1
          //
          splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
          splitContainer1.Location = new System.Drawing.Point(3, 3);
          splitContainer1.Name = "splitContainer1";
          splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
          //
          // splitContainer1.Panel1
          //
          splitContainer1.Panel1.Controls.Add(ctrl_laufendeUhrAbfrage);
          splitContainer1.Panel1.Controls.Add(ctrl_textboxLaufenderEintrag);
          splitContainer1.Panel1.Controls.Add(ctrl_ZeigeSelektiertenMitarbeiter);
          splitContainer1.Panel1.Controls.Add(ctrl_LadeDaten);
          //
          // splitContainer1.Panel2
          //
          splitContainer1.Panel2.Controls.Add(ctrl_Zeiteintraege);
          splitContainer1.Size = new System.Drawing.Size(1273, 663);
          splitContainer1.SplitterDistance = 94;
          splitContainer1.TabIndex = 0;
          //
          // ctrl_laufendeUhrAbfrage
          //
          ctrl_laufendeUhrAbfrage.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)192)), ((int)((byte)128)));
          ctrl_laufendeUhrAbfrage.Location = new System.Drawing.Point(550, 3);
          ctrl_laufendeUhrAbfrage.Name = "ctrl_laufendeUhrAbfrage";
          ctrl_laufendeUhrAbfrage.Size = new System.Drawing.Size(133, 70);
          ctrl_laufendeUhrAbfrage.TabIndex = 5;
          ctrl_laufendeUhrAbfrage.Text = "Laufende Uhr Aktualisieren";
          ctrl_laufendeUhrAbfrage.UseVisualStyleBackColor = false;
          ctrl_laufendeUhrAbfrage.Click += ctrl_laufendeUhrAbfrage_Click;
          //
          // ctrl_textboxLaufenderEintrag
          //
          ctrl_textboxLaufenderEintrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
          ctrl_textboxLaufenderEintrag.Location = new System.Drawing.Point(689, 3);
          ctrl_textboxLaufenderEintrag.Multiline = true;
          ctrl_textboxLaufenderEintrag.Name = "ctrl_textboxLaufenderEintrag";
          ctrl_textboxLaufenderEintrag.ReadOnly = true;
          ctrl_textboxLaufenderEintrag.Size = new System.Drawing.Size(581, 69);
          ctrl_textboxLaufenderEintrag.TabIndex = 4;
          ctrl_textboxLaufenderEintrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          //
          // ctrl_ZeigeSelektiertenMitarbeiter
          //
          ctrl_ZeigeSelektiertenMitarbeiter.Location = new System.Drawing.Point(3, 3);
          ctrl_ZeigeSelektiertenMitarbeiter.Name = "ctrl_ZeigeSelektiertenMitarbeiter";
          ctrl_ZeigeSelektiertenMitarbeiter.Size = new System.Drawing.Size(293, 33);
          ctrl_ZeigeSelektiertenMitarbeiter.TabIndex = 2;
          ctrl_ZeigeSelektiertenMitarbeiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          //
          // ctrl_LadeDaten
          //
          ctrl_LadeDaten.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)192)), ((int)((byte)128)));
          ctrl_LadeDaten.Location = new System.Drawing.Point(3, 39);
          ctrl_LadeDaten.Name = "ctrl_LadeDaten";
          ctrl_LadeDaten.Size = new System.Drawing.Size(293, 33);
          ctrl_LadeDaten.TabIndex = 1;
          ctrl_LadeDaten.Text = "Vergangene Zeiteinträge abrufen";
          ctrl_LadeDaten.UseVisualStyleBackColor = false;
          ctrl_LadeDaten.Click += ctrl_LadeDaten_Click;
          //
          // ctrl_Zeiteintraege
          //
          ctrl_Zeiteintraege.AllowUserToOrderColumns = true;
          ctrl_Zeiteintraege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          ctrl_Zeiteintraege.Dock = System.Windows.Forms.DockStyle.Fill;
          ctrl_Zeiteintraege.Location = new System.Drawing.Point(0, 0);
          ctrl_Zeiteintraege.Name = "ctrl_Zeiteintraege";
          ctrl_Zeiteintraege.Size = new System.Drawing.Size(1273, 565);
          ctrl_Zeiteintraege.TabIndex = 0;
          ctrl_Zeiteintraege.CellDoubleClick += ctrl_Zeiteintraege_CellDoubleClick;
          ctrl_Zeiteintraege.KeyDown += ctrl_Zeiteintraege_KeyDown;
          //
          // tbcForms
          //
          tbcForms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
          tbcForms.Controls.Add(tbpClockodo);
          tbcForms.Controls.Add(tbpLexoffice);
          tbcForms.Controls.Add(tbpErfassen);
          tbcForms.Controls.Add(tabEinstellungen);
          tbcForms.Font = new System.Drawing.Font("Segoe UI", 13F);
          tbcForms.Location = new System.Drawing.Point(2, 9);
          tbcForms.Name = "tbcForms";
          tbcForms.SelectedIndex = 0;
          tbcForms.Size = new System.Drawing.Size(1287, 705);
          tbcForms.TabIndex = 5;
          //
          // tbpClockodo
          //
          tbpClockodo.Controls.Add(tbcClockodo);
          tbpClockodo.Location = new System.Drawing.Point(4, 32);
          tbpClockodo.Name = "tbpClockodo";
          tbpClockodo.Padding = new System.Windows.Forms.Padding(3);
          tbpClockodo.Size = new System.Drawing.Size(1279, 669);
          tbpClockodo.TabIndex = 2;
          tbpClockodo.Text = "Clockodo";
          tbpClockodo.UseVisualStyleBackColor = true;
          //
          // tbcClockodo
          //
          tbcClockodo.Controls.Add(tbpClockodoSelbstkontrolle);
          tbcClockodo.Dock = System.Windows.Forms.DockStyle.Fill;
          tbcClockodo.Location = new System.Drawing.Point(3, 3);
          tbcClockodo.Name = "tbcClockodo";
          tbcClockodo.SelectedIndex = 0;
          tbcClockodo.Size = new System.Drawing.Size(1273, 663);
          tbcClockodo.TabIndex = 9;
          //
          // tbpClockodoSelbstkontrolle
          //
          tbpClockodoSelbstkontrolle.Controls.Add(dgvClockodoFehler);
          tbpClockodoSelbstkontrolle.Controls.Add(btnFehlerAktualisieren);
          tbpClockodoSelbstkontrolle.Controls.Add(gbxZeitraumSchnellauswahl);
          tbpClockodoSelbstkontrolle.Controls.Add(gbxZeitraum);
          tbpClockodoSelbstkontrolle.Location = new System.Drawing.Point(4, 32);
          tbpClockodoSelbstkontrolle.Name = "tbpClockodoSelbstkontrolle";
          tbpClockodoSelbstkontrolle.Padding = new System.Windows.Forms.Padding(3);
          tbpClockodoSelbstkontrolle.Size = new System.Drawing.Size(1265, 627);
          tbpClockodoSelbstkontrolle.TabIndex = 0;
          tbpClockodoSelbstkontrolle.Text = "Selbstkontrolle";
          tbpClockodoSelbstkontrolle.UseVisualStyleBackColor = true;
          //
          // dgvClockodoFehler
          //
          dgvClockodoFehler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
          dgvClockodoFehler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
          dgvClockodoFehler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          dgvClockodoFehler.Location = new System.Drawing.Point(0, 129);
          dgvClockodoFehler.Name = "dgvClockodoFehler";
          dgvClockodoFehler.Size = new System.Drawing.Size(1265, 490);
          dgvClockodoFehler.TabIndex = 0;
          dgvClockodoFehler.CellDoubleClick += dgvClockodoFehler_CellDoubleClick;
          //
          // btnFehlerAktualisieren
          //
          btnFehlerAktualisieren.Location = new System.Drawing.Point(799, 14);
          btnFehlerAktualisieren.Name = "btnFehlerAktualisieren";
          btnFehlerAktualisieren.Size = new System.Drawing.Size(138, 109);
          btnFehlerAktualisieren.TabIndex = 1;
          btnFehlerAktualisieren.Text = "Aktualisieren";
          btnFehlerAktualisieren.UseVisualStyleBackColor = true;
          btnFehlerAktualisieren.Click += btnFehlerAktualisiere_click;
          //
          // gbxZeitraumSchnellauswahl
          //
          gbxZeitraumSchnellauswahl.Controls.Add(btnLetzteZweiWochenVormonat);
          gbxZeitraumSchnellauswahl.Controls.Add(btnLetzterMonat);
          gbxZeitraumSchnellauswahl.Controls.Add(btnErsteZweiWochenAktuellerMonat);
          gbxZeitraumSchnellauswahl.Location = new System.Drawing.Point(408, 3);
          gbxZeitraumSchnellauswahl.Name = "gbxZeitraumSchnellauswahl";
          gbxZeitraumSchnellauswahl.Size = new System.Drawing.Size(385, 120);
          gbxZeitraumSchnellauswahl.TabIndex = 8;
          gbxZeitraumSchnellauswahl.TabStop = false;
          gbxZeitraumSchnellauswahl.Text = "Zeitraum Schnellauswahl";
          //
          // btnLetzteZweiWochenVormonat
          //
          btnLetzteZweiWochenVormonat.Location = new System.Drawing.Point(6, 30);
          btnLetzteZweiWochenVormonat.Name = "btnLetzteZweiWochenVormonat";
          btnLetzteZweiWochenVormonat.Size = new System.Drawing.Size(182, 39);
          btnLetzteZweiWochenVormonat.TabIndex = 11;
          btnLetzteZweiWochenVormonat.Text = "---";
          btnLetzteZweiWochenVormonat.UseVisualStyleBackColor = true;
          btnLetzteZweiWochenVormonat.Click += btnLetzteZweiWochenVormonat_Click;
          //
          // btnLetzterMonat
          //
          btnLetzterMonat.Location = new System.Drawing.Point(6, 75);
          btnLetzterMonat.Name = "btnLetzterMonat";
          btnLetzterMonat.Size = new System.Drawing.Size(182, 39);
          btnLetzterMonat.TabIndex = 10;
          btnLetzterMonat.Text = "---";
          btnLetzterMonat.UseVisualStyleBackColor = true;
          btnLetzterMonat.Click += btnLetzterMonat_Click;
          //
          // btnErsteZweiWochenAktuellerMonat
          //
          btnErsteZweiWochenAktuellerMonat.Location = new System.Drawing.Point(194, 30);
          btnErsteZweiWochenAktuellerMonat.Name = "btnErsteZweiWochenAktuellerMonat";
          btnErsteZweiWochenAktuellerMonat.Size = new System.Drawing.Size(182, 39);
          btnErsteZweiWochenAktuellerMonat.TabIndex = 9;
          btnErsteZweiWochenAktuellerMonat.Text = "---";
          btnErsteZweiWochenAktuellerMonat.UseVisualStyleBackColor = true;
          btnErsteZweiWochenAktuellerMonat.Click += btnErsteZweiWochenAktuellerMonat_Click;
          //
          // gbxZeitraum
          //
          gbxZeitraum.Controls.Add(lblStart);
          gbxZeitraum.Controls.Add(dtpZeitraumEnde);
          gbxZeitraum.Controls.Add(lblEnde);
          gbxZeitraum.Controls.Add(dtpZeitraumStart);
          gbxZeitraum.Location = new System.Drawing.Point(6, 3);
          gbxZeitraum.Name = "gbxZeitraum";
          gbxZeitraum.Size = new System.Drawing.Size(396, 120);
          gbxZeitraum.TabIndex = 7;
          gbxZeitraum.TabStop = false;
          gbxZeitraum.Text = "Zeitraum auswählen";
          //
          // lblStart
          //
          lblStart.AutoSize = true;
          lblStart.Location = new System.Drawing.Point(10, 37);
          lblStart.Name = "lblStart";
          lblStart.Size = new System.Drawing.Size(52, 25);
          lblStart.TabIndex = 4;
          lblStart.Text = "Start:";
          //
          // dtpZeitraumEnde
          //
          dtpZeitraumEnde.Location = new System.Drawing.Point(68, 78);
          dtpZeitraumEnde.Name = "dtpZeitraumEnde";
          dtpZeitraumEnde.Size = new System.Drawing.Size(313, 31);
          dtpZeitraumEnde.TabIndex = 2;
          dtpZeitraumEnde.ValueChanged += dtpZeitraumEnde_ValueChanged;
          //
          // lblEnde
          //
          lblEnde.AutoSize = true;
          lblEnde.Location = new System.Drawing.Point(10, 79);
          lblEnde.Name = "lblEnde";
          lblEnde.Size = new System.Drawing.Size(55, 25);
          lblEnde.TabIndex = 5;
          lblEnde.Text = "Ende:";
          //
          // dtpZeitraumStart
          //
          dtpZeitraumStart.CustomFormat = "";
          dtpZeitraumStart.Location = new System.Drawing.Point(68, 34);
          dtpZeitraumStart.Name = "dtpZeitraumStart";
          dtpZeitraumStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
          dtpZeitraumStart.Size = new System.Drawing.Size(313, 31);
          dtpZeitraumStart.TabIndex = 3;
          dtpZeitraumStart.ValueChanged += dtpZeitraumStart_ValueChanged;
          //
          // tbpLexoffice
          //
          tbpLexoffice.Location = new System.Drawing.Point(4, 32);
          tbpLexoffice.Name = "tbpLexoffice";
          tbpLexoffice.Padding = new System.Windows.Forms.Padding(3);
          tbpLexoffice.Size = new System.Drawing.Size(1279, 669);
          tbpLexoffice.TabIndex = 3;
          tbpLexoffice.Text = "Lexoffice";
          tbpLexoffice.UseVisualStyleBackColor = true;
          //
          // tabEinstellungen
          //
          tabEinstellungen.Location = new System.Drawing.Point(4, 32);
          tabEinstellungen.Name = "tabEinstellungen";
          tabEinstellungen.Padding = new System.Windows.Forms.Padding(3);
          tabEinstellungen.Size = new System.Drawing.Size(1279, 669);
          tabEinstellungen.TabIndex = 4;
          tabEinstellungen.Text = "Einstellungen";
          tabEinstellungen.UseVisualStyleBackColor = true;
          //
          // FormMain
          //
          AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
          AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          ClientSize = new System.Drawing.Size(1293, 726);
          Controls.Add(tbcForms);
          Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
          Text = "co-IT.eu GmbH | Quick Actions";
          Load += FormMain_Load;
          tbpErfassen.ResumeLayout(false);
          splitContainer1.Panel1.ResumeLayout(false);
          splitContainer1.Panel1.PerformLayout();
          splitContainer1.Panel2.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
          splitContainer1.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)ctrl_Zeiteintraege).EndInit();
          tbcForms.ResumeLayout(false);
          tbpClockodo.ResumeLayout(false);
          tbcClockodo.ResumeLayout(false);
          tbpClockodoSelbstkontrolle.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)dgvClockodoFehler).EndInit();
          gbxZeitraumSchnellauswahl.ResumeLayout(false);
          gbxZeitraum.ResumeLayout(false);
          gbxZeitraum.PerformLayout();
          ResumeLayout(false);
        }

        #endregion
        private TabPage tbpErfassen;
        private SplitContainer splitContainer1;
        private Label ctrl_ZeigeSelektiertenMitarbeiter;
        private Button ctrl_LadeDaten;
        private DataGridView ctrl_Zeiteintraege;
        private System.Windows.Forms.TabControl tbcForms;
        private TextBox ctrl_textboxLaufenderEintrag;
        private Button ctrl_laufendeUhrAbfrage;
        private System.Windows.Forms.TabPage tbpClockodo;
        private System.Windows.Forms.DataGridView dgvClockodoFehler;
        private Button btnFehlerAktualisieren;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dtpZeitraumEnde;
        private Label lblStart;
        private DateTimePicker dtpZeitraumStart;
        private Label lblEnde;
        private GroupBox gbxZeitraum;
        private GroupBox gbxZeitraumSchnellauswahl;
        private Button btnLetzteZweiWochenVormonat;
        private Button btnLetzterMonat;
        private Button btnErsteZweiWochenAktuellerMonat;
        private TabPage tbpLexoffice;
        private TabControl tbcClockodo;
        private TabPage tbpClockodoSelbstkontrolle;
        private TabPage tabEinstellungen;
    }
}
