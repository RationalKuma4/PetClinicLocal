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

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem { Title = "Veterinarios", Icon = "surre.png", TargetType = typeof(MainCitaPage) };
            var page2 = new MasterPageItem { Title = "Mascotas", Icon = "paww.png", TargetType = typeof(TabbedMascotaPage) };
            var page3 = new MasterPageItem { Title = "Citas", Icon = "cale.png", TargetType = typeof(MainVeterinarioPage) };

            // Adding menu items to menuList
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainCitaPage)));
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
