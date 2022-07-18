namespace ProgettoRDF
{
    partial class MenuForm
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
            this.txtProva = new System.Windows.Forms.Label();
            this.btProva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProva
            // 
            this.txtProva.AutoSize = true;
            this.txtProva.Location = new System.Drawing.Point(433, 121);
            this.txtProva.Name = "txtProva";
            this.txtProva.Size = new System.Drawing.Size(45, 20);
            this.txtProva.TabIndex = 0;
            this.txtProva.Text = "aaaa";
            // 
            // btProva
            // 
            this.btProva.Location = new System.Drawing.Point(480, 313);
            this.btProva.Name = "btProva";
            this.btProva.Size = new System.Drawing.Size(75, 23);
            this.btProva.TabIndex = 1;
            this.btProva.Text = "Prova\r\n";
            this.btProva.UseVisualStyleBackColor = true;
            this.btProva.Click += new System.EventHandler(this.btProva_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btProva);
            this.Controls.Add(this.txtProva);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtProva;
        private System.Windows.Forms.Button btProva;
    }
}