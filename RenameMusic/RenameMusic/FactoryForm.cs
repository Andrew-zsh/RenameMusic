using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RenameMusic
{
    public partial class FactoryForm : Form
    {
        public FactoryForm()
        {
            InitializeComponent();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {

            //使用FolderBrowserDialog类，它提示用户浏览、创建并最终选择一个文件夹
            FolderBrowserDialog fole = new FolderBrowserDialog();

            //设置是否显示“新建文件夹”按钮  (false为不显示  true为显示)
            fole.ShowNewFolderButton = true;
            //设置显示提示标题文字
            fole.Description = "请选择媒体文件夹";
            //判断是否点击了确定按钮
            if (fole.ShowDialog() == DialogResult.OK)
            {
                //实例化目录信息的类 (文件夹的全路径)
                DirectoryInfo dir = new DirectoryInfo(fole.SelectedPath);

                txtBoxFile.Text = fole.SelectedPath.ToString();


                //获取总文件数目MP3和wma
                int nFileCount = 0;
                FileInfo[] file = dir.GetFiles();


                for (int i = 0; i < file.Length ; i++)
                {
                    if (file[i].Extension.ToLower().Equals(".mp3") || file[i].Extension.ToLower().Equals(".wma"))
                    {
                        nFileCount = nFileCount + 1;
                    }
                }

                lblFileCount.Text = "总歌曲数是：" + nFileCount.ToString() + "首";

                //遍历文件夹中所有文件(除子文件夹)
                foreach (FileInfo info in dir.GetFiles())
                {
                    //判断文件的后缀名 进行筛选
                    if (info.Extension.ToLower().Equals(".mp3") || info.Extension.ToLower().Equals(".wma"))
                    {
                        //把筛选后的文件添加到ListBox控件的集合中
                        listFileName.Items.Add(info.FullName);
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DateTime strStartTime = DateTime.Now;

            for (int i = 0; i < listFileName.Items.Count; i++)
            {
                string strOldName = listFileName.Items[i].ToString();
                string strFileName = strOldName.Substring(strOldName.LastIndexOf('\\') + 1);

                //获取歌手和歌曲名和文件格式
                string strSinger = strFileName.Substring(0,strFileName.IndexOf('-')).Trim();
                string strMusicName = strFileName.Substring(strFileName.IndexOf('-') + 1, (strFileName.LastIndexOf('.') - strFileName.IndexOf('-'))-1).Trim();
                string strFormat = strFileName.Substring(strFileName.LastIndexOf('.'));
                string strNewName=strOldName.Substring(0,strOldName.LastIndexOf('\\')+1)+strMusicName+'-'+strSinger+strFormat;
                //更改歌曲名称
                File.Move(strOldName, strNewName);
            }



            DateTime strEndTime = DateTime.Now;
            TimeSpan span = strEndTime - strStartTime;
            this.labTime.Text = "花费时间为：" + (span.TotalMilliseconds).ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtBoxFile.Text = "";
            listFileName.Items.Clear();
        }

        private void FactoryForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您确定要退出？");
            this.Close();
            
        }
    }
}
