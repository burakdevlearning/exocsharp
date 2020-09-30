using Bmail.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bmail.Model;
using Microsoft.EntityFrameworkCore;

namespace Bmail.Dao
{
    class CampaignDao : IEntityDao<Campaign>
    {
        public BmailContext context { get; set; }

        public CampaignDao()
        {
            context = new BmailContext();
        }

        public async Task<bool> Add(Campaign entity)
        {
            var campaign = context.Campaign.Add(entity);

            await this.context.SaveChangesAsync();

            if (campaign != null)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(Campaign entity)
        {
            var campaign = context.Campaign.Remove(entity);

            await this.context.SaveChangesAsync();

            if (campaign != null)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Campaign>> GetAll()
        {
            return await context.Campaign.ToListAsync();
        }

        public async Task<Campaign> GetOnebyId(int id)
        {
            return await context.Campaign.SingleOrDefaultAsync(c => c.CampaignId == id);
        }

        public async Task<Campaign> Update(Campaign entity)
        {
            var campaign = context.Campaign.Update(entity);

            await this.context.SaveChangesAsync();

            if (campaign != null)
            {
                return await context.Campaign.SingleOrDefaultAsync(c => c.CampaignId == entity.CampaignId);
            }
            return null;
        }
    }
}
