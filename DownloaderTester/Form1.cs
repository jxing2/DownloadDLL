using DownloaderLocal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloaderTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = -1;
        TaskManager manager = null;
        ArrayList al = null;
        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                destPathTb.Text = file;
            }
        }

        private void createManagerBtn_Click(object sender, EventArgs e)
        {
            if(manager == null)
                manager = new TaskManager(int.Parse(capacityTb.Text));
            al = manager.getAllTasks();
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            if (manager == null)
            {
                manager = new TaskManager(2);
                al = manager.getAllTasks();
            }
            manager.enqueueTask(urlTb.Text, destPathTb.Text, Md5Tb.Text);
            refreshLv();
        }

        private void refreshLv()
        {
            if (al == null || manager == null)
                return;
            lv.BeginUpdate();
            lv.Items.Clear();
            ListViewItem lvi;
            
            foreach (DownloadTask task in al)
            {
                lv.BeginUpdate();
                lvi = new ListViewItem();
                lvi.Text = task.getFileName();
                lvi.SubItems.Add(task.totalFileSize + "");
                lvi.SubItems.Add(task.BytesWritten + "");
                lvi.SubItems.Add(task.Status + "");
                lvi.SubItems.Add(task.getSpeed(true) + "");
                lvi.SubItems.Add(task.getPercentage(2) + " %");
                lvi.SubItems.Add(task.ExceptionInfo);
                lv.EndUpdate();
                lv.Items.Add(lvi);
                //infoRtb.AppendText(task.getSpeed(true) + "" + task.getSpeed(false) + "\n\r");

            }
            lv.EndUpdate();
            
        }
        
        private void startBnt_Click(object sender, EventArgs e)
        {
            if (index < 0)
                return;
            try
            {
                DownloadTask task = (DownloadTask)al[index];
                manager.runTask(task);
            }
            catch { }
            refreshLvTimer.Start();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (index < 0)
                return;
            try
            {
                DownloadTask task = (DownloadTask)al[index];
                manager.pauseTask(task);
            }
            catch { }
        }

        private void resumeBtn_Click(object sender, EventArgs e)
        {
            if (index < 0)
                return;
            try
            {
                DownloadTask task = (DownloadTask)al[index];
                manager.resumeTask(task);
            }
            catch { }
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void pauseAllBtn_Click(object sender, EventArgs e)
        {
            refreshLvTimer.Stop();
        }

        private void resumeAllBtn_Click(object sender, EventArgs e)
        {
            refreshLvTimer.Start();
        }

        private void refreshLvTimer_Tick(object sender, EventArgs e)
        {
            refreshLv();
        }

        private void lv_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewItem lvi = lv.GetItemAt(e.X, e.Y);
                if (lvi == null)
                    return;
                index = lv.Items.IndexOf(lvi);
            }
        }
    }
}
