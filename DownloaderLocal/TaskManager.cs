using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DownloaderLocal
{
    public class TaskManager
    {
        public int Capacity { get; set; }

        // DownloadTask list
        ArrayList allTasks = new ArrayList();

        LimitedConcurrencyLevelTaskScheduler lcts = null;
        TaskFactory factory = null;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="count">最大同时任务数[1, 30], 异常为5</param>
        public TaskManager(int count) {
            //ThreadPool.SetMaxThreads(count, count);
            if (count >= 1 && count <= 30)
                Capacity = count;
            else
                Capacity = 5;
            lcts = new LimitedConcurrencyLevelTaskScheduler(Capacity);
            factory = new TaskFactory(lcts);
        }
        /// <summary>
        /// 添加任务到队列
        /// </summary>
        /// <param name="fileUrl">文件的下载地址</param>
        /// <param name="fileDir">文件再本地的保存路径</param>
        /// <param name="offset">在文件中开始下载的的位置, byte</param>
        /// <returns>任务</returns>
        public DownloadTask enqueueTask(string fileUrl, string fileDir, string expectedMD5, long offset = 0L) {
            DownloadTask task = new DownloadTask(fileUrl, fileDir, expectedMD5, offset);
            allTasks.Add(task);
            return task;
        }

        public void runAllTasks() {
            foreach (DownloadTask task in allTasks) {
                task.resumeTask();
                factory.StartNew(() => { DownloadTask.download(task); });
            }
        }

        public void pauseAllTasks() {
            foreach (DownloadTask task in allTasks) {
                task.pauseTask();
            }
        }
        public void resumeAllTasks() {
            foreach (DownloadTask task in allTasks)
            {
                task.resumeTask();
                factory.StartNew(() => { DownloadTask.download(task); });
            }
        }

        public ArrayList getAllTasks() { return allTasks; }

        public void runTask(DownloadTask task) {
            task.resumeTask();
            factory.StartNew(() => { DownloadTask.download(task); });

        }

        public void pauseTask(DownloadTask task) {
            task.pauseTask();
        }
        public void resumeTask(DownloadTask task) {
            task.resumeTask();
            factory.StartNew(() => { DownloadTask.download(task); });
        }
        public void removeTask(DownloadTask task) {
            task.pauseTask();
            allTasks.Remove(task);
        }
    }
}
