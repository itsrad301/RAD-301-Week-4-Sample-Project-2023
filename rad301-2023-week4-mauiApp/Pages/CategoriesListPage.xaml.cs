using rad301_2023_week3_mauiApp.ViewModels;

namespace rad301_2023_week3_mauiApp.Pages;

public partial class CategoriesListPage : ContentPage
{
    CategoriesListViewModel _categoriesListViewModel;
    public CategoriesListPage(ICategory<Category> categoryDataService)
	{
        CategoriesListViewModel = new CategoriesListViewModel(categoryDataService);
        BindingContext = CategoriesListViewModel;
        InitializeComponent();
	}
    public CategoriesListViewModel CategoriesListViewModel
    {
        get => _categoriesListViewModel;
        set
        {
            _categoriesListViewModel = value;
        }
    }

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selection = e.CurrentSelection.FirstOrDefault();
        Category category = (Category)selection;
        CategoriesListViewModel.Goto(category);
    }
}