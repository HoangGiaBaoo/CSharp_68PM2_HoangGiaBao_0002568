using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            UC_QLSV uCLSV = new UC_QLSV();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uCLSV);
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QLSV uCLSV = new UC_QLSV();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uCLSV);
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QLLH uCLLH = new UC_QLLH();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uCLLH);
        }
    }
}
