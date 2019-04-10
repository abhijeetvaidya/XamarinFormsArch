using System;
namespace XamarinFormsArch.Classes.Network.NetworkResponses
{
    public class RegisterResponseModel : IBaseResponseModel
    {
        public int status { get; set; }
        public Data data { get; set; }
        public string message { get; set; }
        public string user_msg { get; set; }

        public class Data
        {
            public int id { get; set; }
            public int role_id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string username { get; set; }
            public object profile_pic { get; set; }
            public object country_id { get; set; }
            public string gender { get; set; }
            public string phone_no { get; set; }
            public object dob { get; set; }
            public bool is_active { get; set; }
            public DateTime created { get; set; }
            public DateTime modified { get; set; }
            public string access_token { get; set; }
        }
    }
}
