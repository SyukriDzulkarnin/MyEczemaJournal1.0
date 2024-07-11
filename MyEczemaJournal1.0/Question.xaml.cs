using System.Diagnostics;

namespace MyEczemaJournal1._0
{
    public partial class Question : ContentPage
    {
        private string fileName;

        public Question()
        {
            InitializeComponent();
            // Initialize file path
            fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "records.txt");
            Console.WriteLine("File Path: " + fileName);
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void CalculateSum()
        {
            int sum = 0;
            sum += Picker1.SelectedIndex + 1;
            sum += Picker2.SelectedIndex + 1;
            sum += Picker3.SelectedIndex + 1;
            sum += Picker4.SelectedIndex + 1;

            ResultLabel.Text = $"Sum: {sum}";
        }

        void onDatePickerSelected(object sender, DateChangedEventArgs e)
        {
            // Do nothing, this handler might be unnecessary if not used elsewhere
        }

        async void OnSaveRecord(object sender, EventArgs e)
        {
            var selectedDate = selectDate.Date.ToString("dd/MM/yyyy");
            var picker1Value = Picker1.SelectedItem?.ToString();
            var picker2Value = Picker2.SelectedItem?.ToString();
            var picker3Value = Picker3.SelectedItem?.ToString();
            var picker4Value = Picker4.SelectedItem?.ToString();
            int sum = 0;
            sum += Picker1.SelectedIndex + 1;
            sum += Picker2.SelectedIndex + 1;
            sum += Picker3.SelectedIndex + 1;
            sum += Picker4.SelectedIndex + 1;

            ResultLabel.Text = $"Sum: {sum}";
            var writerRecord = selectedDate +
                "\nSkin: " + picker1Value +
                "\nStress: " + picker2Value +
                "\nWater: " + picker3Value +
                "\nProduct: " + picker4Value +
                "\nDaily Record " + $"Sum: {sum}" +
                "\n";

            await SaveToFileAsync(writerRecord);
        }

        private async Task SaveToFileAsync(string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    await writer.WriteLineAsync(text);
                }
                await DisplayAlert("Success", "Record saved successfully.", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred while saving the record: {ex.Message}", "OK");
            }
        }
        async void OnViewRecords(object sender, EventArgs e)
        {
            try
            {
                string content = File.ReadAllText(fileName);
                await DisplayAlert("Records", content, "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred while reading the file: {ex.Message}", "OK");
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

      }
}
