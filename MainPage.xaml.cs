namespace LayoutProblem;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Shell.Current.Navigation.PushModalAsync(new Page3());
	}
}

