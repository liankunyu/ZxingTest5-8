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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        static void GenerateQR(string text)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
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
            string filename = @"1.png";
            map.Save(filename, ImageFormat.Png);
            map.Dispose();
        }
        //生成条形码
        //错误说明
        //只支持数字
        //只支持偶数个
        //最大长度80
        static void GenerateBar(string text)
        {
            BarcodeWriter writer = new BarcodeWriter();
            //使用ITF 格式，不能被现在常用的支付宝、微信扫出来
            //如果想生成可识别的可以使用 CODE_128 格式
            //writer.Format = BarcodeFormat.ITF;
            writer.Format = BarcodeFormat.CODE_128;
            EncodingOptions options = new EncodingOptions()
            {
                Width = 150,
                Height = 50,
                Margin = 2
            };
            writer.Options = options;
            Bitmap map = writer.Write(text);
            string filename = @"2.png";
            map.Save(filename, ImageFormat.Png);
        }
        /// <summary>
        /// 生成带Logo的二维码
        /// </summary>
        /// <param name="text"></param>
        static void GenerateLogoQR(string text)
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
        /// <summary>
        /// 读取二维码
        /// 读取失败，返回空字符串
        /// </summary>
        /// <param name="filename">指定二维码图片位置</param>
        static string ReadQR(string filename)
        {
            BarcodeReader reader = new BarcodeReader();
            reader.Options.CharacterSet = "UTF-8";
            Bitmap map = new Bitmap(filename);
            Result result = reader.Decode(map);
            map.Dispose();
            return result == null ? "" : result.Text;
        }
        private void btnGenQR_Click(object sender, EventArgs e)
        {

            if (textBoxQR.Text.Trim()!="")
            {
                GenerateQR(textBoxQR.Text);
                Image img =Image.FromFile("1.png");
                Image bmp = new Bitmap(img);
                img.Dispose();
                pictureBox2.Image = bmp;
                MessageBox.Show("成功");
            }
            else
            {
                MessageBox.Show("输入字符不能为空");
            }
        }

        private void btnGenBar_Click(object sender, EventArgs e)
        {
            int result=0;
            if (int.TryParse(textBoxBar.Text, out result))
            {
                GenerateBar(textBoxBar.Text.Trim());
                Image img = Image.FromFile("2.png");
                Image bmp = new Bitmap(img);
                img.Dispose();
                pictureBox1.Image = bmp;
            }
            else
            {
                MessageBox.Show("输入字符必须是数字");
            }
        }

        private void btnAnBar_Click(object sender, EventArgs e)
        {
            string fileName = "2.png";
            string result=ReadQR(fileName);
            MessageBox.Show(result);
        }

        private void btnAnQR_Click(object sender, EventArgs e)
        {
            string fileName = "1.png";
            string result = ReadQR(fileName);
            MessageBox.Show(result);
        }
    }
}
