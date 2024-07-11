namespace MyEczemaJournal1._0;

public partial class History : ContentPage
{
	public History()
	{
		InitializeComponent();
	}
    async void OnViewRecords(object sender, EventArgs e)
    {
        try
        {
            // Get the file path
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "records.txt");

            // Read the content of the file
            string content = File.ReadAllText(fileName);

            // Display the content in an alert dialog
            await DisplayAlert("Records", content, "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"An error occurred while reading the file: {ex.Message}", "OK");
        }
    }
}