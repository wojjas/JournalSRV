using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft;
using System.Web.Http.Results;

namespace Journal.Controllers
{
    public class JournalMessageInputModel
    {
        public string Message { get; set; }
    }

    public class JournalMessageOutputModel
    {
        public string Status { get; set; }
    }

    public class MessageController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("Message GET: Test message")
            };
        }
        //public HttpResponseMessage Post()
        //{
        //    return new HttpResponseMessage()
        //    {
        //        Content = new StringContent("Message POST: Test message")
        //    };
        //}
        public JsonResult<JournalMessageOutputModel> Post(JournalMessageInputModel messageModel)
        {
            JsonResult<JournalMessageOutputModel> retValue = null;

            //TODO: Implement persistance logic here, eg. save to DB
            if (messageModel != null && !string.IsNullOrEmpty(messageModel.Message))
            {
                string fragment = messageModel.Message.PadRight(6, ' ').Substring(0, 6) + "...";
                var tmp = new JournalMessageOutputModel() { Status = "Posted journal entry to server: '" + fragment + "'" };
                retValue = Json(tmp);
            }
            else
            {
                var tmp = new JournalMessageOutputModel() { Status = "Empty message request." };
                retValue = Json(tmp);
            }

            return retValue;
        }
    }
}
