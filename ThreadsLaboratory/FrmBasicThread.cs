using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsLaboratory
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();

            label1.ForeColor = ColorTranslator.FromHtml("#111318");
            RunButton.BackColor = ColorTranslator.FromHtml("#583722");
            RunButton.ForeColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#BDD7DE");
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(threadStart);
            Thread ThreadB = new Thread(threadStart);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            Console.WriteLine("-- Before starting thread --");

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-- End of thread --");
            label1.Text = "- End of thread -";
        }
    }

    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500);
            }

        }

    }


}
