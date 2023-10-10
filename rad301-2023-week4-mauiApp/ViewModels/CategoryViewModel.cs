using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.Audio;
using ProductModel;
using rad301_2023_week3_mauiApp.DataLayer;
using rad301_2023_week3_mauiApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad301_2023_week3_mauiApp.ViewModels
{
    [QueryProperty("CurrentCategory", "CurrentCategory")]
    public partial class CategoryViewModel : ObservableObject
    {
        public ICategory<Category> CategoryDataService { get; }
        public CategoryViewModel(ICategory<Category> categoryDataService) {
            CategoryDataService = categoryDataService;
        }

        [ObservableProperty]
        Category currentCategory = new();

        [ObservableProperty]
        ObservableCollection<Product> categoryProducts = new();

        [RelayCommand]
        public async void Goto(Product product)
        {
            // Call the Patient sessions 
            await Shell.Current.GoToAsync(nameof(CategoryProductsPage),
                new Dictionary<string, object> { { "CurrentProduct", product} });
        }

        public void LoadProducts()
        {
            if (CategoryProducts != null)
            {
                CategoryProducts.Clear();
                CategoryProducts = new ObservableCollection<Product>(CurrentCategory.Products);
            }
        }



    }
}
