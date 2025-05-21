namespace GridWR;

public partial class ABSOLUTE : ContentPage
{
	public ABSOLUTE()
	{
		InitializeComponent();
	}

    private async void IrAGrid(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///GRID");
    }
}