namespace Tutorial07
{
    partial class DieRollWindowApp
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
            this.dieLabel1 = new System.Windows.Forms.Label();
            this.dieLabel2 = new System.Windows.Forms.Label();
            this.dieLabel3 = new System.Windows.Forms.Label();
            this.dieLabel4 = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.dieLabel5 = new System.Windows.Forms.Label();
            this.dieLabel6 = new System.Windows.Forms.Label();
            this.dieLabel12 = new System.Windows.Forms.Label();
            this.dieLabel11 = new System.Windows.Forms.Label();
            this.dieLabel10 = new System.Windows.Forms.Label();
            this.dieLabel9 = new System.Windows.Forms.Label();
            this.dieLabel8 = new System.Windows.Forms.Label();
            this.dieLabel7 = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dieLabel1
            // 
            this.dieLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel1.Location = new System.Drawing.Point(200, 60);
            this.dieLabel1.Name = "dieLabel1";
            this.dieLabel1.Size = new System.Drawing.Size(60, 60);
            this.dieLabel1.TabIndex = 0;
            this.dieLabel1.Text = "label1";
            this.dieLabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dieLabel2
            // 
            this.dieLabel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dieLabel2.Location = new System.Drawing.Point(298, 60);
            this.dieLabel2.Name = "dieLabel2";
            this.dieLabel2.Size = new System.Drawing.Size(60, 60);
            this.dieLabel2.TabIndex = 1;
            this.dieLabel2.Text = "label2";
            // 
            // dieLabel3
            // 
            this.dieLabel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel3.Location = new System.Drawing.Point(397, 60);
            this.dieLabel3.Name = "dieLabel3";
            this.dieLabel3.Size = new System.Drawing.Size(60, 60);
            this.dieLabel3.TabIndex = 2;
            this.dieLabel3.Text = "label3";
            // 
            // dieLabel4
            // 
            this.dieLabel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel4.Location = new System.Drawing.Point(505, 60);
            this.dieLabel4.Name = "dieLabel4";
            this.dieLabel4.Size = new System.Drawing.Size(60, 60);
            this.dieLabel4.TabIndex = 3;
            this.dieLabel4.Text = "label4";
            this.dieLabel4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(411, 277);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(133, 53);
            this.rollButton.TabIndex = 4;
            this.rollButton.Text = "Roll!";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // dieLabel5
            // 
            this.dieLabel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel5.Location = new System.Drawing.Point(613, 60);
            this.dieLabel5.Name = "dieLabel5";
            this.dieLabel5.Size = new System.Drawing.Size(60, 60);
            this.dieLabel5.TabIndex = 5;
            this.dieLabel5.Text = "label4";
            // 
            // dieLabel6
            // 
            this.dieLabel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel6.Location = new System.Drawing.Point(715, 60);
            this.dieLabel6.Name = "dieLabel6";
            this.dieLabel6.Size = new System.Drawing.Size(60, 60);
            this.dieLabel6.TabIndex = 6;
            this.dieLabel6.Text = "label4";
            // 
            // dieLabel12
            // 
            this.dieLabel12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel12.Location = new System.Drawing.Point(715, 186);
            this.dieLabel12.Name = "dieLabel12";
            this.dieLabel12.Size = new System.Drawing.Size(60, 60);
            this.dieLabel12.TabIndex = 12;
            this.dieLabel12.Text = "label4";
            // 
            // dieLabel11
            // 
            this.dieLabel11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel11.Location = new System.Drawing.Point(613, 186);
            this.dieLabel11.Name = "dieLabel11";
            this.dieLabel11.Size = new System.Drawing.Size(60, 60);
            this.dieLabel11.TabIndex = 11;
            this.dieLabel11.Text = "label4";
            // 
            // dieLabel10
            // 
            this.dieLabel10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel10.Location = new System.Drawing.Point(505, 186);
            this.dieLabel10.Name = "dieLabel10";
            this.dieLabel10.Size = new System.Drawing.Size(60, 60);
            this.dieLabel10.TabIndex = 10;
            this.dieLabel10.Text = "label4";
            // 
            // dieLabel9
            // 
            this.dieLabel9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel9.Location = new System.Drawing.Point(397, 186);
            this.dieLabel9.Name = "dieLabel9";
            this.dieLabel9.Size = new System.Drawing.Size(60, 60);
            this.dieLabel9.TabIndex = 9;
            this.dieLabel9.Text = "label3";
            // 
            // dieLabel8
            // 
            this.dieLabel8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dieLabel8.Location = new System.Drawing.Point(298, 186);
            this.dieLabel8.Name = "dieLabel8";
            this.dieLabel8.Size = new System.Drawing.Size(60, 60);
            this.dieLabel8.TabIndex = 8;
            this.dieLabel8.Text = "label2";
            // 
            // dieLabel7
            // 
            this.dieLabel7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dieLabel7.Location = new System.Drawing.Point(200, 186);
            this.dieLabel7.Name = "dieLabel7";
            this.dieLabel7.Size = new System.Drawing.Size(60, 60);
            this.dieLabel7.TabIndex = 7;
            this.dieLabel7.Text = "label1";
            this.dieLabel7.Click += new System.EventHandler(this.label8_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(202, 395);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(573, 165);
            this.displayTextBox.TabIndex = 13;
            this.displayTextBox.Text = "";
            // 
            // DieRollWindowApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 606);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.dieLabel12);
            this.Controls.Add(this.dieLabel11);
            this.Controls.Add(this.dieLabel10);
            this.Controls.Add(this.dieLabel9);
            this.Controls.Add(this.dieLabel8);
            this.Controls.Add(this.dieLabel7);
            this.Controls.Add(this.dieLabel6);
            this.Controls.Add(this.dieLabel5);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.dieLabel4);
            this.Controls.Add(this.dieLabel3);
            this.Controls.Add(this.dieLabel2);
            this.Controls.Add(this.dieLabel1);
            this.Name = "DieRollWindowApp";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dieLabel1;
        private System.Windows.Forms.Label dieLabel2;
        private System.Windows.Forms.Label dieLabel3;
        private System.Windows.Forms.Label dieLabel4;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label dieLabel5;
        private System.Windows.Forms.Label dieLabel6;
        private System.Windows.Forms.Label dieLabel12;
        private System.Windows.Forms.Label dieLabel11;
        private System.Windows.Forms.Label dieLabel10;
        private System.Windows.Forms.Label dieLabel9;
        private System.Windows.Forms.Label dieLabel8;
        private System.Windows.Forms.Label dieLabel7;
        private System.Windows.Forms.RichTextBox displayTextBox;
    }
}

