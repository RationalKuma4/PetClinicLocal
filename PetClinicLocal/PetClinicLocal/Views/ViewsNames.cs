using PetClinicLocal.Views.Cita;
using PetClinicLocal.Views.Mascota;
using PetClinicLocal.Views.Usuario;
using PetClinicLocal.Views.Veterinario;

namespace PetClinicLocal.Views
{
    public struct ViewsNames
    {
        public const string MainPageName = nameof(MainPage);
        public const string LoginPageName = nameof(LoginPage);

        public const string MasterMenuPageName = nameof(MasterMenuPage);

        #region Usuario

        public const string ResgisterUserPageName = nameof(ResgisterUserPage);

        #endregion

        #region Mascota

        public const string MainMascotaPageName = nameof(MainMascotaPage);
        public const string AddMascotaPageName = nameof(AddMascotaPage);
        public const string TabbedMascotaPageName = nameof(TabbedMascotaPage);

        #endregion

        #region Veterinario

        public const string MainVeterinarioPageName = nameof(MainVeterinarioPage);

        #endregion

        #region Cita

        public const string MainCitaPageName = nameof(MainCitaPage);

        #endregion
    }
}
