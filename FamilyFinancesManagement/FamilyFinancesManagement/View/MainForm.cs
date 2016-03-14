using FamilyFinancesManagement.View;
using System;
using System.IO;
using System.Windows.Forms;

namespace FamilyFinancesManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int Total { get; set; }

        /// <summary>
        /// 登録ボタン押下時の動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registration_Click(object sender, EventArgs e)
        {
            var todayDate = monthCalendar1.TodayDate;
            listBox1.Items.Add(todayDate);
            int amountOfMoney = 0;
            try
            {
                //tryParseでやった方がいいかも。
                var input = int.Parse(textBox1.Text);
                amountOfMoney = input;
                listBox1.Items.Add(amountOfMoney.ToString());

            }
            catch (FormatException)
            {

            }

            //TODO:ひとまずテキスト出力
            //今後はxmlとかエクセルとかクラウド上で管理予定。
            textWriter(todayDate, amountOfMoney);

        }

        /// <summary>
        /// テキスト出力関数
        /// </summary>
        /// <param name="todayDate"></param>
        /// <param name="amountOfMoney"></param>
        public void textWriter(DateTime todayDate, int amountOfMoney)
        {
            StreamWriter writer = new StreamWriter(@"D:\Family\Family.txt");
            writer.WriteLine(todayDate + "," + amountOfMoney);
            writer.Flush();
            writer.Close();
        }


        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingForm settingForm = new SettingForm())
            {
                settingForm.ShowDialog();
            }
        }

    }
}
