using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _100Bgw
{
    //Ferrari Roberto 4*G
    //Prova GitHub
    public partial class frmMain : Form
    {
        BackgroundWorker bgw1, bgw2;
        BackgroundWorker[] arrayBgw = new BackgroundWorker[100];
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtDisplay2.Text = "";
            txtDisplay100.Text = "";
            btnAvvia2.Enabled = true;
            btnAvvia100.Enabled = true;
            btnFerma2.Enabled = false;
            btnFerma100.Enabled = false;
        }

        private void btnAvvia2_Click(object sender, EventArgs e)
        {
            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += Bgw_DoWork;
            bgw1.ProgressChanged += Bgw_ProgressChanged;
            bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += Bgw_DoWork;
            bgw2.ProgressChanged += Bgw_ProgressChanged;
            bgw2.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw1.RunWorkerAsync(txtDisplay2);
            bgw2.RunWorkerAsync(txtDisplay2);

            btnAvvia2.Enabled = false;
            btnFerma2.Enabled = true;
        }
        private void btnAvvia100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                bgw1 = new BackgroundWorker();
                bgw1.WorkerReportsProgress = true;
                bgw1.WorkerSupportsCancellation = true;
                bgw1.DoWork += Bgw_DoWork;
                bgw1.ProgressChanged += Bgw_ProgressChanged;
                bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted;
                arrayBgw[i] = bgw1;
            }
            foreach (BackgroundWorker bgw in arrayBgw)
            {
                bgw.RunWorkerAsync(txtDisplay100);
            }

            btnAvvia100.Enabled = false;
            btnFerma100.Enabled = true;
        }
        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            TextBox tb = e.Argument as TextBox;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                bgw.ReportProgress(i, tb);
                if (bgw.CancellationPending)
                {
                    e.Result = (false, tb);
                    return;
                }
            }
            e.Result = (true, tb);
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var (completato, tb) = (ValueTuple<bool, TextBox>)e.Result;
            tb.Text = completato ? "Concluso" + Environment.NewLine + tb.Text : "Cancellato" + Environment.NewLine + tb.Text;
        }
        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TextBox tb = e.UserState as TextBox;
            tb.Text = e.ProgressPercentage + Environment.NewLine + tb.Text;
        }

        private void btnFerma2_Click(object sender, EventArgs e)
        {
            bgw1.CancelAsync();
            bgw2.CancelAsync();
        }


        private void btnFerma100_Click(object sender, EventArgs e)
        {
            foreach (BackgroundWorker bgw in arrayBgw)
            {
                bgw.CancelAsync();
            }
        }
    }
}
