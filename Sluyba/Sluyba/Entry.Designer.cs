namespace Sluyba
{
    partial class Entry
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
            this.label1 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.TextBox();
            this.labelime = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imeRoditelja = new System.Windows.Forms.TextBox();
            this.datumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radio_muski = new System.Windows.Forms.RadioButton();
            this.radio_zenski = new System.Windows.Forms.RadioButton();
            this.radio_ostalo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.smer = new System.Windows.Forms.ComboBox();
            this.ree = new System.Windows.Forms.Label();
            this.godina = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj Indeksa";
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(85, 10);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(100, 20);
            this.index.TabIndex = 1;
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(85, 37);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(100, 20);
            this.ime.TabIndex = 2;
            // 
            // labelime
            // 
            this.labelime.AutoSize = true;
            this.labelime.Location = new System.Drawing.Point(13, 40);
            this.labelime.Name = "labelime";
            this.labelime.Size = new System.Drawing.Size(24, 13);
            this.labelime.TabIndex = 3;
            this.labelime.Text = "Ime";
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(85, 64);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(100, 20);
            this.prezime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ime Roditelja";
            // 
            // imeRoditelja
            // 
            this.imeRoditelja.Location = new System.Drawing.Point(85, 116);
            this.imeRoditelja.Name = "imeRoditelja";
            this.imeRoditelja.Size = new System.Drawing.Size(100, 20);
            this.imeRoditelja.TabIndex = 7;
            // 
            // datumRodjenja
            // 
            this.datumRodjenja.Location = new System.Drawing.Point(102, 90);
            this.datumRodjenja.Name = "datumRodjenja";
            this.datumRodjenja.Size = new System.Drawing.Size(200, 20);
            this.datumRodjenja.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datum Rodjenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pol";
            // 
            // radio_muski
            // 
            this.radio_muski.AutoSize = true;
            this.radio_muski.Location = new System.Drawing.Point(85, 147);
            this.radio_muski.Name = "radio_muski";
            this.radio_muski.Size = new System.Drawing.Size(53, 17);
            this.radio_muski.TabIndex = 11;
            this.radio_muski.TabStop = true;
            this.radio_muski.Text = "Muski";
            this.radio_muski.UseVisualStyleBackColor = true;
            // 
            // radio_zenski
            // 
            this.radio_zenski.AutoSize = true;
            this.radio_zenski.Location = new System.Drawing.Point(85, 170);
            this.radio_zenski.Name = "radio_zenski";
            this.radio_zenski.Size = new System.Drawing.Size(57, 17);
            this.radio_zenski.TabIndex = 12;
            this.radio_zenski.TabStop = true;
            this.radio_zenski.Text = "Zenski";
            this.radio_zenski.UseVisualStyleBackColor = true;
            // 
            // radio_ostalo
            // 
            this.radio_ostalo.AutoSize = true;
            this.radio_ostalo.Location = new System.Drawing.Point(85, 194);
            this.radio_ostalo.Name = "radio_ostalo";
            this.radio_ostalo.Size = new System.Drawing.Size(55, 17);
            this.radio_ostalo.TabIndex = 13;
            this.radio_ostalo.TabStop = true;
            this.radio_ostalo.Text = "Ostalo";
            this.radio_ostalo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Smer";
            // 
            // smer
            // 
            this.smer.FormattingEnabled = true;
            this.smer.Location = new System.Drawing.Point(85, 218);
            this.smer.Name = "smer";
            this.smer.Size = new System.Drawing.Size(121, 21);
            this.smer.TabIndex = 15;
            // 
            // ree
            // 
            this.ree.AutoSize = true;
            this.ree.Location = new System.Drawing.Point(13, 248);
            this.ree.Name = "ree";
            this.ree.Size = new System.Drawing.Size(41, 13);
            this.ree.TabIndex = 16;
            this.ree.Text = "Godina";
            // 
            // godina
            // 
            this.godina.Location = new System.Drawing.Point(85, 245);
            this.godina.Name = "godina";
            this.godina.Size = new System.Drawing.Size(100, 20);
            this.godina.TabIndex = 17;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(13, 297);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 18;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 332);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.godina);
            this.Controls.Add(this.ree);
            this.Controls.Add(this.smer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radio_ostalo);
            this.Controls.Add(this.radio_zenski);
            this.Controls.Add(this.radio_muski);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumRodjenja);
            this.Controls.Add(this.imeRoditelja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.labelime);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.index);
            this.Controls.Add(this.label1);
            this.Name = "Entry";
            this.Text = "Unos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label labelime;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imeRoditelja;
        private System.Windows.Forms.DateTimePicker datumRodjenja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radio_muski;
        private System.Windows.Forms.RadioButton radio_zenski;
        private System.Windows.Forms.RadioButton radio_ostalo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox smer;
        private System.Windows.Forms.Label ree;
        private System.Windows.Forms.TextBox godina;
        private System.Windows.Forms.Button submit;
    }
}