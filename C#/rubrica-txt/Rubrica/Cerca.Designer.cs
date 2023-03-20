namespace Rubrica
{
    partial class Cerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cerca));
            this.indietro = new System.Windows.Forms.Button();
            this.tabella = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).BeginInit();
            this.SuspendLayout();
            // 
            // indietro
            // 
            this.indietro.BackColor = System.Drawing.Color.Transparent;
            this.indietro.FlatAppearance.BorderSize = 0;
            this.indietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro.Image = global::Rubrica.Properties.Resources._1904658_arrow_arrow_left_change_direction_left_next_undo_122508;
            this.indietro.Location = new System.Drawing.Point(8, 9);
            this.indietro.Margin = new System.Windows.Forms.Padding(0);
            this.indietro.Name = "indietro";
            this.indietro.Size = new System.Drawing.Size(46, 41);
            this.indietro.TabIndex = 16;
            this.indietro.TabStop = false;
            this.indietro.UseVisualStyleBackColor = false;
            this.indietro.Click += new System.EventHandler(this.indietro_Click);
            // 
            // tabella
            // 
            this.tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabella.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.cognome,
            this.telefono,
            this.email,
            this.nascita,
            this.indirizzo});
            this.tabella.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabella.Location = new System.Drawing.Point(57, 37);
            this.tabella.Name = "tabella";
            this.tabella.Size = new System.Drawing.Size(994, 401);
            this.tabella.TabIndex = 17;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "Identificativo utente";
            this.id.Width = 30;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.ToolTipText = "Nome utente";
            // 
            // cognome
            // 
            this.cognome.HeaderText = "Cognome";
            this.cognome.Name = "cognome";
            this.cognome.ReadOnly = true;
            this.cognome.ToolTipText = "Cognome utenet";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Numero di Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.ToolTipText = "Numero di telefono";
            this.telefono.Width = 120;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.ToolTipText = "Email utente";
            this.email.Width = 150;
            // 
            // nascita
            // 
            this.nascita.HeaderText = "Data di nascita";
            this.nascita.Name = "nascita";
            this.nascita.ReadOnly = true;
            this.nascita.ToolTipText = "Data di nascita utente";
            this.nascita.Width = 150;
            // 
            // indirizzo
            // 
            this.indirizzo.HeaderText = "Indirizzo";
            this.indirizzo.Name = "indirizzo";
            this.indirizzo.ReadOnly = true;
            this.indirizzo.ToolTipText = "Indirizzo di casa dell\'utente";
            this.indirizzo.Width = 300;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(233, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(337, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 20);
            this.textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(457, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 20);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(603, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(128, 20);
            this.textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(755, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(282, 20);
            this.textBox7.TabIndex = 24;
            // 
            // Cerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabella);
            this.Controls.Add(this.indietro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cerca";
            this.Text = "Cerca";
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button indietro;
        private System.Windows.Forms.DataGridView tabella;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascita;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}