using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Queuing
{
    public partial class frmCashierWindowQueue : Form
    {
        public frmCashierWindowQueue()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Cashier.cashierQueue.Dequeue();
            System.Windows.Forms.Timer timer = 
                new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(Cashier.cashierQueue);
        }

        private void DisplayCashierQueue(IEnumerable CashierList)
        {
            lvCashierQueue.Items.Clear();
            foreach (string c in CashierList)
                lvCashierQueue.Items.Add(c.ToString());
        }
    }
}
