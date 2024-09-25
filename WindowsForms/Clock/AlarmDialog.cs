using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class AlarmDialog : Form
    {
        MainForm owner;
        public AlarmDialog()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public AlarmDialog(MainForm owner):this()
        {
            this.owner = owner;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            owner.alarTime=dateTimePicker1.Value;
            Console.WriteLine(owner.alarTime);
            this.Close();
        }

       
    }
}
