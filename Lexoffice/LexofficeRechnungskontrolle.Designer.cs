namespace coIT.Toolkit.QuickActions.Lexoffice
{
    partial class LexofficeRechnungskontrolle
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
          tbxRechnungUrl = new System.Windows.Forms.TextBox();
          btnRechnungPrüfen = new System.Windows.Forms.Button();
          groupBox1 = new System.Windows.Forms.GroupBox();
          txtLexofficeClipboardHint = new System.Windows.Forms.Label();
          label1 = new System.Windows.Forms.Label();
          groupBox2 = new System.Windows.Forms.GroupBox();
          lblErgebnisse = new System.Windows.Forms.Label();
          groupBox1.SuspendLayout();
          groupBox2.SuspendLayout();
          SuspendLayout();
          // 
          // tbxRechnungUrl
          // 
          tbxRechnungUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
          tbxRechnungUrl.Location = new System.Drawing.Point(31, 68);
          tbxRechnungUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
          tbxRechnungUrl.Name = "tbxRechnungUrl";
          tbxRechnungUrl.PlaceholderText = "https://app.lexoffice.de/voucher/#/########-####-####-####-############";
          tbxRechnungUrl.Size = new System.Drawing.Size(3859, 30);
          tbxRechnungUrl.TabIndex = 0;
          // 
          // btnRechnungPrüfen
          // 
          btnRechnungPrüfen.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
          btnRechnungPrüfen.Location = new System.Drawing.Point(3898, 73);
          btnRechnungPrüfen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
          btnRechnungPrüfen.Name = "btnRechnungPrüfen";
          btnRechnungPrüfen.Size = new System.Drawing.Size(247, 30);
          btnRechnungPrüfen.TabIndex = 1;
          btnRechnungPrüfen.Text = "Rechnung prüfen";
          btnRechnungPrüfen.UseVisualStyleBackColor = true;
          btnRechnungPrüfen.Click += btnRechnungPrüfen_Click;
          // 
          // groupBox1
          // 
          groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
          groupBox1.Controls.Add(txtLexofficeClipboardHint);
          groupBox1.Controls.Add(label1);
          groupBox1.Controls.Add(tbxRechnungUrl);
          groupBox1.Controls.Add(btnRechnungPrüfen);
          groupBox1.Location = new System.Drawing.Point(22, 5);
          groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
          groupBox1.Name = "groupBox1";
          groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
          groupBox1.Size = new System.Drawing.Size(4202, 148);
          groupBox1.TabIndex = 2;
          groupBox1.TabStop = false;
          groupBox1.Text = "URL der zu prüfenden Rechnung einfügen";
          // 
          // txtLexofficeClipboardHint
          // 
          txtLexofficeClipboardHint.Cursor = System.Windows.Forms.Cursors.Hand;
          txtLexofficeClipboardHint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)0));
          txtLexofficeClipboardHint.ForeColor = System.Drawing.SystemColors.HotTrack;
          txtLexofficeClipboardHint.Location = new System.Drawing.Point(31, 103);
          txtLexofficeClipboardHint.Name = "txtLexofficeClipboardHint";
          txtLexofficeClipboardHint.Size = new System.Drawing.Size(578, 23);
          txtLexofficeClipboardHint.TabIndex = 3;
          txtLexofficeClipboardHint.Text = "Lexoffice URL in Zwischenablage erkannt! Klicke hier, um sie einzufügen.";
          txtLexofficeClipboardHint.Click += txtLexofficeClipboardHint_Click;
          // 
          // label1
          // 
          label1.AutoSize = true;
          label1.Location = new System.Drawing.Point(31, 40);
          label1.Name = "label1";
          label1.Size = new System.Drawing.Size(554, 23);
          label1.TabIndex = 2;
          label1.Text = "Bitte stelle sicher, dass die Rechnung zuerst zwischengespeichert wurde";
          // 
          // groupBox2
          // 
          groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
          groupBox2.Controls.Add(lblErgebnisse);
          groupBox2.Location = new System.Drawing.Point(22, 153);
          groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
          groupBox2.Name = "groupBox2";
          groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
          groupBox2.Size = new System.Drawing.Size(4202, 426);
          groupBox2.TabIndex = 3;
          groupBox2.TabStop = false;
          groupBox2.Text = "Ergebnisse der Prüfung";
          // 
          // lblErgebnisse
          // 
          lblErgebnisse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
          lblErgebnisse.Location = new System.Drawing.Point(31, 38);
          lblErgebnisse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
          lblErgebnisse.Name = "lblErgebnisse";
          lblErgebnisse.Size = new System.Drawing.Size(4150, 282);
          lblErgebnisse.TabIndex = 0;
          // 
          // LexofficeRechnungskontrolle
          // 
          AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
          AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          Controls.Add(groupBox2);
          Controls.Add(groupBox1);
          Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
          Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
          Size = new System.Drawing.Size(1166, 579);
          groupBox1.ResumeLayout(false);
          groupBox1.PerformLayout();
          groupBox2.ResumeLayout(false);
          ResumeLayout(false);
        }

        private System.Windows.Forms.Label txtLexofficeClipboardHint;

        #endregion

        private System.Windows.Forms.TextBox tbxRechnungUrl;
        private Button btnRechnungPrüfen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Label lblErgebnisse;
        private System.Windows.Forms.Label label1;
    }
}
