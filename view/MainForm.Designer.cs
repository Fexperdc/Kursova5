namespace InternetServiceProvider.view {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.керуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countClientByMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorsByDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pricesL = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.changerPrices = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pricePTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.operatorBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.connectSimulation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientList = new InternetServiceProvider.view.control.ClientList();
            this.pricePCB = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.керуванняToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // керуванняToolStripMenuItem
            // 
            this.керуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.addOperatorToolStripMenuItem});
            this.керуванняToolStripMenuItem.Name = "керуванняToolStripMenuItem";
            this.керуванняToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.керуванняToolStripMenuItem.Text = "Керування";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addClientToolStripMenuItem.Text = "Додати клієнта";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // addOperatorToolStripMenuItem
            // 
            this.addOperatorToolStripMenuItem.Name = "addOperatorToolStripMenuItem";
            this.addOperatorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addOperatorToolStripMenuItem.Text = "Додати оператора";
            this.addOperatorToolStripMenuItem.Click += new System.EventHandler(this.addOperatorToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countClientByMonthToolStripMenuItem,
            this.operatorsByDayToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.functionsToolStripMenuItem.Text = "Функції";
            // 
            // countClientByMonthToolStripMenuItem
            // 
            this.countClientByMonthToolStripMenuItem.Name = "countClientByMonthToolStripMenuItem";
            this.countClientByMonthToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.countClientByMonthToolStripMenuItem.Text = "Кількість клієнтів за місяць";
            this.countClientByMonthToolStripMenuItem.Click += new System.EventHandler(this.countClientByMonthToolStripMenuItem_Click);
            // 
            // operatorsByDayToolStripMenuItem
            // 
            this.operatorsByDayToolStripMenuItem.Name = "operatorsByDayToolStripMenuItem";
            this.operatorsByDayToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.operatorsByDayToolStripMenuItem.Text = "Список операторів за день";
            this.operatorsByDayToolStripMenuItem.Click += new System.EventHandler(this.operatorsByDayToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.saveToolStripMenuItem.Text = "Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pricesL);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.operatorBtn);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 424);
            this.panel1.TabIndex = 1;
            // 
            // pricesL
            // 
            this.pricesL.AutoSize = true;
            this.pricesL.ForeColor = System.Drawing.Color.Purple;
            this.pricesL.Location = new System.Drawing.Point(499, 1);
            this.pricesL.Name = "pricesL";
            this.pricesL.Size = new System.Drawing.Size(178, 13);
            this.pricesL.TabIndex = 6;
            this.pricesL.Text = "Звичайна ціна: 5 | Пільгова ціна: 3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.changerPrices);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(362, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 101);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Зміна цін";
            // 
            // changerPrices
            // 
            this.changerPrices.Location = new System.Drawing.Point(9, 71);
            this.changerPrices.Name = "changerPrices";
            this.changerPrices.Size = new System.Drawing.Size(291, 23);
            this.changerPrices.TabIndex = 1;
            this.changerPrices.Text = "Змінити";
            this.changerPrices.UseVisualStyleBackColor = true;
            this.changerPrices.Click += new System.EventHandler(this.changerPrices_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.priceTB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pricePTB, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(291, 46);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Звичайна ціна";
            // 
            // priceTB
            // 
            this.priceTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.priceTB.Location = new System.Drawing.Point(148, 3);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(140, 20);
            this.priceTB.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Пільгова ціна";
            // 
            // pricePTB
            // 
            this.pricePTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pricePTB.Location = new System.Drawing.Point(148, 26);
            this.pricePTB.Name = "pricePTB";
            this.pricePTB.Size = new System.Drawing.Size(140, 20);
            this.pricePTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Оператор";
            // 
            // operatorBtn
            // 
            this.operatorBtn.Location = new System.Drawing.Point(114, 106);
            this.operatorBtn.Name = "operatorBtn";
            this.operatorBtn.Size = new System.Drawing.Size(175, 23);
            this.operatorBtn.TabIndex = 3;
            this.operatorBtn.Text = "Оператор не вибраний";
            this.operatorBtn.UseVisualStyleBackColor = true;
            this.operatorBtn.Click += new System.EventHandler(this.operatorBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pricePCB);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.connectSimulation);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(362, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 228);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Симуляція з\'єднання";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.27027F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.72973F));
            this.tableLayoutPanel1.Controls.Add(this.startDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.endDate, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 52);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // startDate
            // 
            this.startDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startDate.Location = new System.Drawing.Point(90, 3);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(195, 20);
            this.startDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Початок";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Кінець";
            // 
            // endDate
            // 
            this.endDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endDate.Location = new System.Drawing.Point(90, 29);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(194, 20);
            this.endDate.TabIndex = 0;
            // 
            // connectSimulation
            // 
            this.connectSimulation.Location = new System.Drawing.Point(9, 196);
            this.connectSimulation.Name = "connectSimulation";
            this.connectSimulation.Size = new System.Drawing.Size(288, 23);
            this.connectSimulation.TabIndex = 1;
            this.connectSimulation.Text = "Симулювати";
            this.connectSimulation.UseVisualStyleBackColor = true;
            this.connectSimulation.Click += new System.EventHandler(this.connectSimulation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть клієнта для симуляції";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientList);
            this.groupBox1.Location = new System.Drawing.Point(13, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список клієнтів";
            // 
            // clientList
            // 
            this.clientList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientList.Location = new System.Drawing.Point(3, 16);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(337, 209);
            this.clientList.TabIndex = 0;
            // 
            // pricePCB
            // 
            this.pricePCB.AutoSize = true;
            this.pricePCB.Location = new System.Drawing.Point(9, 142);
            this.pricePCB.Name = "pricePCB";
            this.pricePCB.Size = new System.Drawing.Size(118, 17);
            this.pricePCB.TabIndex = 3;
            this.pricePCB.Text = "Час пільгової ціни";
            this.pricePCB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem керуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOperatorToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private control.ClientList clientList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectSimulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button operatorBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countClientByMonthToolStripMenuItem;
        private System.Windows.Forms.Label pricesL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button changerPrices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pricePTB;
        private System.Windows.Forms.ToolStripMenuItem operatorsByDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.CheckBox pricePCB;
    }
}