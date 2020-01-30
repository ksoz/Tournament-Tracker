namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.victoryLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.PersonOne = new System.Windows.Forms.CheckBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.PersonTwo = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.beltLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.schoolLabel = new System.Windows.Forms.Label();
            this.beltLabelTwo = new System.Windows.Forms.Label();
            this.weightLabelTwo = new System.Windows.Forms.Label();
            this.schoolLabelTwo = new System.Windows.Forms.Label();
            this.matchUpList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(214, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentName.Location = new System.Drawing.Point(232, 9);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(150, 50);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // victoryLabel
            // 
            this.victoryLabel.AutoSize = true;
            this.victoryLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.victoryLabel.Location = new System.Drawing.Point(16, 92);
            this.victoryLabel.Name = "victoryLabel";
            this.victoryLabel.Size = new System.Drawing.Size(121, 32);
            this.victoryLabel.TabIndex = 2;
            this.victoryLabel.Text = "Victory By:";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(143, 91);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(263, 38);
            this.roundDropDown.TabIndex = 3;
            // 
            // PersonOne
            // 
            this.PersonOne.AutoSize = true;
            this.PersonOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PersonOne.Location = new System.Drawing.Point(590, 162);
            this.PersonOne.Name = "PersonOne";
            this.PersonOne.Size = new System.Drawing.Size(184, 41);
            this.PersonOne.TabIndex = 4;
            this.PersonOne.Text = "<unnamed>";
            this.PersonOne.UseVisualStyleBackColor = true;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.winnerLabel.Location = new System.Drawing.Point(31, 160);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(106, 37);
            this.winnerLabel.TabIndex = 5;
            this.winnerLabel.Text = "Winner:";
            // 
            // PersonTwo
            // 
            this.PersonTwo.AutoSize = true;
            this.PersonTwo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PersonTwo.Location = new System.Drawing.Point(198, 159);
            this.PersonTwo.Name = "PersonTwo";
            this.PersonTwo.Size = new System.Drawing.Size(184, 41);
            this.PersonTwo.TabIndex = 6;
            this.PersonTwo.Text = "<unnamed>";
            this.PersonTwo.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(434, 164);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(810, 167);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown2.TabIndex = 8;
            // 
            // beltLabel
            // 
            this.beltLabel.AutoSize = true;
            this.beltLabel.Location = new System.Drawing.Point(265, 204);
            this.beltLabel.Name = "beltLabel";
            this.beltLabel.Size = new System.Drawing.Size(48, 30);
            this.beltLabel.TabIndex = 9;
            this.beltLabel.Text = "belt";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(265, 245);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(75, 30);
            this.weightLabel.TabIndex = 10;
            this.weightLabel.Text = "weight";
            // 
            // schoolLabel
            // 
            this.schoolLabel.AutoSize = true;
            this.schoolLabel.Location = new System.Drawing.Point(265, 284);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(73, 30);
            this.schoolLabel.TabIndex = 11;
            this.schoolLabel.Text = "school";
            // 
            // beltLabelTwo
            // 
            this.beltLabelTwo.AutoSize = true;
            this.beltLabelTwo.Location = new System.Drawing.Point(652, 204);
            this.beltLabelTwo.Name = "beltLabelTwo";
            this.beltLabelTwo.Size = new System.Drawing.Size(68, 30);
            this.beltLabelTwo.TabIndex = 12;
            this.beltLabelTwo.Text = "label4";
            this.beltLabelTwo.Click += new System.EventHandler(this.beltLabelTwo_Click);
            // 
            // weightLabelTwo
            // 
            this.weightLabelTwo.AutoSize = true;
            this.weightLabelTwo.Location = new System.Drawing.Point(652, 245);
            this.weightLabelTwo.Name = "weightLabelTwo";
            this.weightLabelTwo.Size = new System.Drawing.Size(68, 30);
            this.weightLabelTwo.TabIndex = 13;
            this.weightLabelTwo.Text = "label5";
            // 
            // schoolLabelTwo
            // 
            this.schoolLabelTwo.AutoSize = true;
            this.schoolLabelTwo.Location = new System.Drawing.Point(652, 284);
            this.schoolLabelTwo.Name = "schoolLabelTwo";
            this.schoolLabelTwo.Size = new System.Drawing.Size(68, 30);
            this.schoolLabelTwo.TabIndex = 14;
            this.schoolLabelTwo.Text = "label6";
            // 
            // matchUpList
            // 
            this.matchUpList.FormattingEnabled = true;
            this.matchUpList.ItemHeight = 30;
            this.matchUpList.Location = new System.Drawing.Point(207, 353);
            this.matchUpList.Name = "matchUpList";
            this.matchUpList.Size = new System.Drawing.Size(723, 214);
            this.matchUpList.TabIndex = 15;
            this.matchUpList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 579);
            this.Controls.Add(this.matchUpList);
            this.Controls.Add(this.schoolLabelTwo);
            this.Controls.Add(this.weightLabelTwo);
            this.Controls.Add(this.beltLabelTwo);
            this.Controls.Add(this.schoolLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.beltLabel);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.PersonTwo);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.PersonOne);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.victoryLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label victoryLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox PersonOne;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.CheckBox PersonTwo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label beltLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.Label beltLabelTwo;
        private System.Windows.Forms.Label weightLabelTwo;
        private System.Windows.Forms.Label schoolLabelTwo;
        private System.Windows.Forms.ListBox matchUpList;
    }
}

