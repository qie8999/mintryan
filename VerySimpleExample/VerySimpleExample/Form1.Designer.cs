﻿
namespace VerySimpleExample
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.텍박출력 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label_nowTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_second = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(41, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "MessageBox 출력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 텍박출력
            // 
            this.텍박출력.Location = new System.Drawing.Point(41, 57);
            this.텍박출력.Name = "텍박출력";
            this.텍박출력.Size = new System.Drawing.Size(104, 28);
            this.텍박출력.TabIndex = 1;
            this.텍박출력.Text = "텍박출력";
            this.텍박출력.UseVisualStyleBackColor = true;
            this.텍박출력.Click += new System.EventHandler(this.텍박출력_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "현재 시간";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(170, 57);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(100, 21);
            this.textBox_message.TabIndex = 3;
            // 
            // label_nowTime
            // 
            this.label_nowTime.AutoSize = true;
            this.label_nowTime.Location = new System.Drawing.Point(296, 94);
            this.label_nowTime.Name = "label_nowTime";
            this.label_nowTime.Size = new System.Drawing.Size(11, 12);
            this.label_nowTime.TabIndex = 4;
            this.label_nowTime.Text = "-";
            this.label_nowTime.Click += new System.EventHandler(this.label_nowTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "프로그램이 시작되고 나서";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "초 경과";
            // 
            // label_second
            // 
            this.label_second.AutoSize = true;
            this.label_second.Location = new System.Drawing.Point(198, 176);
            this.label_second.Name = "label_second";
            this.label_second.Size = new System.Drawing.Size(11, 12);
            this.label_second.TabIndex = 7;
            this.label_second.Text = "0";
            this.label_second.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(39, 303);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(36, 12);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "naver";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(39, 343);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(21, 12);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "KB";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "현재";
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Location = new System.Drawing.Point(77, 209);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(11, 12);
            this.label_s.TabIndex = 11;
            this.label_s.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "초 경과";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_second);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_nowTime);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.텍박출력);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button 텍박출력;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Label label_nowTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_second;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
    }
}

