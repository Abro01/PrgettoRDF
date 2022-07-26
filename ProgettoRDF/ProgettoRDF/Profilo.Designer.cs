namespace ProgettoRDF
{
    partial class Profilo
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
            this.lTitolo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lCognome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTitolo
            // 
            this.lTitolo.AutoSize = true;
            this.lTitolo.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitolo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lTitolo.Location = new System.Drawing.Point(22, -3);
            this.lTitolo.Name = "lTitolo";
            this.lTitolo.Size = new System.Drawing.Size(485, 82);
            this.lTitolo.TabIndex = 1;
            this.lTitolo.Text = "DATI PROFILO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME:";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(199, 105);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(35, 13);
            this.lUsername.TabIndex = 3;
            this.lUsername.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EMAIL:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(199, 157);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(35, 13);
            this.lEmail.TabIndex = 5;
            this.lEmail.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOME:";
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(199, 211);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(35, 13);
            this.lNome.TabIndex = 7;
            this.lNome.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "COGNOME:";
            // 
            // lCognome
            // 
            this.lCognome.AutoSize = true;
            this.lCognome.Location = new System.Drawing.Point(199, 256);
            this.lCognome.Name = "lCognome";
            this.lCognome.Size = new System.Drawing.Size(35, 13);
            this.lCognome.TabIndex = 9;
            this.lCognome.Text = "label7";
            // 
            // Profilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 419);
            this.Controls.Add(this.lCognome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lTitolo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Profilo";
            this.Text = "Profilo";
            this.Load += new System.EventHandler(this.Profilo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTitolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lCognome;
    }
}