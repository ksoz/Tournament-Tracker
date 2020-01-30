namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.createLabel = new System.Windows.Forms.Label();
            this.createBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pointButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.personButton = new System.Windows.Forms.Button();
            this.prizeButton = new System.Windows.Forms.Button();
            this.initTournament = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contestantList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(317, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createLabel.Location = new System.Drawing.Point(16, 76);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(236, 37);
            this.createLabel.TabIndex = 2;
            this.createLabel.Text = "Tournament Name";
            // 
            // createBox
            // 
            this.createBox.Location = new System.Drawing.Point(258, 80);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(236, 33);
            this.createBox.TabIndex = 3;
            this.createBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(16, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Victory Conditions";
            // 
            // pointButton
            // 
            this.pointButton.AutoSize = true;
            this.pointButton.Location = new System.Drawing.Point(258, 190);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(81, 29);
            this.pointButton.TabIndex = 5;
            this.pointButton.TabStop = true;
            this.pointButton.Text = "Points";
            this.pointButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.Location = new System.Drawing.Point(258, 155);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(126, 29);
            this.submitButton.TabIndex = 6;
            this.submitButton.TabStop = true;
            this.submitButton.Text = "Submission";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(258, 225);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 29);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Advantage";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // personButton
            // 
            this.personButton.Location = new System.Drawing.Point(23, 307);
            this.personButton.Name = "personButton";
            this.personButton.Size = new System.Drawing.Size(229, 44);
            this.personButton.TabIndex = 8;
            this.personButton.Text = "Add Contestant";
            this.personButton.UseVisualStyleBackColor = true;
            // 
            // prizeButton
            // 
            this.prizeButton.Location = new System.Drawing.Point(23, 359);
            this.prizeButton.Name = "prizeButton";
            this.prizeButton.Size = new System.Drawing.Size(229, 44);
            this.prizeButton.TabIndex = 9;
            this.prizeButton.Text = "Add Prize";
            this.prizeButton.UseVisualStyleBackColor = true;
            // 
            // initTournament
            // 
            this.initTournament.Location = new System.Drawing.Point(23, 454);
            this.initTournament.Name = "initTournament";
            this.initTournament.Size = new System.Drawing.Size(229, 57);
            this.initTournament.TabIndex = 10;
            this.initTournament.Text = "Create";
            this.initTournament.UseVisualStyleBackColor = true;
            this.initTournament.Click += new System.EventHandler(this.initTournament_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(288, 307);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 204);
            this.listBox1.TabIndex = 11;
            // 
            // contestantList
            // 
            this.contestantList.AutoSize = true;
            this.contestantList.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestantList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.contestantList.Location = new System.Drawing.Point(281, 264);
            this.contestantList.Name = "contestantList";
            this.contestantList.Size = new System.Drawing.Size(193, 37);
            this.contestantList.TabIndex = 12;
            this.contestantList.Text = "Contestant List";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 531);
            this.Controls.Add(this.contestantList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.initTournament);
            this.Controls.Add(this.prizeButton);
            this.Controls.Add(this.personButton);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createBox);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.TextBox createBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton pointButton;
        private System.Windows.Forms.RadioButton submitButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button personButton;
        private System.Windows.Forms.Button prizeButton;
        private System.Windows.Forms.Button initTournament;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label contestantList;
    }
}