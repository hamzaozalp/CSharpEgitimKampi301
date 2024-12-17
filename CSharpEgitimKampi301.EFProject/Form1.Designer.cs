namespace CSharpEgitimKampi301.EFProject
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnList1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.btnGetById1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rehber Id:";
            // 
            // btnList1
            // 
            this.btnList1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnList1.Location = new System.Drawing.Point(120, 137);
            this.btnList1.Name = "btnList1";
            this.btnList1.Size = new System.Drawing.Size(176, 43);
            this.btnList1.TabIndex = 1;
            this.btnList1.Text = "Listele";
            this.btnList1.UseVisualStyleBackColor = false;
            this.btnList1.Click += new System.EventHandler(this.btnList1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 22);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 22);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rehber Adı:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(120, 92);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(176, 22);
            this.txtSurname.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rehber Soyadı:";
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAdd1.Location = new System.Drawing.Point(120, 186);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(176, 43);
            this.btnAdd1.TabIndex = 8;
            this.btnAdd1.Text = "Ekle";
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelete1.Location = new System.Drawing.Point(120, 235);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(176, 43);
            this.btnDelete1.TabIndex = 9;
            this.btnDelete1.Text = "Sil";
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnUpdate1.Location = new System.Drawing.Point(120, 284);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(176, 43);
            this.btnUpdate1.TabIndex = 10;
            this.btnUpdate1.Text = "Güncelle";
            this.btnUpdate1.UseVisualStyleBackColor = false;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // btnGetById1
            // 
            this.btnGetById1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGetById1.Location = new System.Drawing.Point(120, 333);
            this.btnGetById1.Name = "btnGetById1";
            this.btnGetById1.Size = new System.Drawing.Size(176, 43);
            this.btnGetById1.TabIndex = 11;
            this.btnGetById1.Text = "Id\'ye Göre Getir";
            this.btnGetById1.UseVisualStyleBackColor = false;
            this.btnGetById1.Click += new System.EventHandler(this.btnGetById1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(363, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(601, 364);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1058, 461);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGetById1);
            this.Controls.Add(this.btnUpdate1);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnList1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnList1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btnGetById1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

