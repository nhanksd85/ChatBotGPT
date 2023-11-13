
using System;
using System.Net;
using System.IO;
using System.Linq.Expressions;
using System.Text.Json;
using System.Security.Policy;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;

namespace ChatBotGPT
{

    public partial class Form1 : Form
    {

        enum AssistantStatus
        {
            idle,
            greeting,
            request_requirement,
            complaint
        }
        AssistantStatus assistant_status = AssistantStatus.idle;
        ContextInfoModel objContext = new ContextInfoModel();

        private string assistant_dfa(string _action, string _category, string _phone_number, string _user_id)
        {
            string result = "";
            switch (assistant_status)
            {
                case AssistantStatus.idle:
                    if (_action == "welcome" || _action == "greeting")
                    {
                        result = "Chào Anh/Chị em có thể hỗ trợ gì cho Anh/chị?";
                    }
                    if (_action == "complaint")
                    {
                        result = "Xin Anh/Chi vui lòng cho em xin số điện thoại";
                        assistant_status = AssistantStatus.complaint;
                    }
                    break;
                case AssistantStatus.complaint:
                    if (_action == "welcome" || _action == "greeting")
                    {
                        result = "Chào Anh/Chị em có thể hỗ trợ gì cho Anh/chị?";
                        assistant_status = AssistantStatus.idle;
                        objContext.ClearContextInfo();
                        break;
                    }
                    if (_phone_number.Length > 0)
                    {
                        result = "Trong vòng 24h, BWACO sẽ liên hệ với anh chị ở số " + _phone_number + " để khắc phụ sự cố này.";
                        assistant_status = AssistantStatus.idle;
                        objContext.ClearContextInfo();
                        break;
                    }

                    result = "Xin vui lòng nhập lại số điện thoại";
                    break;
                default:

                    break;
            }
            return result;
        }


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

        private string getGPTResponseStructure(string input)
        {
            try
            {
                HttpClient client = new HttpClient();
                string sURL = "http://lpnserver.net:51087/chat/url?model=ft:gpt-3.5-turbo-0613:personal::8K5iB26y&key=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&c=" + input;

                var responce = client.GetStringAsync(sURL).Result;
                return responce.ToString();
            }
            catch (Exception ex)
            {
                return "Xin lỗi tôi không hiểu câu hỏi này.";
            }
        }

        private string gptResponseProcessing(string jsonData)
        {
            try
            {
                ResponseModel gptResponse = JsonConvert.DeserializeObject<ResponseModel>(jsonData);


                if (gptResponse != null)
                {
                    txtAction.Text = "";
                    if (gptResponse.action != null)
                    {
                        for (int i = 0; i < gptResponse.action.Length; i++)
                        {
                            txtAction.Text += gptResponse.action[i] + " ";
                        }
                        objContext.action = gptResponse.action[0];
                    }

                    txtCategory.Text = "";
                    if (gptResponse.category != null)
                    {
                        for (int i = 0; i < gptResponse.category.Length; i++)
                        {
                            txtCategory.Text += gptResponse.category[i] + " ";
                        }
                        objContext.category = gptResponse.category[0];
                    }

                    txtCustomerPhone.Text = "";
                    if (gptResponse.phone_number != null)
                    {
                        for (int i = 0; i < gptResponse.phone_number.Length; i++)
                        {
                            txtCustomerPhone.Text += gptResponse.phone_number[i] + " ";
                        }
                        objContext.phone_number = gptResponse.phone_number[0];
                    }
                    txtCustomerID.Text = "";
                    if (gptResponse.user_id != null)
                    {
                        for (int i = 0; i < gptResponse.user_id.Length; i++)
                        {
                            txtCustomerID.Text += gptResponse.user_id[i] + " ";
                        }
                        objContext.user_id = gptResponse.user_id[0];
                    }
                    return assistant_dfa(objContext.action, objContext.category, objContext.phone_number, objContext.user_id);

                }
                return "401";

            }
            catch
            {
                return "402";
            }
        }
        private void chatGPTProcessing()
        {
            
            string answer = getGPTResponseStructure(txtInput.Text);

            richOuput.Text += "Khách: " + txtInput.Text.Replace(Environment.NewLine, "") + Environment.NewLine;

            txtInput.Text = "Đang xử lý ...";

            richGPTResponse.Text = answer;
            
            string bwaco_answer = gptResponseProcessing(answer);
            richOuput.Text += "BWACO: " + bwaco_answer + Environment.NewLine;

            

            txtInput.Text = "";
            txtInput.Focus();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chatGPTProcessing();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            chatGPTProcessing();
        }
    }
}