using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_241217
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] stringArray = new string[10];

            // 1
            string message = "동해 물과 백두산이";
            string keyword = "백두산";
            int index1 = message.IndexOf(keyword);
            stringArray[0] = index1.ToString();

            // 2
            message = "토요일에 먹는 토마토";
            keyword = "토";
            int index2 = message.LastIndexOf(keyword);
            stringArray[1] = index2.ToString();


            // 3
            string orderlyExit = "질서 있는 퇴장";
            string exit = "퇴";
            bool index3 = orderlyExit.Contains(exit);
            stringArray[2] = index3.ToString();


            // 4
            string personShadow = "그 사람의 그림자는 그랬다.";
            stringArray[3] = personShadow.Replace("그", "이");

            //5
            string samsungGalaxy = "삼성 갤럭시";
            string updatedSamsungGalaxy = samsungGalaxy.Insert(3, " 애플");

            //6
            string todayHungry = "오늘은 왠지 더 배고프다";
            int index = todayHungry.IndexOf("더");
            if (index != -1)
            {
                string updatedTodayHungry = todayHungry.Remove(index, 1);
            }

            //7
            

            //8
            string nationalAnthem = "우리 나라 만세";

            string korea = nationalAnthem.Substring(3, 2);

            textBox_print.Text = stringArray[0]+ "\r\n";
            textBox_print.Text += stringArray[1];

        }
    }
}
