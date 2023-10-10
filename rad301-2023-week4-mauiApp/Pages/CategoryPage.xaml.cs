using rad301_2023_week3_mauiApp.ViewModels;

namespace rad301_2023_week3_mauiApp.Pages;

public partial class CategoryPage : ContentPage
{
	public CategoryPage(ICategory<Category> categoryDataService)
	{
        BindingContext = new CategoryViewModel(categoryDataService);
		InitializeComponent();
	}

    public CategoryViewModel CategoryViewModel
    {
        get => default;
        set
        {
        }
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        if (BindingContext != null)
        {

            CategoryViewModel vm = (CategoryViewModel)this.BindingContext;
            vm.LoadProducts();
        }

        base.OnNavigatedTo(args);
    }
}