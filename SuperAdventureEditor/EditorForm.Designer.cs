namespace SuperAdventureEditor
{
    partial class EditorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pMainPanel = new System.Windows.Forms.Panel();
            this.tcDataTabs = new System.Windows.Forms.TabControl();
            this.tpItems = new System.Windows.Forms.TabPage();
            this.tpQuests = new System.Windows.Forms.TabPage();
            this.tpMonsters = new System.Windows.Forms.TabPage();
            this.tpNPCs = new System.Windows.Forms.TabPage();
            this.tpLocations = new System.Windows.Forms.TabPage();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.dgvMonsters = new System.Windows.Forms.DataGridView();
            this.dgvNPCs = new System.Windows.Forms.DataGridView();
            this.dgvLocations = new System.Windows.Forms.DataGridView();
            this.cItemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemsType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cItemsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemsNamePlural = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemsHealPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemsMinD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemsMaxD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tcDataTabs.SuspendLayout();
            this.tpItems.SuspendLayout();
            this.tpQuests.SuspendLayout();
            this.tpMonsters.SuspendLayout();
            this.tpNPCs.SuspendLayout();
            this.tpLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonsters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPCs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.91304F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.08695F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveToFile, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pMainPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tcDataTabs, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 532);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pMainPanel
            // 
            this.pMainPanel.AutoScroll = true;
            this.pMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainPanel.Location = new System.Drawing.Point(33, 33);
            this.pMainPanel.Name = "pMainPanel";
            this.pMainPanel.Size = new System.Drawing.Size(207, 476);
            this.pMainPanel.TabIndex = 1;
            // 
            // tcDataTabs
            // 
            this.tcDataTabs.Controls.Add(this.tpItems);
            this.tcDataTabs.Controls.Add(this.tpQuests);
            this.tcDataTabs.Controls.Add(this.tpMonsters);
            this.tcDataTabs.Controls.Add(this.tpNPCs);
            this.tcDataTabs.Controls.Add(this.tpLocations);
            this.tcDataTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDataTabs.Location = new System.Drawing.Point(246, 33);
            this.tcDataTabs.Name = "tcDataTabs";
            this.tcDataTabs.SelectedIndex = 0;
            this.tcDataTabs.Size = new System.Drawing.Size(675, 476);
            this.tcDataTabs.TabIndex = 2;
            // 
            // tpItems
            // 
            this.tpItems.Controls.Add(this.dgvItems);
            this.tpItems.Location = new System.Drawing.Point(4, 22);
            this.tpItems.Name = "tpItems";
            this.tpItems.Padding = new System.Windows.Forms.Padding(3);
            this.tpItems.Size = new System.Drawing.Size(667, 450);
            this.tpItems.TabIndex = 0;
            this.tpItems.Text = "Предметы";
            this.tpItems.UseVisualStyleBackColor = true;
            // 
            // tpQuests
            // 
            this.tpQuests.Controls.Add(this.dgvQuests);
            this.tpQuests.Location = new System.Drawing.Point(4, 22);
            this.tpQuests.Name = "tpQuests";
            this.tpQuests.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuests.Size = new System.Drawing.Size(271, 450);
            this.tpQuests.TabIndex = 1;
            this.tpQuests.Text = "Задания";
            this.tpQuests.UseVisualStyleBackColor = true;
            // 
            // tpMonsters
            // 
            this.tpMonsters.Controls.Add(this.dgvMonsters);
            this.tpMonsters.Location = new System.Drawing.Point(4, 22);
            this.tpMonsters.Name = "tpMonsters";
            this.tpMonsters.Size = new System.Drawing.Size(271, 450);
            this.tpMonsters.TabIndex = 2;
            this.tpMonsters.Text = "Монстры";
            this.tpMonsters.UseVisualStyleBackColor = true;
            // 
            // tpNPCs
            // 
            this.tpNPCs.Controls.Add(this.dgvNPCs);
            this.tpNPCs.Location = new System.Drawing.Point(4, 22);
            this.tpNPCs.Name = "tpNPCs";
            this.tpNPCs.Size = new System.Drawing.Size(271, 450);
            this.tpNPCs.TabIndex = 3;
            this.tpNPCs.Text = "NPC";
            this.tpNPCs.UseVisualStyleBackColor = true;
            // 
            // tpLocations
            // 
            this.tpLocations.Controls.Add(this.dgvLocations);
            this.tpLocations.Location = new System.Drawing.Point(4, 22);
            this.tpLocations.Name = "tpLocations";
            this.tpLocations.Size = new System.Drawing.Size(271, 450);
            this.tpLocations.TabIndex = 4;
            this.tpLocations.Text = "Локации";
            this.tpLocations.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cItemsID,
            this.cItemsType,
            this.cItemsName,
            this.cItemsNamePlural,
            this.cItemsPrice,
            this.cItemsHealPoints,
            this.cItemsMinD,
            this.cItemsMaxD});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(3, 3);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.Size = new System.Drawing.Size(661, 444);
            this.dgvItems.TabIndex = 3;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // dgvQuests
            // 
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuests.Location = new System.Drawing.Point(3, 3);
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.Size = new System.Drawing.Size(265, 444);
            this.dgvQuests.TabIndex = 4;
            // 
            // dgvMonsters
            // 
            this.dgvMonsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonsters.Location = new System.Drawing.Point(0, 0);
            this.dgvMonsters.Name = "dgvMonsters";
            this.dgvMonsters.Size = new System.Drawing.Size(271, 450);
            this.dgvMonsters.TabIndex = 4;
            // 
            // dgvNPCs
            // 
            this.dgvNPCs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNPCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNPCs.Location = new System.Drawing.Point(0, 0);
            this.dgvNPCs.Name = "dgvNPCs";
            this.dgvNPCs.Size = new System.Drawing.Size(271, 450);
            this.dgvNPCs.TabIndex = 4;
            // 
            // dgvLocations
            // 
            this.dgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocations.Location = new System.Drawing.Point(0, 0);
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.Size = new System.Drawing.Size(271, 450);
            this.dgvLocations.TabIndex = 4;
            // 
            // cItemsID
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.cItemsID.DefaultCellStyle = dataGridViewCellStyle1;
            this.cItemsID.HeaderText = "ID";
            this.cItemsID.Name = "cItemsID";
            this.cItemsID.ReadOnly = true;
            this.cItemsID.Width = 50;
            // 
            // cItemsType
            // 
            this.cItemsType.HeaderText = "Type";
            this.cItemsType.Items.AddRange(new object[] {
            "Weapon",
            "HealingPotion"});
            this.cItemsType.Name = "cItemsType";
            this.cItemsType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cItemsType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cItemsType.Width = 80;
            // 
            // cItemsName
            // 
            this.cItemsName.HeaderText = "Name";
            this.cItemsName.Name = "cItemsName";
            // 
            // cItemsNamePlural
            // 
            this.cItemsNamePlural.HeaderText = "Name Plural";
            this.cItemsNamePlural.Name = "cItemsNamePlural";
            // 
            // cItemsPrice
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.cItemsPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.cItemsPrice.HeaderText = "Price";
            this.cItemsPrice.Name = "cItemsPrice";
            this.cItemsPrice.Width = 50;
            // 
            // cItemsHealPoints
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.cItemsHealPoints.DefaultCellStyle = dataGridViewCellStyle3;
            this.cItemsHealPoints.HeaderText = "Heal points";
            this.cItemsHealPoints.Name = "cItemsHealPoints";
            this.cItemsHealPoints.Width = 50;
            // 
            // cItemsMinD
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.cItemsMinD.DefaultCellStyle = dataGridViewCellStyle4;
            this.cItemsMinD.HeaderText = "MinD";
            this.cItemsMinD.Name = "cItemsMinD";
            this.cItemsMinD.Width = 50;
            // 
            // cItemsMaxD
            // 
            dataGridViewCellStyle5.Format = "N0";
            this.cItemsMaxD.DefaultCellStyle = dataGridViewCellStyle5;
            this.cItemsMaxD.HeaderText = "MaxD";
            this.cItemsMaxD.Name = "cItemsMaxD";
            this.cItemsMaxD.Width = 50;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(246, 3);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToFile.TabIndex = 4;
            this.btnSaveToFile.Text = "Save";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditorForm";
            this.Text = "Редактор для игры SuperAdventure";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tcDataTabs.ResumeLayout(false);
            this.tpItems.ResumeLayout(false);
            this.tpQuests.ResumeLayout(false);
            this.tpMonsters.ResumeLayout(false);
            this.tpNPCs.ResumeLayout(false);
            this.tpLocations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonsters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNPCs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pMainPanel;
        private System.Windows.Forms.TabControl tcDataTabs;
        private System.Windows.Forms.TabPage tpItems;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TabPage tpQuests;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.TabPage tpMonsters;
        private System.Windows.Forms.DataGridView dgvMonsters;
        private System.Windows.Forms.TabPage tpNPCs;
        private System.Windows.Forms.DataGridView dgvNPCs;
        private System.Windows.Forms.TabPage tpLocations;
        private System.Windows.Forms.DataGridView dgvLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemsID;
        private System.Windows.Forms.DataGridViewComboBoxColumn cItemsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemsNamePlural;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemsHealPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemsMinD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemsMaxD;
        private System.Windows.Forms.Button btnSaveToFile;
    }
}

