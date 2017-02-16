namespace FlatUI
{
    partial class ucDash
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmp = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Barcode = new System.Windows.Forms.TextBox();
            this.DB_con = new System.Windows.Forms.Label();
            this.Result_label = new System.Windows.Forms.Label();
            this.Reset_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.tabTenP = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabTenP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 705);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmp);
            this.tabControl1.Controls.Add(this.tabTenP);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 35);
            this.tabControl1.Location = new System.Drawing.Point(15, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 625);
            this.tabControl1.TabIndex = 1;
            // 
            // tabEmp
            // 
            this.tabEmp.Controls.Add(this.label3);
            this.tabEmp.Controls.Add(this.dataGridView1);
            this.tabEmp.Controls.Add(this.label2);
            this.tabEmp.Controls.Add(this.Barcode);
            this.tabEmp.Controls.Add(this.DB_con);
            this.tabEmp.Controls.Add(this.Result_label);
            this.tabEmp.Controls.Add(this.Reset_button);
            this.tabEmp.Controls.Add(this.OK_button);
            this.tabEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabEmp.Location = new System.Drawing.Point(4, 39);
            this.tabEmp.Name = "tabEmp";
            this.tabEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmp.Size = new System.Drawing.Size(1018, 582);
            this.tabEmp.TabIndex = 0;
            this.tabEmp.Text = "Sugar Daddy";
            this.tabEmp.UseVisualStyleBackColor = true;
            this.tabEmp.Click += new System.EventHandler(this.tabEmp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Well call";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(469, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 496);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Give or not?";
            // 
            // Barcode
            // 
            this.Barcode.Location = new System.Drawing.Point(34, 29);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(191, 26);
            this.Barcode.TabIndex = 1;
            this.Barcode.TextChanged += new System.EventHandler(this.Barcode_TextChanged);
            this.Barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Barcode_keydown);
            // 
            // DB_con
            // 
            this.DB_con.AutoSize = true;
            this.DB_con.Location = new System.Drawing.Point(49, 532);
            this.DB_con.Name = "DB_con";
            this.DB_con.Size = new System.Drawing.Size(80, 20);
            this.DB_con.TabIndex = 3;
            this.DB_con.Text = "DB status";
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_label.Location = new System.Drawing.Point(21, 97);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(204, 37);
            this.Result_label.TabIndex = 2;
            this.Result_label.Text = "Sugar Daddy";
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(54, 482);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(75, 32);
            this.Reset_button.TabIndex = 0;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(244, 26);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(76, 32);
            this.OK_button.TabIndex = 0;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.button1_Click);
            this.OK_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usDash);
            // 
            // tabTenP
            // 
            this.tabTenP.Controls.Add(this.dataGridView2);
            this.tabTenP.Location = new System.Drawing.Point(4, 39);
            this.tabTenP.Name = "tabTenP";
            this.tabTenP.Padding = new System.Windows.Forms.Padding(3);
            this.tabTenP.Size = new System.Drawing.Size(1018, 582);
            this.tabTenP.TabIndex = 1;
            this.tabTenP.Text = "10 Point";
            this.tabTenP.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(411, 120);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(576, 425);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = ">  Human Resource";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ucDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel1);
            this.Name = "ucDash";
            this.Size = new System.Drawing.Size(1059, 705);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabEmp.ResumeLayout(false);
            this.tabEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabTenP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmp;
        private System.Windows.Forms.TabPage tabTenP;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label DB_con;
        private System.Windows.Forms.TextBox Barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}
