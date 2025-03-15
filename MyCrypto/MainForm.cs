using MyCrypto.Models;

namespace MyCrypto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadUserControl(new BlockchainUC());
        }

        private void LoadUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear(); // Xóa màn hình cũ
            panelContainer.Controls.Add(uc); // Thêm màn hình mới
        }

        private void BlockchainLabel_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BlockchainUC());
        }

        private void HashBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new HashUC());
        }

        private void TransBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new TransactionUC());
        }

        private void KeyBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new KeyUC());
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SettingUC());
        }
    }
}
