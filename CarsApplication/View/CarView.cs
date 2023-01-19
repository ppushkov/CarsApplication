using CarsApplication.Controller;
using System.Windows.Forms;

namespace CarsApplication.View
{
    public partial class CarView : Form
    {
        CarController controller = new CarController();
        public CarView()
        {
            InitializeComponent();
        }

        private void CarView_Load(object sender, System.EventArgs e)
        {
            dgvCars.DataSource = controller.GetAll();
        }
    }
}
