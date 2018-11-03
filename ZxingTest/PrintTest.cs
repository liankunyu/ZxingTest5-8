using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZxingTest
{
    public partial class PrintTest : Form
    {
        public PrintTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //保存成图片
           // Bitmap bit = new Bitmap(this.Width, this.Height);//实例化一个和窗体一样大的bitmap
           // Graphics g = Graphics.FromImage(bit);
           // g.CompositingQuality = CompositingQuality.HighQuality;//质量设为最高
           // g.CopyFromScreen(panel1.PointToScreen(Point.Empty),Point.Empty,panel1.Size);//保存整个窗体为图片
           ////g.CopyFromScreen(panel游戏区 .PointToScreen(Point.Empty), Point.Empty, panel游戏区.Size);//只保存某个控件（这里是panel游戏区）                                                      //g.CopyFromScreen(panel游戏区 .PointToScreen(Point.Empty), Point.Empty, panel游戏区.Size);//只保存某个控件（这里是panel游戏区）
           // bit.Save("weiboTemp.png");//默认保存格式为PNG，保存成jpg格式质量不是很好

            //打印输出
            this.printDialog1.Document = this.printDocument1;
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
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
