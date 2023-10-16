using System;
using System.Windows.Forms;

namespace Howtallyouare
{
    public partial class popup : Form
    {
        public popup(int heightToShow)
        {
            InitializeComponent();
            height.Text = Convert.ToString(heightToShow).PadLeft(3, '0');
        }

        private void retry_click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
