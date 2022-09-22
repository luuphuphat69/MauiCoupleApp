using MauiToDoList.ViewModels;

namespace MauiToDoList.Pages;

public partial class GiftPage : ContentPage
{
	public GiftPage()
	{
		InitializeComponent();
		BindingContext = new DateViewModel();
	}

}