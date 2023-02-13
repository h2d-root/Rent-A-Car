namespace Rent_A_Car
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.markaLBL = new System.Windows.Forms.Label();
            this.yilLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.renkLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ucretLBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(495, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(513, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araç Markası";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // markaLBL
            // 
            this.markaLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.markaLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.markaLBL.Location = new System.Drawing.Point(513, 146);
            this.markaLBL.Name = "markaLBL";
            this.markaLBL.Size = new System.Drawing.Size(275, 28);
            this.markaLBL.TabIndex = 2;
            this.markaLBL.Text = "-";
            this.markaLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yilLBL
            // 
            this.yilLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yilLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yilLBL.Location = new System.Drawing.Point(513, 222);
            this.yilLBL.Name = "yilLBL";
            this.yilLBL.Size = new System.Drawing.Size(275, 28);
            this.yilLBL.TabIndex = 4;
            this.yilLBL.Text = "-";
            this.yilLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(513, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Araç Üretim Yılı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // renkLBL
            // 
            this.renkLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.renkLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.renkLBL.Location = new System.Drawing.Point(513, 312);
            this.renkLBL.Name = "renkLBL";
            this.renkLBL.Size = new System.Drawing.Size(275, 28);
            this.renkLBL.TabIndex = 6;
            this.renkLBL.Text = "-";
            this.renkLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(513, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "Araç Rengi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucretLBL
            // 
            this.ucretLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucretLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucretLBL.Location = new System.Drawing.Point(513, 386);
            this.ucretLBL.Name = "ucretLBL";
            this.ucretLBL.Size = new System.Drawing.Size(275, 28);
            this.ucretLBL.TabIndex = 8;
            this.ucretLBL.Text = "-";
            this.ucretLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(513, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 40);
            this.label6.TabIndex = 7;
            this.label6.Text = "Günlük Araç Ücreti";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(513, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "h2d Rent A Car";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(744, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(682, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "ADMİN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(620, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 25);
            this.button3.TabIndex = 12;
            this.button3.Text = "YENİLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucretLBL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.renkLBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yilLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.markaLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent A Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label markaLBL;
        private Label yilLBL;
        private Label label3;
        private Label renkLBL;
        private Label label4;
        private Label ucretLBL;
        private Label label6;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}