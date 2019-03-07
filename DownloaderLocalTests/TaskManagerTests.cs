using Microsoft.VisualStudio.TestTools.UnitTesting;
using DownloaderLocal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DownloaderLocal.Tests
{
    [TestClass()]
    public class TaskManagerTests
    {
        [TestMethod()]
        public void runTaskTest()
        {
            TaskManager tm = new TaskManager(2);
            string url1 = @"https://img-blog.csdn.net/20140518163903765?watermark/2/text/aHR0cDovL2Jsb2cuY3Nkbi5uZXQvcTYyNjc3OTMxMw==/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70/gravity/Center";
            string url2 = @"https://img-blog.csdn.net/20140518163903765?watermark/2/text/aHR0cDovL2Jsb2cuY3Nkbi5uZXQvcTYyNjc3OTMxMw==/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70/gravity/Center";
            string url3 = @"https://img-blog.csdn.net/20140518163903765?watermark/2/text/aHR0cDovL2Jsb2cuY3Nkbi5uZXQvcTYyNjc3OTMxMw==/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70/gravity/Center";
            string url4 = @"https://img-blog.csdn.net/20140518163903765?watermark/2/text/aHR0cDovL2Jsb2cuY3Nkbi5uZXQvcTYyNjc3OTMxMw==/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70/gravity/Center";
            string url5 = @"https://img-blog.csdn.net/20140518163903765?watermark/2/text/aHR0cDovL2Jsb2cuY3Nkbi5uZXQvcTYyNjc3OTMxMw==/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70/gravity/Center";
            DownloadTask task = tm.enqueueTask(url1, @"E:\experiment\downloader\2.jpg", "");
            //tm.enqueueTask(url2, @"E:\experiment\downloader\2.jpg", "");
            //tm.enqueueTask(url3, @"E:\experiment\downloader\3.jpg", "");
            //tm.enqueueTask(url4, @"E:\experiment\downloader\4.jpg", "");
            //tm.enqueueTask(url5, @"E:\experiment\downloader\5.jpg", "");
            tm.runAllTasks();

        }
        [TestMethod()]
        public void ThreadPoolTest() {
            int workthread;
            int iothread;
            ThreadPool.SetMaxThreads(5, 7);
            ThreadPool.SetMinThreads(5, 7);
            ThreadPool.GetMaxThreads(out workthread, out iothread);
            Console.WriteLine("Max Work Thread:{0} Max I/O Thread:{1}", workthread, iothread);
        }
    }
}