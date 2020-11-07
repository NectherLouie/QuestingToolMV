namespace QuestingTool
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuestName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxObjectives = new System.Windows.Forms.TextBox();
            this.textBoxResolutions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGetPath = new System.Windows.Forms.Label();
            this.buttonGetPath = new System.Windows.Forms.Button();
            this.buttonAddQuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quest Name";
            // 
            // textBoxQuestName
            // 
            this.textBoxQuestName.Location = new System.Drawing.Point(115, 97);
            this.textBoxQuestName.Name = "textBoxQuestName";
            this.textBoxQuestName.Size = new System.Drawing.Size(245, 22);
            this.textBoxQuestName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Difficulty";
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBoxDifficulty.Location = new System.Drawing.Point(115, 137);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(245, 24);
            this.comboBoxDifficulty.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBoxCategory.Location = new System.Drawing.Point(115, 177);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(245, 24);
            this.comboBoxCategory.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Objectives";
            // 
            // textBoxObjectives
            // 
            this.textBoxObjectives.Location = new System.Drawing.Point(115, 217);
            this.textBoxObjectives.Multiline = true;
            this.textBoxObjectives.Name = "textBoxObjectives";
            this.textBoxObjectives.Size = new System.Drawing.Size(245, 106);
            this.textBoxObjectives.TabIndex = 9;
            // 
            // textBoxResolutions
            // 
            this.textBoxResolutions.Location = new System.Drawing.Point(504, 97);
            this.textBoxResolutions.Multiline = true;
            this.textBoxResolutions.Name = "textBoxResolutions";
            this.textBoxResolutions.Size = new System.Drawing.Size(245, 106);
            this.textBoxResolutions.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resolutions";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(504, 217);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(245, 106);
            this.textBoxDescription.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Description";
            // 
            // labelGetPath
            // 
            this.labelGetPath.AutoSize = true;
            this.labelGetPath.Location = new System.Drawing.Point(140, 18);
            this.labelGetPath.Name = "labelGetPath";
            this.labelGetPath.Size = new System.Drawing.Size(52, 17);
            this.labelGetPath.TabIndex = 14;
            this.labelGetPath.Text = "<path>";
            // 
            // buttonGetPath
            // 
            this.buttonGetPath.Location = new System.Drawing.Point(25, 15);
            this.buttonGetPath.Name = "buttonGetPath";
            this.buttonGetPath.Size = new System.Drawing.Size(109, 23);
            this.buttonGetPath.TabIndex = 15;
            this.buttonGetPath.Text = "Get Path";
            this.buttonGetPath.UseVisualStyleBackColor = true;
            this.buttonGetPath.Click += new System.EventHandler(this.buttonGetPath_Click);
            // 
            // buttonAddQuest
            // 
            this.buttonAddQuest.Location = new System.Drawing.Point(25, 55);
            this.buttonAddQuest.Name = "buttonAddQuest";
            this.buttonAddQuest.Size = new System.Drawing.Size(109, 23);
            this.buttonAddQuest.TabIndex = 16;
            this.buttonAddQuest.Text = "Add Quest";
            this.buttonAddQuest.UseVisualStyleBackColor = true;
            this.buttonAddQuest.Click += new System.EventHandler(this.buttonAddQuest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(778, 337);
            this.Controls.Add(this.buttonAddQuest);
            this.Controls.Add(this.buttonGetPath);
            this.Controls.Add(this.labelGetPath);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxResolutions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxObjectives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDifficulty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuestName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxObjectives;
        private System.Windows.Forms.TextBox textBoxResolutions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGetPath;
        private System.Windows.Forms.Button buttonGetPath;
        private System.Windows.Forms.Button buttonAddQuest;
    }
}

