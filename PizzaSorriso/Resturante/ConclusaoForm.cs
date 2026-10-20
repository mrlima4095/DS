using System;
using System.Windows.Forms;

namespace Resturante
{
    public partial class ConclusaoForm : Form
    {
        public ConclusaoForm()
            : this("")
        {
        }

        public ConclusaoForm(string recibo)
        {
            InitializeComponent();
            txtRecibo.Text = recibo;
        }
    }
}
