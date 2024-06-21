namespace usolayouts.Views;

public partial class GridLayoutPage : ContentPage
{
	public GridLayoutPage()
	{
		InitializeComponent();
	}

    private async void OnStackLayoutButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayoutPage());
    }

}