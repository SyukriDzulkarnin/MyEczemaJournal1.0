namespace MyEczemaJournal1._0
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnQuestion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Question());
        }
        private async void OnHistory(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new History());
        }
        private async void OnTips(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tips());
        }
        private async void OnAbout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }
    }

}
