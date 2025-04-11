using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class ShowMessage: Form
    {
        public ShowMessage()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text What You Enter", "Title What You Enter", "Ok", "Information");
        }

        private void BtnYesNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text What You Enter", "Title What You Enter", "YesNo", "Question");
        }

        private void BtnRetryCencel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text What You Enter", "Title What You Enter", "RetryCancel", "Error");
        }

        private void BtnOkCencel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text What You Enter", "Title What You Enter", "OkCancel", "Warning");
        }

        private void BtnAbortRetryCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text What You Enter", "Title What You Enter", "AbortRetryCancel", "Asterisk");
        }

        private void BtnYesNoCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text What You Enter", "Title What You Enter", "YesNoCancel", "Exclamation");
        }
    }
}
