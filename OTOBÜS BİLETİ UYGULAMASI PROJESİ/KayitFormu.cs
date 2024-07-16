using System;
using System.Windows.Forms;

namespace OTOBÜS_BİLETİ_UYGULAMASI_PROJESİ
{
    public partial class KayitFormu : Form
    {
        public KayitFormu()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOkey_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
