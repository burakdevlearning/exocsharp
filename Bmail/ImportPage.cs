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
    public partial class ImportPage : Form
    {
        public ImportPage()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImportPage_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new ComboItem[]
            {
                new ComboItem{ID = 0, Text = "test"}
            };
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Text";
        }
    }
}
