namespace halcon_chepai
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.threshold_up = new System.Windows.Forms.TrackBar();
            this.area_down = new System.Windows.Forms.TrackBar();
            this.threhold_up_label = new System.Windows.Forms.Label();
            this.area_down_label = new System.Windows.Forms.Label();
            this.area_up_label = new System.Windows.Forms.Label();
            this.area_up = new System.Windows.Forms.TrackBar();
            this.threhold_down_label = new System.Windows.Forms.Label();
            this.threshold_down = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshold_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshold_down)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 563);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(596, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "C:/Users/Administrator/Desktop/halcon/chepai4.jpg";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // threshold_up
            // 
            this.threshold_up.Location = new System.Drawing.Point(596, 284);
            this.threshold_up.Maximum = 255;
            this.threshold_up.Name = "threshold_up";
            this.threshold_up.Size = new System.Drawing.Size(301, 69);
            this.threshold_up.TabIndex = 3;
            this.threshold_up.Scroll += new System.EventHandler(this.threshold_up_Scroll);
            // 
            // area_down
            // 
            this.area_down.Location = new System.Drawing.Point(596, 394);
            this.area_down.Maximum = 5000;
            this.area_down.Name = "area_down";
            this.area_down.Size = new System.Drawing.Size(301, 69);
            this.area_down.TabIndex = 4;
            this.area_down.Scroll += new System.EventHandler(this.area_down_Scroll);
            // 
            // threhold_up_label
            // 
            this.threhold_up_label.AutoSize = true;
            this.threhold_up_label.Location = new System.Drawing.Point(605, 247);
            this.threhold_up_label.Name = "threhold_up_label";
            this.threhold_up_label.Size = new System.Drawing.Size(116, 18);
            this.threhold_up_label.TabIndex = 5;
            this.threhold_up_label.Text = "阈值（上限）";
            // 
            // area_down_label
            // 
            this.area_down_label.AutoSize = true;
            this.area_down_label.Location = new System.Drawing.Point(605, 373);
            this.area_down_label.Name = "area_down_label";
            this.area_down_label.Size = new System.Drawing.Size(152, 18);
            this.area_down_label.TabIndex = 6;
            this.area_down_label.Text = "车牌面积（下限）";
            // 
            // area_up_label
            // 
            this.area_up_label.AutoSize = true;
            this.area_up_label.Location = new System.Drawing.Point(605, 466);
            this.area_up_label.Name = "area_up_label";
            this.area_up_label.Size = new System.Drawing.Size(152, 18);
            this.area_up_label.TabIndex = 8;
            this.area_up_label.Text = "车牌面积（上限）";
            // 
            // area_up
            // 
            this.area_up.Location = new System.Drawing.Point(596, 487);
            this.area_up.Maximum = 20000;
            this.area_up.Name = "area_up";
            this.area_up.Size = new System.Drawing.Size(301, 69);
            this.area_up.TabIndex = 7;
            this.area_up.Scroll += new System.EventHandler(this.area_up_Scroll);
            // 
            // threhold_down_label
            // 
            this.threhold_down_label.AutoSize = true;
            this.threhold_down_label.Location = new System.Drawing.Point(605, 138);
            this.threhold_down_label.Name = "threhold_down_label";
            this.threhold_down_label.Size = new System.Drawing.Size(116, 18);
            this.threhold_down_label.TabIndex = 10;
            this.threhold_down_label.Text = "阈值（下限）";
            // 
            // threshold_down
            // 
            this.threshold_down.Location = new System.Drawing.Point(596, 175);
            this.threshold_down.Maximum = 255;
            this.threshold_down.Name = "threshold_down";
            this.threshold_down.Size = new System.Drawing.Size(301, 69);
            this.threshold_down.TabIndex = 9;
            this.threshold_down.Scroll += new System.EventHandler(this.threshold_down_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(376, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "结果";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 600);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(329, 308);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "识别结果";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "可信度";
            this.columnHeader2.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 962);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.threhold_down_label);
            this.Controls.Add(this.threshold_down);
            this.Controls.Add(this.area_up_label);
            this.Controls.Add(this.area_up);
            this.Controls.Add(this.area_down_label);
            this.Controls.Add(this.threhold_up_label);
            this.Controls.Add(this.area_down);
            this.Controls.Add(this.threshold_up);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshold_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.area_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshold_down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar threshold_up;
        private System.Windows.Forms.TrackBar area_down;
        private System.Windows.Forms.Label threhold_up_label;
        private System.Windows.Forms.Label area_down_label;
        private System.Windows.Forms.Label area_up_label;
        private System.Windows.Forms.TrackBar area_up;
        private System.Windows.Forms.Label threhold_down_label;
        private System.Windows.Forms.TrackBar threshold_down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

