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
    public partial class MainViewModel : ObservableObject
    {
        public IAudioManager AudioManager { get; set; }
        public ICategory<Category> CategoryDataService { get; }
        public IAudioPlayer AudioPlayer { get; set; }
        public MainViewModel(ICategory<Category> categoryDataService, IAudioManager audioManager) {
            AudioManager = audioManager;
            CategoryDataService = categoryDataService;
            Categories = new(Task.Run (() => categoryDataService.GetAll()).Result);
        }

        [ObservableProperty]
        List<Category> categories;

        [RelayCommand]
        public async void Tap(Category category)
        {
            // Call the Patient sessions 
            await Shell.Current.GoToAsync(nameof(CategoryPage),
                new Dictionary<string, object> { { "CurrentCategory", category } });
        }


        public void Play(string Sound)
        {
            System.IO.Stream s = Task.Run(() => FileSystem.OpenAppPackageFileAsync(Sound)).Result ;
            AudioPlayer = AudioManager.CreatePlayer(s);
            AudioPlayer.Play();
        }

        public async void FillCategories()
        {
            
        }

    }
}
