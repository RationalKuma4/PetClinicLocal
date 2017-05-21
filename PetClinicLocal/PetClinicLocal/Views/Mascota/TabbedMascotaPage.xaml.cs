using Xamarin.Forms;

namespace PetClinicLocal.Views.Mascota
{
    public partial class TabbedMascotaPage : TabbedPage
    {
        public TabbedMascotaPage()
        {
            InitializeComponent();
            Children.Add(new MainMascotaPage());
            Children.Add(new AddMascotaPage());
        }
    }
}
