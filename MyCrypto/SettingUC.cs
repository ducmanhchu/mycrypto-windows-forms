using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCrypto
{
    public partial class SettingUC : UserControl
    {
        public SettingUC()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Lưu MainPrivateKey và MainPublicKey (String)
            Properties.Settings.Default.MainPrivateKey = MainPrivateKeyInput.Text;
            Properties.Settings.Default.MainPublicKey = MainPublicKeyInput.Text;

            // Kiểm tra và lưu Difficulty (Int)
            if (int.TryParse(DifficultyInput.Text, out int difficulty))
            {
                Properties.Settings.Default.Difficulty = difficulty;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho độ khó!", "Lỗi");
                return;
            }

            // Kiểm tra và lưu MiningRewards (Double)
            if (double.TryParse(RewardInput.Text, out double miningRewards))
            {
                Properties.Settings.Default.MiningRewards = miningRewards;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho phần thưởng đào!", "Lỗi");
                return;
            }

            // Lưu lại cài đặt
            Properties.Settings.Default.Save();

            MessageBox.Show("Cài đặt đã được lưu thành công!\n(Vui lòng khởi động lại để áp dụng thay đổi)", "Thông báo");
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            MainPrivateKeyInput.Text = Properties.Settings.Default.MainPrivateKey;
            MainPublicKeyInput.Text = Properties.Settings.Default.MainPublicKey;
            RewardInput.Text = Properties.Settings.Default.MiningRewards.ToString();
            DifficultyInput.Text = Properties.Settings.Default.Difficulty.ToString();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if (MainPrivateKeyInput.PasswordChar == '*')
            {
                MainPrivateKeyInput.PasswordChar = '\0';
                ShowBtn.Text = "Ẩn";
            }
            else
            {
                MainPrivateKeyInput.PasswordChar = '*';
                ShowBtn.Text = "Hiển thị";
            }
        }
    }
}
