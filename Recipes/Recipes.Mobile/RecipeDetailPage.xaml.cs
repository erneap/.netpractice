using Recipes.Client.Core.ViewModels;

namespace Recipes.Mobile;

public partial class RecipeDetailPage : ContentPage
{
	public RecipeDetailPage()
	{
		InitializeComponent();

		BindingContext = new RecipeDetailViewModel();
	}
}