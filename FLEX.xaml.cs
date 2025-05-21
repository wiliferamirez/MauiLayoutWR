namespace GridWR;

public partial class FLEX : ContentPage
{
	public FLEX()
	{
		InitializeComponent();
	}

    private async void IrAbsolute(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ABSOLUTE");
    }
}