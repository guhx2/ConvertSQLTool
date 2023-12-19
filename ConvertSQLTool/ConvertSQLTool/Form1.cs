using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertSQLTool
{
    public partial class ConvertSQLTool : Form
    {
        float X;//窗体的宽度
        float Y;//窗体的高度

        public ConvertSQLTool()
        {
            InitializeComponent();
        }

        private void ConvertSQLTool_Load(object sender, EventArgs e)
        {
            X = this.Width;//赋值初始窗体宽度
            Y = this.Height;//赋值初始窗体高度
            SetTag(this);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //删除PreparedParameters:以及之前的字符
            //int i = txtParam.Text.IndexOf("PreparedParameters:");
            //string[] arr_para = txtParam.Text.Remove(0, i == -1 ? 0 : (i + "PreparedParameters:".Length)).Split(',');

            //CONSOLE Log: PreparedParameters:'200'
            //SQLFile Log：{"bindArgs":["DASL001","111","20230803","20230803"]}
            String pattern = "{|}|\\[|]";
            String param = txtParam.Text.Replace("PreparedParameters:", string.Empty).Replace("\"bindArgs\":", string.Empty).Trim();
            String replace = Regex.Replace(param, pattern, string.Empty);

            string[] arr_para = replace.Replace("\"","\'").Split(',');
            string strTmpAto = txtMae.Text;
            int idx = -1;
            if (arr_para != null && arr_para.Length > 0 && !string.IsNullOrEmpty(txtMae.Text))
            {
                foreach (string str in arr_para)
                {
                    idx = strTmpAto.IndexOf("?");

                    if (idx != -1)
                    {//删除？并在该位置插入替换参数,参数为空的场合用null替换
                        strTmpAto = strTmpAto.Remove(idx, 1).Insert(idx, !string.IsNullOrEmpty(str) ? str: "null");
                    }
                }
                txtAto.Text = strTmpAto;
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtParam.Text = string.Empty;
            txtMae.Text = string.Empty;
            txtAto.Text = string.Empty;
        }
        /// <summary>
        /// 调整控件大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertSQLTool_Resize(object sender, EventArgs e)
        {
            float newWidth = this.Width/X;//获取当前宽度与初始宽度的比例
            float newHeight = this.Height/Y;//获取当前高度与初始高度的比例
            SetControls(newWidth, newHeight,this);
            //this.Text = "窗体宽：" + this.Width.ToString() + " 窗体高：" + this.Height.ToString();//窗体标题栏
        }

        /// <summary>
      /// 获取控件的width、height、left、top、字体大小的值
      /// </summary>
      /// <param name="cons">要获取信息的控件</param>
      private void SetTag(Control cons)
      {
          //遍历窗体中的控件
          foreach (Control con in cons.Controls)
          {
              con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
          }
      }
        /// <summary>
        /// 根据窗体大小调整控件大小
        /// </summary>
        /// <param name="newX"></param>
        /// <param name="newY"></param>
        /// <param name="cons"></param>
        private void SetControls(float newX, float newY, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值，并分割后存储字符串数组

                float a = Convert.ToSingle(mytag[0]) * newX;//根据窗体缩放比例确定控件的值，宽度//89*300
                con.Width = (int)(a);//宽度

                a = Convert.ToSingle(mytag[1]) * newY;//根据窗体缩放比例确定控件的值，高度//12*300
                con.Height = (int)(a);//高度

                a = Convert.ToSingle(mytag[2]) * newX;//根据窗体缩放比例确定控件的值，左边距离//
                con.Left = (int)(a);//左边距离

                a = Convert.ToSingle(mytag[3]) * newY;//根据窗体缩放比例确定控件的值，上边缘距离
                con.Top = (int)(a);//上边缘距离

                Single currentSize = Convert.ToSingle(mytag[4]) * newY;//根据窗体缩放比例确定控件的值，字体大小
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);//字体大小


                //Remarks：
                //控件当前宽度：控件初始宽度=窗体当前宽度：窗体初始宽度
                //控件当前宽度=控件初始宽度*(窗体当前宽度/窗体初始宽度)
            }
        }

        /// <summary>
        /// 把变换后内容复制到剪贴板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCopy_Click(object sender, EventArgs e)
        {
                Clipboard.SetDataObject(txtAto.Text);
        }
    }
}
