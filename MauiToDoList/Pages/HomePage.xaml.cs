using MauiToDoList.ViewModels;

namespace MauiToDoList.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}