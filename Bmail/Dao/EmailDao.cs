using Bmail.Interface;
using Bmail.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmail.Dao
{
    class EmailDao : IEntityDao<Email>
    {
        public BmailContext context { get; set; }

        public EmailDao()
        {
            context = new BmailContext();
        }

        public async Task<bool> Add(Email entity)
        {
            var email = context.Email.Add(entity);

            await this.context.SaveChangesAsync();

            if (email != null)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(Email entity)
        {
            var email = context.Email.Remove(entity);

            await this.context.SaveChangesAsync();

            if (email != null)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Email>> GetAll()
        {
            return await context.Email.ToListAsync();
        }

        public async Task<Email> GetOnebyId(int id)
        {
            return await context.Email.SingleOrDefaultAsync(e => e.EmailId == id);
        }

        public async Task<Email> Update(Email entity)
        {
            var email = context.Email.Update(entity);

            await this.context.SaveChangesAsync();

            if (email != null)
            {
                return await context.Email.SingleOrDefaultAsync(e => e.EmailId == entity.EmailId);
            }
            return null;
        }
    }
}
