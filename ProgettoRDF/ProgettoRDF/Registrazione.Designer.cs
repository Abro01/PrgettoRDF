
namespace ProgettoRDF
{
    partial class Registrazione
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
            this.btRegistrazione = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCognome = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btRegistrazione
            // 
            this.btRegistrazione.Location = new System.Drawing.Point(366, 258);
            this.btRegistrazione.Name = "btRegistrazione";
            this.btRegistrazione.Size = new System.Drawing.Size(98, 36);
            this.btRegistrazione.TabIndex = 0;
            this.btRegistrazione.Text = "Registati";
            this.btRegistrazione.UseVisualStyleBackColor = true;
            this.btRegistrazione.Click += new System.EventHandler(this.btRegistrazione_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cognome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(366, 29);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 20);
            this.textUser.TabIndex = 6;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(366, 62);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 7;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(366, 90);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 8;
            // 
            // textCognome
            // 
            this.textCognome.Location = new System.Drawing.Point(366, 117);
            this.textCognome.Name = "textCognome";
            this.textCognome.Size = new System.Drawing.Size(100, 20);
            this.textCognome.TabIndex = 9;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(364, 148);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 10;
            // 
            // Registrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 440);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textCognome);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegistrazione);
            this.Name = "Registrazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegistrazione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textCognome;
        private System.Windows.Forms.TextBox textPassword;
    }
}