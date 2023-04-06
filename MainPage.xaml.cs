namespace Ideal_Weight;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void calculatorClicked(object sender, EventArgs e)
	{
		// navigate to calculator page
		await Navigation.PushAsync(new CalculatorView());
	}

    private void apiClicked(object sender, EventArgs e)
    {
        // navigate to calculator page
    }

    void btn2_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}


