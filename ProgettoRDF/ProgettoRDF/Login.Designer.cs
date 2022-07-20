namespace ProgettoRDF
{
    partial class Login
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
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btRegistrati = new ProgettoRDF.Elementi.RJButton();
            this.Accedi = new ProgettoRDF.Elementi.RJButton();
            this.Exit = new ProgettoRDF.Elementi.RJButton();
            this.Clear = new ProgettoRDF.Elementi.RJButton();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(187, 37);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(187, 71);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 2;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD";
            // 
            // btRegistrati
            // 
            this.btRegistrati.BackColor = System.Drawing.Color.LightGray;
            this.btRegistrati.FlatAppearance.BorderSize = 0;
            this.btRegistrati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrati.ForeColor = System.Drawing.Color.Black;
            this.btRegistrati.Location = new System.Drawing.Point(346, 257);
            this.btRegistrati.Margin = new System.Windows.Forms.Padding(2);
            this.btRegistrati.Name = "btRegistrati";
            this.btRegistrati.Size = new System.Drawing.Size(108, 29);
            this.btRegistrati.TabIndex = 11;
            this.btRegistrati.Text = "REGISTRATI";
            this.btRegistrati.UseVisualStyleBackColor = false;
            this.btRegistrati.Click += new System.EventHandler(this.btRegistrati_Click);
            // 
            // Accedi
            // 
            this.Accedi.BackColor = System.Drawing.Color.LightGray;
            this.Accedi.FlatAppearance.BorderSize = 0;
            this.Accedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accedi.ForeColor = System.Drawing.Color.White;
            this.Accedi.Location = new System.Drawing.Point(177, 194);
            this.Accedi.Margin = new System.Windows.Forms.Padding(2);
            this.Accedi.Name = "Accedi";
            this.Accedi.Size = new System.Drawing.Size(108, 29);
            this.Accedi.TabIndex = 10;
            this.Accedi.Text = "Login";
            this.Accedi.UseVisualStyleBackColor = false;
            this.Accedi.Click += new System.EventHandler(this.Accedi_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightGray;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(81, 129);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 29);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Silver;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(265, 129);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(108, 29);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(465, 297);
            this.Controls.Add(this.btRegistrati);
            this.Controls.Add(this.Accedi);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Name = "Login";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Elementi.RJButton Clear;
        private Elementi.RJButton Exit;
        private Elementi.RJButton Accedi;
        private Elementi.RJButton btRegistrati;
    }
}

