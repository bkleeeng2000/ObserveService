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
            this.button1.Location = new System.Drawing.Point(129, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "AllKill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
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
    }
}

