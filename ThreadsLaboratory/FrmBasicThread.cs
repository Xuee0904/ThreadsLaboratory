using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
