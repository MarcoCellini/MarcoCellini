namespace CodiceFiscale
{
    partial class CodF
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.cognome = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.nato = new System.Windows.Forms.DateTimePicker();
            this.MA = new System.Windows.Forms.CheckBox();
            this.FE = new System.Windows.Forms.CheckBox();
            this.city = new System.Windows.Forms.TextBox();
            this.provincia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cognome
            // 
            this.cognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cognome.Location = new System.Drawing.Point(269, 113);
            this.cognome.Name = "cognome";
            this.cognome.Size = new System.Drawing.Size(274, 29);
            this.cognome.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(269, 158);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(274, 29);
            this.nome.TabIndex = 1;
            // 
            // nato
            // 
            this.nato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nato.Location = new System.Drawing.Point(269, 202);
            this.nato.Name = "nato";
            this.nato.Size = new System.Drawing.Size(274, 29);
            this.nato.TabIndex = 2;
            // 
            // MA
            // 
            this.MA.AutoSize = true;
            this.MA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MA.Location = new System.Drawing.Point(269, 237);
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(100, 28);
            this.MA.TabIndex = 3;
            this.MA.Text = "Maschio";
            this.MA.UseVisualStyleBackColor = true;
            // 
            // FE
            // 
            this.FE.AutoSize = true;
            this.FE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FE.Location = new System.Drawing.Point(434, 237);
            this.FE.Name = "FE";
            this.FE.Size = new System.Drawing.Size(109, 28);
            this.FE.TabIndex = 4;
            this.FE.Text = "Femmina";
            this.FE.UseVisualStyleBackColor = true;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(269, 271);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(199, 29);
            this.city.TabIndex = 5;
            // 
            // provincia
            // 
            this.provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provincia.Location = new System.Drawing.Point(474, 271);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(71, 29);
            this.provincia.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codice Fiscale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data di nascita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sesso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Città e Provincia";
            // 
            // CodF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.provincia);
            this.Controls.Add(this.city);
            this.Controls.Add(this.FE);
            this.Controls.Add(this.MA);
            this.Controls.Add(this.nato);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.cognome);
            this.Name = "CodF";
            this.Text = "Codice Fiscale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cognome;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.DateTimePicker nato;
        private System.Windows.Forms.CheckBox MA;
        private System.Windows.Forms.CheckBox FE;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox provincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

