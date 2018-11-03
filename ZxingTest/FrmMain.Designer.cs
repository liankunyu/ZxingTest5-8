namespace ZxingTest
{
    partial class FrmMain
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
            this.btnGenQR = new System.Windows.Forms.Button();
            this.btnAnQR = new System.Windows.Forms.Button();
            this.QRlbl = new System.Windows.Forms.Label();
            this.textBoxQR = new System.Windows.Forms.TextBox();
            this.textBoxBar = new System.Windows.Forms.TextBox();
            this.Tiaolbl = new System.Windows.Forms.Label();
            this.btnAnBar = new System.Windows.Forms.Button();
            this.btnGenBar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenQR
            // 
            this.btnGenQR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenQR.Location = new System.Drawing.Point(430, 511);
            this.btnGenQR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenQR.Name = "btnGenQR";
            this.btnGenQR.Size = new System.Drawing.Size(157, 55);
            this.btnGenQR.TabIndex = 0;
            this.btnGenQR.Text = "生成二维码";
            this.btnGenQR.UseVisualStyleBackColor = true;
            this.btnGenQR.Click += new System.EventHandler(this.btnGenQR_Click);
            // 
            // btnAnQR
            // 
            this.btnAnQR.Location = new System.Drawing.Point(610, 511);
            this.btnAnQR.Name = "btnAnQR";
            this.btnAnQR.Size = new System.Drawing.Size(157, 55);
            this.btnAnQR.TabIndex = 3;
            this.btnAnQR.Text = "识别二维码";
            this.btnAnQR.UseVisualStyleBackColor = true;
            this.btnAnQR.Click += new System.EventHandler(this.btnAnQR_Click);
            // 
            // QRlbl
            // 
            this.QRlbl.AutoSize = true;
            this.QRlbl.Location = new System.Drawing.Point(426, 99);
            this.QRlbl.Name = "QRlbl";
            this.QRlbl.Size = new System.Drawing.Size(129, 20);
            this.QRlbl.TabIndex = 1;
            this.QRlbl.Text = "二维码信息：";
            this.QRlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxQR
            // 
            this.textBoxQR.Location = new System.Drawing.Point(580, 96);
            this.textBoxQR.Name = "textBoxQR";
            this.textBoxQR.Size = new System.Drawing.Size(160, 30);
            this.textBoxQR.TabIndex = 2;
            // 
            // textBoxBar
            // 
            this.textBoxBar.Location = new System.Drawing.Point(176, 96);
            this.textBoxBar.Name = "textBoxBar";
            this.textBoxBar.Size = new System.Drawing.Size(160, 30);
            this.textBoxBar.TabIndex = 5;
            // 
            // Tiaolbl
            // 
            this.Tiaolbl.AutoSize = true;
            this.Tiaolbl.Location = new System.Drawing.Point(29, 99);
            this.Tiaolbl.Name = "Tiaolbl";
            this.Tiaolbl.Size = new System.Drawing.Size(129, 20);
            this.Tiaolbl.TabIndex = 4;
            this.Tiaolbl.Text = "条形码信息：";
            this.Tiaolbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAnBar
            // 
            this.btnAnBar.Location = new System.Drawing.Point(204, 511);
            this.btnAnBar.Name = "btnAnBar";
            this.btnAnBar.Size = new System.Drawing.Size(157, 55);
            this.btnAnBar.TabIndex = 7;
            this.btnAnBar.Text = "识别条形码";
            this.btnAnBar.UseVisualStyleBackColor = true;
            this.btnAnBar.Click += new System.EventHandler(this.btnAnBar_Click);
            // 
            // btnGenBar
            // 
            this.btnGenBar.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenBar.Location = new System.Drawing.Point(26, 511);
            this.btnGenBar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenBar.Name = "btnGenBar";
            this.btnGenBar.Size = new System.Drawing.Size(157, 55);
            this.btnGenBar.TabIndex = 6;
            this.btnGenBar.Text = "生成条形码";
            this.btnGenBar.UseVisualStyleBackColor = true;
            this.btnGenBar.Click += new System.EventHandler(this.btnGenBar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(111, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(500, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 590);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnBar);
            this.Controls.Add(this.btnGenBar);
            this.Controls.Add(this.textBoxBar);
            this.Controls.Add(this.Tiaolbl);
            this.Controls.Add(this.btnAnQR);
            this.Controls.Add(this.textBoxQR);
            this.Controls.Add(this.QRlbl);
            this.Controls.Add(this.btnGenQR);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenQR;
        private System.Windows.Forms.Button btnAnQR;
        private System.Windows.Forms.Label QRlbl;
        private System.Windows.Forms.TextBox textBoxQR;
        private System.Windows.Forms.TextBox textBoxBar;
        private System.Windows.Forms.Label Tiaolbl;
        private System.Windows.Forms.Button btnAnBar;
        private System.Windows.Forms.Button btnGenBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

