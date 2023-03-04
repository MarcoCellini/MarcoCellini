namespace Rubrica
{
    partial class Aggiuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aggiuni));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nome = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.cognome = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.invio = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.indirizzo = new System.Windows.Forms.TextBox();
            this.nascita = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nome);
            this.flowLayoutPanel1.Controls.Add(this.name);
            this.flowLayoutPanel1.Controls.Add(this.cognome);
            this.flowLayoutPanel1.Controls.Add(this.surname);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.phone);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(213, 106);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(185, 142);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(4, 0);
            this.nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(4, 18);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(168, 20);
            this.name.TabIndex = 0;
            // 
            // cognome
            // 
            this.cognome.AutoSize = true;
            this.cognome.Location = new System.Drawing.Point(4, 43);
            this.cognome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cognome.Name = "cognome";
            this.cognome.Size = new System.Drawing.Size(52, 13);
            this.cognome.TabIndex = 4;
            this.cognome.Text = "Cognome";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(4, 61);
            this.surname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(168, 20);
            this.surname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero di telefono";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(4, 104);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(168, 20);
            this.phone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(4, 18);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(168, 20);
            this.email.TabIndex = 3;
            // 
            // invio
            // 
            this.invio.Location = new System.Drawing.Point(373, 256);
            this.invio.Name = "invio";
            this.invio.Size = new System.Drawing.Size(69, 33);
            this.invio.TabIndex = 6;
            this.invio.Text = "Invio";
            this.invio.UseVisualStyleBackColor = true;
            this.invio.Click += new System.EventHandler(this.invio_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.email);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.nascita);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.indirizzo);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(406, 106);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(185, 142);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data di nascita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Indirizzo";
            // 
            // indirizzo
            // 
            this.indirizzo.Location = new System.Drawing.Point(4, 100);
            this.indirizzo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indirizzo.Name = "indirizzo";
            this.indirizzo.Size = new System.Drawing.Size(168, 20);
            this.indirizzo.TabIndex = 5;
            // 
            // nascita
            // 
            this.nascita.Location = new System.Drawing.Point(3, 59);
            this.nascita.MaxDate = new System.DateTime(2023, 3, 4, 0, 0, 0, 0);
            this.nascita.MinDate = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            this.nascita.Name = "nascita";
            this.nascita.Size = new System.Drawing.Size(169, 20);
            this.nascita.TabIndex = 4;
            this.nascita.Value = new System.DateTime(2023, 3, 4, 0, 0, 0, 0);
            // 
            // Aggiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.invio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aggiuni";
            this.Text = "Aggiuni";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label cognome;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Button invio;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox indirizzo;
        private System.Windows.Forms.DateTimePicker nascita;
    }
}