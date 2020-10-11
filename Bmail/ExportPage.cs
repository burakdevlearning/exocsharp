using Bmail.Dao;
using Bmail.Model;
using Bmail.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmail
{
    public partial class ExportPage : Form
    {
        private List<Campaign> campaigns { get; set; }
        private List<Email> mails { get; set; }
        private bool loadEnd = false;
  
        public ExportPage()
        {
            InitializeComponent();
        }
        public ExportPage(List<Campaign> campaigns) : this()
        {
            this.campaigns = campaigns;
        }

        private async void ExportPage_Load(object sender, EventArgs e)
        {
            // declaring & instanciating data holder
            List<ComboItem> cbitems = new List<ComboItem>();
            List<ComboItem> cbitems2 = new List<ComboItem>();
            mails = new List<Email>();

            // adding values to data holders
            foreach (Campaign cp in campaigns)
            {
                cbitems.Add(new ComboItem { ID = cp.CampaignId, Text = cp.Name });
            }

            // Getting every email for the selected campaign
            mails = (await (new EmailDao()).GetAll()).Where(em => em.CampaignId == cbitems[0].ID).ToList();

            if (mails.Count == 0)
                cbitems2.Add(new ComboItem { ID = 0, Text = "This campaign has no mail." });
            else
                foreach (Email em in mails)
                    cbitems2.Add(new ComboItem { ID = em.EmailId, Text = em.Subject });

            // putting into datasource of each combobox the respective data holder
            comboBox1.DataSource = cbitems.ToArray();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Text";

            comboBox2.DataSource = cbitems2.ToArray();
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "Text";
            loadEnd = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        // when a different line is selected in the first combobox (campaign)
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadEnd)
            {
                List<ComboItem> cbitems2 = new List<ComboItem>();
                int selectedCampaignId = (int)comboBox1.SelectedValue;

                mails = (await (new EmailDao()).GetAll()).Where(em => em.CampaignId == selectedCampaignId).ToList(); ;

                if (mails.Count == 0)
                    cbitems2.Add(new ComboItem { ID = 0, Text = "This campaign has no mail." });
                else
                    foreach (Email em in mails)
                        cbitems2.Add(new ComboItem { ID = em.EmailId, Text = em.Subject });
                comboBox2.DataSource = cbitems2.ToArray();
            }
        }

        // Export campaign button
        private async void button4_Click(object sender, EventArgs e)
        {

            Campaign cp = new Campaign();
            cp = await new CampaignDao().GetOnebyId((int)comboBox1.SelectedValue);
            cp.Email = (await(new EmailDao()).GetAll()).Where(em => em.CampaignId == (int)comboBox1.SelectedValue).ToList();
            string[] json = cp.toJson();
            JsonHelper.writeJsonFile($"{cp.Name}.json", json);
        }

        // Export mail button
        private async void button1_Click(object sender, EventArgs e)
        {
            Email em = new Email();
            em = await new EmailDao().GetOnebyId((int)comboBox2.SelectedValue);
            string[] json = em.toJson();
            JsonHelper.writeJsonFile($"{em.Subject}.json", json);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            List<string> json = new List<string>();
            foreach(Campaign cp in campaigns)
            {
                cp.Email = (await new EmailDao().GetAll()).Where(em => em.CampaignId == cp.CampaignId).ToList();
                json.AddRange(cp.toJson());
                json.Add(",\r");
            }
            JsonHelper.writeJsonFile($"Bmail.json", json.ToArray());
        }
    }
}
