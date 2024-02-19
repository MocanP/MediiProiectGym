using MediiProiectGym.Models;

namespace MediiProiectGym;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (WorkoutList)BindingContext;
        slist.Date = DateTime.UtcNow;
        await App.Database.SaveShopListAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (WorkoutList)BindingContext;
        await App.Database.DeleteShopListAsync(slist);
        await Navigation.PopAsync();
    }

}