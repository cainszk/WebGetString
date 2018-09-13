namespace WebGetString
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn4get = new System.Windows.Forms.Button();
            this.txt4url = new System.Windows.Forms.TextBox();
            this.txt4show = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ck4auto = new System.Windows.Forms.CheckBox();
            this.t1int = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn4substr = new System.Windows.Forms.Button();
            this.txt4sub0 = new System.Windows.Forms.TextBox();
            this.txt4sub0x = new System.Windows.Forms.TextBox();
            this.txt4sub0y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn4get
            // 
            this.btn4get.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4get.Location = new System.Drawing.Point(788, 498);
            this.btn4get.Name = "btn4get";
            this.btn4get.Size = new System.Drawing.Size(211, 41);
            this.btn4get.TabIndex = 0;
            this.btn4get.Text = "获取源代码";
            this.btn4get.UseVisualStyleBackColor = true;
            this.btn4get.Click += new System.EventHandler(this.btn4get_Click);
            // 
            // txt4url
            // 
            this.txt4url.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4url.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt4url.Location = new System.Drawing.Point(60, 12);
            this.txt4url.Name = "txt4url";
            this.txt4url.Size = new System.Drawing.Size(468, 29);
            this.txt4url.TabIndex = 1;
            this.txt4url.Text = "https://www.feixiaohao.com/currencies/bitcoin/";
            this.txt4url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4show
            // 
            this.txt4show.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4show.Location = new System.Drawing.Point(12, 47);
            this.txt4show.Multiline = true;
            this.txt4show.Name = "txt4show";
            this.txt4show.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt4show.Size = new System.Drawing.Size(516, 492);
            this.txt4show.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ck4auto
            // 
            this.ck4auto.AutoSize = true;
            this.ck4auto.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ck4auto.Location = new System.Drawing.Point(754, 457);
            this.ck4auto.Name = "ck4auto";
            this.ck4auto.Size = new System.Drawing.Size(93, 25);
            this.ck4auto.TabIndex = 3;
            this.ck4auto.Text = "自动获取";
            this.ck4auto.UseVisualStyleBackColor = true;
            this.ck4auto.CheckStateChanged += new System.EventHandler(this.ck4auto_CheckStateChanged);
            // 
            // t1int
            // 
            this.t1int.Enabled = false;
            this.t1int.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.t1int.ForeColor = System.Drawing.Color.Black;
            this.t1int.Location = new System.Drawing.Point(942, 455);
            this.t1int.Name = "t1int";
            this.t1int.Size = new System.Drawing.Size(30, 29);
            this.t1int.TabIndex = 4;
            this.t1int.Text = "1";
            this.t1int.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1int.TextChanged += new System.EventHandler(this.t1int_TextChanged);
            this.t1int.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t1int_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(551, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "前标志：";
            // 
            // btn4substr
            // 
            this.btn4substr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4substr.Location = new System.Drawing.Point(788, 193);
            this.btn4substr.Name = "btn4substr";
            this.btn4substr.Size = new System.Drawing.Size(211, 41);
            this.btn4substr.TabIndex = 6;
            this.btn4substr.Text = "截取字段";
            this.btn4substr.UseVisualStyleBackColor = true;
            this.btn4substr.Click += new System.EventHandler(this.btn4substr_Click);
            // 
            // txt4sub0
            // 
            this.txt4sub0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4sub0.ForeColor = System.Drawing.Color.Black;
            this.txt4sub0.Location = new System.Drawing.Point(642, 144);
            this.txt4sub0.Name = "txt4sub0";
            this.txt4sub0.Size = new System.Drawing.Size(357, 29);
            this.txt4sub0.TabIndex = 7;
            this.txt4sub0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4sub0x
            // 
            this.txt4sub0x.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4sub0x.ForeColor = System.Drawing.Color.Black;
            this.txt4sub0x.Location = new System.Drawing.Point(642, 53);
            this.txt4sub0x.Name = "txt4sub0x";
            this.txt4sub0x.Size = new System.Drawing.Size(357, 29);
            this.txt4sub0x.TabIndex = 8;
            this.txt4sub0x.Text = "<div class=coinprice>";
            this.txt4sub0x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4sub0y
            // 
            this.txt4sub0y.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt4sub0y.ForeColor = System.Drawing.Color.Black;
            this.txt4sub0y.Location = new System.Drawing.Point(642, 97);
            this.txt4sub0y.Name = "txt4sub0y";
            this.txt4sub0y.Size = new System.Drawing.Size(357, 29);
            this.txt4sub0y.TabIndex = 9;
            this.txt4sub0y.Text = "<span class=tags";
            this.txt4sub0y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(551, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "后标志：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(551, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "截获内容：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(853, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "获取频率为        秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "网址：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt4sub0y);
            this.Controls.Add(this.txt4sub0x);
            this.Controls.Add(this.txt4sub0);
            this.Controls.Add(this.btn4substr);
            this.Controls.Add(this.t1int);
            this.Controls.Add(this.ck4auto);
            this.Controls.Add(this.txt4show);
            this.Controls.Add(this.txt4url);
            this.Controls.Add(this.btn4get);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web源代码获取&提取工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn4get;
        private System.Windows.Forms.TextBox txt4url;
        private System.Windows.Forms.TextBox txt4show;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ck4auto;
        private System.Windows.Forms.TextBox t1int;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn4substr;
        private System.Windows.Forms.TextBox txt4sub0;
        private System.Windows.Forms.TextBox txt4sub0x;
        private System.Windows.Forms.TextBox txt4sub0y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

