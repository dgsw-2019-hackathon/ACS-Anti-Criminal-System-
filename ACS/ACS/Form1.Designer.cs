namespace ACS
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
            this.main_lv = new System.Windows.Forms.ListView();
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.now_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doublemod_bt = new System.Windows.Forms.Button();
            this.pause_bt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.time_lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // main_lv
            // 
            this.main_lv.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.main_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.count,
            this.time});
            this.main_lv.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.main_lv.FullRowSelect = true;
            this.main_lv.GridLines = true;
            this.main_lv.Location = new System.Drawing.Point(12, 58);
            this.main_lv.Name = "main_lv";
            this.main_lv.Size = new System.Drawing.Size(355, 217);
            this.main_lv.TabIndex = 0;
            this.main_lv.UseCompatibleStateImageBehavior = false;
            this.main_lv.View = System.Windows.Forms.View.Details;
            // 
            // count
            // 
            this.count.Text = "회수";
            // 
            // time
            // 
            this.time.Text = "발생 시간";
            this.time.Width = 287;
            // 
            // now_tb
            // 
            this.now_tb.Location = new System.Drawing.Point(433, 93);
            this.now_tb.Name = "now_tb";
            this.now_tb.ReadOnly = true;
            this.now_tb.Size = new System.Drawing.Size(118, 21);
            this.now_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "시간 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "현상황 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F);
            this.label4.Location = new System.Drawing.Point(136, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "ACS(Anti-Criminal System)";
            // 
            // doublemod_bt
            // 
            this.doublemod_bt.Location = new System.Drawing.Point(433, 205);
            this.doublemod_bt.Name = "doublemod_bt";
            this.doublemod_bt.Size = new System.Drawing.Size(118, 29);
            this.doublemod_bt.TabIndex = 9;
            this.doublemod_bt.Text = "집중 감시/해제";
            this.doublemod_bt.UseVisualStyleBackColor = true;
            this.doublemod_bt.Click += new System.EventHandler(this.Doublemod_bt_Click);
            // 
            // pause_bt
            // 
            this.pause_bt.Location = new System.Drawing.Point(433, 246);
            this.pause_bt.Name = "pause_bt";
            this.pause_bt.Size = new System.Drawing.Size(118, 29);
            this.pause_bt.TabIndex = 10;
            this.pause_bt.Text = "감시 중단";
            this.pause_bt.UseVisualStyleBackColor = true;
            this.pause_bt.Click += new System.EventHandler(this.Pause_bt_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // time_lb
            // 
            this.time_lb.AutoSize = true;
            this.time_lb.Location = new System.Drawing.Point(438, 71);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(67, 12);
            this.time_lb.TabIndex = 11;
            this.time_lb.Text = "hh-mm-ss";
            this.time_lb.Click += new System.EventHandler(this.Time_lb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "포트 :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM12"});
            this.comboBox1.Location = new System.Drawing.Point(433, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 297);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.time_lb);
            this.Controls.Add(this.pause_bt);
            this.Controls.Add(this.doublemod_bt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.now_tb);
            this.Controls.Add(this.main_lv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView main_lv;
        private System.Windows.Forms.TextBox now_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button doublemod_bt;
        private System.Windows.Forms.Button pause_bt;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Label time_lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

