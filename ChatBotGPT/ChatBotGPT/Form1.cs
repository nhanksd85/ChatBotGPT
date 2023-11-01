
using System;
using System.Net;
using System.IO;
using System.Linq.Expressions;
using System.Text.Json;
using System.Security.Policy;

namespace ChatBotGPT
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getGPTResponse(string input)
        {
            try
            {
                HttpClient client = new HttpClient();
                string sURL = "http://lpnserver.net:51087/chat?c=" + input;

                var responce = client.GetStringAsync(sURL).Result;
                return responce.ToString();
            }
            catch (Exception ex)
            {
                return "Xin lỗi tôi không hiểu câu hỏi này.";
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string answer = getGPTResponse(txtInput.Text);

                richOuput.Text += "Hỏi: " + txtInput.Text.Replace(Environment.NewLine, "") + Environment.NewLine;
               

                txtInput.Text = "Đang xử lý ...";

                
                richOuput.Text += "Trả lời: " + answer + Environment.NewLine;

                txtInput.Text = "";
                txtInput.Focus();
                
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richOuput.Text = "";
            txtInput.Focus();
        }
    }
}