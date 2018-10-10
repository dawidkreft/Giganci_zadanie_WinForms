namespace Fizyka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPredkosc = new System.Windows.Forms.Button();
            this.btnGestosc = new System.Windows.Forms.Button();
            this.btnKwadrat = new System.Windows.Forms.Button();
            this.btnKolo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDroga = new System.Windows.Forms.TextBox();
            this.txtCzas = new System.Windows.Forms.TextBox();
            this.txtPredkosc = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtObjetosc = new System.Windows.Forms.TextBox();
            this.txtGestosc = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPredkosc
            // 
            this.btnPredkosc.Location = new System.Drawing.Point(468, 44);
            this.btnPredkosc.Name = "btnPredkosc";
            this.btnPredkosc.Size = new System.Drawing.Size(136, 41);
            this.btnPredkosc.TabIndex = 0;
            this.btnPredkosc.Text = "Oblicz";
            this.btnPredkosc.UseVisualStyleBackColor = true;
            this.btnPredkosc.Click += new System.EventHandler(this.btnPredkosc_Click);
            // 
            // btnGestosc
            // 
            this.btnGestosc.Location = new System.Drawing.Point(468, 175);
            this.btnGestosc.Name = "btnGestosc";
            this.btnGestosc.Size = new System.Drawing.Size(136, 41);
            this.btnGestosc.TabIndex = 1;
            this.btnGestosc.Text = "Oblicz";
            this.btnGestosc.UseVisualStyleBackColor = true;
            this.btnGestosc.Click += new System.EventHandler(this.btnGestosc_Click);
            // 
            // btnKwadrat
            // 
            this.btnKwadrat.Location = new System.Drawing.Point(468, 285);
            this.btnKwadrat.Name = "btnKwadrat";
            this.btnKwadrat.Size = new System.Drawing.Size(136, 41);
            this.btnKwadrat.TabIndex = 2;
            this.btnKwadrat.Text = "Oblicz";
            this.btnKwadrat.UseVisualStyleBackColor = true;
            // 
            // btnKolo
            // 
            this.btnKolo.Location = new System.Drawing.Point(468, 406);
            this.btnKolo.Name = "btnKolo";
            this.btnKolo.Size = new System.Drawing.Size(136, 41);
            this.btnKolo.TabIndex = 3;
            this.btnKolo.Text = "Oblicz";
            this.btnKolo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oblicz prędkość";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oblicz gęstość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oblicz  pole kwadratu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oblicz pole koła";
            // 
            // txtDroga
            // 
            this.txtDroga.Location = new System.Drawing.Point(46, 62);
            this.txtDroga.Name = "txtDroga";
            this.txtDroga.Size = new System.Drawing.Size(100, 22);
            this.txtDroga.TabIndex = 8;
            this.txtDroga.Text = "s";
            this.txtDroga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCzas
            // 
            this.txtCzas.Location = new System.Drawing.Point(282, 62);
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.Size = new System.Drawing.Size(100, 22);
            this.txtCzas.TabIndex = 9;
            this.txtCzas.Text = "t";
            this.txtCzas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPredkosc
            // 
            this.txtPredkosc.Location = new System.Drawing.Point(689, 63);
            this.txtPredkosc.Name = "txtPredkosc";
            this.txtPredkosc.Size = new System.Drawing.Size(100, 22);
            this.txtPredkosc.TabIndex = 10;
            this.txtPredkosc.Text = "s/t";
            this.txtPredkosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(43, 194);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(100, 22);
            this.txtMasa.TabIndex = 11;
            this.txtMasa.Text = "m";
            this.txtMasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObjetosc
            // 
            this.txtObjetosc.Location = new System.Drawing.Point(282, 194);
            this.txtObjetosc.Name = "txtObjetosc";
            this.txtObjetosc.Size = new System.Drawing.Size(100, 22);
            this.txtObjetosc.TabIndex = 12;
            this.txtObjetosc.Text = "v";
            this.txtObjetosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGestosc
            // 
            this.txtGestosc.Location = new System.Drawing.Point(689, 194);
            this.txtGestosc.Name = "txtGestosc";
            this.txtGestosc.Size = new System.Drawing.Size(100, 22);
            this.txtGestosc.TabIndex = 13;
            this.txtGestosc.Text = "m/v";
            this.txtGestosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(195, 304);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(195, 425);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(689, 304);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 16;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(689, 425);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wyniki ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtGestosc);
            this.Controls.Add(this.txtObjetosc);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.txtPredkosc);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.txtDroga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKolo);
            this.Controls.Add(this.btnKwadrat);
            this.Controls.Add(this.btnGestosc);
            this.Controls.Add(this.btnPredkosc);
            this.Name = "Form1";
            this.Text = "Wzory fizyczne i matematyczne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPredkosc;
        private System.Windows.Forms.Button btnGestosc;
        private System.Windows.Forms.Button btnKwadrat;
        private System.Windows.Forms.Button btnKolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDroga;
        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.TextBox txtPredkosc;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox txtObjetosc;
        private System.Windows.Forms.TextBox txtGestosc;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label5;
    }
}

