namespace ObserveService
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
            this.ServicaA_On = new System.Windows.Forms.Button();
            this.ServiceA_Off = new System.Windows.Forms.Button();
            this.ServiceB_On = new System.Windows.Forms.Button();
            this.ServiceB_Off = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceA_Status = new System.Windows.Forms.Label();
            this.ServiceB_Status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServicaA_On
            // 
            this.ServicaA_On.Location = new System.Drawing.Point(12, 130);
            this.ServicaA_On.Name = "ServicaA_On";
            this.ServicaA_On.Size = new System.Drawing.Size(75, 23);
            this.ServicaA_On.TabIndex = 0;
            this.ServicaA_On.Text = "On";
            this.ServicaA_On.UseVisualStyleBackColor = true;
            this.ServicaA_On.Click += new System.EventHandler(this.ServicaA_On_Click);
            // 
            // ServiceA_Off
            // 
            this.ServiceA_Off.Location = new System.Drawing.Point(12, 159);
            this.ServiceA_Off.Name = "ServiceA_Off";
            this.ServiceA_Off.Size = new System.Drawing.Size(75, 23);
            this.ServiceA_Off.TabIndex = 1;
            this.ServiceA_Off.Text = "Off";
            this.ServiceA_Off.UseVisualStyleBackColor = true;
            this.ServiceA_Off.Click += new System.EventHandler(this.ServiceA_Off_Click);
            // 
            // ServiceB_On
            // 
            this.ServiceB_On.Location = new System.Drawing.Point(181, 130);
            this.ServiceB_On.Name = "ServiceB_On";
            this.ServiceB_On.Size = new System.Drawing.Size(75, 23);
            this.ServiceB_On.TabIndex = 2;
            this.ServiceB_On.Text = "On";
            this.ServiceB_On.UseVisualStyleBackColor = true;
            this.ServiceB_On.Click += new System.EventHandler(this.ServiceB_On_Click);
            // 
            // ServiceB_Off
            // 
            this.ServiceB_Off.Location = new System.Drawing.Point(181, 159);
            this.ServiceB_Off.Name = "ServiceB_Off";
            this.ServiceB_Off.Size = new System.Drawing.Size(75, 23);
            this.ServiceB_Off.TabIndex = 3;
            this.ServiceB_Off.Text = "Off";
            this.ServiceB_Off.UseVisualStyleBackColor = true;
            this.ServiceB_Off.Click += new System.EventHandler(this.ServiceB_Off_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ServiceA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "ServiceB";
            // 
            // ServiceA_Status
            // 
            this.ServiceA_Status.AutoSize = true;
            this.ServiceA_Status.Location = new System.Drawing.Point(93, 150);
            this.ServiceA_Status.Name = "ServiceA_Status";
            this.ServiceA_Status.Size = new System.Drawing.Size(40, 12);
            this.ServiceA_Status.TabIndex = 6;
            this.ServiceA_Status.Text = "Status";
            // 
            // ServiceB_Status
            // 
            this.ServiceB_Status.AutoSize = true;
            this.ServiceB_Status.Location = new System.Drawing.Point(264, 150);
            this.ServiceB_Status.Name = "ServiceB_Status";
            this.ServiceB_Status.Size = new System.Drawing.Size(40, 12);
            this.ServiceB_Status.TabIndex = 7;
            this.ServiceB_Status.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "AllKill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 191);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(124, 132);
            this.checkedListBox1.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 16);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 16);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(142, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 132);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Location = new System.Drawing.Point(244, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 132);
            this.panel2.TabIndex = 13;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(92, 16);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Count : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 335);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ServiceB_Status);
            this.Controls.Add(this.ServiceA_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceB_Off);
            this.Controls.Add(this.ServiceB_On);
            this.Controls.Add(this.ServiceA_Off);
            this.Controls.Add(this.ServicaA_On);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ServicaA_On;
        private System.Windows.Forms.Button ServiceA_Off;
        private System.Windows.Forms.Button ServiceB_On;
        private System.Windows.Forms.Button ServiceB_Off;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ServiceA_Status;
        private System.Windows.Forms.Label ServiceB_Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

