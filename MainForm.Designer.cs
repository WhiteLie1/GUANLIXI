namespace XueshenguanLi
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip4 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考试安排查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生基本情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生工作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生考勤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.请拨打热线电话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            this.statusStrip4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(44, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "显示信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(147, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "添加信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(256, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 97);
            this.button3.TabIndex = 2;
            this.button3.Text = "修改信息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(364, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 97);
            this.button4.TabIndex = 3;
            this.button4.Text = "删除信息";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "欢迎使用学生信息管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(452, 296);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 593);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(521, 25);
            this.statusStrip2.TabIndex = 7;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel1.Text = "登录时间";
            // 
            // statusStrip3
            // 
            this.statusStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3});
            this.statusStrip3.Location = new System.Drawing.Point(0, 568);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(521, 25);
            this.statusStrip3.TabIndex = 8;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel3.Text = "操作权限";
            // 
            // statusStrip4
            // 
            this.statusStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip4.Location = new System.Drawing.Point(0, 543);
            this.statusStrip4.Name = "statusStrip4";
            this.statusStrip4.Size = new System.Drawing.Size(521, 25);
            this.statusStrip4.TabIndex = 9;
            this.statusStrip4.Text = "statusStrip4";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel2.Text = "操作用户";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩查询ToolStripMenuItem,
            this.课表查询ToolStripMenuItem,
            this.菜单查询ToolStripMenuItem,
            this.选课情况ToolStripMenuItem,
            this.考试安排查询ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.toolStripMenuItem1.Text = "学生信息管理";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            // 
            // 课表查询ToolStripMenuItem
            // 
            this.课表查询ToolStripMenuItem.Name = "课表查询ToolStripMenuItem";
            this.课表查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.课表查询ToolStripMenuItem.Text = "课表查询";
            // 
            // 菜单查询ToolStripMenuItem
            // 
            this.菜单查询ToolStripMenuItem.Name = "菜单查询ToolStripMenuItem";
            this.菜单查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.菜单查询ToolStripMenuItem.Text = "菜单查询";
            // 
            // 选课情况ToolStripMenuItem
            // 
            this.选课情况ToolStripMenuItem.Name = "选课情况ToolStripMenuItem";
            this.选课情况ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.选课情况ToolStripMenuItem.Text = "选课情况";
            // 
            // 考试安排查询ToolStripMenuItem
            // 
            this.考试安排查询ToolStripMenuItem.Name = "考试安排查询ToolStripMenuItem";
            this.考试安排查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.考试安排查询ToolStripMenuItem.Text = "考试安排查询";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息ToolStripMenuItem,
            this.学生基本情况ToolStripMenuItem,
            this.学生工作ToolStripMenuItem,
            this.学生考勤ToolStripMenuItem,
            this.学生成绩修改ToolStripMenuItem,
            this.学生成绩统计ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 24);
            this.toolStripMenuItem2.Text = "管理员信息管理";
            // 
            // 学生信息ToolStripMenuItem
            // 
            this.学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            this.学生信息ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.学生信息ToolStripMenuItem.Text = "学生信息";
            // 
            // 学生基本情况ToolStripMenuItem
            // 
            this.学生基本情况ToolStripMenuItem.Name = "学生基本情况ToolStripMenuItem";
            this.学生基本情况ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.学生基本情况ToolStripMenuItem.Text = "学生基本情况";
            // 
            // 学生工作ToolStripMenuItem
            // 
            this.学生工作ToolStripMenuItem.Name = "学生工作ToolStripMenuItem";
            this.学生工作ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.学生工作ToolStripMenuItem.Text = "学生工作";
            // 
            // 学生考勤ToolStripMenuItem
            // 
            this.学生考勤ToolStripMenuItem.Name = "学生考勤ToolStripMenuItem";
            this.学生考勤ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.学生考勤ToolStripMenuItem.Text = "学生考勤";
            // 
            // 学生成绩修改ToolStripMenuItem
            // 
            this.学生成绩修改ToolStripMenuItem.Name = "学生成绩修改ToolStripMenuItem";
            this.学生成绩修改ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.学生成绩修改ToolStripMenuItem.Text = "学生成绩修改";
            // 
            // 学生成绩统计ToolStripMenuItem
            // 
            this.学生成绩统计ToolStripMenuItem.Name = "学生成绩统计ToolStripMenuItem";
            this.学生成绩统计ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.学生成绩统计ToolStripMenuItem.Text = "学生成绩统计";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统退出ToolStripMenuItem,
            this.系统查询ToolStripMenuItem,
            this.系统维修ToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem3.Text = "系统管理";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // 系统退出ToolStripMenuItem
            // 
            this.系统退出ToolStripMenuItem.Name = "系统退出ToolStripMenuItem";
            this.系统退出ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.系统退出ToolStripMenuItem.Text = "系统退出";
            // 
            // 系统查询ToolStripMenuItem
            // 
            this.系统查询ToolStripMenuItem.Name = "系统查询ToolStripMenuItem";
            this.系统查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.系统查询ToolStripMenuItem.Text = "系统查询";
            // 
            // 系统维修ToolStripMenuItem
            // 
            this.系统维修ToolStripMenuItem.Name = "系统维修ToolStripMenuItem";
            this.系统维修ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.系统维修ToolStripMenuItem.Text = "系统维修";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.请拨打热线电话ToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(51, 24);
            this.toolStripMenuItem4.Text = "帮助";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 请拨打热线电话ToolStripMenuItem
            // 
            this.请拨打热线电话ToolStripMenuItem.Name = "请拨打热线电话ToolStripMenuItem";
            this.请拨打热线电话ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.请拨打热线电话ToolStripMenuItem.Text = "请拨打热线电话";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::XueshenguanLi.Properties.Resources.QQ图片20170101175407;
            this.ClientSize = new System.Drawing.Size(521, 618);
            this.Controls.Add(this.statusStrip4);
            this.Controls.Add(this.statusStrip3);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.statusStrip4.ResumeLayout(false);
            this.statusStrip4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.StatusStrip statusStrip4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜单查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考试安排查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生基本情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生工作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生考勤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请拨打热线电话ToolStripMenuItem;
    }
}