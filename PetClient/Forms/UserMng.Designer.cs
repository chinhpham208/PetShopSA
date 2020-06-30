namespace PetClient.Forms
{
    partial class UserMng
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnShowR = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnUpdateU = new System.Windows.Forms.Button();
            this.btnDeleteU = new System.Windows.Forms.Button();
            this.btkBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(25, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Password";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER MANAGEMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(395, 115);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(50, 17);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "USER:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(395, 157);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(92, 17);
            this.lbPass.TabIndex = 3;
            this.lbPass.Text = "PASSWORD:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(519, 112);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(195, 22);
            this.tbUser.TabIndex = 4;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(519, 157);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(195, 22);
            this.tbPass.TabIndex = 5;
            // 
            // btnShowR
            // 
            this.btnShowR.Location = new System.Drawing.Point(25, 294);
            this.btnShowR.Name = "btnShowR";
            this.btnShowR.Size = new System.Drawing.Size(119, 32);
            this.btnShowR.TabIndex = 6;
            this.btnShowR.Text = "Show Records";
            this.btnShowR.UseVisualStyleBackColor = true;
            this.btnShowR.Click += new System.EventHandler(this.btnShowR_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(409, 233);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(97, 37);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "REGISTER";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnUpdateU
            // 
            this.btnUpdateU.Location = new System.Drawing.Point(546, 233);
            this.btnUpdateU.Name = "btnUpdateU";
            this.btnUpdateU.Size = new System.Drawing.Size(97, 37);
            this.btnUpdateU.TabIndex = 8;
            this.btnUpdateU.Text = "UPDATE";
            this.btnUpdateU.UseVisualStyleBackColor = true;
            this.btnUpdateU.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteU
            // 
            this.btnDeleteU.Location = new System.Drawing.Point(488, 312);
            this.btnDeleteU.Name = "btnDeleteU";
            this.btnDeleteU.Size = new System.Drawing.Size(97, 37);
            this.btnDeleteU.TabIndex = 9;
            this.btnDeleteU.Text = "DELETE";
            this.btnDeleteU.UseVisualStyleBackColor = true;
            this.btnDeleteU.Click += new System.EventHandler(this.btnDeleteU_Click);
            // 
            // btkBack
            // 
            this.btkBack.Location = new System.Drawing.Point(704, 404);
            this.btkBack.Name = "btkBack";
            this.btkBack.Size = new System.Drawing.Size(75, 23);
            this.btkBack.TabIndex = 10;
            this.btkBack.Text = "Back";
            this.btkBack.UseVisualStyleBackColor = true;
            this.btkBack.Click += new System.EventHandler(this.btkBack_Click);
            // 
            // UserMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btkBack);
            this.Controls.Add(this.btnDeleteU);
            this.Controls.Add(this.btnUpdateU);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnShowR);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserMng";
            this.Text = "UserMng";
            this.Load += new System.EventHandler(this.UserMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnShowR;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnUpdateU;
        private System.Windows.Forms.Button btnDeleteU;
        private System.Windows.Forms.Button btkBack;
    }
}