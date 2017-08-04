namespace CharacterCreationDatabase
{
    partial class DataControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataControl));
            System.Windows.Forms.Label accuracyLabel;
            System.Windows.Forms.Label healthLabel;
            System.Windows.Forms.Label damageLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label raceLabel;
            System.Windows.Forms.Label classLabel;
            System.Windows.Forms.Label nameLabel;
            this.characterDataSet = new CharacterCreationDatabase.CharacterDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new CharacterCreationDatabase.CharacterDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new CharacterCreationDatabase.CharacterDataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.accuracyTextBox = new System.Windows.Forms.TextBox();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.damageTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            accuracyLabel = new System.Windows.Forms.Label();
            healthLabel = new System.Windows.Forms.Label();
            damageLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            raceLabel = new System.Windows.Forms.Label();
            classLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // characterDataSet
            // 
            this.characterDataSet.DataSetName = "CharacterDataSet";
            this.characterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.characterDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CharacterCreationDatabase.CharacterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = null;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = null;
            this.tableBindingNavigator.DeleteItem = null;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = null;
            this.tableBindingNavigator.Size = new System.Drawing.Size(211, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // accuracyTextBox
            // 
            this.accuracyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Accuracy", true));
            this.accuracyTextBox.Location = new System.Drawing.Point(73, 192);
            this.accuracyTextBox.Name = "accuracyTextBox";
            this.accuracyTextBox.Size = new System.Drawing.Size(123, 20);
            this.accuracyTextBox.TabIndex = 16;
            // 
            // accuracyLabel
            // 
            accuracyLabel.AutoSize = true;
            accuracyLabel.Location = new System.Drawing.Point(12, 195);
            accuracyLabel.Name = "accuracyLabel";
            accuracyLabel.Size = new System.Drawing.Size(55, 13);
            accuracyLabel.TabIndex = 15;
            accuracyLabel.Text = "Accuracy:";
            // 
            // healthTextBox
            // 
            this.healthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Health", true));
            this.healthTextBox.Location = new System.Drawing.Point(73, 166);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(123, 20);
            this.healthTextBox.TabIndex = 14;
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.Location = new System.Drawing.Point(12, 169);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new System.Drawing.Size(41, 13);
            healthLabel.TabIndex = 13;
            healthLabel.Text = "Health:";
            // 
            // damageTextBox
            // 
            this.damageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Damage", true));
            this.damageTextBox.Location = new System.Drawing.Point(73, 140);
            this.damageTextBox.Name = "damageTextBox";
            this.damageTextBox.Size = new System.Drawing.Size(123, 20);
            this.damageTextBox.TabIndex = 12;
            // 
            // damageLabel
            // 
            damageLabel.AutoSize = true;
            damageLabel.Location = new System.Drawing.Point(12, 143);
            damageLabel.Name = "damageLabel";
            damageLabel.Size = new System.Drawing.Size(50, 13);
            damageLabel.TabIndex = 11;
            damageLabel.Text = "Damage:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(73, 114);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(123, 20);
            this.speedTextBox.TabIndex = 10;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new System.Drawing.Point(12, 117);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(41, 13);
            speedLabel.TabIndex = 9;
            speedLabel.Text = "Speed:";
            // 
            // raceTextBox
            // 
            this.raceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Race", true));
            this.raceTextBox.Location = new System.Drawing.Point(73, 88);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.Size = new System.Drawing.Size(123, 20);
            this.raceTextBox.TabIndex = 8;
            // 
            // raceLabel
            // 
            raceLabel.AutoSize = true;
            raceLabel.Location = new System.Drawing.Point(12, 91);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new System.Drawing.Size(36, 13);
            raceLabel.TabIndex = 7;
            raceLabel.Text = "Race:";
            // 
            // classTextBox
            // 
            this.classTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Class", true));
            this.classTextBox.Location = new System.Drawing.Point(73, 62);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(123, 20);
            this.classTextBox.TabIndex = 6;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new System.Drawing.Point(12, 65);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(35, 13);
            classLabel.TabIndex = 5;
            classLabel.Text = "Class:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(73, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(123, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(121, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // DataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 233);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(classLabel);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(raceLabel);
            this.Controls.Add(this.raceTextBox);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(damageLabel);
            this.Controls.Add(this.damageTextBox);
            this.Controls.Add(healthLabel);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(accuracyLabel);
            this.Controls.Add(this.accuracyTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Name = "DataControl";
            this.Text = "Create-A-Char";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CharacterDataSet characterDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private CharacterDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private CharacterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox accuracyTextBox;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.TextBox damageTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button btnCreate;
    }
}

