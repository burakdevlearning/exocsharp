using System;
using System.Collections.Generic;
using System.Linq;

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

        public string[] toJson()
        {
            List<string> json = new List<string>();
            json.Add("{ \r");
            json.Add($"\t \"CampaignId\" : {CampaignId}, \r");
            json.Add($"\t \"Name\" : \"{Name}\", \r");
            json.Add("\t \"Email\" : [\r");
            foreach(Email em in Email)
            {
                var currentmail = em.toJson();
                for(int i = 0; i < currentmail.Length; i++)
                {
                    currentmail[i] = currentmail[i].Insert(0, "\t\t");
                }
                json.AddRange(currentmail); 
                json.Add("\t,\r");
            }
            json.Add("\t ]\r");
            json.Add("}");
            return json.ToArray();
        }
    }
}
