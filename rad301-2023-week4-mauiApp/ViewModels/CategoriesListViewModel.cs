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
    public partial class CategoriesListViewModel : ObservableObject
    {
        public ICategory<Category> CategoryDataService { get; }
        public CategoriesListViewModel(ICategory<Category> categoryDataService) {
            CategoryDataService = categoryDataService;
            Categories = new(Task.Run(() => CategoryDataService.GetAll()).Result);
        }

        [ObservableProperty]
        ObservableCollection<Category> categories = new();

        [RelayCommand]
        public async void Goto(Category category)
        {
            // Call the Category Page with it's assocaited view
            await Shell.Current.GoToAsync(nameof(CategoryPage),
                new Dictionary<string, object> { { "CurrentCategory", category} });
        }


    }
}
