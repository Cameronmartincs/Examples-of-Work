namespace CharacterCreation
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
            this.btnSword = new System.Windows.Forms.Button();
            this.btnDagger = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbRace = new System.Windows.Forms.GroupBox();
            this.btnHuman = new System.Windows.Forms.Button();
            this.btnElf = new System.Windows.Forms.Button();
            this.btnDwarf = new System.Windows.Forms.Button();
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.btnHunter = new System.Windows.Forms.Button();
            this.btnRogue = new System.Windows.Forms.Button();
            this.btnWarrior = new System.Windows.Forms.Button();
            this.bgWeapon = new System.Windows.Forms.GroupBox();
            this.btnBow = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFemale = new System.Windows.Forms.Button();
            this.btnMale = new System.Windows.Forms.Button();
            this.gbRace.SuspendLayout();
            this.gbClass.SuspendLayout();
            this.bgWeapon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSword
            // 
            this.btnSword.Location = new System.Drawing.Point(126, 35);
            this.btnSword.Name = "btnSword";
            this.btnSword.Size = new System.Drawing.Size(75, 23);
            this.btnSword.TabIndex = 0;
            this.btnSword.Text = "Sword";
            this.btnSword.UseVisualStyleBackColor = true;
            this.btnSword.Click += new System.EventHandler(this.btnSword_Click);
            // 
            // btnDagger
            // 
            this.btnDagger.Location = new System.Drawing.Point(32, 35);
            this.btnDagger.Name = "btnDagger";
            this.btnDagger.Size = new System.Drawing.Size(75, 23);
            this.btnDagger.TabIndex = 1;
            this.btnDagger.Text = "Dagger";
            this.btnDagger.UseVisualStyleBackColor = true;
            this.btnDagger.Click += new System.EventHandler(this.btnDagger_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(171, 449);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbRace
            // 
            this.gbRace.Controls.Add(this.btnHuman);
            this.gbRace.Controls.Add(this.btnElf);
            this.gbRace.Controls.Add(this.btnDwarf);
            this.gbRace.Location = new System.Drawing.Point(45, 119);
            this.gbRace.Name = "gbRace";
            this.gbRace.Size = new System.Drawing.Size(323, 100);
            this.gbRace.TabIndex = 3;
            this.gbRace.TabStop = false;
            this.gbRace.Text = "Choose a race:";
            // 
            // btnHuman
            // 
            this.btnHuman.Location = new System.Drawing.Point(32, 36);
            this.btnHuman.Name = "btnHuman";
            this.btnHuman.Size = new System.Drawing.Size(75, 23);
            this.btnHuman.TabIndex = 8;
            this.btnHuman.Text = "Human";
            this.btnHuman.UseVisualStyleBackColor = true;
            this.btnHuman.Click += new System.EventHandler(this.btnHuman_Click);
            // 
            // btnElf
            // 
            this.btnElf.Location = new System.Drawing.Point(126, 36);
            this.btnElf.Name = "btnElf";
            this.btnElf.Size = new System.Drawing.Size(75, 23);
            this.btnElf.TabIndex = 9;
            this.btnElf.Text = "Elf";
            this.btnElf.UseVisualStyleBackColor = true;
            this.btnElf.Click += new System.EventHandler(this.btnElf_Click);
            // 
            // btnDwarf
            // 
            this.btnDwarf.Location = new System.Drawing.Point(220, 36);
            this.btnDwarf.Name = "btnDwarf";
            this.btnDwarf.Size = new System.Drawing.Size(75, 23);
            this.btnDwarf.TabIndex = 10;
            this.btnDwarf.Text = "Dwarf";
            this.btnDwarf.UseVisualStyleBackColor = true;
            this.btnDwarf.Click += new System.EventHandler(this.btnDwarf_Click);
            // 
            // gbClass
            // 
            this.gbClass.Controls.Add(this.btnHunter);
            this.gbClass.Controls.Add(this.btnRogue);
            this.gbClass.Controls.Add(this.btnWarrior);
            this.gbClass.Location = new System.Drawing.Point(45, 225);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(323, 100);
            this.gbClass.TabIndex = 4;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "Choose a class:";
            // 
            // btnHunter
            // 
            this.btnHunter.Location = new System.Drawing.Point(220, 40);
            this.btnHunter.Name = "btnHunter";
            this.btnHunter.Size = new System.Drawing.Size(75, 23);
            this.btnHunter.TabIndex = 8;
            this.btnHunter.Text = "Hunter";
            this.btnHunter.UseVisualStyleBackColor = true;
            this.btnHunter.Click += new System.EventHandler(this.btnHunter_Click);
            // 
            // btnRogue
            // 
            this.btnRogue.Location = new System.Drawing.Point(126, 40);
            this.btnRogue.Name = "btnRogue";
            this.btnRogue.Size = new System.Drawing.Size(75, 23);
            this.btnRogue.TabIndex = 9;
            this.btnRogue.Text = "Rogue";
            this.btnRogue.UseVisualStyleBackColor = true;
            this.btnRogue.Click += new System.EventHandler(this.btnRogue_Click);
            // 
            // btnWarrior
            // 
            this.btnWarrior.Location = new System.Drawing.Point(32, 40);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(75, 23);
            this.btnWarrior.TabIndex = 10;
            this.btnWarrior.Text = "Warrior";
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // bgWeapon
            // 
            this.bgWeapon.Controls.Add(this.btnBow);
            this.bgWeapon.Controls.Add(this.btnDagger);
            this.bgWeapon.Controls.Add(this.btnSword);
            this.bgWeapon.Location = new System.Drawing.Point(45, 331);
            this.bgWeapon.Name = "bgWeapon";
            this.bgWeapon.Size = new System.Drawing.Size(323, 100);
            this.bgWeapon.TabIndex = 5;
            this.bgWeapon.TabStop = false;
            this.bgWeapon.Text = "Choose a weapon:";
            // 
            // btnBow
            // 
            this.btnBow.Location = new System.Drawing.Point(220, 35);
            this.btnBow.Name = "btnBow";
            this.btnBow.Size = new System.Drawing.Size(75, 23);
            this.btnBow.TabIndex = 3;
            this.btnBow.Text = "Bow";
            this.btnBow.UseVisualStyleBackColor = true;
            this.btnBow.Click += new System.EventHandler(this.btnBow_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose a name:";
            // 
            // btnFemale
            // 
            this.btnFemale.Location = new System.Drawing.Point(265, 90);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(75, 23);
            this.btnFemale.TabIndex = 11;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // btnMale
            // 
            this.btnMale.Location = new System.Drawing.Point(171, 90);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(75, 23);
            this.btnMale.TabIndex = 12;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 511);
            this.Controls.Add(this.btnMale);
            this.Controls.Add(this.btnFemale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bgWeapon);
            this.Controls.Add(this.gbClass);
            this.Controls.Add(this.gbRace);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Create-A-Char";
            this.gbRace.ResumeLayout(false);
            this.gbClass.ResumeLayout(false);
            this.bgWeapon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSword;
        private System.Windows.Forms.Button btnDagger;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gbRace;
        private System.Windows.Forms.Button btnHuman;
        private System.Windows.Forms.Button btnElf;
        private System.Windows.Forms.Button btnDwarf;
        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.Button btnHunter;
        private System.Windows.Forms.Button btnRogue;
        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.GroupBox bgWeapon;
        private System.Windows.Forms.Button btnBow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFemale;
        private System.Windows.Forms.Button btnMale;
        
    }
}

