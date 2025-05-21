namespace GridWR;

public partial class STACK : ContentPage
{
	public STACK()
	{
		InitializeComponent();
	}

    private async void IrAFlex(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///FLEX");
    }
}