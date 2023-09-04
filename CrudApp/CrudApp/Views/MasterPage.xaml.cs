using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CrudApp.Views

{
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            Title = "Select Option";

        }
        public bool IsPresented { get; private set; }
        public MasterDetailPage MainPage { get; }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            if (e.SelectedItem == null)
                return;

            var selectedItem = e.SelectedItem.ToString();
            Page page = null;

            switch (selectedItem)
            {
                case "Add Company":
                    page = new AddCompanyPage();
                    break;
                case "Delete Company":
                    page = new DeleteCompanyPage();
                    break;
                case "Edit Company":
                    page = new EditCompanyPage();
                    break;
                case "Get All Companies":
                    page = new GetAllCompaniesPage();
                    break;
                default:
                    // Página de inicio u otras opciones
                    page = new HomePage();
                    break;
            }

            await Navigation.PushAsync(page);

            // Cierra la barra lateral
            IsPresented = false;
        }
    }
}
