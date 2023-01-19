using CarsApplication.View;
using System;
using System.Windows.Forms;

namespace CarsApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCarView_Click(object sender, EventArgs e)
        {
            Close();
            CarView carview = new CarView();
            carview.Show();
        }
    }
}
