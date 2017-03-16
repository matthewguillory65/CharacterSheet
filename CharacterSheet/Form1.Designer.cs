namespace CharacterSheet
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
            this.PlayerSelection = new System.Windows.Forms.ComboBox();
            this.PlayerAttack = new System.Windows.Forms.TextBox();
            this.PlayerDefense = new System.Windows.Forms.TextBox();
            this.ItemSelection = new System.Windows.Forms.ComboBox();
            this.ItemCombo = new System.Windows.Forms.TextBox();
            this.SaveData = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            this.SaveLoad = new System.Windows.Forms.TextBox();
            this.ArmorSelection = new System.Windows.Forms.ComboBox();
            this.ArmorCombo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerSelection
            // 
            this.PlayerSelection.FormattingEnabled = true;
            this.PlayerSelection.Location = new System.Drawing.Point(12, 12);
            this.PlayerSelection.Name = "PlayerSelection";
            this.PlayerSelection.Size = new System.Drawing.Size(121, 21);
            this.PlayerSelection.TabIndex = 0;
            this.PlayerSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox);
            // 
            // PlayerAttack
            // 
            this.PlayerAttack.Location = new System.Drawing.Point(139, 13);
            this.PlayerAttack.Name = "PlayerAttack";
            this.PlayerAttack.ReadOnly = true;
            this.PlayerAttack.Size = new System.Drawing.Size(56, 20);
            this.PlayerAttack.TabIndex = 1;
            // 
            // PlayerDefense
            // 
            this.PlayerDefense.Location = new System.Drawing.Point(201, 13);
            this.PlayerDefense.Name = "PlayerDefense";
            this.PlayerDefense.ReadOnly = true;
            this.PlayerDefense.Size = new System.Drawing.Size(59, 20);
            this.PlayerDefense.TabIndex = 2;
            // 
            // ItemSelection
            // 
            this.ItemSelection.FormattingEnabled = true;
            this.ItemSelection.Location = new System.Drawing.Point(12, 109);
            this.ItemSelection.Name = "ItemSelection";
            this.ItemSelection.Size = new System.Drawing.Size(121, 21);
            this.ItemSelection.TabIndex = 3;
            this.ItemSelection.SelectedIndexChanged += new System.EventHandler(this.ItemSelections);
            // 
            // ItemCombo
            // 
            this.ItemCombo.Location = new System.Drawing.Point(139, 109);
            this.ItemCombo.Name = "ItemCombo";
            this.ItemCombo.ReadOnly = true;
            this.ItemCombo.Size = new System.Drawing.Size(56, 20);
            this.ItemCombo.TabIndex = 4;
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(12, 183);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(75, 23);
            this.SaveData.TabIndex = 5;
            this.SaveData.Text = "Save";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(120, 183);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(75, 23);
            this.LoadData.TabIndex = 6;
            this.LoadData.Text = "Load";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // SaveLoad
            // 
            this.SaveLoad.Location = new System.Drawing.Point(52, 157);
            this.SaveLoad.Name = "SaveLoad";
            this.SaveLoad.ReadOnly = true;
            this.SaveLoad.Size = new System.Drawing.Size(100, 20);
            this.SaveLoad.TabIndex = 7;
            this.SaveLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ArmorSelection
            // 
            this.ArmorSelection.FormattingEnabled = true;
            this.ArmorSelection.Location = new System.Drawing.Point(12, 60);
            this.ArmorSelection.Name = "ArmorSelection";
            this.ArmorSelection.Size = new System.Drawing.Size(121, 21);
            this.ArmorSelection.TabIndex = 8;
            this.ArmorSelection.SelectedIndexChanged += new System.EventHandler(this.ArmorSelection_SelectedIndexChanged);
            // 
            // ArmorCombo
            // 
            this.ArmorCombo.Location = new System.Drawing.Point(139, 60);
            this.ArmorCombo.Name = "ArmorCombo";
            this.ArmorCombo.ReadOnly = true;
            this.ArmorCombo.Size = new System.Drawing.Size(56, 20);
            this.ArmorCombo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Origional Attack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Origional Defense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Defense with Armor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Attack with Item";
            // 
            // UpdateD
            // 
            this.UpdateD.Location = new System.Drawing.Point(236, 183);
            this.UpdateD.Name = "UpdateD";
            this.UpdateD.Size = new System.Drawing.Size(75, 23);
            this.UpdateD.TabIndex = 14;
            this.UpdateD.Text = "Update";
            this.UpdateD.UseVisualStyleBackColor = true;
            this.UpdateD.Click += new System.EventHandler(this.UpdateD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "When Player is ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Click Me!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Changed, or when you";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "click Load,";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 229);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArmorCombo);
            this.Controls.Add(this.ArmorSelection);
            this.Controls.Add(this.SaveLoad);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.ItemCombo);
            this.Controls.Add(this.ItemSelection);
            this.Controls.Add(this.PlayerDefense);
            this.Controls.Add(this.PlayerAttack);
            this.Controls.Add(this.PlayerSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PlayerSelection;
        private System.Windows.Forms.TextBox PlayerAttack;
        private System.Windows.Forms.TextBox PlayerDefense;
        private System.Windows.Forms.ComboBox ItemSelection;
        private System.Windows.Forms.TextBox ItemCombo;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.TextBox SaveLoad;
        private System.Windows.Forms.ComboBox ArmorSelection;
        private System.Windows.Forms.TextBox ArmorCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

