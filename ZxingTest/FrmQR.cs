using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace ZxingTest
{
    public partial class FrmQR : Form
    {
        public FrmQR()
        {
            InitializeComponent();
        }
        ///<summary>
        ///生成二维码
        ///</summary>
        ///<paramname="pictureBox"></param>
        ///<paramname="text"></param>
        static void GenerateQR(PictureBox pictureBox,string text)
        {
            if (text == string.Empty)
            {
                MessageBox.Show("输入内容不能为空！");
                return;
            }
            QrCodeEncodingOptions options = null;
            BarcodeWriter writer = null;
            writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            options = new QrCodeEncodingOptions();
            options.DisableECI = true;
            //设置内容编码
            options.CharacterSet = "UTF-8";
            //设置二维码的宽度和高度
            options.Width = 200;
            options.Height = 200;
            //设置二维码的边距,单位不是固定像素
            options.Margin = 1;
            writer.Options = options;

            Bitmap map = writer.Write(text);
            pictureBox.Image = map;
        }


        ///<summary>
        ///生成条形码
        ///</summary>
        ///<paramname="pictureBox"></param>
        ///<paramname="text"></param>
        static void GenerateBar(PictureBox pictureBox,string text)
        {
            if (text==string.Empty)
            {
                MessageBox.Show("输入内容不能为空！");
                return;
            }
            EncodingOptions options = null;
            BarcodeWriter writer = null;
            writer = new BarcodeWriter();
            //使用ITF 格式，不能被现在常用的支付宝、微信扫出来
            //如果想生成可识别的可以使用 CODE_128 格式
            //writer.Format = BarcodeFormat.ITF;
            writer.Format = BarcodeFormat.CODE_128;
            options = new EncodingOptions()
            {
                Width = 200,
                Height = 100,
                Margin = 2
            };
            writer.Options = options;
            Bitmap map = writer.Write(text);
            pictureBox.Image = map;
        }


        ///<summary>
        ///生成带Logo的二维码
        ///</summary>
        ///<paramname="pictureBox"></param>
        ///<paramname="text"></param>
        static void GenerateLogoQR(PictureBox pictureBox,string text)
        {
            //Logo 图片
            Bitmap logo = new Bitmap(@"102.jpg");
            //构造二维码写码器
            MultiFormatWriter writer = new MultiFormatWriter();
            Dictionary<EncodeHintType, object> hint = new Dictionary<EncodeHintType, object>();
            hint.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
            hint.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            //生成二维码 
            BitMatrix bm = writer.encode(text, BarcodeFormat.QR_CODE, 300, 300, hint);
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            Bitmap map = barcodeWriter.Write(bm);


            //获取二维码实际尺寸（去掉二维码两边空白后的实际尺寸）
            int[] rectangle = bm.getEnclosingRectangle();

            //计算插入图片的大小和位置
            int middleW = Math.Min((int)(rectangle[2] / 3.5), logo.Width);
            int middleH = Math.Min((int)(rectangle[3] / 3.5), logo.Height);
            int middleL = (map.Width - middleW) / 2;
            int middleT = (map.Height - middleH) / 2;

            //将img转换成bmp格式，否则后面无法创建Graphics对象
            Bitmap bmpimg = new Bitmap(map.Width, map.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmpimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.DrawImage(map, 0, 0);
            }
            //将二维码插入图片
            Graphics myGraphic = Graphics.FromImage(bmpimg);
            //白底
            myGraphic.FillRectangle(Brushes.White, middleL, middleT, middleW, middleH);
            myGraphic.DrawImage(logo, middleL, middleT, middleW, middleH);

            //保存成图片
            bmpimg.Save(@"generateLogoQR.png", ImageFormat.Png);
        }

        ///<summary>
        ///解码
        ///</summary>
        ///<paramname="pictureBox"></param>
        public void Decode(PictureBox pictureBox)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pictureBox.Image);
            MessageBox.Show(result.Text);
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            GenerateBar(picBox,txtID.Text.Trim());
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            GenerateQR(picBox, txtID.Text.Trim());
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (picBox.Image == null)
            {
                MessageBox.Show("请录入图像后再进行解码!");
                return;
            }
            Decode(picBox);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (picBox.Image == null)
            {
                MessageBox.Show("图像不能为空！");
                return;
            }
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                MessageBox.Show("打印成功！");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap _NewBitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(_NewBitmap, new Rectangle(0, 0, _NewBitmap.Width, _NewBitmap.Height));
            e.Graphics.DrawImage(_NewBitmap, 0, 0, _NewBitmap.Width, _NewBitmap.Height);
        }
    }
}
