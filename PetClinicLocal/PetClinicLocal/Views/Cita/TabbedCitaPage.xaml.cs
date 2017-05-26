using Xamarin.Forms;

namespace PetClinicLocal.Views.Cita
{
    public partial class TabbedCitaPage : TabbedPage
    {
        public TabbedCitaPage()
        {
            InitializeComponent();
            Children.Add(new MainCitaPage());
            Children.Add(new AddCitaPage());
        }
    }
}
