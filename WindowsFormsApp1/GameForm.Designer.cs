namespace WindowsFormsApp1
{
    partial class GameForm
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
            this.labelRound = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.defaultAttackButtonPlayer1 = new System.Windows.Forms.Button();
            this.aimAttackButtonPlayer1 = new System.Windows.Forms.Button();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.HPBar1 = new System.Windows.Forms.ProgressBar();
            this.HPBar2 = new System.Windows.Forms.ProgressBar();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.BackColor = System.Drawing.Color.Transparent;
            this.labelRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRound.Location = new System.Drawing.Point(872, 55);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(282, 73);
            this.labelRound.TabIndex = 0;
            this.labelRound.Text = "Round 1";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPlayer.Location = new System.Drawing.Point(777, 149);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(456, 73);
            this.labelPlayer.TabIndex = 3;
            this.labelPlayer.Text = "Player 1 shoot";
            // 
            // defaultAttackButtonPlayer1
            // 
            this.defaultAttackButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.defaultAttackButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultAttackButtonPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defaultAttackButtonPlayer1.Location = new System.Drawing.Point(460, 297);
            this.defaultAttackButtonPlayer1.Name = "defaultAttackButtonPlayer1";
            this.defaultAttackButtonPlayer1.Size = new System.Drawing.Size(235, 152);
            this.defaultAttackButtonPlayer1.TabIndex = 4;
            this.defaultAttackButtonPlayer1.Text = "Default attack";
            this.defaultAttackButtonPlayer1.UseVisualStyleBackColor = false;
            this.defaultAttackButtonPlayer1.Click += new System.EventHandler(this.defaultAttackButtonPlayer1_Click);
            // 
            // aimAttackButtonPlayer1
            // 
            this.aimAttackButtonPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.aimAttackButtonPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aimAttackButtonPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aimAttackButtonPlayer1.Location = new System.Drawing.Point(460, 446);
            this.aimAttackButtonPlayer1.Name = "aimAttackButtonPlayer1";
            this.aimAttackButtonPlayer1.Size = new System.Drawing.Size(235, 152);
            this.aimAttackButtonPlayer1.TabIndex = 5;
            this.aimAttackButtonPlayer1.Text = "Aim attack";
            this.aimAttackButtonPlayer1.UseVisualStyleBackColor = false;
            this.aimAttackButtonPlayer1.Click += new System.EventHandler(this.aimAttackButtonPlayer1_Click);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPlayer1.Location = new System.Drawing.Point(24, 484);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(124, 42);
            this.labelPlayer1.TabIndex = 8;
            this.labelPlayer1.Text = "label2";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPlayer2.Location = new System.Drawing.Point(1637, 484);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(124, 42);
            this.labelPlayer2.TabIndex = 9;
            this.labelPlayer2.Text = "label3";
            // 
            // HPBar1
            // 
            this.HPBar1.Location = new System.Drawing.Point(31, 551);
            this.HPBar1.Name = "HPBar1";
            this.HPBar1.Size = new System.Drawing.Size(275, 47);
            this.HPBar1.TabIndex = 10;
            // 
            // HPBar2
            // 
            this.HPBar2.Location = new System.Drawing.Point(1644, 551);
            this.HPBar2.Name = "HPBar2";
            this.HPBar2.Size = new System.Drawing.Size(275, 47);
            this.HPBar2.TabIndex = 11;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(OverwatchLibrary.Unit);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Versus1;
            this.pictureBox1.Location = new System.Drawing.Point(745, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 539);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(460, 597);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(235, 152);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(745, 794);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(673, 121);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Diesel_untitled_page_EGS_PLAYDEAD_LIMBO_GALLERY_7_1920x1080_e62836a599b2716d8c40afed1c048bf15a79829a;
            this.ClientSize = new System.Drawing.Size(2326, 1311);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HPBar2);
            this.Controls.Add(this.HPBar1);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.aimAttackButtonPlayer1);
            this.Controls.Add(this.defaultAttackButtonPlayer1);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelRound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Button defaultAttackButtonPlayer1;
        private System.Windows.Forms.Button aimAttackButtonPlayer1;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.ProgressBar HPBar1;
        private System.Windows.Forms.ProgressBar HPBar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
    }
}