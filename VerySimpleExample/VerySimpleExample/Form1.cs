using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerySimpleExample
{
    public partial class Form1 : Form
    {
        int countTime = 0;
        int cTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요^^~");
        }

        private void 텍박출력_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;
            MessageBox.Show($"내가 빈칸에 적은 말은{message}이다");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_nowTime.Text = $"{DateTime.Now.Year}년 " +
                $"{DateTime.Now.Month}월 {DateTime.Now.Day} 일 " +
                $"{DateTime.Now.Hour}시 {DateTime.Now.Minute}분 " +
                $"{DateTime.Now.Second}초";
        }

        private void label_nowTime_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //내가 지정한 interval에 한번씩 동작
            //여기에선 1000ms에 한번씩 동작
            label_second.Text = countTime.ToString();
            countTime++;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //1초에 한번씩 lable_s의 Text값을 바꾸는 것
            label_s.Text = countTime.ToString();
            cTime++;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.naver.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://kb.or.kr");

        }
    }
}
