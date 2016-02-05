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

        /// <summary>
        /// カテゴリ登録ボタン押下時の動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClickCategory(object sender, EventArgs e)
        {
            string input = textBox2.Text;

            //コンボボックスに既に追加されているものは入力チェックしたい。
            int index = comboBox1.FindStringExact(input);

            //comboBox1.SelectedIndex = index;

            if (index.Equals(-1))
            {
                comboBox1.Items.Add(input);
                //TODO:表示欄みたいなのを作成して、表示欄へ「入力されたXXが登録されました」のメッセージを出力。
            }
            else
            {
                listBox1.Items.Add("すでに存在するカテゴリ名です。");
                //「すでに存在するカテゴリ名です」のメッセージを出力する。
            }

            textBox2.Text = "";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
