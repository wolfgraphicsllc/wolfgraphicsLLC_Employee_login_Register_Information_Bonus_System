namespace wolfgraphicsLLC_Employee_login_Register_Information_Bonus_System
{
    partial class BonusTabulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonusTabulator));
            this.EmployeeInfo_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YorBonus_label = new System.Windows.Forms.Label();
            this.BonusOutput_label = new System.Windows.Forms.Label();
            this.BonusSelection_comboBox = new System.Windows.Forms.ComboBox();
            this.Tabulate_button = new System.Windows.Forms.Button();
            this.Bonus_label2 = new System.Windows.Forms.Label();
            this.EmployeeOutput_label = new System.Windows.Forms.Label();
            this.EmployeeName_label = new System.Windows.Forms.Label();
            this.Save_button2 = new System.Windows.Forms.Button();
            this.EmpoyeeIDBonusOutput_label = new System.Windows.Forms.Label();
            this.EmployeeIDBonus_label = new System.Windows.Forms.Label();
            this.Exit_button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmployeeBonusBack_button = new System.Windows.Forms.Button();
            this.BonusHeaderText_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.EmployeeIDOutput_label = new System.Windows.Forms.Label();
            this.EmployeeIDNumber_label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Header_panel = new System.Windows.Forms.Panel();
            this.EmployeeBonus_label = new System.Windows.Forms.Label();
            this.EmployeeInfo_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeInfo_panel
            // 
            this.EmployeeInfo_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmployeeInfo_panel.BackgroundImage")));
            this.EmployeeInfo_panel.Controls.Add(this.panel1);
            this.EmployeeInfo_panel.Controls.Add(this.Save_button);
            this.EmployeeInfo_panel.Controls.Add(this.EmployeeIDOutput_label);
            this.EmployeeInfo_panel.Controls.Add(this.EmployeeIDNumber_label);
            this.EmployeeInfo_panel.Controls.Add(this.Exit_button);
            this.EmployeeInfo_panel.Controls.Add(this.Header_panel);
            this.EmployeeInfo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeInfo_panel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeInfo_panel.Name = "EmployeeInfo_panel";
            this.EmployeeInfo_panel.Size = new System.Drawing.Size(564, 782);
            this.EmployeeInfo_panel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.YorBonus_label);
            this.panel1.Controls.Add(this.BonusOutput_label);
            this.panel1.Controls.Add(this.BonusSelection_comboBox);
            this.panel1.Controls.Add(this.Tabulate_button);
            this.panel1.Controls.Add(this.Bonus_label2);
            this.panel1.Controls.Add(this.EmployeeOutput_label);
            this.panel1.Controls.Add(this.EmployeeName_label);
            this.panel1.Controls.Add(this.Save_button2);
            this.panel1.Controls.Add(this.EmpoyeeIDBonusOutput_label);
            this.panel1.Controls.Add(this.EmployeeIDBonus_label);
            this.panel1.Controls.Add(this.Exit_button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 782);
            this.panel1.TabIndex = 41;
            // 
            // YorBonus_label
            // 
            this.YorBonus_label.AutoSize = true;
            this.YorBonus_label.BackColor = System.Drawing.Color.Transparent;
            this.YorBonus_label.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YorBonus_label.ForeColor = System.Drawing.Color.White;
            this.YorBonus_label.Location = new System.Drawing.Point(12, 592);
            this.YorBonus_label.Name = "YorBonus_label";
            this.YorBonus_label.Size = new System.Drawing.Size(211, 39);
            this.YorBonus_label.TabIndex = 47;
            this.YorBonus_label.Text = "Your Bonus Is :";
            // 
            // BonusOutput_label
            // 
            this.BonusOutput_label.BackColor = System.Drawing.Color.DarkGray;
            this.BonusOutput_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BonusOutput_label.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusOutput_label.ForeColor = System.Drawing.Color.White;
            this.BonusOutput_label.Location = new System.Drawing.Point(225, 558);
            this.BonusOutput_label.Name = "BonusOutput_label";
            this.BonusOutput_label.Size = new System.Drawing.Size(318, 104);
            this.BonusOutput_label.TabIndex = 46;
            // 
            // BonusSelection_comboBox
            // 
            this.BonusSelection_comboBox.FormattingEnabled = true;
            this.BonusSelection_comboBox.Items.AddRange(new object[] {
            "Anual Bonus",
            "Simi Anual Bonus",
            "Quarterly Bonus",
            "Extra Vacation Days",
            "JackPot Bonus"});
            this.BonusSelection_comboBox.Location = new System.Drawing.Point(161, 372);
            this.BonusSelection_comboBox.Name = "BonusSelection_comboBox";
            this.BonusSelection_comboBox.Size = new System.Drawing.Size(229, 21);
            this.BonusSelection_comboBox.TabIndex = 45;
            // 
            // Tabulate_button
            // 
            this.Tabulate_button.BackColor = System.Drawing.Color.Transparent;
            this.Tabulate_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tabulate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tabulate_button.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabulate_button.ForeColor = System.Drawing.Color.White;
            this.Tabulate_button.Location = new System.Drawing.Point(200, 426);
            this.Tabulate_button.Name = "Tabulate_button";
            this.Tabulate_button.Size = new System.Drawing.Size(158, 89);
            this.Tabulate_button.TabIndex = 44;
            this.Tabulate_button.Text = "Tabulate";
            this.Tabulate_button.UseVisualStyleBackColor = false;
            this.Tabulate_button.Click += new System.EventHandler(this.Tabulate_button_Click);
            // 
            // Bonus_label2
            // 
            this.Bonus_label2.AutoSize = true;
            this.Bonus_label2.BackColor = System.Drawing.Color.Transparent;
            this.Bonus_label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus_label2.ForeColor = System.Drawing.Color.White;
            this.Bonus_label2.Location = new System.Drawing.Point(218, 330);
            this.Bonus_label2.Name = "Bonus_label2";
            this.Bonus_label2.Size = new System.Drawing.Size(129, 39);
            this.Bonus_label2.TabIndex = 43;
            this.Bonus_label2.Text = "BONUS ";
            // 
            // EmployeeOutput_label
            // 
            this.EmployeeOutput_label.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeOutput_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeeOutput_label.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeOutput_label.ForeColor = System.Drawing.Color.White;
            this.EmployeeOutput_label.Location = new System.Drawing.Point(290, 203);
            this.EmployeeOutput_label.Name = "EmployeeOutput_label";
            this.EmployeeOutput_label.Size = new System.Drawing.Size(218, 39);
            this.EmployeeOutput_label.TabIndex = 42;
            // 
            // EmployeeName_label
            // 
            this.EmployeeName_label.AutoSize = true;
            this.EmployeeName_label.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeName_label.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName_label.ForeColor = System.Drawing.Color.White;
            this.EmployeeName_label.Location = new System.Drawing.Point(44, 203);
            this.EmployeeName_label.Name = "EmployeeName_label";
            this.EmployeeName_label.Size = new System.Drawing.Size(221, 39);
            this.EmployeeName_label.TabIndex = 41;
            this.EmployeeName_label.Text = "Employee Name ";
            // 
            // Save_button2
            // 
            this.Save_button2.BackColor = System.Drawing.Color.Transparent;
            this.Save_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button2.ForeColor = System.Drawing.Color.White;
            this.Save_button2.Location = new System.Drawing.Point(225, 725);
            this.Save_button2.Name = "Save_button2";
            this.Save_button2.Size = new System.Drawing.Size(99, 53);
            this.Save_button2.TabIndex = 40;
            this.Save_button2.Text = "Save";
            this.Save_button2.UseVisualStyleBackColor = false;
            this.Save_button2.Click += new System.EventHandler(this.Save_button2_Click);
            // 
            // EmpoyeeIDBonusOutput_label
            // 
            this.EmpoyeeIDBonusOutput_label.BackColor = System.Drawing.Color.Transparent;
            this.EmpoyeeIDBonusOutput_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmpoyeeIDBonusOutput_label.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpoyeeIDBonusOutput_label.ForeColor = System.Drawing.Color.White;
            this.EmpoyeeIDBonusOutput_label.Location = new System.Drawing.Point(290, 149);
            this.EmpoyeeIDBonusOutput_label.Name = "EmpoyeeIDBonusOutput_label";
            this.EmpoyeeIDBonusOutput_label.Size = new System.Drawing.Size(218, 39);
            this.EmpoyeeIDBonusOutput_label.TabIndex = 39;
            this.EmpoyeeIDBonusOutput_label.Click += new System.EventHandler(this.EmpoyeeIDBonusOutput_label_Click);
            // 
            // EmployeeIDBonus_label
            // 
            this.EmployeeIDBonus_label.AutoSize = true;
            this.EmployeeIDBonus_label.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeIDBonus_label.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDBonus_label.ForeColor = System.Drawing.Color.White;
            this.EmployeeIDBonus_label.Location = new System.Drawing.Point(44, 149);
            this.EmployeeIDBonus_label.Name = "EmployeeIDBonus_label";
            this.EmployeeIDBonus_label.Size = new System.Drawing.Size(218, 39);
            this.EmployeeIDBonus_label.TabIndex = 8;
            this.EmployeeIDBonus_label.Text = "Employee ID # ";
            // 
            // Exit_button2
            // 
            this.Exit_button2.BackColor = System.Drawing.Color.Transparent;
            this.Exit_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button2.ForeColor = System.Drawing.Color.White;
            this.Exit_button2.Location = new System.Drawing.Point(468, 738);
            this.Exit_button2.Name = "Exit_button2";
            this.Exit_button2.Size = new System.Drawing.Size(75, 32);
            this.Exit_button2.TabIndex = 6;
            this.Exit_button2.Text = "Exit";
            this.Exit_button2.UseVisualStyleBackColor = false;
            this.Exit_button2.Click += new System.EventHandler(this.Exit_button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.EmployeeBonusBack_button);
            this.panel2.Controls.Add(this.BonusHeaderText_label);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 100);
            this.panel2.TabIndex = 0;
            // 
            // EmployeeBonusBack_button
            // 
            this.EmployeeBonusBack_button.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeBonusBack_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EmployeeBonusBack_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeBonusBack_button.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBonusBack_button.ForeColor = System.Drawing.Color.White;
            this.EmployeeBonusBack_button.Location = new System.Drawing.Point(19, 20);
            this.EmployeeBonusBack_button.Name = "EmployeeBonusBack_button";
            this.EmployeeBonusBack_button.Size = new System.Drawing.Size(40, 59);
            this.EmployeeBonusBack_button.TabIndex = 51;
            this.EmployeeBonusBack_button.Text = "<";
            this.EmployeeBonusBack_button.UseVisualStyleBackColor = false;
            this.EmployeeBonusBack_button.Click += new System.EventHandler(this.EmployeeBonusBack_Click);
            // 
            // BonusHeaderText_label
            // 
            this.BonusHeaderText_label.BackColor = System.Drawing.Color.Transparent;
            this.BonusHeaderText_label.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusHeaderText_label.ForeColor = System.Drawing.Color.DarkRed;
            this.BonusHeaderText_label.Location = new System.Drawing.Point(90, 20);
            this.BonusHeaderText_label.Name = "BonusHeaderText_label";
            this.BonusHeaderText_label.Size = new System.Drawing.Size(372, 59);
            this.BonusHeaderText_label.TabIndex = 0;
            this.BonusHeaderText_label.Text = "Employee Bonus";
            this.BonusHeaderText_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.Transparent;
            this.Save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.ForeColor = System.Drawing.Color.White;
            this.Save_button.Location = new System.Drawing.Point(225, 725);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(99, 53);
            this.Save_button.TabIndex = 40;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = false;
            // 
            // EmployeeIDOutput_label
            // 
            this.EmployeeIDOutput_label.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeIDOutput_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeeIDOutput_label.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDOutput_label.ForeColor = System.Drawing.Color.White;
            this.EmployeeIDOutput_label.Location = new System.Drawing.Point(290, 149);
            this.EmployeeIDOutput_label.Name = "EmployeeIDOutput_label";
            this.EmployeeIDOutput_label.Size = new System.Drawing.Size(218, 39);
            this.EmployeeIDOutput_label.TabIndex = 39;
            // 
            // EmployeeIDNumber_label
            // 
            this.EmployeeIDNumber_label.AutoSize = true;
            this.EmployeeIDNumber_label.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeIDNumber_label.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDNumber_label.ForeColor = System.Drawing.Color.White;
            this.EmployeeIDNumber_label.Location = new System.Drawing.Point(44, 149);
            this.EmployeeIDNumber_label.Name = "EmployeeIDNumber_label";
            this.EmployeeIDNumber_label.Size = new System.Drawing.Size(218, 39);
            this.EmployeeIDNumber_label.TabIndex = 8;
            this.EmployeeIDNumber_label.Text = "Employee ID # ";
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.Color.White;
            this.Exit_button.Location = new System.Drawing.Point(468, 738);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 32);
            this.Exit_button.TabIndex = 6;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            // 
            // Header_panel
            // 
            this.Header_panel.BackColor = System.Drawing.Color.Black;
            this.Header_panel.Controls.Add(this.EmployeeBonus_label);
            this.Header_panel.Location = new System.Drawing.Point(0, 0);
            this.Header_panel.Name = "Header_panel";
            this.Header_panel.Size = new System.Drawing.Size(564, 100);
            this.Header_panel.TabIndex = 0;
            // 
            // EmployeeBonus_label
            // 
            this.EmployeeBonus_label.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeBonus_label.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBonus_label.ForeColor = System.Drawing.Color.DarkRed;
            this.EmployeeBonus_label.Location = new System.Drawing.Point(90, 20);
            this.EmployeeBonus_label.Name = "EmployeeBonus_label";
            this.EmployeeBonus_label.Size = new System.Drawing.Size(372, 59);
            this.EmployeeBonus_label.TabIndex = 0;
            this.EmployeeBonus_label.Text = "Employee Registration";
            this.EmployeeBonus_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BonusTabulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 782);
            this.Controls.Add(this.EmployeeInfo_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BonusTabulator";
            this.Text = "BonusTabulator";
            this.EmployeeInfo_panel.ResumeLayout(false);
            this.EmployeeInfo_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Header_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EmployeeInfo_panel;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Label EmployeeIDOutput_label;
        private System.Windows.Forms.Label EmployeeIDNumber_label;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Panel Header_panel;
        private System.Windows.Forms.Label EmployeeBonus_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label YorBonus_label;
        private System.Windows.Forms.Label BonusOutput_label;
        private System.Windows.Forms.ComboBox BonusSelection_comboBox;
        private System.Windows.Forms.Button Tabulate_button;
        private System.Windows.Forms.Label Bonus_label2;
        private System.Windows.Forms.Label EmployeeOutput_label;
        private System.Windows.Forms.Label EmployeeName_label;
        private System.Windows.Forms.Button Save_button2;
        private System.Windows.Forms.Label EmpoyeeIDBonusOutput_label;
        private System.Windows.Forms.Label EmployeeIDBonus_label;
        private System.Windows.Forms.Button Exit_button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BonusHeaderText_label;
        private System.Windows.Forms.Button EmployeeBonusBack_button;
    }
}