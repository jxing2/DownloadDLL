namespace DownloaderTester
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urlTb = new System.Windows.Forms.TextBox();
            this.destPathTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Md5Tb = new System.Windows.Forms.TextBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pauseBtn = new System.Windows.Forms.Button();
            this.startBnt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.capacityTb = new System.Windows.Forms.TextBox();
            this.createManagerBtn = new System.Windows.Forms.Button();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.pauseAllBtn = new System.Windows.Forms.Button();
            this.resumeAllBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.removeAllBtn = new System.Windows.Forms.Button();
            this.c6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshLvTimer = new System.Windows.Forms.Timer(this.components);
            this.c7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "DestPath :";
            // 
            // urlTb
            // 
            this.urlTb.Location = new System.Drawing.Point(118, 45);
            this.urlTb.Name = "urlTb";
            this.urlTb.Size = new System.Drawing.Size(589, 21);
            this.urlTb.TabIndex = 1;
            this.urlTb.Text = "http://down.xitongwanjia.com/windows10_64_201903.iso";
            // 
            // destPathTb
            // 
            this.destPathTb.Location = new System.Drawing.Point(118, 74);
            this.destPathTb.Name = "destPathTb";
            this.destPathTb.Size = new System.Drawing.Size(511, 21);
            this.destPathTb.TabIndex = 1;
            this.destPathTb.Text = "E:\\experiment\\downloader\\windows.iso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "MD5 :";
            // 
            // Md5Tb
            // 
            this.Md5Tb.Location = new System.Drawing.Point(118, 106);
            this.Md5Tb.Name = "Md5Tb";
            this.Md5Tb.Size = new System.Drawing.Size(589, 21);
            this.Md5Tb.TabIndex = 1;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(636, 74);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(71, 21);
            this.selectFileBtn.TabIndex = 2;
            this.selectFileBtn.Text = "选择";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(961, 101);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(80, 28);
            this.addTaskBtn.TabIndex = 3;
            this.addTaskBtn.Text = "添加任务";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(49, 200);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(866, 197);
            this.lv.TabIndex = 4;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lv_MouseUp);
            // 
            // c1
            // 
            this.c1.Text = "文件名";
            this.c1.Width = 200;
            // 
            // c2
            // 
            this.c2.Text = "大小";
            this.c2.Width = 100;
            // 
            // c3
            // 
            this.c3.Text = "已下载字节数";
            this.c3.Width = 100;
            // 
            // c4
            // 
            this.c4.Text = "状态";
            this.c4.Width = 150;
            // 
            // c5
            // 
            this.c5.Text = "下载速度";
            this.c5.Width = 100;
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(485, 418);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.Text = "暂停";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // startBnt
            // 
            this.startBnt.Location = new System.Drawing.Point(387, 418);
            this.startBnt.Name = "startBnt";
            this.startBnt.Size = new System.Drawing.Size(75, 23);
            this.startBnt.TabIndex = 6;
            this.startBnt.Text = "开始";
            this.startBnt.UseVisualStyleBackColor = true;
            this.startBnt.Click += new System.EventHandler(this.startBnt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capacity :";
            // 
            // capacityTb
            // 
            this.capacityTb.Location = new System.Drawing.Point(842, 45);
            this.capacityTb.Name = "capacityTb";
            this.capacityTb.Size = new System.Drawing.Size(100, 21);
            this.capacityTb.TabIndex = 8;
            // 
            // createManagerBtn
            // 
            this.createManagerBtn.Location = new System.Drawing.Point(961, 43);
            this.createManagerBtn.Name = "createManagerBtn";
            this.createManagerBtn.Size = new System.Drawing.Size(75, 23);
            this.createManagerBtn.TabIndex = 9;
            this.createManagerBtn.Text = "创建队列";
            this.createManagerBtn.UseVisualStyleBackColor = true;
            this.createManagerBtn.Click += new System.EventHandler(this.createManagerBtn_Click);
            // 
            // resumeBtn
            // 
            this.resumeBtn.Location = new System.Drawing.Point(583, 418);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(75, 23);
            this.resumeBtn.TabIndex = 10;
            this.resumeBtn.Text = "继续";
            this.resumeBtn.UseVisualStyleBackColor = true;
            this.resumeBtn.Click += new System.EventHandler(this.resumeBtn_Click);
            // 
            // pauseAllBtn
            // 
            this.pauseAllBtn.Location = new System.Drawing.Point(888, 418);
            this.pauseAllBtn.Name = "pauseAllBtn";
            this.pauseAllBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseAllBtn.TabIndex = 11;
            this.pauseAllBtn.Text = "全部暂停";
            this.pauseAllBtn.UseVisualStyleBackColor = true;
            this.pauseAllBtn.Click += new System.EventHandler(this.pauseAllBtn_Click);
            // 
            // resumeAllBtn
            // 
            this.resumeAllBtn.Location = new System.Drawing.Point(986, 418);
            this.resumeAllBtn.Name = "resumeAllBtn";
            this.resumeAllBtn.Size = new System.Drawing.Size(75, 23);
            this.resumeAllBtn.TabIndex = 12;
            this.resumeAllBtn.Text = "全部开始";
            this.resumeAllBtn.UseVisualStyleBackColor = true;
            this.resumeAllBtn.Click += new System.EventHandler(this.resumeAllBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(675, 418);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 13;
            this.removeBtn.Text = "移除";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.Location = new System.Drawing.Point(792, 418);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(75, 23);
            this.removeAllBtn.TabIndex = 14;
            this.removeAllBtn.Text = "移除全部任务";
            this.removeAllBtn.UseVisualStyleBackColor = true;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // c6
            // 
            this.c6.Text = "异常描述";
            this.c6.Width = 90;
            // 
            // refreshLvTimer
            // 
            this.refreshLvTimer.Enabled = true;
            this.refreshLvTimer.Interval = 800;
            this.refreshLvTimer.Tick += new System.EventHandler(this.refreshLvTimer_Tick);
            // 
            // c7
            // 
            this.c7.Text = "完成度";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 573);
            this.Controls.Add(this.removeAllBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.resumeAllBtn);
            this.Controls.Add(this.pauseAllBtn);
            this.Controls.Add(this.resumeBtn);
            this.Controls.Add(this.createManagerBtn);
            this.Controls.Add(this.capacityTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startBnt);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.Md5Tb);
            this.Controls.Add(this.destPathTb);
            this.Controls.Add(this.urlTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urlTb;
        private System.Windows.Forms.TextBox destPathTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Md5Tb;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.ColumnHeader c3;
        private System.Windows.Forms.ColumnHeader c4;
        private System.Windows.Forms.ColumnHeader c5;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button startBnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox capacityTb;
        private System.Windows.Forms.Button createManagerBtn;
        private System.Windows.Forms.Button resumeBtn;
        private System.Windows.Forms.Button pauseAllBtn;
        private System.Windows.Forms.Button resumeAllBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button removeAllBtn;
        private System.Windows.Forms.ColumnHeader c6;
        private System.Windows.Forms.Timer refreshLvTimer;
        private System.Windows.Forms.ColumnHeader c7;
    }
}

