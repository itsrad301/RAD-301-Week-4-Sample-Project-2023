using rad301_2023_week3_mauiApp.Pages;

namespace rad301_2023_week3_mauiApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(CategoriesListPage), typeof(CategoriesListPage));
            Routing.RegisterRoute(nameof(CategoryPage), typeof(CategoryPage));
            Routing.RegisterRoute(nameof(CategoryProductsPage), typeof(CategoryProductsPage));
            InitializeComponent();
        }
    }
}