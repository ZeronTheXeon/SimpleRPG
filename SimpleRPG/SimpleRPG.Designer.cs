namespace SimpleRPG
{
    partial class SimpleRPG
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
            this.Health = new System.Windows.Forms.Label();
            this.HealthValue = new System.Windows.Forms.Label();
            this.Mana = new System.Windows.Forms.Label();
            this.ManaValue = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.CharLevel = new System.Windows.Forms.Label();
            this.CharLevelValue = new System.Windows.Forms.Label();
            this.MoneyValue = new System.Windows.Forms.Label();
            this.CharStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Location = new System.Drawing.Point(35, 470);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(27, 17);
            this.Health.TabIndex = 0;
            this.Health.Text = "HP";
            this.Health.Click += new System.EventHandler(this.label1_Click);
            // 
            // HealthValue
            // 
            this.HealthValue.AutoSize = true;
            this.HealthValue.Location = new System.Drawing.Point(102, 470);
            this.HealthValue.Name = "HealthValue";
            this.HealthValue.Size = new System.Drawing.Size(59, 17);
            this.HealthValue.TabIndex = 1;
            this.HealthValue.Text = "|||||||||||||||||";
            // 
            // Mana
            // 
            this.Mana.AutoSize = true;
            this.Mana.Location = new System.Drawing.Point(35, 500);
            this.Mana.Name = "Mana";
            this.Mana.Size = new System.Drawing.Size(43, 17);
            this.Mana.TabIndex = 2;
            this.Mana.Text = "Mana";
            // 
            // ManaValue
            // 
            this.ManaValue.AutoSize = true;
            this.ManaValue.Location = new System.Drawing.Point(102, 500);
            this.ManaValue.Name = "ManaValue";
            this.ManaValue.Size = new System.Drawing.Size(59, 17);
            this.ManaValue.TabIndex = 3;
            this.ManaValue.Text = "|||||||||||||||||";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(35, 530);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(50, 17);
            this.Money.TabIndex = 4;
            this.Money.Text = "Money";
            // 
            // CharLevel
            // 
            this.CharLevel.AutoSize = true;
            this.CharLevel.Location = new System.Drawing.Point(35, 440);
            this.CharLevel.Name = "CharLevel";
            this.CharLevel.Size = new System.Drawing.Size(33, 17);
            this.CharLevel.TabIndex = 5;
            this.CharLevel.Text = "LVL";
            // 
            // CharLevelValue
            // 
            this.CharLevelValue.AutoSize = true;
            this.CharLevelValue.Location = new System.Drawing.Point(102, 440);
            this.CharLevelValue.Name = "CharLevelValue";
            this.CharLevelValue.Size = new System.Drawing.Size(32, 17);
            this.CharLevelValue.TabIndex = 6;
            this.CharLevelValue.Text = "Yes";
            // 
            // MoneyValue
            // 
            this.MoneyValue.AutoSize = true;
            this.MoneyValue.Location = new System.Drawing.Point(102, 529);
            this.MoneyValue.Name = "MoneyValue";
            this.MoneyValue.Size = new System.Drawing.Size(16, 17);
            this.MoneyValue.TabIndex = 7;
            this.MoneyValue.Text = "0";
            // 
            // CharStats
            // 
            this.CharStats.Location = new System.Drawing.Point(447, 523);
            this.CharStats.Name = "CharStats";
            this.CharStats.Size = new System.Drawing.Size(75, 23);
            this.CharStats.TabIndex = 8;
            this.CharStats.Text = "Stats";
            this.CharStats.UseVisualStyleBackColor = true;
            this.CharStats.Click += new System.EventHandler(this.CharStats_Click);
            // 
            // SimpleRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.CharStats);
            this.Controls.Add(this.MoneyValue);
            this.Controls.Add(this.CharLevelValue);
            this.Controls.Add(this.CharLevel);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.ManaValue);
            this.Controls.Add(this.Mana);
            this.Controls.Add(this.HealthValue);
            this.Controls.Add(this.Health);
            this.Name = "SimpleRPG";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label HealthValue;
        private System.Windows.Forms.Label Mana;
        private System.Windows.Forms.Label ManaValue;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label CharLevel;
        private System.Windows.Forms.Label CharLevelValue;
        private System.Windows.Forms.Label MoneyValue;
        private System.Windows.Forms.Button CharStats;
    }
}

