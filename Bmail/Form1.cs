using Bmail.Dao;
using Bmail.Model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private EmailDao mDao { get; set; }
        private CampaignDao cDao { get; set; }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Initialization of data access objects
            cDao = new CampaignDao();
            mDao = new EmailDao();

            // Getting every campaign
            var results = await cDao.GetAll();

            // Adding campaign names to the list to show to the user
            listBox1.Items.AddRange(results.Select(c => c.Name).ToArray());

            // Adding campaign objects to the listbox
            listBox1.Tag = results;
        }

        // Delete campaign button
        private async void button2_Click(object sender, EventArgs e)
        {

            // Checking if an item (campaign) has been selected
            if (listBox1.SelectedItems.Count > 0)
            {
                // Getting the campaign to delete 
                Campaign campaignToDelete = ((List<Campaign>)listBox1.Tag)[listBox1.SelectedIndex];

                // deleting the campaign
                var isDeleted = await cDao.Delete(campaignToDelete);

                // Getting every campaign
                var results = await cDao.GetAll();

                // Clearing list
                listBox1.Items.Clear();

                // Adding campaign names to the list to show to the user
                listBox1.Items.AddRange(results.Select(c => c.Name).ToArray());

                // Adding campaign objects to the listbox
                listBox1.Tag = results;
            }
            else
            {
                // popup
                MessageBox.Show("Select one campaign.");
            }
        }

        // View mails button
        private async void button4_Click(object sender, EventArgs e)
        {
            // Checking if an item (campaign) has been selected
            if (listBox1.SelectedItems.Count > 0)
            {
                // Getting every campaign added to the first list then filtering them by the selected campaign
                // finally assigning it to the variable
                int selectedCampaignId = ((List<Campaign>)listBox1.Tag)[listBox1.SelectedIndex].CampaignId;

                // Getting every email then filtering with the selected campaignId
                var results = (await mDao.GetAll())
                    .Where(c => c.CampaignId.Value == selectedCampaignId);

                // Clearing list if it is not the first time we pass through here
                listBox2.Items.Clear();
                // Adding the subjects of every mail in the list to be shown to the user
                listBox2.Items.AddRange(results.Select(e => e.Subject).ToArray());
                // Adding every mail to the listbox
                listBox2.Tag = results;
            }
            else
            {
                // popup
                MessageBox.Show("Select one campaign.");
            }
        }

        // add campaign button
        private void button1_Click(object sender, EventArgs e)
        {
            // opening the form with the listbox to add the value to.
            CampaignPage cp = new CampaignPage(listBox1, null);
            cp.Show();
        }

        // update campaign button
        private void button3_Click(object sender, EventArgs e)
        {
            // Checking if an item (campaign) has been selected
            if (listBox1.SelectedItems.Count > 0)
            {
                // Getting every campaign added to the first list then filtering them by the selected campaign
                // finally assigning it to the variable
                int selectedCampaignId = ((List<Campaign>)listBox1.Tag)[listBox1.SelectedIndex].CampaignId;

                CampaignPage cp = new CampaignPage(listBox1, selectedCampaignId);
                cp.Show();
            }
            else
            {
                // popup
                MessageBox.Show("Select one campaign.");
            }
        }

        // update email button
        private void button6_Click(object sender, EventArgs e)
        {
            // Checking if an item (mail) has been selected
            if (listBox2.SelectedItems.Count > 0)
            {
                // Getting every mail added to the first list then filtering them by the selected campaign
                // finally assigning it to the variable
                int selectedEmailId = ((List<Email>)listBox2.Tag)[listBox2.SelectedIndex].EmailId;

                EmailPage ep = new EmailPage(listBox2, selectedEmailId);
                ep.Show();
            }
            else
            {
                // popup
                MessageBox.Show("Select one mail.");
            }
        }

        // View mail details button (like update but read only)
        private void button5_Click(object sender, EventArgs e)
        {
            // Checking if an item (mail) has been selected
            if (listBox2.SelectedItems.Count > 0)
            {
                // Getting every mail added to the first list then filtering them by the selected campaign
                // finally assigning it to the variable
                int selectedEmailId = ((List<Email>)listBox2.Tag)[listBox2.SelectedIndex].EmailId;

                EmailPage ep = new EmailPage(listBox2, selectedEmailId, true);
                ep.Show();
            }
            else
            {
                // popup
                MessageBox.Show("Select one mail.");
            }
        }

        // Add mail button
        private void button8_Click(object sender, EventArgs e)
        {
            EmailPage ep = new EmailPage(listBox2, null);
            ep.Show();
        }

        // Delete mail button
        private async void button7_Click(object sender, EventArgs e)
        {
            // Checking if an item (email) has been selected
            if (listBox2.SelectedItems.Count > 0)
            {
                // Getting the email to delete 
                Email emailToDelete = ((List<Email>)listBox2.Tag)[listBox2.SelectedIndex];

                // deleting the email
                var isDeleted = await mDao.Delete(emailToDelete);

                // Getting every email
                var results = await mDao.GetAll();
                
                // Clearing list
                listBox2.Items.Clear();

                // Adding email sbujects to the list to show to the user
                listBox2.Items.AddRange(results.Select(c => c.Subject).ToArray());

                // Adding email objects to the listbox
                listBox2.Tag = results;
            }
            else
            {
                // popup
                MessageBox.Show("Select one mail.");
            }
        }

        // Send mails button from campaign list
        private void button9_Click(object sender, EventArgs e)
        {

        }

        // Send mail button from mail list
        private void button10_Click(object sender, EventArgs e)
        {

        }

        // Export menu button
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportPage ep = new ExportPage((List<Campaign>)listBox1.Tag);
            ep.Show();
        }

        // Import menu button
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportPage ip = new ImportPage();
            ip.Show();
        }
    }
}
