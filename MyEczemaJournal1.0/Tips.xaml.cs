namespace MyEczemaJournal1._0;

public partial class Tips : ContentPage
{
	public Tips()
	{
		InitializeComponent();
	}
    async void OnkkmClicked(object sender, EventArgs args)
    {

        await Browser.OpenAsync(" https://youtu.be/OzZVh26MO0k?si=rBT_b29iR2EImI2m", BrowserLaunchMode.SystemPreferred);

    }
    async void OnnihClicked(object sender, EventArgs args)
    {

        await Browser.OpenAsync("https://youtu.be/p-NVeGnK71w?si=nw2_DW6BKGlDzO8d", BrowserLaunchMode.SystemPreferred);

    }
    async void OnnhsClicked(object sender, EventArgs args)
    {

        await Browser.OpenAsync("https://youtu.be/pFO-qON7Br0?si=IxtJdNQGm3doB6gI", BrowserLaunchMode.SystemPreferred);

    }

}