using System;
using System.Collections.Generic;

namespace Bmail.Model
{
    public partial class Campaign
    {
        public Campaign()
        {
            Email = new HashSet<Email>();
        }

        public int CampaignId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Email> Email { get; set; }
    }
}
