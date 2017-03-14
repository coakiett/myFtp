using System;
using System.Linq;
using System.Windows.Forms;

namespace myFtp
{
    public partial class Form1 : Form
    {
        static string host = "10.3.12.1";
        //static string host = "191.168.19.101";
        //static int port = 21;
        static string user = "ebs";
        static string pwd = "sebs";
        string removePath = "";

        public Form1()
        {
            InitializeComponent();
            textBoxPowerInfo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                removePath = "file/xhxgm";
                //removePath = "";
                FTPHelper myClient = new FTPHelper(host, removePath, user, pwd);
                textBoxPowerInfo.Text += "连接服务器成功！\r\n";
            if (textBox1.Text==""){
                    //MessageBox.Show("文件名不能为空！");
                    textBoxPowerInfo.Text += "文件名不能为空！\r\n";
            }
            else
            {
                string removeName = textBox1.Text;
                string[] removeN = removeName.Split('\\');
                string[] removeNr = removeN.LastOrDefault().Split('/');
                try
                {
                        if (myClient.IsFileExist(removeNr.LastOrDefault()))
                        {
                            myClient.Download(textBoxLoacal.Text, removeNr.LastOrDefault());
                            textBoxPowerInfo.Text += "下载文件" + removeNr.LastOrDefault() + "成功！\r\n";
                        }
                        else
                        {
                            textBoxPowerInfo.Text += "服务器上不存在" + removeNr.LastOrDefault() + "文件！\r\n";
                        }
                }
                catch
                {
                        textBoxPowerInfo.Text += "服务器上未找到该文件！\r\n";
                }
            }
            }
            catch
            {
                textBoxPowerInfo.Text += "连接服务器失败！\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxLoacal.Text=folderBrowserDialog1.SelectedPath.ToString()+"\\";
            textBoxPowerInfo.Text += "选择文件存储路径为："+ textBoxLoacal.Text + "！\r\n";
        }

        private void buttonSelectPathCard_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxLocalPathCard.Text = openFileDialog1.FileName;
            textBoxCardResp.Text += "选择本地文件"+ openFileDialog1.FileName +"！\r\n";
        }

        private void buttonCommitCardFile_Click(object sender, EventArgs e)
        {
            try
            {
                removePath = "OBOW/BTOC";
                //removePath = "";
                FTPHelper myClient = new FTPHelper(host, removePath, user, pwd);
                textBoxCardResp.Text += "连接服务器成功！\r\n";
                if (textBoxLocalPathCard.Text == "")
                {
                    //MessageBox.Show("文件名不能为空！");
                    textBoxCardResp.Text += "文件名不能为空！\r\n";
                }
                else
                {
                    string removeName = textBoxLocalPathCard.Text;
                    string[] removeN = removeName.Split('\\');
                    string[] removeNr = removeN.LastOrDefault().Split('/');
                    try
                    {
                        if (myClient.IsFileExist(removeNr.LastOrDefault()))
                        {
                            textBoxCardResp.Text += "文件" + removeNr.LastOrDefault() + "已经存在！\r\n";
                        }
                        else
                        {
                            myClient.Upload(textBoxLocalPathCard.Text);
                            textBoxCardResp.Text += "上传文件" + removeNr.LastOrDefault() + "成功！\r\n";
                        }
                    }
                    catch(Exception ex)
                    {
                        textBoxCardResp.Text += "本地计算机上未找到该文件！\r\n";
                    }
                }
            }
            catch(Exception ex)
            {
                textBoxCardResp.Text += "连接服务器失败！\r\n";
            }
        }
    }
}
