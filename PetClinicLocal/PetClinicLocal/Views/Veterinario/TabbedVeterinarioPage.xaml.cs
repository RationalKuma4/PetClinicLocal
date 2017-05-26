using Xamarin.Forms;

namespace PetClinicLocal.Views.Veterinario
{
    public partial class TabbedVeterinarioPage : TabbedPage
    {
        public TabbedVeterinarioPage()
        {
            InitializeComponent();
            Children.Add(new MainVeterinarioPage());
            Children.Add(new AddVeterinarioPage());
        }
    }
}
