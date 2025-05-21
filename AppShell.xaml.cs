namespace GridWR
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("STACK", typeof(STACK));
            Routing.RegisterRoute("FLEX", typeof(FLEX));
            Routing.RegisterRoute("GRID", typeof(GRID));
            Routing.RegisterRoute("ABSOLUTE", typeof(ABSOLUTE));
        }
    }
}
