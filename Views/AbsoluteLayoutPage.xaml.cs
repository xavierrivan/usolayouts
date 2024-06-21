namespace usolayouts.Views;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
	}
}

private async void OnGridLayoutButtonClicked(object sender, EventArgs e)
{
    await Navigation.PushAsync(new GridLayoutPage());
}
