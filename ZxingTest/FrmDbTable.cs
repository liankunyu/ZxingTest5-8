using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ZxingTest
{
    public partial class FrmDbTable : Form
    {

        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter sda;
        public FrmDbTable()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=.;database=JHDD;uid=sa;pwd=111");
            SqlDataAdapter sda = new SqlDataAdapter("select * from 棉布订单信息表", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.RowHeadersVisible = false;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = 84;
            }
            button1.Enabled = false;
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void FrmDbTable_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=.;database=Test;uid=sa;pwd=sa");
            SqlCommand cmd = new SqlCommand("select * from chengji", conn);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            ds = new DataSet();
            sda.Fill(ds, "cs");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataToExcel(ds.Tables[0], "1");

        }

        public string DataToExcel(System.Data.DataTable m_DataTable, string s_FileName)
        {
            string FileName = AppDomain.CurrentDomain.BaseDirectory + s_FileName + ".xls";  //文件存放路径  
            if (System.IO.File.Exists(FileName))                                //存在则删除  
            {
                System.IO.File.Delete(FileName);
            }
            System.IO.FileStream objFileStream;
            System.IO.StreamWriter objStreamWriter;
            string strLine = "";
            objFileStream = new System.IO.FileStream(FileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
            objStreamWriter = new System.IO.StreamWriter(objFileStream, Encoding.Unicode);
            for (int i = 0; i < m_DataTable.Columns.Count; i++)
            {
                strLine = strLine + m_DataTable.Columns[i].Caption.ToString() + Convert.ToChar(9);      //写列标题  
            }
            objStreamWriter.WriteLine(strLine);
            strLine = "";
            for (int i = 0; i < m_DataTable.Rows.Count; i++)
            {
                for (int j = 0; j < m_DataTable.Columns.Count; j++)
                {
                    if (m_DataTable.Rows[i].ItemArray[j] == null)
                        strLine = strLine + " " + Convert.ToChar(9);                                    //写内容  
                    else
                    {
                        string rowstr = "";
                        rowstr = m_DataTable.Rows[i].ItemArray[j].ToString();
                        if (rowstr.IndexOf("\r\n") > 0)
                            rowstr = rowstr.Replace("\r\n", " ");
                        if (rowstr.IndexOf("\t") > 0)
                            rowstr = rowstr.Replace("\t", " ");
                        strLine = strLine + rowstr + Convert.ToChar(9);
                    }
                }
                objStreamWriter.WriteLine(strLine);
                strLine = "";
            }
            objStreamWriter.Close();
            objFileStream.Close();
            return FileName;        //返回生成文件的绝对路径  
        }
        private DataTable dbconn(string strSql)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            sda = new SqlDataAdapter(strSql, conn);
            DataTable dtSelect = new DataTable();
            int rnt = sda.Fill(dtSelect);
            return dtSelect;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dbUpdate())
            {
                MessageBox.Show("修改成功！");
            }
        }

        private Boolean dbUpdate()
        {
            string strSql = "select * from 棉布订单信息表";
            DataTable dtUpdate = new DataTable();
            dtUpdate = this.dbconn(strSql);
            DataTable dtShow = new DataTable();
            dtShow = (DataTable)this.dataGridView1.DataSource;
            for (int i = 0; i < dtShow.Rows.Count; i++)
            {
                dtUpdate.ImportRow(dtShow.Rows[i]);
            }
            try
            {
                SqlCommandBuilder CommandBuiler;
                CommandBuiler = new SqlCommandBuilder(sda);
                sda.Update(dtUpdate);
                dtUpdate.AcceptChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
    }
}
