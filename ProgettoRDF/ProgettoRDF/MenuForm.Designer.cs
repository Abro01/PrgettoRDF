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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnProva = new System.Windows.Forms.Button();
            this.btnProfilo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProva
            // 
            this.btnProva.Location = new System.Drawing.Point(329, 173);
            this.btnProva.Name = "btnProva";
            this.btnProva.Size = new System.Drawing.Size(189, 118);
            this.btnProva.TabIndex = 1;
            this.btnProva.Text = "Prova\r\n";
            this.btnProva.UseVisualStyleBackColor = true;
            this.btnProva.Click += new System.EventHandler(this.btnProva_Click);
            // 
            // btnProfilo
            // 
            this.btnProfilo.Image = ((System.Drawing.Image)(resources.GetObject("btnProfilo.Image")));
            this.btnProfilo.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnProfilo.InitialImage")));
            this.btnProfilo.Location = new System.Drawing.Point(12, 12);
            this.btnProfilo.Name = "btnProfilo";
            this.btnProfilo.Size = new System.Drawing.Size(93, 85);
            this.btnProfilo.TabIndex = 2;
            this.btnProfilo.TabStop = false;
            this.btnProfilo.Click += new System.EventHandler(this.btnProfilo_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnProfilo);
            this.Controls.Add(this.btnProva);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProva;
        private System.Windows.Forms.PictureBox btnProfilo;
    }
}