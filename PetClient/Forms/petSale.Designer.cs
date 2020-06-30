namespace PetClient.Forms
{
    partial class petSale
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
            this.lbPetsale = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbId = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.picPet = new System.Windows.Forms.PictureBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPetsale
            // 
            this.lbPetsale.AutoSize = true;
            this.lbPetsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPetsale.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPetsale.Location = new System.Drawing.Point(127, 18);
            this.lbPetsale.Name = "lbPetsale";
            this.lbPetsale.Size = new System.Drawing.Size(448, 95);
            this.lbPetsale.TabIndex = 0;
            this.lbPetsale.Text = "PET SALE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(704, 170);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbId.Location = new System.Drawing.Point(31, 336);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(28, 17);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID:";
            this.lbId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbType.Location = new System.Drawing.Point(31, 377);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(53, 17);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "TYPE:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGender.Location = new System.Drawing.Point(31, 412);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(78, 17);
            this.lbGender.TabIndex = 4;
            this.lbGender.Text = "GENDER:";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbWeight.Location = new System.Drawing.Point(31, 441);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(74, 17);
            this.lbWeight.TabIndex = 5;
            this.lbWeight.Text = "WEIGHT:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAge.Location = new System.Drawing.Point(31, 474);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(45, 17);
            this.lbAge.TabIndex = 6;
            this.lbAge.Text = "AGE:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(143, 336);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(376, 22);
            this.tbID.TabIndex = 7;
            this.tbID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(143, 372);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(376, 22);
            this.tbType.TabIndex = 8;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(143, 407);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(376, 22);
            this.tbGender.TabIndex = 9;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(143, 436);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(376, 22);
            this.tbWeight.TabIndex = 10;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(143, 469);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(376, 22);
            this.tbAge.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(767, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 58);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Location = new System.Drawing.Point(767, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 58);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Location = new System.Drawing.Point(767, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 58);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(573, 474);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(193, 22);
            this.tbSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Location = new System.Drawing.Point(789, 453);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 58);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(143, 497);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(376, 22);
            this.tbPrice.TabIndex = 16;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.Location = new System.Drawing.Point(31, 500);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 17);
            this.lbPrice.TabIndex = 17;
            this.lbPrice.Text = "PRICE:";
            // 
            // picPet
            // 
            this.picPet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picPet.Location = new System.Drawing.Point(573, 356);
            this.picPet.Name = "picPet";
            this.picPet.Size = new System.Drawing.Size(135, 102);
            this.picPet.TabIndex = 18;
            this.picPet.TabStop = false;
            this.picPet.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(573, 333);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 19;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(828, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // petSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(915, 531);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.picPet);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbPetsale);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "petSale";
            this.Text = "petSale";
            this.Load += new System.EventHandler(this.petSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPetsale;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox picPet;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnBack;
    }
}