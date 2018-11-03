namespace ZxingTest
{
    partial class FrmQR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVariety = new System.Windows.Forms.TextBox();
            this.lblVariety = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtXu = new System.Windows.Forms.TextBox();
            this.lblXu = new System.Windows.Forms.Label();
            this.txtChe = new System.Windows.Forms.TextBox();
            this.lblChe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtXu);
            this.panel1.Controls.Add(this.lblXu);
            this.panel1.Controls.Add(this.txtChe);
            this.panel1.Controls.Add(this.lblChe);
            this.panel1.Controls.Add(this.txtVariety);
            this.panel1.Controls.Add(this.lblVariety);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Location = new System.Drawing.Point(90, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 0;
            // 
            // txtVariety
            // 
            this.txtVariety.Location = new System.Drawing.Point(397, 255);
            this.txtVariety.Name = "txtVariety";
            this.txtVariety.Size = new System.Drawing.Size(156, 30);
            this.txtVariety.TabIndex = 4;
            this.txtVariety.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVariety
            // 
            this.lblVariety.AutoSize = true;
            this.lblVariety.Location = new System.Drawing.Point(337, 258);
            this.lblVariety.Name = "lblVariety";
            this.lblVariety.Size = new System.Drawing.Size(69, 20);
            this.lblVariety.TabIndex = 3;
            this.lblVariety.Text = "品种：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 255);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(208, 30);
            this.txtID.TabIndex = 2;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 258);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(300, 31);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(200, 200);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(760, 655);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 50);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(590, 655);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(250, 655);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(140, 50);
            this.btnQR.TabIndex = 4;
            this.btnQR.Text = "生成二维码";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(420, 655);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(140, 50);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "解码";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(80, 655);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(140, 50);
            this.btnBar.TabIndex = 5;
            this.btnBar.Text = "生成条形码";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtXu
            // 
            this.txtXu.Location = new System.Drawing.Point(397, 309);
            this.txtXu.Name = "txtXu";
            this.txtXu.Size = new System.Drawing.Size(156, 30);
            this.txtXu.TabIndex = 8;
            this.txtXu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblXu
            // 
            this.lblXu.AutoSize = true;
            this.lblXu.Location = new System.Drawing.Point(337, 312);
            this.lblXu.Name = "lblXu";
            this.lblXu.Size = new System.Drawing.Size(69, 20);
            this.lblXu.TabIndex = 7;
            this.lblXu.Text = "序号：";
            // 
            // txtChe
            // 
            this.txtChe.Location = new System.Drawing.Point(79, 309);
            this.txtChe.Name = "txtChe";
            this.txtChe.Size = new System.Drawing.Size(184, 30);
            this.txtChe.TabIndex = 6;
            this.txtChe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblChe
            // 
            this.lblChe.AutoSize = true;
            this.lblChe.Location = new System.Drawing.Point(13, 312);
            this.lblChe.Name = "lblChe";
            this.lblChe.Size = new System.Drawing.Size(69, 20);
            this.lblChe.TabIndex = 5;
            this.lblChe.Text = "车号：";
            // 
            // FrmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQR";
            this.Text = "FrmQR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtVariety;
        private System.Windows.Forms.Label lblVariety;
        private System.Windows.Forms.TextBox txtXu;
        private System.Windows.Forms.Label lblXu;
        private System.Windows.Forms.TextBox txtChe;
        private System.Windows.Forms.Label lblChe;
    }
}