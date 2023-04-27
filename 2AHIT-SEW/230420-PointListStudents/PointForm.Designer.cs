namespace PointCoords
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXcoords = new System.Windows.Forms.TextBox();
            this.txtYcoords = new System.Windows.Forms.TextBox();
            this.cmdSaveCoords = new System.Windows.Forms.Button();
            this.cmdAusgabe = new System.Windows.Forms.Button();
            this.cmdClearLbox = new System.Windows.Forms.Button();
            this.cmdWriteCoords = new System.Windows.Forms.Button();
            this.cmdReadCoords = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Index = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lboxcoords = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonBin = new System.Windows.Forms.RadioButton();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // txtXcoords
            // 
            this.txtXcoords.Location = new System.Drawing.Point(47, 15);
            this.txtXcoords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXcoords.Name = "txtXcoords";
            this.txtXcoords.Size = new System.Drawing.Size(41, 22);
            this.txtXcoords.TabIndex = 2;
            // 
            // txtYcoords
            // 
            this.txtYcoords.Location = new System.Drawing.Point(144, 15);
            this.txtYcoords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYcoords.Name = "txtYcoords";
            this.txtYcoords.Size = new System.Drawing.Size(45, 22);
            this.txtYcoords.TabIndex = 3;
            // 
            // cmdSaveCoords
            // 
            this.cmdSaveCoords.Location = new System.Drawing.Point(199, 11);
            this.cmdSaveCoords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSaveCoords.Name = "cmdSaveCoords";
            this.cmdSaveCoords.Size = new System.Drawing.Size(171, 28);
            this.cmdSaveCoords.TabIndex = 4;
            this.cmdSaveCoords.Text = "Koordinaten speichern";
            this.cmdSaveCoords.UseVisualStyleBackColor = true;
            this.cmdSaveCoords.Click += new System.EventHandler(this.cmdSaveCoords_Click);
            // 
            // cmdAusgabe
            // 
            this.cmdAusgabe.Location = new System.Drawing.Point(199, 60);
            this.cmdAusgabe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAusgabe.Name = "cmdAusgabe";
            this.cmdAusgabe.Size = new System.Drawing.Size(171, 46);
            this.cmdAusgabe.TabIndex = 6;
            this.cmdAusgabe.Text = "Koordinaten in Listbox schreiben";
            this.cmdAusgabe.UseVisualStyleBackColor = true;
            this.cmdAusgabe.Click += new System.EventHandler(this.cmdAusgabe_Click);
            // 
            // cmdClearLbox
            // 
            this.cmdClearLbox.Location = new System.Drawing.Point(199, 113);
            this.cmdClearLbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdClearLbox.Name = "cmdClearLbox";
            this.cmdClearLbox.Size = new System.Drawing.Size(171, 46);
            this.cmdClearLbox.TabIndex = 9;
            this.cmdClearLbox.Text = "Koordinaten aus Listbox löschen";
            this.cmdClearLbox.UseVisualStyleBackColor = true;
            this.cmdClearLbox.Click += new System.EventHandler(this.cmdClearLbox_Click);
            // 
            // cmdWriteCoords
            // 
            this.cmdWriteCoords.Location = new System.Drawing.Point(199, 166);
            this.cmdWriteCoords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdWriteCoords.Name = "cmdWriteCoords";
            this.cmdWriteCoords.Size = new System.Drawing.Size(171, 50);
            this.cmdWriteCoords.TabIndex = 10;
            this.cmdWriteCoords.Text = "Koordinaten in Datei schreiben";
            this.cmdWriteCoords.UseVisualStyleBackColor = true;
            this.cmdWriteCoords.Click += new System.EventHandler(this.cmdWriteCoords_Click);
            // 
            // cmdReadCoords
            // 
            this.cmdReadCoords.Location = new System.Drawing.Point(199, 228);
            this.cmdReadCoords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdReadCoords.Name = "cmdReadCoords";
            this.cmdReadCoords.Size = new System.Drawing.Size(171, 46);
            this.cmdReadCoords.TabIndex = 11;
            this.cmdReadCoords.Text = "Koordinaten aus Datei lesen";
            this.cmdReadCoords.UseVisualStyleBackColor = true;
            this.cmdReadCoords.Click += new System.EventHandler(this.cmdReadCoords_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nullbasierter Index der Koordinate";
            // 
            // txt_Index
            // 
            this.txt_Index.Location = new System.Drawing.Point(32, 330);
            this.txt_Index.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Index.Name = "txt_Index";
            this.txt_Index.Size = new System.Drawing.Size(37, 22);
            this.txt_Index.TabIndex = 13;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(79, 327);
            this.cmdSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(100, 28);
            this.cmdSearch.TabIndex = 14;
            this.cmdSearch.Text = "Suchen...";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lboxcoords
            // 
            this.lboxcoords.FormattingEnabled = true;
            this.lboxcoords.ItemHeight = 16;
            this.lboxcoords.Location = new System.Drawing.Point(20, 60);
            this.lboxcoords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lboxcoords.Name = "lboxcoords";
            this.lboxcoords.Size = new System.Drawing.Size(169, 212);
            this.lboxcoords.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonBin);
            this.panel1.Controls.Add(this.radioButtonText);
            this.panel1.Location = new System.Drawing.Point(272, 292);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 63);
            this.panel1.TabIndex = 16;
            // 
            // radioButtonBin
            // 
            this.radioButtonBin.AutoSize = true;
            this.radioButtonBin.Location = new System.Drawing.Point(5, 36);
            this.radioButtonBin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonBin.Name = "radioButtonBin";
            this.radioButtonBin.Size = new System.Drawing.Size(62, 21);
            this.radioButtonBin.TabIndex = 1;
            this.radioButtonBin.TabStop = true;
            this.radioButtonBin.Text = "Binär";
            this.radioButtonBin.UseVisualStyleBackColor = true;
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Checked = true;
            this.radioButtonText.Location = new System.Drawing.Point(5, 7);
            this.radioButtonText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(56, 21);
            this.radioButtonText.TabIndex = 0;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.Text = "Text";
            this.radioButtonText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboxcoords);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txt_Index);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdReadCoords);
            this.Controls.Add(this.cmdWriteCoords);
            this.Controls.Add(this.cmdClearLbox);
            this.Controls.Add(this.cmdAusgabe);
            this.Controls.Add(this.cmdSaveCoords);
            this.Controls.Add(this.txtYcoords);
            this.Controls.Add(this.txtXcoords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "PointCoords";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXcoords;
        private System.Windows.Forms.TextBox txtYcoords;
        private System.Windows.Forms.Button cmdSaveCoords;
        private System.Windows.Forms.Button cmdAusgabe;
        private System.Windows.Forms.Button cmdClearLbox;
        private System.Windows.Forms.Button cmdWriteCoords;
        private System.Windows.Forms.Button cmdReadCoords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Index;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox lboxcoords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonBin;
        private System.Windows.Forms.RadioButton radioButtonText;
    }
}

