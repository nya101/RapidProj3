namespace TradingCardApp
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
            labelName = new Label();
            labelTeam = new Label();
            labelGoals = new Label();
            labelAssists = new Label();
            labelAppearances = new Label();
            labelAge = new Label();
            listBoxPlayers = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = SystemColors.ControlLightLight;
            labelName.BorderStyle = BorderStyle.Fixed3D;
            labelName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(265, 61);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 17);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            labelName.Click += labelName_Click;
            // 
            // labelTeam
            // 
            labelTeam.AutoSize = true;
            labelTeam.BackColor = SystemColors.ControlLightLight;
            labelTeam.BorderStyle = BorderStyle.Fixed3D;
            labelTeam.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTeam.Location = new Point(265, 87);
            labelTeam.Name = "labelTeam";
            labelTeam.Size = new Size(49, 17);
            labelTeam.TabIndex = 1;
            labelTeam.Text = "label2";
            // 
            // labelGoals
            // 
            labelGoals.AutoSize = true;
            labelGoals.BackColor = SystemColors.ButtonFace;
            labelGoals.BorderStyle = BorderStyle.Fixed3D;
            labelGoals.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGoals.ForeColor = Color.Green;
            labelGoals.Location = new Point(397, 61);
            labelGoals.Name = "labelGoals";
            labelGoals.Size = new Size(43, 17);
            labelGoals.TabIndex = 2;
            labelGoals.Text = "label3";
            // 
            // labelAssists
            // 
            labelAssists.AutoSize = true;
            labelAssists.BackColor = SystemColors.ButtonFace;
            labelAssists.BorderStyle = BorderStyle.Fixed3D;
            labelAssists.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAssists.ForeColor = Color.Black;
            labelAssists.Location = new Point(397, 85);
            labelAssists.Name = "labelAssists";
            labelAssists.Size = new Size(43, 17);
            labelAssists.TabIndex = 3;
            labelAssists.Text = "label4";
            // 
            // labelAppearances
            // 
            labelAppearances.AutoSize = true;
            labelAppearances.BackColor = SystemColors.ButtonFace;
            labelAppearances.BorderStyle = BorderStyle.Fixed3D;
            labelAppearances.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAppearances.Location = new Point(265, 314);
            labelAppearances.Name = "labelAppearances";
            labelAppearances.Size = new Size(43, 17);
            labelAppearances.TabIndex = 4;
            labelAppearances.Text = "label5";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.BackColor = SystemColors.ButtonFace;
            labelAge.BorderStyle = BorderStyle.Fixed3D;
            labelAge.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAge.Location = new Point(397, 314);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(43, 17);
            labelAge.TabIndex = 5;
            labelAge.Text = "label6";
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.AccessibleRole = AccessibleRole.MenuBar;
            listBoxPlayers.AllowDrop = true;
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 15;
            listBoxPlayers.Location = new Point(25, 33);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(144, 124);
            listBoxPlayers.Sorted = true;
            listBoxPlayers.TabIndex = 6;
            listBoxPlayers.SelectedIndexChanged += listBoxPlayers_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(265, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Resize += pictureBox1_Resize;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxPlayers);
            Controls.Add(labelAge);
            Controls.Add(labelAppearances);
            Controls.Add(labelAssists);
            Controls.Add(labelGoals);
            Controls.Add(labelTeam);
            Controls.Add(labelName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelTeam;
        private Label labelGoals;
        private Label labelAssists;
        private Label labelAppearances;
        private Label labelAge;
        private ListBox listBoxPlayers;
        private PictureBox pictureBox1;
    }
}
