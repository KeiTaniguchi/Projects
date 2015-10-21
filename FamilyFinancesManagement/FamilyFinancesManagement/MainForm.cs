using System;
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

        private void registration_Click(object sender, EventArgs e)
        {
            int amountOfMoney = 0;
            var input = int.Parse(textBox1.Text);
            amountOfMoney = input;
            listBox1.Items.Add(amountOfMoney.ToString());
            var todayDate = monthCalendar1.TodayDate;
            listBox1.Items.Add(todayDate);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {





        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }


    }
}
