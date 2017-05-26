using System;
using System.Collections.Generic;
using PetClinicLocal.Models;
using PetClinicLocal.Views.Cita;
using PetClinicLocal.Views.Mascota;
using PetClinicLocal.Views.Veterinario;
using Xamarin.Forms;

namespace PetClinicLocal.Views
{
    public partial class MasterMenuPage : MasterDetailPage
    {
        public List<MasterPageItem> MenuList { get; set; }
        public MasterMenuPage()
        {
            InitializeComponent();

            MenuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem { Title = "Veterinarios", Icon = "surre.png", TargetType = typeof(MainCitaPage) };
            var page2 = new MasterPageItem { Title = "Mascotas", Icon = "paww.png", TargetType = typeof(TabbedMascotaPage) };
            var page3 = new MasterPageItem { Title = "Citas", Icon = "cale.png", TargetType = typeof(MainVeterinarioPage) };

            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);

            navigationDrawerList.ItemsSource = MenuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainMascotaPage)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
