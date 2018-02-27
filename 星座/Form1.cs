using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        private string[] date;
        private int luckynum = 0;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy,mmmm,dd";
        }

        private void ComputeNum()
        {
            int j = 0;
            foreach(var i in date)
            {
                for(int x=0;x<i.Length;x++)
                {
                    j += int.Parse(i[x].ToString());
                }
            }
            while (j > 0)
            {
                luckynum += j % 10;
                j = j / 10;
            }
            Console.WriteLine(luckynum);
            ConstellationRange();
        }
        private string ConstellationRange()
        {
            var s = date[1] + date[2];
            string[] atomBound = { "120", "220", "321", "421", "521", "622", "723", "823", "923", "1023", "1121", "1222", "1320" };
            string[] atoms = { "水瓶座", "雙魚座", "牡羊座", "金牛座", "雙子座", "巨蟹座", "獅子座", "處女座", "天秤座", "天蠍座", "射手座", "魔羯座" };
            string ret = string.Empty;
            for (int i = 0; i < atomBound.Length - 1; i++)
            {
                if (int.Parse(atomBound[i]) <= int.Parse(s) && int.Parse(atomBound[i + 1]) > int.Parse(s))
                {
                    ret = atoms[i];
                    break;
                }
            }
            return ret;
        }
        private Dictionary<int, string> dic = new Dictionary<int, string>();
        private void show()
        {
            switch (ConstellationRange())
            {
                case "水瓶座":
                    dic = DataProcess.CreateAquarius();
                    label1.Text = "我是水瓶座\n"+dic[luckynum];
                    break;
                case "雙魚座":
                    dic = DataProcess.CreatePieces();
                    label1.Text = "我是雙魚座\n" + dic[luckynum];
                    break;
                case "牡羊座":
                    dic = DataProcess.CreateAries();
                    label1.Text = "我是牡羊座\n" + dic[luckynum];
                    break;
                case "金牛座":
                    dic = DataProcess.CreateTaurus();
                    label1.Text = "我是金牛座\n" + dic[luckynum];
                    break;
                case "雙子座":
                    dic = DataProcess.CreateGemini();
                    label1.Text = "我是雙子座\n" + dic[luckynum];
                    break;
                case "巨蟹座":
                    dic = DataProcess.CreateCancer();
                    label1.Text = "我是巨蟹座\n" + dic[luckynum];
                    break;
                case "獅子座":
                    dic = DataProcess.CreateLeo();
                    label1.Text = "我是獅子座\n" + dic[luckynum];
                    break;
                case "處女座":
                    dic = DataProcess.CreateVirgo();
                    label1.Text = "我是處女座\n" + dic[luckynum];
                    break;
                case "天秤座":
                    dic = DataProcess.CreateLibra();
                    label1.Text = "我是天秤座\n" + dic[luckynum];
                    break;
                case "天蠍座":
                    dic = DataProcess.CreateScorpio();
                    label1.Text = "我是天蠍座\n" + dic[luckynum];
                    break;
                case "射手座":
                    dic = DataProcess.CreateSagittarius();
                    label1.Text = "我是射手座\n" + dic[luckynum];
                    break;
                case "摩羯座":
                    dic = DataProcess.CreateCapricorn();
                    label1.Text = "我是摩羯座\n" + dic[luckynum];
                    break;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Text.Replace("年", ",").Replace("月", ",").Replace("日", ",").Split(',');
            ComputeNum();
            show();
        }
    }
}
