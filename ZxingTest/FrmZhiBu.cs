using SkinSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZxingTest
{
    public partial class FrmZhiBu : Form
    {
        public SkinH_Net skin;
        public FrmZhiBu()
        {
            skin = new SkinH_Net();
            skin.Attach();
            InitializeComponent();
        }

        private void FrmZhiBu_Load(object sender, EventArgs e)
        {

        }
    }
}
