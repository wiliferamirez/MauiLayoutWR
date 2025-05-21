using Microsoft.Maui.Controls;

namespace GridWR
{
    public partial class GRID : ContentPage
    {
        public GRID()
        {
            InitializeComponent();
        }
        private async void IrAStack(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///STACK");
        }
    }
}