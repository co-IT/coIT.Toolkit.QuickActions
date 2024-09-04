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
            dlgKundenstamm = new OpenFileDialog();
            dlgUmsatzkonten = new OpenFileDialog();
            dlgMitarbeiter = new OpenFileDialog();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            tbcEinstellungen.SuspendLayout();
            tbpClockodo.SuspendLayout();
            SuspendLayout();
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
            // EinstellungenControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbcEinstellungen);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EinstellungenControl";
            Size = new Size(1163, 757);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tbcEinstellungen.ResumeLayout(false);
            tbpClockodo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private OpenFileDialog dlgKundenstamm;
        private OpenFileDialog dlgUmsatzkonten;
        private OpenFileDialog dlgMitarbeiter;
    }
}
