using Plugin.Maui.Audio;
using ProductModel;
using rad301_2023_week3_mauiApp.ViewModels;

namespace rad301_2023_week3_mauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        ICategory<Category> CategoryService;
        MainViewModel _mainViewModel;
        public MainPage(ICategory<Category> categoryDataService, IAudioManager audioManager)
        {
            MainViewModel = new MainViewModel(categoryDataService, audioManager);
            CategoryService = categoryDataService;
            BindingContext = MainViewModel;
            InitializeComponent();
        }

        public MainViewModel MainViewModel
        {
            get => _mainViewModel;
            set  
            { _mainViewModel = value;
            }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            MainViewModel.Play("1.wav");
            count++;
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        protected override async void OnAppearing()
        {
            MainViewModel.Play("0.wav");

        }

        private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = e.CurrentSelection.FirstOrDefault();
            Category category = (Category)selection;
            MainViewModel.Tap(category);
        }
    }
    
}