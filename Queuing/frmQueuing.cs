using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queuing
{
    public partial class frmQueuing : Form
    {
        Cashier cashier = new Cashier();
        public frmQueuing()
        {
            InitializeComponent();
            frmCashierWindowQueue frmCashierWindowQueue = new frmCashierWindowQueue();
            frmCashierWindowQueue.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblPosQueue.Text = cashier.CashierGeneratedNumber("P - ");
            Cashier.getNumberInQueue = lblPosQueue.Text;
            Cashier.cashierQueue.Enqueue(Cashier.getNumberInQueue);
        }

    }
}
