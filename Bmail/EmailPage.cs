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
    public partial class EmailPage : Form
    {
        private ListBox mailsList;
        private int? selectedIndex;
        private bool isReadOnly=false;
        public EmailPage()
        {
            InitializeComponent();
        }

        public EmailPage(ListBox cd, int? index, bool isreadonly = false) : this()
        {
            mailsList = cd;
            selectedIndex = index;
            isReadOnly = isreadonly;
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailPage_Load(object sender, EventArgs e)
        {

        }
    }
}
