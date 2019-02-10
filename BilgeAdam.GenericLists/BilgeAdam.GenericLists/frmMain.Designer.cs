namespace BilgeAdam.GenericLists
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lstCities = new System.Windows.Forms.ListBox();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnNumberList = new System.Windows.Forms.Button();
            this.btnAddUnique = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.erpValidate = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpValidate)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCities
            // 
            this.lstCities.FormattingEnabled = true;
            this.lstCities.Location = new System.Drawing.Point(12, 12);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(221, 420);
            this.lstCities.TabIndex = 0;
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(240, 13);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(101, 23);
            this.btnArray.TabIndex = 1;
            this.btnArray.Text = "Diziyle Doldur";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(240, 42);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(101, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listeyle Doldur";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnNumberList
            // 
            this.btnNumberList.Location = new System.Drawing.Point(240, 71);
            this.btnNumberList.Name = "btnNumberList";
            this.btnNumberList.Size = new System.Drawing.Size(101, 23);
            this.btnNumberList.TabIndex = 1;
            this.btnNumberList.Text = "Numaraları Doldur";
            this.btnNumberList.UseVisualStyleBackColor = true;
            this.btnNumberList.Click += new System.EventHandler(this.btnNumberList_Click);
            // 
            // btnAddUnique
            // 
            this.btnAddUnique.Location = new System.Drawing.Point(240, 100);
            this.btnAddUnique.Name = "btnAddUnique";
            this.btnAddUnique.Size = new System.Drawing.Size(101, 23);
            this.btnAddUnique.TabIndex = 1;
            this.btnAddUnique.Text = "Tekil Ekle";
            this.btnAddUnique.UseVisualStyleBackColor = true;
            this.btnAddUnique.Click += new System.EventHandler(this.btnAddUnique_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Can",
            "Deniz",
            "Gamze",
            "Mazlum",
            "Fatih",
            "Gülşah",
            "Ali",
            "İsmail",
            "Neslihan",
            "Nevzat"});
            this.comboBox1.Location = new System.Drawing.Point(240, 411);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(358, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tekil Ekleme Alanı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // erpValidate
            // 
            this.erpValidate.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAddUnique);
            this.Controls.Add(this.btnNumberList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.lstCities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic Lists";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpValidate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnNumberList;
        private System.Windows.Forms.Button btnAddUnique;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erpValidate;
    }
}