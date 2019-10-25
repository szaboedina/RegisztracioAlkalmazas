namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.labelNev = new System.Windows.Forms.Label();
            this.labelSzulDatum = new System.Windows.Forms.Label();
            this.labelNem = new System.Windows.Forms.Label();
            this.radioFerfi = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetolt = new System.Windows.Forms.Button();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.textHobbi = new System.Windows.Forms.TextBox();
            this.labelUjHobbi = new System.Windows.Forms.Label();
            this.labelHobbi = new System.Windows.Forms.Label();
            this.hobbilista = new System.Windows.Forms.ListBox();
            this.textNev = new System.Windows.Forms.TextBox();
            this.textSzul = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNev.Location = new System.Drawing.Point(12, 30);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(65, 29);
            this.labelNev.TabIndex = 0;
            this.labelNev.Text = "Név:";
            // 
            // labelSzulDatum
            // 
            this.labelSzulDatum.AutoSize = true;
            this.labelSzulDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzulDatum.Location = new System.Drawing.Point(12, 88);
            this.labelSzulDatum.Name = "labelSzulDatum";
            this.labelSzulDatum.Size = new System.Drawing.Size(155, 29);
            this.labelSzulDatum.TabIndex = 1;
            this.labelSzulDatum.Text = "Szül. dátum:";
            // 
            // labelNem
            // 
            this.labelNem.AutoSize = true;
            this.labelNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNem.Location = new System.Drawing.Point(12, 149);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(74, 29);
            this.labelNem.TabIndex = 2;
            this.labelNem.Text = "Nem:";
            // 
            // radioFerfi
            // 
            this.radioFerfi.AutoSize = true;
            this.radioFerfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioFerfi.Location = new System.Drawing.Point(165, 145);
            this.radioFerfi.Name = "radioFerfi";
            this.radioFerfi.Size = new System.Drawing.Size(49, 33);
            this.radioFerfi.TabIndex = 3;
            this.radioFerfi.TabStop = true;
            this.radioFerfi.Text = "F";
            this.radioFerfi.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioNo.Location = new System.Drawing.Point(277, 147);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(52, 33);
            this.radioNo.TabIndex = 4;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "N";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // buttonMentes
            // 
            this.buttonMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMentes.Location = new System.Drawing.Point(570, 396);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(83, 42);
            this.buttonMentes.TabIndex = 5;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.ButtonMentes_Click);
            // 
            // buttonBetolt
            // 
            this.buttonBetolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBetolt.Location = new System.Drawing.Point(678, 396);
            this.buttonBetolt.Name = "buttonBetolt";
            this.buttonBetolt.Size = new System.Drawing.Size(85, 43);
            this.buttonBetolt.TabIndex = 6;
            this.buttonBetolt.Text = "Betöltés";
            this.buttonBetolt.UseVisualStyleBackColor = true;
            this.buttonBetolt.Click += new System.EventHandler(this.ButtonBetolt_Click);
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHozzaad.Location = new System.Drawing.Point(606, 303);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(157, 41);
            this.buttonHozzaad.TabIndex = 7;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            this.buttonHozzaad.Click += new System.EventHandler(this.ButtonHozzaad_Click);
            // 
            // textHobbi
            // 
            this.textHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textHobbi.Location = new System.Drawing.Point(606, 261);
            this.textHobbi.Name = "textHobbi";
            this.textHobbi.Size = new System.Drawing.Size(157, 36);
            this.textHobbi.TabIndex = 8;
            this.textHobbi.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // labelUjHobbi
            // 
            this.labelUjHobbi.AutoSize = true;
            this.labelUjHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUjHobbi.Location = new System.Drawing.Point(480, 261);
            this.labelUjHobbi.Name = "labelUjHobbi";
            this.labelUjHobbi.Size = new System.Drawing.Size(120, 29);
            this.labelUjHobbi.TabIndex = 9;
            this.labelUjHobbi.Text = "Új hobbi :";
            // 
            // labelHobbi
            // 
            this.labelHobbi.AutoSize = true;
            this.labelHobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHobbi.Location = new System.Drawing.Point(480, 29);
            this.labelHobbi.Name = "labelHobbi";
            this.labelHobbi.Size = new System.Drawing.Size(188, 29);
            this.labelHobbi.TabIndex = 10;
            this.labelHobbi.Text = "Kedvenc hobbi:";
            // 
            // hobbilista
            // 
            this.hobbilista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hobbilista.FormattingEnabled = true;
            this.hobbilista.ItemHeight = 20;
            this.hobbilista.Location = new System.Drawing.Point(485, 61);
            this.hobbilista.Name = "hobbilista";
            this.hobbilista.Size = new System.Drawing.Size(278, 184);
            this.hobbilista.TabIndex = 11;
            // 
            // textNev
            // 
            this.textNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textNev.Location = new System.Drawing.Point(165, 30);
            this.textNev.Name = "textNev";
            this.textNev.Size = new System.Drawing.Size(164, 36);
            this.textNev.TabIndex = 12;
            this.textNev.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.textNev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox2_KeyDown);
            // 
            // textSzul
            // 
            this.textSzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textSzul.Location = new System.Drawing.Point(165, 81);
            this.textSzul.Name = "textSzul";
            this.textSzul.Size = new System.Drawing.Size(164, 36);
            this.textSzul.TabIndex = 13;
            this.textSzul.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textSzul);
            this.Controls.Add(this.textNev);
            this.Controls.Add(this.hobbilista);
            this.Controls.Add(this.labelHobbi);
            this.Controls.Add(this.labelUjHobbi);
            this.Controls.Add(this.textHobbi);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.buttonBetolt);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.radioFerfi);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.labelSzulDatum);
            this.Controls.Add(this.labelNev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelSzulDatum;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.RadioButton radioFerfi;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetolt;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.TextBox textHobbi;
        private System.Windows.Forms.Label labelUjHobbi;
        private System.Windows.Forms.Label labelHobbi;
        private System.Windows.Forms.ListBox hobbilista;
        private System.Windows.Forms.TextBox textNev;
        private System.Windows.Forms.TextBox textSzul;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

