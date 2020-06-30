namespace PetClient.Forms
{
    partial class petServices
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
            this.lbPetservices = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbIdCus = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbPetName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNameCus = new System.Windows.Forms.TextBox();
            this.tbIdCus = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbWhat = new System.Windows.Forms.TextBox();
            this.lbWhat = new System.Windows.Forms.Label();
            this.tbTypePet = new System.Windows.Forms.TextBox();
            this.tbWeightPet = new System.Windows.Forms.TextBox();
            this.tbAgePet = new System.Windows.Forms.TextBox();
            this.tbGenderPet = new System.Windows.Forms.TextBox();
            this.tbNamePet = new System.Windows.Forms.TextBox();
            this.lbPetType = new System.Windows.Forms.Label();
            this.lbPetWeight = new System.Windows.Forms.Label();
            this.lbPetAge = new System.Windows.Forms.Label();
            this.btnAddS = new System.Windows.Forms.Button();
            this.btnUpdateS = new System.Windows.Forms.Button();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.tbSearchS = new System.Windows.Forms.TextBox();
            this.btnSearchS = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPetservices
            // 
            this.lbPetservices.AutoSize = true;
            this.lbPetservices.BackColor = System.Drawing.SystemColors.Control;
            this.lbPetservices.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPetservices.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPetservices.Location = new System.Drawing.Point(99, 9);
            this.lbPetservices.Name = "lbPetservices";
            this.lbPetservices.Size = new System.Drawing.Size(524, 95);
            this.lbPetservices.TabIndex = 0;
            this.lbPetservices.Text = "Pet Services";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 215);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // lbIdCus
            // 
            this.lbIdCus.AutoSize = true;
            this.lbIdCus.Location = new System.Drawing.Point(6, 30);
            this.lbIdCus.Name = "lbIdCus";
            this.lbIdCus.Size = new System.Drawing.Size(28, 17);
            this.lbIdCus.TabIndex = 2;
            this.lbIdCus.Text = "ID:";
            this.lbIdCus.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Location = new System.Drawing.Point(6, 61);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(142, 17);
            this.lbCustomer.TabIndex = 3;
            this.lbCustomer.Text = "CUSTOMERNAME:";
            // 
            // lbPetName
            // 
            this.lbPetName.Location = new System.Drawing.Point(6, 31);
            this.lbPetName.Name = "lbPetName";
            this.lbPetName.Size = new System.Drawing.Size(88, 22);
            this.lbPetName.TabIndex = 4;
            this.lbPetName.Text = "PETNAME:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(6, 66);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(78, 17);
            this.lbGender.TabIndex = 5;
            this.lbGender.Text = "GENDER:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNameCus);
            this.groupBox1.Controls.Add(this.tbIdCus);
            this.groupBox1.Controls.Add(this.lbIdCus);
            this.groupBox1.Controls.Add(this.lbCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(24, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUSTOMER:";
            // 
            // tbNameCus
            // 
            this.tbNameCus.Location = new System.Drawing.Point(151, 61);
            this.tbNameCus.Name = "tbNameCus";
            this.tbNameCus.Size = new System.Drawing.Size(416, 22);
            this.tbNameCus.TabIndex = 15;
            // 
            // tbIdCus
            // 
            this.tbIdCus.Location = new System.Drawing.Point(53, 27);
            this.tbIdCus.Name = "tbIdCus";
            this.tbIdCus.Size = new System.Drawing.Size(416, 22);
            this.tbIdCus.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbWhat);
            this.groupBox2.Controls.Add(this.lbWhat);
            this.groupBox2.Controls.Add(this.tbTypePet);
            this.groupBox2.Controls.Add(this.tbWeightPet);
            this.groupBox2.Controls.Add(this.tbAgePet);
            this.groupBox2.Controls.Add(this.tbGenderPet);
            this.groupBox2.Controls.Add(this.tbNamePet);
            this.groupBox2.Controls.Add(this.lbPetType);
            this.groupBox2.Controls.Add(this.lbPetWeight);
            this.groupBox2.Controls.Add(this.lbPetAge);
            this.groupBox2.Controls.Add(this.lbPetName);
            this.groupBox2.Controls.Add(this.lbGender);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(24, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 244);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PET:";
            // 
            // tbWhat
            // 
            this.tbWhat.Location = new System.Drawing.Point(146, 212);
            this.tbWhat.Name = "tbWhat";
            this.tbWhat.Size = new System.Drawing.Size(416, 22);
            this.tbWhat.TabIndex = 15;
            // 
            // lbWhat
            // 
            this.lbWhat.AutoSize = true;
            this.lbWhat.Location = new System.Drawing.Point(7, 215);
            this.lbWhat.Name = "lbWhat";
            this.lbWhat.Size = new System.Drawing.Size(133, 17);
            this.lbWhat.TabIndex = 14;
            this.lbWhat.Text = "WHATSERVICES:";
            // 
            // tbTypePet
            // 
            this.tbTypePet.Location = new System.Drawing.Point(87, 178);
            this.tbTypePet.Name = "tbTypePet";
            this.tbTypePet.Size = new System.Drawing.Size(416, 22);
            this.tbTypePet.TabIndex = 13;
            // 
            // tbWeightPet
            // 
            this.tbWeightPet.Location = new System.Drawing.Point(87, 137);
            this.tbWeightPet.Name = "tbWeightPet";
            this.tbWeightPet.Size = new System.Drawing.Size(416, 22);
            this.tbWeightPet.TabIndex = 12;
            // 
            // tbAgePet
            // 
            this.tbAgePet.Location = new System.Drawing.Point(87, 101);
            this.tbAgePet.Name = "tbAgePet";
            this.tbAgePet.Size = new System.Drawing.Size(416, 22);
            this.tbAgePet.TabIndex = 11;
            // 
            // tbGenderPet
            // 
            this.tbGenderPet.Location = new System.Drawing.Point(87, 66);
            this.tbGenderPet.Name = "tbGenderPet";
            this.tbGenderPet.Size = new System.Drawing.Size(416, 22);
            this.tbGenderPet.TabIndex = 10;
            // 
            // tbNamePet
            // 
            this.tbNamePet.Location = new System.Drawing.Point(91, 31);
            this.tbNamePet.Name = "tbNamePet";
            this.tbNamePet.Size = new System.Drawing.Size(416, 22);
            this.tbNamePet.TabIndex = 9;
            // 
            // lbPetType
            // 
            this.lbPetType.AutoSize = true;
            this.lbPetType.Location = new System.Drawing.Point(6, 178);
            this.lbPetType.Name = "lbPetType";
            this.lbPetType.Size = new System.Drawing.Size(53, 17);
            this.lbPetType.TabIndex = 8;
            this.lbPetType.Text = "TYPE:";
            // 
            // lbPetWeight
            // 
            this.lbPetWeight.AutoSize = true;
            this.lbPetWeight.Location = new System.Drawing.Point(6, 140);
            this.lbPetWeight.Name = "lbPetWeight";
            this.lbPetWeight.Size = new System.Drawing.Size(74, 17);
            this.lbPetWeight.TabIndex = 7;
            this.lbPetWeight.Text = "WEIGHT:";
            // 
            // lbPetAge
            // 
            this.lbPetAge.AutoSize = true;
            this.lbPetAge.Location = new System.Drawing.Point(7, 104);
            this.lbPetAge.Name = "lbPetAge";
            this.lbPetAge.Size = new System.Drawing.Size(45, 17);
            this.lbPetAge.TabIndex = 6;
            this.lbPetAge.Text = "AGE:";
            // 
            // btnAddS
            // 
            this.btnAddS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAddS.Location = new System.Drawing.Point(835, 107);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(99, 61);
            this.btnAddS.TabIndex = 8;
            this.btnAddS.Text = "ADD";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // btnUpdateS
            // 
            this.btnUpdateS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateS.Location = new System.Drawing.Point(835, 193);
            this.btnUpdateS.Name = "btnUpdateS";
            this.btnUpdateS.Size = new System.Drawing.Size(99, 61);
            this.btnUpdateS.TabIndex = 9;
            this.btnUpdateS.Text = "UPDATE";
            this.btnUpdateS.UseVisualStyleBackColor = true;
            this.btnUpdateS.Click += new System.EventHandler(this.btnUpdateS_Click);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteS.Location = new System.Drawing.Point(835, 280);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(99, 61);
            this.btnDeleteS.TabIndex = 10;
            this.btnDeleteS.Text = "DELETE";
            this.btnDeleteS.UseVisualStyleBackColor = true;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // tbSearchS
            // 
            this.tbSearchS.Location = new System.Drawing.Point(652, 457);
            this.tbSearchS.Name = "tbSearchS";
            this.tbSearchS.Size = new System.Drawing.Size(212, 22);
            this.tbSearchS.TabIndex = 11;
            // 
            // btnSearchS
            // 
            this.btnSearchS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearchS.Location = new System.Drawing.Point(870, 451);
            this.btnSearchS.Name = "btnSearchS";
            this.btnSearchS.Size = new System.Drawing.Size(111, 44);
            this.btnSearchS.TabIndex = 12;
            this.btnSearchS.Text = "SEARCH";
            this.btnSearchS.UseVisualStyleBackColor = true;
            this.btnSearchS.Click += new System.EventHandler(this.btnSearchS_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(890, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // petServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 713);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchS);
            this.Controls.Add(this.tbSearchS);
            this.Controls.Add(this.btnDeleteS);
            this.Controls.Add(this.btnUpdateS);
            this.Controls.Add(this.btnAddS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbPetservices);
            this.Name = "petServices";
            this.Text = "petServices";
            this.Load += new System.EventHandler(this.petServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPetservices;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbIdCus;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbPetName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNameCus;
        private System.Windows.Forms.TextBox tbIdCus;
        private System.Windows.Forms.TextBox tbTypePet;
        private System.Windows.Forms.TextBox tbWeightPet;
        private System.Windows.Forms.TextBox tbAgePet;
        private System.Windows.Forms.TextBox tbGenderPet;
        private System.Windows.Forms.TextBox tbNamePet;
        private System.Windows.Forms.Label lbPetType;
        private System.Windows.Forms.Label lbPetWeight;
        private System.Windows.Forms.Label lbPetAge;
        private System.Windows.Forms.TextBox tbWhat;
        private System.Windows.Forms.Label lbWhat;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.Button btnUpdateS;
        private System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.TextBox tbSearchS;
        private System.Windows.Forms.Button btnSearchS;
        private System.Windows.Forms.Button btnBack;
    }
}