using System;
using System.IO;
using System.Windows.Forms;

namespace Lambda1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "挨拶1";
            label2.Text = "挨拶2";
            label3.Text = "挨拶3";
        }

        //デリゲート、ラムダ式
        Func<int, string> AA = (int y) =>
        {
            y = 67890;
            string GM = "おはよう" + y;
            return GM;
        };

        //Func<string>型の AAを定義し
        //()内の引数(int型のy)を元に
        //=>{}内に記載されているメソッドを実行している。

        Func<int, string> BB = (int x) =>
        {
            string GE = "こんばんは" + x;
            return GE;

            //引数なしを指定する場合
            //Func<string>型の BBを定義することもできる。
            //この場合の書き方は以下。
            //Func<string> BB = () =>
            //{
            //    string GE = "こんばんは" + x;
            //    return GE;
            //と記載することで()の引数なしで=>{}内に記載されているメソッドを実行していることになる。
        };

        public void buttonclick_sub_lambda1()
        {
            FuncAll(AA);
        }

        public void buttonclick_sub_lambda2()
        {
            FuncAll(BB);
        }

        public void sub_filewriter_testC()
        {
            string filepathC = "testC.txt";
            using (StreamWriter CC = new StreamWriter(filepathC))
            {
                CC.WriteLine(textBox1);
            }
        }

        public void sub_filereader_testD()
        {
            string filepathD = "testD.txt";
            //string filepathD = "D:\\testD.txt";
            //\\をのように書く必要があるので注意。
            using (StreamReader DD = new StreamReader(filepathD))
            {
                textBox1.Text = DD.ReadToEnd();
            }
        }

        public void FuncAll(Func<int, string> afunc)
        {
            int hogehoge = 12345;
            label1.Text = "こんにちは";
            label2.Text = afunc(hogehoge);
            label3.Text = "こんにちは";
            //ラムダ式で記載することにより、label1.Textとlabel3.Textに
            //値を入れる処理は共通化でき、label2.Textのみラムダ式で
            //記載した処理にすることができる。
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            buttonclick_sub_lambda1();
            sub_filereader_testD();
            newtest nt = new newtest();
            label4.Text = nt.Taniguchi;
            label5.Text = nt.Old.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonclick_sub_lambda2();
            sub_filewriter_testC();

            int no1 = 17;
            string result;
            newtest nt = new newtest();
            result = nt.calc(no1).ToString();
            label4.Text = result;
            arr arr1 = new arr();
            label5.Text = arr1.fore().ToString();
        }
    }

    public class newtest
    {
        private string taniguchi = "谷口";

        public string Taniguchi
        {
            get { return this.taniguchi; }
            set { this.taniguchi = value; }
        }

        private int old = 30;
        //隠蔽化がされているかってどう確かめればいいのだろうか・・？
        //業務でコードを見た時に、set;get;しか書いてないのを見かけたが、どういう違いなのだろうか・・？

        public int Old
        {
            get { return this.old; }
            set { this.old = value; }
        }

        public int Sex { get; set; }

        int no2 = 4;
        int no3 = 3;

        public int calc(int no1)
        {
            int result = ((no2 - (no1 % no3)) % no3);
            return result;
        }
    }

    public class arr
    {
        int[] arr1 = { 1, 2, 3, 4, 5, };

        public int fore()
        {
            int total;
            total = 0;
            foreach (int n in arr1)
            {
                total += n * n;
            }
            return total;
        }

        //newtest nt = new newtest();
        //string aaa = nt.Taniguchi;
        //string bbb = nt.Old.ToString();

    }

    //インターフェースの使い方がいまいちわからない。
    //public class taniguchi : Ihogehoge
    //{
    //    public string kei()
    //    {
    //        newtest nt1 = new newtest();
    //        string result = nt1.taniguchi;

    //        return result;
    //    }
    //}

    //public interface Ihogehoge
    //{
    //    string taniguchi
    //    {
    //        get;
    //        set;
    //    }
    //}

}




