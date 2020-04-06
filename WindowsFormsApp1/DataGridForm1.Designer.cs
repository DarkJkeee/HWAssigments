namespace WindowsFormsApp1
{
    partial class DataGridForm1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChoiceColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.heroesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagePSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headDPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleShotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChoiceColumn,
            this.heroesDataGridViewTextBoxColumn,
            this.damagePSDataGridViewTextBoxColumn,
            this.headDPSDataGridViewTextBoxColumn,
            this.singleShotDataGridViewTextBoxColumn,
            this.healthDataGridViewTextBoxColumn,
            this.reloadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.unitBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1841, 1356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(OverwatchLibrary.Unit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2149, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Damage per second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2245, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Life";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2192, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Headshot DPS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2155, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.Filter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2155, 358);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 31);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.Filter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(2155, 452);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(268, 31);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.Filter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2201, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 77);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2145, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 77);
            this.label5.TabIndex = 10;
            this.label5.Text = "Your choice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2189, 678);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 51);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(2189, 905);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 55);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MV Boli", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2057, 786);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(646, 77);
            this.label8.TabIndex = 14;
            this.label8.Text = "Your opponent choice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.skull;
            this.pictureBox1.Location = new System.Drawing.Point(2155, 1032);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 250);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ChoiceColumn
            // 
            this.ChoiceColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChoiceColumn.HeaderText = "Your choice";
            this.ChoiceColumn.MinimumWidth = 10;
            this.ChoiceColumn.Name = "ChoiceColumn";
            this.ChoiceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChoiceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChoiceColumn.Text = "Take hero";
            this.ChoiceColumn.UseColumnTextForButtonValue = true;
            this.ChoiceColumn.Width = 120;
            // 
            // heroesDataGridViewTextBoxColumn
            // 
            this.heroesDataGridViewTextBoxColumn.DataPropertyName = "Heroes";
            this.heroesDataGridViewTextBoxColumn.HeaderText = "Heroes";
            this.heroesDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.heroesDataGridViewTextBoxColumn.Name = "heroesDataGridViewTextBoxColumn";
            this.heroesDataGridViewTextBoxColumn.Width = 200;
            // 
            // damagePSDataGridViewTextBoxColumn
            // 
            this.damagePSDataGridViewTextBoxColumn.DataPropertyName = "DamagePS";
            this.damagePSDataGridViewTextBoxColumn.HeaderText = "Damage per second";
            this.damagePSDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.damagePSDataGridViewTextBoxColumn.Name = "damagePSDataGridViewTextBoxColumn";
            // 
            // headDPSDataGridViewTextBoxColumn
            // 
            this.headDPSDataGridViewTextBoxColumn.DataPropertyName = "HeadDPS";
            this.headDPSDataGridViewTextBoxColumn.HeaderText = "Headshot DPS";
            this.headDPSDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.headDPSDataGridViewTextBoxColumn.Name = "headDPSDataGridViewTextBoxColumn";
            // 
            // singleShotDataGridViewTextBoxColumn
            // 
            this.singleShotDataGridViewTextBoxColumn.DataPropertyName = "SingleShot";
            this.singleShotDataGridViewTextBoxColumn.HeaderText = "Single shot";
            this.singleShotDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.singleShotDataGridViewTextBoxColumn.Name = "singleShotDataGridViewTextBoxColumn";
            // 
            // healthDataGridViewTextBoxColumn
            // 
            this.healthDataGridViewTextBoxColumn.DataPropertyName = "Health";
            this.healthDataGridViewTextBoxColumn.HeaderText = "Life";
            this.healthDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.healthDataGridViewTextBoxColumn.Name = "healthDataGridViewTextBoxColumn";
            // 
            // reloadDataGridViewTextBoxColumn
            // 
            this.reloadDataGridViewTextBoxColumn.DataPropertyName = "Reload";
            this.reloadDataGridViewTextBoxColumn.HeaderText = "Reload";
            this.reloadDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.reloadDataGridViewTextBoxColumn.Name = "reloadDataGridViewTextBoxColumn";
            // 
            // DataGridForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2778, 1351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DataGridForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewButtonColumn ChoiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heroesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagePSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headDPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singleShotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloadDataGridViewTextBoxColumn;
    }
}