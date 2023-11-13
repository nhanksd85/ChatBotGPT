using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotGPT
{
    public class ContextInfoModel
    {
        public string action { get; set; }
        public string category { get; set; }
        public string user_id { get; set; }
        public string phone_number { get; set; }
        public string user_name { get; set; }
        public string address { get; set; }
        public string device_id { get; set; }
        public string special_number { get; set; }

        public ContextInfoModel() { 
            action = string.Empty;
            category = string.Empty;
            user_id = string.Empty;
            phone_number = string.Empty;
            user_name = string.Empty;
            address = string.Empty;
            device_id = string.Empty;
            special_number = string.Empty;
        }
        public void ClearContextInfo()
        {
            action = string.Empty;
            category = string.Empty;
            user_id = string.Empty;
            phone_number = string.Empty;
            user_name = string.Empty;
            address = string.Empty;
            device_id = string.Empty;
            special_number = string.Empty;
        }
    }
}
