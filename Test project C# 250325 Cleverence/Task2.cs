using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_project_C__250325_Cleverence
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Task2_Load(object sender, EventArgs e)
        {

        }

        private void buttonReadCount_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                int currentCount = Task2StaticServer.GetCount();
                Invoke((MethodInvoker)(() => labelCount.Text = currentCount.ToString()));
            });
        }

        private void buttonWriteCount_Click(object sender, EventArgs e)
        {
            int valueToAdd = (int)numericUpDownWrite.Value;
            Task.Run(() =>
            {
                Task2StaticServer.AddToCount(valueToAdd);
                Invoke((MethodInvoker)(() => labelCount.Text = Task2StaticServer.GetCount().ToString()));
            });
            numericUpDownWrite.Value = 0;
        }
    }
}
