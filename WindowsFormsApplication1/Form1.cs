using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //计数器，用于绘制label坐标
        static int COUNT = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        /**
         * 读取日志
         */
        private void start_Click(object sender, EventArgs e)
        {
            createLabel();


        }

        private void perbankLable_Click(object sender, EventArgs e)
        {

        }
        /**
         * 双击隐藏label
         */
        private void Lable_DoubleClick(object sender, EventArgs e)
        {
            Label lbl2 = (Label)sender;
            lbl2.Visible = false;
        }
        /**
         * 生成label方法
         */
        private void createLabel(){
            Label lbl = new Label();
            //从标签页的左上角开始创建，依次向下生成，每次增加一个标签的高度
            lbl.Location = new System.Drawing.Point(0,COUNT);
            lbl.AutoSize = false;
            lbl.Size = new Size(876,12);
            lbl.Name = "lbl" + COUNT;
            lbl.Text = "label"+COUNT;
            perbankTextBox.Controls.Add(lbl);
            //绑定调用双击隐藏label方法
            lbl.DoubleClick += new System.EventHandler(Lable_DoubleClick);
            COUNT = COUNT+12;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            //createLabel();
        }
    }
}
