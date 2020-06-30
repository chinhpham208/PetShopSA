namespace PetClient.Forms
{
    partial class Menu
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
            this.btnPetsale = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnPetser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPetsale
            // 
            this.btnPetsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPetsale.ForeColor = System.Drawing.Color.Maroon;
            this.btnPetsale.Location = new System.Drawing.Point(27, 163);
            this.btnPetsale.Name = "btnPetsale";
            this.btnPetsale.Size = new System.Drawing.Size(171, 67);
            this.btnPetsale.TabIndex = 0;
            this.btnPetsale.Text = "PetSales";
            this.btnPetsale.UseVisualStyleBackColor = true;
            this.btnPetsale.Click += new System.EventHandler(this.btnPetsale_Click);
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnU.ForeColor = System.Drawing.Color.Maroon;
            this.btnU.Location = new System.Drawing.Point(542, 163);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(186, 67);
            this.btnU.TabIndex = 1;
            this.btnU.Text = "User Management";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPetser
            // 
            this.btnPetser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPetser.ForeColor = System.Drawing.Color.Maroon;
            this.btnPetser.Location = new System.Drawing.Point(277, 163);
            this.btnPetser.Name = "btnPetser";
            this.btnPetser.Size = new System.Drawing.Size(171, 67);
            this.btnPetser.TabIndex = 2;
            this.btnPetser.Text = "Pet Services";
            this.btnPetser.UseVisualStyleBackColor = true;
            this.btnPetser.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogout.Location = new System.Drawing.Point(658, 394);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(117, 44);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(214, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPetser);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnPetsale);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPetsale;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnPetser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}