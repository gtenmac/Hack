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
                    dic = CreateAquarius();
                    label1.Text = dic[luckynum];
                    break;
                case "雙魚座":
                    dic = CreatePieces();
                    label1.Text = dic[luckynum];
                    break;
                case "牡羊座":
                    dic = CreateAries();
                    label1.Text = dic[luckynum];
                    break;
                case "金牛座":
                    dic = CreateTaurus();
                    label1.Text = dic[luckynum];
                    break;
                case "雙子座":
                    dic = CreateGemini();
                    label1.Text = dic[luckynum];
                    break;
                case "巨蟹座":
                    dic = CreateCancer();
                    label1.Text = dic[luckynum];
                    break;
                case "獅子座":
                    dic = CreateLeo();
                    label1.Text = dic[luckynum];
                    break;
                case "處女座":
                    dic = CreateVirgo();
                    label1.Text = dic[luckynum];
                    break;
                case "天秤座":
                    dic = CreateLibra();
                    label1.Text = dic[luckynum];
                    break;
                case "天蠍座":
                    dic = CreateScorpio();
                    label1.Text = dic[luckynum];
                    break;
                case "射手座":
                    dic = CreateSagittarius();
                    label1.Text = dic[luckynum];
                    break;
                case "摩羯座":
                    dic = CreateCapricorn();
                    label1.Text = dic[luckynum];
                    break;
            }
        }
        /// <summary>
        /// 牡羊座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateAries()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你是個主觀很強的人，只想著自己想做的事。");
            result.Add(2, "你會在意別人看你的眼光，個性比較害羞一點。");
            result.Add(3, "喜歡錶達自己的想法，但也要多聽聽別人的意見哦！");
            result.Add(4, "你對未來很關心，很少胡思亂想，會腳踏實地的努力。");
            result.Add(5, "最愛玩的Aries牧羊非你莫屬，尤其喜歡到處去湊熱鬧。");
            result.Add(6, "你很固執哦！尤其是感情層面，而且非常的主觀。");
            result.Add(7, "對於自己覺得有理的地方非常的堅持，不聽別人的意見。");
            result.Add(8, "很重視實際層面的成就，會很努力在學習和工作上。");
            result.Add(9, "你是較不切實際的人，不過你的熱情可將不可能變可能。");
            return result;
        }

        /// <summary>
        /// 金牛座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateTaurus()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你的行動力很強，對事自有一套，做法也不喜歡受干涉。");
            result.Add(2, "你會重視人際關係，在與別人相處時也比較容易受影響。");
            result.Add(3, "你是牛座中比較靈活的，喜歡發表自己所研究出來的事物。");
            result.Add(4, "你是牛座中最固執的哦！你的想法常常和別人不太一樣。");
            result.Add(5, "你是一隻多才多藝的牛，如果能夠定下來會更有成就。");
            result.Add(6, "你是最念舊的牛座，對於自己重視的東西會非常呵護。");
            result.Add(7, "你是有叛逆性格的牛牛，不易被別人說服，自有一套想法。");
            result.Add(8, "你很重視實際層面的成就，會努力讓自己更加的優秀或成功。");
            result.Add(9, "你是牛座中最有夢想的，但是要多學習如何落實在現實中。");
            return result;
        }

        /// <summary>
        /// 雙子座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateGemini()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "喜歡自由自在的你，對於自己有興趣的事情都會去鑽研哦！");
            result.Add(2, "你是最喜歡與別人溝通的Gemini雙子座，不過很容易受外來的影響。");
            result.Add(3, "你真的是Gemini雙子座中最為多才多藝的，什麼東西都是一學就會。");
            result.Add(4, "你是比較重視生活規律的人，看來隨和但自有一套規則。");
            result.Add(5, "喜歡到處亂跑的你真是交友滿天下，心性上也比較不穩定。");
            result.Add(6, "你是Gemini雙子中最重視人情味的，尤其重視老朋友之間的感情。");
            result.Add(7, "你是Gemini雙子中最刁鑽古怪的，常想些別人都不會想到的問題。");
            result.Add(8, "你喜歡享受生活，會特別的注重自己的生活品質。");
            result.Add(9, "你是Gemini雙子中最會胡思亂想的，同時也是比較熱情的。");
            return result;
        }

        /// <summary>
        /// 巨蟹座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateCancer()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你個性上有點自閉哦！不容易真正和別人有好的交流。");
            result.Add(2, "會很看重別人的意見，要小心因此喪失自己的意見。");
            result.Add(3, "喜歡感情上的表達與溝通，在藝術上會有不錯的天份哩！");
            result.Add(4, "你是蟹子中比較龜毛的，尤其重視自己生活上的規律。");
            result.Add(5, "你不一定喜歡亂跑，但不能受到太多拘束，想自由自在。");
            result.Add(6, "你是蟹座中最重感情的，尤其在感情世界里很要求完美。");
            result.Add(7, "你是蟹子中想得最多的，表現出來的模樣也頗為固執己見。");
            result.Add(8, "你很重視現實上的成就與穩定，會努力讓自己的生活更好。");
            result.Add(9, "你是蟹子中相當熱情的，但剛到新的環境會比較害羞。");
            return result;
        }

        /// <summary>
        /// 獅子座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateLeo()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你是Leo獅子座中最為自我的，但可能因此造成人際問題。");
            result.Add(2, "別人的肯定對你來說非常重要，可能因此而失去自我。");
            result.Add(3, "你是Leo獅子座中最愛表現自己的，通常是人際關係中的佼佼者。");
            result.Add(4, "你是只固執的Leo獅子，而且在行動上比較缺乏冒險犯難的精神。");
            result.Add(5, "Leo獅子中最熱愛自由的就是你啦！一般來說你們是相當大方的。");
            result.Add(6, "你是Leo獅子座中比較龜毛的，尤其是感情的表達上會顯得害羞。");
            result.Add(7, "你是很會想的Leo獅子座哦！雖然比較主觀，但還可以溝通。");
            result.Add(8, "你是一個講究生活品味的人哦！喜歡從容優渥的過日子。");
            result.Add(9, "你的熱情很容易感動別人，在人群中常是人氣很旺的明星哩！");
            return result;
        }

        /// <summary>
        /// 處女座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateVirgo()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你有點孤僻，常常覺得別人不了解你，要多與別人互動才好。");
            result.Add(2, "你會很注重每個人的意見，與別人來往時也是非常誠懇的。");
            result.Add(3, "能力頗佳的你，適合擔任發言或主持的任務，會勝任愉快哦！");
            result.Add(4, "你是Virgo處女座中最為 ? t毛的，尤其容易劃地自限，要特別注意。");
            result.Add(5, "你是屬於比較外向的，容易交到許多朋友，但知心的並不多。");
            result.Add(6, "你是非常非常念舊的人哦！尤其是感情上，常常很難割捨。");
            result.Add(7, "你的個性比較剛直，不過在與人交往上還是要多體諒別人哦！");
            result.Add(8, "你是比較圓滑的人，很了解人際上的交流要如何互動。");
            result.Add(9, "對你投入的事情非常的狂熱，有時甚至因此而廢寢忘食。");
            return result;
        }

        /// <summary>
        /// 天秤座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateLibra()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你是秤子中比較獨立的，在決定事情時也比較不會猶豫不決。");
            result.Add(2, "在秤子中你是最需要別人陪伴的，如果沒有伴會感到不安。");
            result.Add(3, "你是秤子中最有才華的，在各項藝術領域都有不錯的天份。");
            result.Add(4, "你是秤子中最為重視實際層面的，也是比較有責任感的哦！");
            result.Add(5, "你是一隻喜愛交遊的Libra天秤，對感到好玩的事情都不會放過。");
            result.Add(6, "感情的順利與否對你來說非常重要哦！要小心的經營才好。");
            result.Add(7, "你是秤子中最喜歡思考的，對許多事都會找出合理的方法。");
            result.Add(8, "很重視生活的感覺，不能忍受太差的生活環境，有雅癖傾向。");
            result.Add(9, "你許多想法都有些不切實際，而且熱情常常無法持久哦！");
            return result;
        }


        /// <summary>
        /// 天蠍座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateScorpio()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你很重視自己的目標，不太理睬身邊其他人在做些什麼。");
            result.Add(2, "你很在乎兩人關係上的忠誠，會全心全意的對待另一半。");
            result.Add(3, "對於溝通與人際關係是你的專長，總能夠得到大家幫助。");
            result.Add(4, "你是非常非常固執的，一旦你決定的事就難以改變。");
            result.Add(5, "你是蠍子中最開朗的，也是最容易與大家打成一片的。");
            result.Add(6, "你是個完美主義者，尤其是非常重視感情方面的經營。");
            result.Add(7, "你想的很多，常想到一些別人找不到的問題，非常聰明。");
            result.Add(8, "你很重視自己的地社會地位，認為應該得到的就會去爭取。");
            result.Add(9, "對於你喜歡或相信的事是非常狂熱的，但表面上看不出來。");
            return result;
        }

        /// <summary>
        /// 射手座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateSagittarius()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你常常我行我素，一有目標就會很快去執行，行動力很強。");
            result.Add(2, "喜歡與別人溝通相處的你，在人際上會得到大家的幫忙。");
            result.Add(3, "你是相當有才華的人哦！很能夠表現自己在藝術上的才華。");
            result.Add(4, "你是Sagittarius射手座中最重視生活規律的，而且也很有自己的想法。");
            result.Add(5, "哇！你真是超愛亂跑，一直待在同一個地方會讓你很難過。");
            result.Add(6, "你是很重視親情的人哦！在人際交流上也是很有一套的。");
            result.Add(7, "你真是想得太多，又有點固執的人，懷疑的心態很強哦！");
            result.Add(8, "你很重視自己的成就和外在的表現，喜歡富裕的生活環境。");
            result.Add(9, "你是很有理想的人，也是舉辦活動的高手，受到大家歡迎！");
            return result;
        }

        /// <summary>
        /// 摩羯座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateCapricorn()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你的自尊心很強哦！會默默的努力讓自己有所成就。");
            result.Add(2, "你覺得與人交遊是件重要的事，另外感情也是生活重心。");
            result.Add(3, "只要你多加努力就能展現出自己的才華，會很有成就哦！");
            result.Add(4, "你很重視腳踏實地的生活，會努力讓自己生活穩定下來。");
            result.Add(5, "你是Capricorn摩羯座中比較開朗的，對一些事比較不會那麼憂慮。");
            result.Add(6, "感情是你生活平穩的重點，希望經營有未來的感情生活。");
            result.Add(7, "你是一個非常聰明的人，但有時會因情緒化而下錯判斷。");
            result.Add(8, "對你來說功成名就吸引力大，會努力成為重要的人物。");
            result.Add(9, "你對自己想做的事非常投入，不過有時會忘了實際狀況。");
            return result;
        }

        /// <summary>
        /// 水瓶座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreateAquarius()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你是瓶子座中最自閉的，有時候會顯得太過我行我素了些。");
            result.Add(2, "你會比較受到別人的影響，但還不會失去自己原本的主張。");
            result.Add(3, "你是一隻多才多藝的瓶子哩！尤其擅長於表達與溝通哦！");
            result.Add(4, "你是瓶子中比較穩定的，會習慣維持某一種生活的方式。");
            result.Add(5, "常常讓人找不到的就是你這種瓶子啦！朋友也是多不勝數。");
            result.Add(6, "你是比較重感情的瓶子，也比較桃花，感情問題會比較多。");
            result.Add(7, "你是瓶子中最為理性的，太過聰明的話有時候會不近人情。");
            result.Add(8, "你是瓶子中比較重視物質的，會去追求自己所想要的生活。");
            result.Add(9, "你的理想非常高遠，如果持續努力，成功的機會是很大的。");

            return result;
        }

        /// <summary>
        /// 雙魚座生命靈數
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, string> CreatePieces()
        {
            var result = new Dictionary<int, string>();
            result.Add(1, "你容易沉溺在自己的世界的，忘掉了身邊還有別人存在。");
            result.Add(2, "你很容易受到別人的引導，而忘記了自己原本的方向哦！");
            result.Add(3, "你是天生的藝術家，不過還是要稍為注意一下現實環境。");
            result.Add(4, "你是追求穩定生活的魚座，不喜歡太過混亂的生活。");
            result.Add(5, "你比較沒有目標，幾乎什麼事都會去做做看，但都維持不久。");
            result.Add(6, "感情是你最煩惱的事，常常因此而受到打擊或挫折。");
            result.Add(7, "你想得很多，但是一旦遇到自己的事情就會比較主觀。");
            result.Add(8, "你是喜歡享受的魚座，對於生活上的小事都非常的注意。");
            result.Add(9, "你對於某些事都抱著很大的熱誠，過度的話會顯得特別偏執。");

            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Text.Replace("年", ",").Replace("月", ",").Replace("日", ",").Split(',');
            ComputeNum();
            show();
        }
    }
}
