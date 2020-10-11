using System;
using System.Collections.Generic;
using System.Linq;

namespace Bmail.Model
{
    public partial class Email
    {
        public int EmailId { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }
        public string Subject { get; set; }
        public string Format { get; set; }
        public byte[] Attachments { get; set; }
        public int? CampaignId { get; set; }

        public virtual Campaign Campaign { get; set; }

        public string[] toJson()
        {
            List<string> json = new List<string>();
            json.Add("{ \r\n");
            json.Add($"\t \"EmailId\" : {EmailId}, \r");
            json.Add($"\t \"Sender\" : \"{Sender}\", \r");
            json.Add($"\t \"Receiver\" : \"{Receiver}\", \r");
            if (!string.IsNullOrEmpty(Content))
                json.Add($"\t \"Content\" : \"{Content}\", \r");
            json.Add($"\t \"Subject\" : \"{Subject}\", \r");
            if (!string.IsNullOrEmpty(Format))
                json.Add($"\t \"Format\" : \"{Format}\", \r");
            if (CampaignId.HasValue)
                json.Add($"\t \"CampaignId\" : {CampaignId}, \r");
            json.Add("}");
            return json.ToArray();
        }
    }
}
