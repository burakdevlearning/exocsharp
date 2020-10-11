using Bmail.Dao;
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
    public partial class CampaignPage : Form
    {
        private ListBox campaignList;
        private int? selectedIndex;
        public CampaignPage()
        {
            InitializeComponent();
        }
        public CampaignPage(ListBox cd, int? index) : this()
        {
            campaignList = cd;
            selectedIndex = index;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Confirm button
        private void button3_Click(object sender, EventArgs e)
        {
            // get data
            // add to list
            this.Close();
        }
    }
}
