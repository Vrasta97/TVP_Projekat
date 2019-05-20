namespace TVP_Projekat
{
    partial class frmMeni
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
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.btnNoviArtikal = new System.Windows.Forms.Button();
            this.btnPretragaRacuna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNoviRacun.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviRacun.Location = new System.Drawing.Point(190, 175);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(454, 189);
            this.btnNoviRacun.TabIndex = 1;
            this.btnNoviRacun.Text = "Novi Racun";
            this.btnNoviRacun.UseVisualStyleBackColor = false;
            // 
            // btnNoviArtikal
            // 
            this.btnNoviArtikal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNoviArtikal.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviArtikal.Location = new System.Drawing.Point(66, 9);
            this.btnNoviArtikal.Name = "btnNoviArtikal";
            this.btnNoviArtikal.Size = new System.Drawing.Size(303, 123);
            this.btnNoviArtikal.TabIndex = 2;
            this.btnNoviArtikal.Text = "Novi Artikal";
            this.btnNoviArtikal.UseVisualStyleBackColor = false;
            // 
            // btnPretragaRacuna
            // 
            this.btnPretragaRacuna.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPretragaRacuna.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretragaRacuna.Location = new System.Drawing.Point(500, 9);
            this.btnPretragaRacuna.Name = "btnPretragaRacuna";
            this.btnPretragaRacuna.Size = new System.Drawing.Size(303, 123);
            this.btnPretragaRacuna.TabIndex = 3;
            this.btnPretragaRacuna.Text = "Pretraga Racuna";
            this.btnPretragaRacuna.UseVisualStyleBackColor = false;
            // 
            // frmMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(853, 496);
            this.Controls.Add(this.btnPretragaRacuna);
            this.Controls.Add(this.btnNoviArtikal);
            this.Controls.Add(this.btnNoviRacun);
            this.Name = "frmMeni";
            this.Text = "Meni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoviRacun;
        private System.Windows.Forms.Button btnNoviArtikal;
        private System.Windows.Forms.Button btnPretragaRacuna;
    }
}

