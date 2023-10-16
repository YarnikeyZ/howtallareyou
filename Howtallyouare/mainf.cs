using System;
using System.Windows.Forms;

namespace Howtallyouare
{
    public partial class mainf : Form
    {
        public mainf()
        {
            InitializeComponent();
        }

        private void exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submit_click(object sender, EventArgs e)
        {
            popup popup = new popup(Convert.ToInt32(height.Text));
            popup.ShowDialog();
        }

        private void minus_click(object sender, EventArgs e)
        {
            int heightBefore = Convert.ToInt32(height.Text);
            if (heightBefore - 1 > -1)
            {
                height.Text = Convert.ToString(heightBefore - 1).PadLeft(3, '0');
            }
        }

        private void plus_click(object sender, EventArgs e)
        {
            int heightBefore = Convert.ToInt32(height.Text);
            if (heightBefore + 1 < 1000)
            {
                height.Text = Convert.ToString(heightBefore + 1).PadLeft(3, '0');
            }
        }
    }
}
