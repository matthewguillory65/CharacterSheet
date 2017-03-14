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
            this.PlayerAttack.TextChanged += new System.EventHandler(this.currentPlayerAttack);
            // 
            // PlayerDefense
            // 
            this.PlayerDefense.Location = new System.Drawing.Point(201, 13);
            this.PlayerDefense.Name = "PlayerDefense";
            this.PlayerDefense.ReadOnly = true;
            this.PlayerDefense.Size = new System.Drawing.Size(59, 20);
            this.PlayerDefense.TabIndex = 2;
            this.PlayerDefense.TextChanged += new System.EventHandler(this.currentPlayerDefense);
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
            this.ItemCombo.TextChanged += new System.EventHandler(this.ItemCombo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 445);
            this.Controls.Add(this.ItemCombo);
            this.Controls.Add(this.ItemSelection);
            this.Controls.Add(this.PlayerDefense);
            this.Controls.Add(this.PlayerAttack);
            this.Controls.Add(this.PlayerSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PlayerSelection;
        private System.Windows.Forms.TextBox PlayerAttack;
        private System.Windows.Forms.TextBox PlayerDefense;
        private System.Windows.Forms.ComboBox ItemSelection;
        private System.Windows.Forms.TextBox ItemCombo;
    }
}

