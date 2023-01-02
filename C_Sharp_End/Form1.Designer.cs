namespace C_Sharp_End
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.start6Btn = new System.Windows.Forms.RadioButton();
            this.start5Btn = new System.Windows.Forms.RadioButton();
            this.start4Btn = new System.Windows.Forms.RadioButton();
            this.start3Btn = new System.Windows.Forms.RadioButton();
            this.start2Btn = new System.Windows.Forms.RadioButton();
            this.start1Btn = new System.Windows.Forms.RadioButton();
            this.jobPanel = new System.Windows.Forms.Panel();
            this.job8Btn = new System.Windows.Forms.RadioButton();
            this.job7Btn = new System.Windows.Forms.RadioButton();
            this.job6Btn = new System.Windows.Forms.RadioButton();
            this.job5Btn = new System.Windows.Forms.RadioButton();
            this.job4Btn = new System.Windows.Forms.RadioButton();
            this.job3Btn = new System.Windows.Forms.RadioButton();
            this.job2Btn = new System.Windows.Forms.RadioButton();
            this.job1Btn = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.名字 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.稀有度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.職業 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.特性 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.startPanel.SuspendLayout();
            this.jobPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SearchBtn.Location = new System.Drawing.Point(898, 126);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(132, 42);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "稀有度";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "職業";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.Location = new System.Drawing.Point(840, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 30);
            this.name.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(765, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "名字";
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.start6Btn);
            this.startPanel.Controls.Add(this.start5Btn);
            this.startPanel.Controls.Add(this.start4Btn);
            this.startPanel.Controls.Add(this.start3Btn);
            this.startPanel.Controls.Add(this.start2Btn);
            this.startPanel.Controls.Add(this.start1Btn);
            this.startPanel.Location = new System.Drawing.Point(114, 46);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(507, 48);
            this.startPanel.TabIndex = 33;
            // 
            // start6Btn
            // 
            this.start6Btn.AutoSize = true;
            this.start6Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start6Btn.Location = new System.Drawing.Point(403, 16);
            this.start6Btn.Name = "start6Btn";
            this.start6Btn.Size = new System.Drawing.Size(36, 23);
            this.start6Btn.TabIndex = 5;
            this.start6Btn.TabStop = true;
            this.start6Btn.Text = "6";
            this.start6Btn.UseVisualStyleBackColor = true;
            // 
            // start5Btn
            // 
            this.start5Btn.AutoSize = true;
            this.start5Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start5Btn.Location = new System.Drawing.Point(325, 16);
            this.start5Btn.Name = "start5Btn";
            this.start5Btn.Size = new System.Drawing.Size(36, 23);
            this.start5Btn.TabIndex = 4;
            this.start5Btn.TabStop = true;
            this.start5Btn.Text = "5";
            this.start5Btn.UseVisualStyleBackColor = true;
            // 
            // start4Btn
            // 
            this.start4Btn.AutoSize = true;
            this.start4Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start4Btn.Location = new System.Drawing.Point(247, 16);
            this.start4Btn.Name = "start4Btn";
            this.start4Btn.Size = new System.Drawing.Size(36, 23);
            this.start4Btn.TabIndex = 3;
            this.start4Btn.TabStop = true;
            this.start4Btn.Text = "4";
            this.start4Btn.UseVisualStyleBackColor = true;
            // 
            // start3Btn
            // 
            this.start3Btn.AutoSize = true;
            this.start3Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start3Btn.Location = new System.Drawing.Point(169, 16);
            this.start3Btn.Name = "start3Btn";
            this.start3Btn.Size = new System.Drawing.Size(36, 23);
            this.start3Btn.TabIndex = 2;
            this.start3Btn.TabStop = true;
            this.start3Btn.Text = "3";
            this.start3Btn.UseVisualStyleBackColor = true;
            // 
            // start2Btn
            // 
            this.start2Btn.AutoSize = true;
            this.start2Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start2Btn.Location = new System.Drawing.Point(91, 16);
            this.start2Btn.Name = "start2Btn";
            this.start2Btn.Size = new System.Drawing.Size(36, 23);
            this.start2Btn.TabIndex = 1;
            this.start2Btn.TabStop = true;
            this.start2Btn.Text = "2";
            this.start2Btn.UseVisualStyleBackColor = true;
            // 
            // start1Btn
            // 
            this.start1Btn.AutoSize = true;
            this.start1Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start1Btn.Location = new System.Drawing.Point(13, 16);
            this.start1Btn.Name = "start1Btn";
            this.start1Btn.Size = new System.Drawing.Size(36, 23);
            this.start1Btn.TabIndex = 0;
            this.start1Btn.TabStop = true;
            this.start1Btn.Text = "1";
            this.start1Btn.UseVisualStyleBackColor = true;
            // 
            // jobPanel
            // 
            this.jobPanel.Controls.Add(this.job8Btn);
            this.jobPanel.Controls.Add(this.job7Btn);
            this.jobPanel.Controls.Add(this.job6Btn);
            this.jobPanel.Controls.Add(this.job5Btn);
            this.jobPanel.Controls.Add(this.job4Btn);
            this.jobPanel.Controls.Add(this.job3Btn);
            this.jobPanel.Controls.Add(this.job2Btn);
            this.jobPanel.Controls.Add(this.job1Btn);
            this.jobPanel.Location = new System.Drawing.Point(114, 120);
            this.jobPanel.Name = "jobPanel";
            this.jobPanel.Size = new System.Drawing.Size(702, 48);
            this.jobPanel.TabIndex = 34;
            // 
            // job8Btn
            // 
            this.job8Btn.AutoSize = true;
            this.job8Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.job8Btn.Location = new System.Drawing.Point(618, 11);
            this.job8Btn.Name = "job8Btn";
            this.job8Btn.Size = new System.Drawing.Size(65, 23);
            this.job8Btn.TabIndex = 13;
            this.job8Btn.TabStop = true;
            this.job8Btn.Text = "特種";
            this.job8Btn.UseVisualStyleBackColor = true;
            // 
            // job7Btn
            // 
            this.job7Btn.AutoSize = true;
            this.job7Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.job7Btn.Location = new System.Drawing.Point(531, 11);
            this.job7Btn.Name = "job7Btn";
            this.job7Btn.Size = new System.Drawing.Size(65, 23);
            this.job7Btn.TabIndex = 12;
            this.job7Btn.TabStop = true;
            this.job7Btn.Text = "醫療";
            this.job7Btn.UseVisualStyleBackColor = true;
            // 
            // job6Btn
            // 
            this.job6Btn.AutoSize = true;
            this.job6Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.job6Btn.Location = new System.Drawing.Point(444, 11);
            this.job6Btn.Name = "job6Btn";
            this.job6Btn.Size = new System.Drawing.Size(65, 23);
            this.job6Btn.TabIndex = 11;
            this.job6Btn.TabStop = true;
            this.job6Btn.Text = "輔助";
            this.job6Btn.UseVisualStyleBackColor = true;
            // 
            // job5Btn
            // 
            this.job5Btn.AutoSize = true;
            this.job5Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.job5Btn.Location = new System.Drawing.Point(357, 11);
            this.job5Btn.Name = "job5Btn";
            this.job5Btn.Size = new System.Drawing.Size(65, 23);
            this.job5Btn.TabIndex = 10;
            this.job5Btn.TabStop = true;
            this.job5Btn.Text = "術師";
            this.job5Btn.UseVisualStyleBackColor = true;
            // 
            // job4Btn
            // 
            this.job4Btn.AutoSize = true;
            this.job4Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.job4Btn.Location = new System.Drawing.Point(270, 11);
            this.job4Btn.Name = "job4Btn";
            this.job4Btn.Size = new System.Drawing.Size(65, 23);
            this.job4Btn.TabIndex = 9;
            this.job4Btn.TabStop = true;
            this.job4Btn.Text = "狙擊";
            this.job4Btn.UseVisualStyleBackColor = true;
            // 
            // job3Btn
            // 
            this.job3Btn.AutoSize = true;
            this.job3Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.job3Btn.Location = new System.Drawing.Point(183, 11);
            this.job3Btn.Name = "job3Btn";
            this.job3Btn.Size = new System.Drawing.Size(65, 23);
            this.job3Btn.TabIndex = 8;
            this.job3Btn.TabStop = true;
            this.job3Btn.Text = "重裝";
            this.job3Btn.UseVisualStyleBackColor = true;
            // 
            // job2Btn
            // 
            this.job2Btn.AutoSize = true;
            this.job2Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.job2Btn.Location = new System.Drawing.Point(96, 11);
            this.job2Btn.Name = "job2Btn";
            this.job2Btn.Size = new System.Drawing.Size(65, 23);
            this.job2Btn.TabIndex = 7;
            this.job2Btn.TabStop = true;
            this.job2Btn.Text = "近衛";
            this.job2Btn.UseVisualStyleBackColor = true;
            // 
            // job1Btn
            // 
            this.job1Btn.AutoSize = true;
            this.job1Btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.job1Btn.Location = new System.Drawing.Point(9, 11);
            this.job1Btn.Name = "job1Btn";
            this.job1Btn.Size = new System.Drawing.Size(65, 23);
            this.job1Btn.TabIndex = 6;
            this.job1Btn.TabStop = true;
            this.job1Btn.Text = "先鋒";
            this.job1Btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名字,
            this.稀有度,
            this.職業,
            this.特性});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 479);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // 名字
            // 
            this.名字.HeaderText = "名字";
            this.名字.Name = "名字";
            this.名字.ReadOnly = true;
            // 
            // 稀有度
            // 
            this.稀有度.HeaderText = "稀有度";
            this.稀有度.Name = "稀有度";
            this.稀有度.ReadOnly = true;
            // 
            // 職業
            // 
            this.職業.HeaderText = "職業";
            this.職業.Name = "職業";
            this.職業.ReadOnly = true;
            // 
            // 特性
            // 
            this.特性.HeaderText = "特性";
            this.特性.Name = "特性";
            this.特性.ReadOnly = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearBtn.Location = new System.Drawing.Point(627, 58);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(64, 33);
            this.ClearBtn.TabIndex = 36;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 693);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.jobPanel);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Name = "Form1";
            this.Text = "Arknight Search Tools";
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.jobPanel.ResumeLayout(false);
            this.jobPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel jobPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton start6Btn;
        private System.Windows.Forms.RadioButton start5Btn;
        private System.Windows.Forms.RadioButton start4Btn;
        private System.Windows.Forms.RadioButton start3Btn;
        private System.Windows.Forms.RadioButton start2Btn;
        private System.Windows.Forms.RadioButton start1Btn;
        private System.Windows.Forms.RadioButton job8Btn;
        private System.Windows.Forms.RadioButton job7Btn;
        private System.Windows.Forms.RadioButton job6Btn;
        private System.Windows.Forms.RadioButton job5Btn;
        private System.Windows.Forms.RadioButton job4Btn;
        private System.Windows.Forms.RadioButton job3Btn;
        private System.Windows.Forms.RadioButton job2Btn;
        private System.Windows.Forms.RadioButton job1Btn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名字;
        private System.Windows.Forms.DataGridViewTextBoxColumn 稀有度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 職業;
        private System.Windows.Forms.DataGridViewTextBoxColumn 特性;
    }
}

