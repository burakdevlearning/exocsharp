using System;
using System.Collections.Generic;

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
    }
}
