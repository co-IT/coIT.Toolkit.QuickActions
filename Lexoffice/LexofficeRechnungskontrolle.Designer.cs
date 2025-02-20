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
      tbxRechnungUrl = new TextBox();
      btnRechnungPrüfen = new Button();
      groupBox1 = new GroupBox();
      txtLexofficeClipboardHint = new Label();
      label1 = new Label();
      groupBox2 = new GroupBox();
      lblErgebnisse = new Label();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      SuspendLayout();
      // 
      // tbxRechnungUrl
      // 
      tbxRechnungUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbxRechnungUrl.Location = new Point(31, 68);
      tbxRechnungUrl.Margin = new Padding(4, 5, 4, 5);
      tbxRechnungUrl.Name = "tbxRechnungUrl";
      tbxRechnungUrl.PlaceholderText = "https://app.lexoffice.de/voucher/#/########-####-####-####-############";
      tbxRechnungUrl.Size = new Size(777, 30);
      tbxRechnungUrl.TabIndex = 0;
      // 
      // btnRechnungPrüfen
      // 
      btnRechnungPrüfen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnRechnungPrüfen.Location = new Point(816, 73);
      btnRechnungPrüfen.Margin = new Padding(4, 5, 4, 5);
      btnRechnungPrüfen.Name = "btnRechnungPrüfen";
      btnRechnungPrüfen.Size = new Size(247, 30);
      btnRechnungPrüfen.TabIndex = 1;
      btnRechnungPrüfen.Text = "Rechnung prüfen";
      btnRechnungPrüfen.UseVisualStyleBackColor = true;
      btnRechnungPrüfen.Click += btnRechnungPrüfen_Click;
      // 
      // groupBox1
      // 
      groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      groupBox1.Controls.Add(txtLexofficeClipboardHint);
      groupBox1.Controls.Add(label1);
      groupBox1.Controls.Add(tbxRechnungUrl);
      groupBox1.Controls.Add(btnRechnungPrüfen);
      groupBox1.Location = new Point(22, 5);
      groupBox1.Margin = new Padding(4, 5, 4, 5);
      groupBox1.Name = "groupBox1";
      groupBox1.Padding = new Padding(4, 5, 4, 5);
      groupBox1.Size = new Size(1120, 148);
      groupBox1.TabIndex = 2;
      groupBox1.TabStop = false;
      groupBox1.Text = "URL der zu prüfenden Rechnung einfügen";
      // 
      // txtLexofficeClipboardHint
      // 
      txtLexofficeClipboardHint.Cursor = Cursors.Hand;
      txtLexofficeClipboardHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
      txtLexofficeClipboardHint.ForeColor = SystemColors.HotTrack;
      txtLexofficeClipboardHint.Location = new Point(31, 103);
      txtLexofficeClipboardHint.Name = "txtLexofficeClipboardHint";
      txtLexofficeClipboardHint.Size = new Size(578, 23);
      txtLexofficeClipboardHint.TabIndex = 3;
      txtLexofficeClipboardHint.Text = "Lexoffice URL in Zwischenablage erkannt! Klicke hier, um sie einzufügen.";
      txtLexofficeClipboardHint.Click += txtLexofficeClipboardHint_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(31, 40);
      label1.Name = "label1";
      label1.Size = new Size(554, 23);
      label1.TabIndex = 2;
      label1.Text = "Bitte stelle sicher, dass die Rechnung zuerst zwischengespeichert wurde";
      // 
      // groupBox2
      // 
      groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      groupBox2.Controls.Add(lblErgebnisse);
      groupBox2.Location = new Point(22, 153);
      groupBox2.Margin = new Padding(4, 5, 4, 5);
      groupBox2.Name = "groupBox2";
      groupBox2.Padding = new Padding(4, 5, 4, 5);
      groupBox2.Size = new Size(1120, 426);
      groupBox2.TabIndex = 3;
      groupBox2.TabStop = false;
      groupBox2.Text = "Ergebnisse der Prüfung";
      // 
      // lblErgebnisse
      // 
      lblErgebnisse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      lblErgebnisse.Location = new Point(31, 38);
      lblErgebnisse.Margin = new Padding(4, 0, 4, 0);
      lblErgebnisse.Name = "lblErgebnisse";
      lblErgebnisse.Size = new Size(1072, 282);
      lblErgebnisse.TabIndex = 0;
      // 
      // LexofficeRechnungskontrolle
      // 
      AutoScaleDimensions = new SizeF(9F, 23F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSizeMode = AutoSizeMode.GrowAndShrink;
      Controls.Add(groupBox1);
      Controls.Add(groupBox2);
      Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      Margin = new Padding(4, 5, 4, 5);
      Name = "LexofficeRechnungskontrolle";
      Size = new Size(1166, 579);
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      groupBox2.ResumeLayout(false);
      ResumeLayout(false);
    }

    private System.Windows.Forms.Label txtLexofficeClipboardHint;

        #endregion

        private System.Windows.Forms.TextBox tbxRechnungUrl;
        private System.Windows.Forms.Button btnRechnungPrüfen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblErgebnisse;
        private System.Windows.Forms.Label label1;
    }
}
