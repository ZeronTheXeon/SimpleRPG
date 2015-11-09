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
            this.GoldValue = new System.Windows.Forms.Label();
            this.CharStats = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.Label();
            this.LocationValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Location = new System.Drawing.Point(26, 382);
            this.Health.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(22, 13);
            this.Health.TabIndex = 0;
            this.Health.Text = "HP";
            this.Health.Click += new System.EventHandler(this.label1_Click);
            // 
            // HealthValue
            // 
            this.HealthValue.AutoSize = true;
            this.HealthValue.Location = new System.Drawing.Point(80, 382);
            this.HealthValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HealthValue.Name = "HealthValue";
            this.HealthValue.Size = new System.Drawing.Size(13, 13);
            this.HealthValue.TabIndex = 1;
            this.HealthValue.Text = "0";
            // 
            // Mana
            // 
            this.Mana.AutoSize = true;
            this.Mana.Location = new System.Drawing.Point(26, 406);
            this.Mana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mana.Name = "Mana";
            this.Mana.Size = new System.Drawing.Size(34, 13);
            this.Mana.TabIndex = 2;
            this.Mana.Text = "Mana";
            // 
            // ManaValue
            // 
            this.ManaValue.AutoSize = true;
            this.ManaValue.Location = new System.Drawing.Point(80, 406);
            this.ManaValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManaValue.Name = "ManaValue";
            this.ManaValue.Size = new System.Drawing.Size(13, 13);
            this.ManaValue.TabIndex = 3;
            this.ManaValue.Text = "0";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(26, 430);
            this.Money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(29, 13);
            this.Money.TabIndex = 4;
            this.Money.Text = "Gold";
            this.Money.Click += new System.EventHandler(this.Money_Click);
            // 
            // CharLevel
            // 
            this.CharLevel.AutoSize = true;
            this.CharLevel.Location = new System.Drawing.Point(26, 358);
            this.CharLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CharLevel.Name = "CharLevel";
            this.CharLevel.Size = new System.Drawing.Size(26, 13);
            this.CharLevel.TabIndex = 5;
            this.CharLevel.Text = "LVL";
            // 
            // CharLevelValue
            // 
            this.CharLevelValue.AutoSize = true;
            this.CharLevelValue.Location = new System.Drawing.Point(80, 358);
            this.CharLevelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CharLevelValue.Name = "CharLevelValue";
            this.CharLevelValue.Size = new System.Drawing.Size(25, 13);
            this.CharLevelValue.TabIndex = 6;
            this.CharLevelValue.Text = "Yes";
            this.CharLevelValue.Click += new System.EventHandler(this.CharLevelValue_Click);
            // 
            // GoldValue
            // 
            this.GoldValue.AutoSize = true;
            this.GoldValue.Location = new System.Drawing.Point(80, 430);
            this.GoldValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoldValue.Name = "GoldValue";
            this.GoldValue.Size = new System.Drawing.Size(13, 13);
            this.GoldValue.TabIndex = 7;
            this.GoldValue.Text = "0";
            this.GoldValue.Click += new System.EventHandler(this.MoneyValue_Click);
            // 
            // CharStats
            // 
            this.CharStats.Location = new System.Drawing.Point(335, 425);
            this.CharStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CharStats.Name = "CharStats";
            this.CharStats.Size = new System.Drawing.Size(56, 19);
            this.CharStats.TabIndex = 8;
            this.CharStats.Text = "Stats";
            this.CharStats.UseVisualStyleBackColor = true;
            this.CharStats.Click += new System.EventHandler(this.CharStats_Click);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(428, 9);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(48, 13);
            this.Location.TabIndex = 9;
            this.Location.Text = "Location";
            // 
            // LocationValue
            // 
            this.LocationValue.AutoSize = true;
            this.LocationValue.Location = new System.Drawing.Point(528, 9);
            this.LocationValue.Name = "LocationValue";
            this.LocationValue.Size = new System.Drawing.Size(35, 13);
            this.LocationValue.TabIndex = 10;
            this.LocationValue.Text = "Home";
            // 
            // SimpleRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 451);
            this.Controls.Add(this.LocationValue);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.CharStats);
            this.Controls.Add(this.GoldValue);
            this.Controls.Add(this.CharLevelValue);
            this.Controls.Add(this.CharLevel);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.ManaValue);
            this.Controls.Add(this.Mana);
            this.Controls.Add(this.HealthValue);
            this.Controls.Add(this.Health);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SimpleRPG";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.SimpleRPG_Load);
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
        private System.Windows.Forms.Label GoldValue;
        private System.Windows.Forms.Button CharStats;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label LocationValue;
    }
}

