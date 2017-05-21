using Microsoft.Practices.Unity;
using PetClinicLocal.Contracts;
using PetClinicLocal.Data;
using PetClinicLocal.Repositories;
using PetClinicLocal.Repositories.IAppointment;
using PetClinicLocal.Repositories.IOwner;
using PetClinicLocal.Repositories.IPet;
using PetClinicLocal.Repositories.IVeterinarian;
using PetClinicLocal.Views.Usuario;
using Prism.Unity;
using PetClinicLocal.Views;
using PetClinicLocal.Views.Cita;
using PetClinicLocal.Views.Mascota;
using PetClinicLocal.Views.Veterinario;
using Prism.Logging;
using Xamarin.Forms;

namespace PetClinicLocal
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent(); 
            //NavigationService.NavigateAsync(ViewsNames.LoginPageName);
            //NavigationService.NavigateAsync(ViewsNames.MasterMenuPageName);
            NavigationService.NavigateAsync(ViewsNames.MasterMenuPageName);
        }

        protected override void RegisterTypes()
        {
            RegisterNavigation();
            RegisterServices();
            RegisterRepositories();
        }

        private void RegisterNavigation()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();

            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<ResgisterUserPage>();

            Container.RegisterTypeForNavigation<MasterMenuPage>();
            Container.RegisterTypeForNavigation<MainCitaPage>();
            Container.RegisterTypeForNavigation<MainMascotaPage>();
            Container.RegisterTypeForNavigation<MainVeterinarioPage>();

            Container.RegisterTypeForNavigation<AddMascotaPage>();
            Container.RegisterTypeForNavigation<MainMascotaPage>();
            Container.RegisterTypeForNavigation<TabbedMascotaPage>();
        }

        private void RegisterServices()
        {
            Container.RegisterType<IOwnerService, PetClinicDatabaseService>();
            Container.RegisterType<IPetService, PetClinicDatabaseService>();
            Container.RegisterType<IVeterinarianService, PetClinicDatabaseService>();
            Container.RegisterType<IAppointmentService, PetClinicDatabaseService>();
        }

        private void RegisterRepositories()
        {
            Container.RegisterType<IOwnerWriter, OwnerRepository>();
            Container.RegisterType<IOwnerReader, OwnerRepository>();

            Container.RegisterType<IPetWriter, PetRepository>();
            Container.RegisterType<IPetReader, PetRepository>();

            Container.RegisterType<IVeterinarianWriter, VeterinarianRepository>();
            Container.RegisterType<IVeterinarianReader, VeterinarianRepository>();

            Container.RegisterType<IAppointmentWriter, AppointmentRepository>();
            Container.RegisterType<IAppointmentReader, AppointmentRepository>();
        }

        public new static App Current => Application.Current as App;

        public new ILoggerFacade Logger => base.Logger;
    }
}
