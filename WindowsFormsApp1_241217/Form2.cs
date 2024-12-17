using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_241217
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string Gongja = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";

            int index = Gongja.LastIndexOf(" -");
            string updateGongja = "";

            if (index != -1)
            {
                updateGongja = Gongja.Substring(0, index);
            }

            string temp_str = "";
            int index1 = updateGongja.IndexOf("얼마나");
            if (index1 != -1)
            {
                // 얼마나
                temp_str = updateGongja.Substring(index1, "얼마나".Length) + " ";
            }

            int index2 = updateGongja.IndexOf("천천히");
            if (index2 != -1)
            {
                // 얼마나 천천히
                temp_str += updateGongja.Substring(index2, "천천히".Length) + " ";
            }

            int index3 = updateGongja.IndexOf("가는지");
            if (index3 != -1)
            {
                // 얼마나 천천히 가는지
                temp_str += updateGongja.Substring(index3, "가는지".Length);
            }

            // 얼마나 천천히 가는지
            string[] wordsArray = temp_str.Split(' ');
            temp_str = temp_str.Replace(' ', ',');

            // textBox_print.Text = index.ToString();
            /*textBox_print.Text += wordsArray[0];
            textBox_print.Text += wordsArray[1];
            textBox_print.Text += wordsArray[2];*/
            textBox_print.Text = updateGongja + "\r\n";
            textBox_print.Text += wordsArray[0] + wordsArray[1] + wordsArray[2] + "\r\n";
            textBox_print.Text += temp_str;

        }
    }
}
