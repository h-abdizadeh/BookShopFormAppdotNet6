namespace BookShop
{
    partial class BookForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.bookSummary = new System.Windows.Forms.TextBox();
            this.bookInventory = new System.Windows.Forms.TextBox();
            this.bookPrice = new System.Windows.Forms.TextBox();
            this.comboGroups = new System.Windows.Forms.ComboBox();
            this.bookPublisher = new System.Windows.Forms.TextBox();
            this.bookTranslator = new System.Windows.Forms.TextBox();
            this.bookWriter = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAddPicture);
            this.groupBox1.Controls.Add(this.bookPicture);
            this.groupBox1.Controls.Add(this.bookSummary);
            this.groupBox1.Controls.Add(this.bookInventory);
            this.groupBox1.Controls.Add(this.bookPrice);
            this.groupBox1.Controls.Add(this.comboGroups);
            this.groupBox1.Controls.Add(this.bookPublisher);
            this.groupBox1.Controls.Add(this.bookTranslator);
            this.groupBox1.Controls.Add(this.bookWriter);
            this.groupBox1.Controls.Add(this.bookName);
            this.groupBox1.Location = new System.Drawing.Point(520, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(300, 649);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت / وبرایش کتاب";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(199, 602);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 41);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(6, 602);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ثبت کتاب";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(143, 548);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(147, 29);
            this.btnAddPicture.TabIndex = 10;
            this.btnAddPicture.Text = "انتخاب تصویر جلد";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // bookPicture
            // 
            this.bookPicture.BackColor = System.Drawing.Color.White;
            this.bookPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookPicture.Location = new System.Drawing.Point(6, 382);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(288, 200);
            this.bookPicture.TabIndex = 9;
            this.bookPicture.TabStop = false;
            // 
            // bookSummary
            // 
            this.bookSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookSummary.Location = new System.Drawing.Point(6, 264);
            this.bookSummary.Multiline = true;
            this.bookSummary.Name = "bookSummary";
            this.bookSummary.PlaceholderText = "خلاصه";
            this.bookSummary.Size = new System.Drawing.Size(288, 112);
            this.bookSummary.TabIndex = 8;
            // 
            // bookInventory
            // 
            this.bookInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookInventory.Location = new System.Drawing.Point(6, 226);
            this.bookInventory.Name = "bookInventory";
            this.bookInventory.PlaceholderText = "موجودی ";
            this.bookInventory.Size = new System.Drawing.Size(90, 32);
            this.bookInventory.TabIndex = 7;
            // 
            // bookPrice
            // 
            this.bookPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookPrice.Location = new System.Drawing.Point(102, 226);
            this.bookPrice.Name = "bookPrice";
            this.bookPrice.PlaceholderText = "قیمت (تومان)";
            this.bookPrice.Size = new System.Drawing.Size(192, 32);
            this.bookPrice.TabIndex = 6;
            this.bookPrice.TextChanged += new System.EventHandler(this.bookPrice_TextChanged);
            // 
            // comboGroups
            // 
            this.comboGroups.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboGroups.FormattingEnabled = true;
            this.comboGroups.Location = new System.Drawing.Point(6, 187);
            this.comboGroups.Name = "comboGroups";
            this.comboGroups.Size = new System.Drawing.Size(288, 33);
            this.comboGroups.TabIndex = 5;
            this.comboGroups.Text = "--  انتخاب گروه --";
            // 
            // bookPublisher
            // 
            this.bookPublisher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookPublisher.Location = new System.Drawing.Point(6, 149);
            this.bookPublisher.Name = "bookPublisher";
            this.bookPublisher.PlaceholderText = "انتشارات";
            this.bookPublisher.Size = new System.Drawing.Size(288, 32);
            this.bookPublisher.TabIndex = 4;
            // 
            // bookTranslator
            // 
            this.bookTranslator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookTranslator.Location = new System.Drawing.Point(6, 111);
            this.bookTranslator.Name = "bookTranslator";
            this.bookTranslator.PlaceholderText = "مترجم";
            this.bookTranslator.Size = new System.Drawing.Size(288, 32);
            this.bookTranslator.TabIndex = 3;
            // 
            // bookWriter
            // 
            this.bookWriter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookWriter.Location = new System.Drawing.Point(6, 73);
            this.bookWriter.Name = "bookWriter";
            this.bookWriter.PlaceholderText = "نویسنده";
            this.bookWriter.Size = new System.Drawing.Size(288, 32);
            this.bookWriter.TabIndex = 2;
            // 
            // bookName
            // 
            this.bookName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookName.Location = new System.Drawing.Point(6, 35);
            this.bookName.Name = "bookName";
            this.bookName.PlaceholderText = "نام کتاب";
            this.bookName.Size = new System.Drawing.Size(288, 32);
            this.bookName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(502, 566);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(502, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(92, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "جستجو";
            this.textBox1.Size = new System.Drawing.Size(312, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کتاب ها";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TextBox bookWriter;
        private TextBox bookName;
        private TextBox bookPrice;
        private ComboBox comboGroups;
        private TextBox bookPublisher;
        private TextBox bookTranslator;
        private Button btnAdd;
        private Button btnAddPicture;
        private PictureBox bookPicture;
        private TextBox bookSummary;
        private TextBox bookInventory;
        private Button btnDelete;
    }
}