
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTechFriday.ViewModels;

namespace XamarinTechFriday.Views.Steps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThirdStep : ContentPage
	{
		public ThirdStep ()
		{
			InitializeComponent ();

            this.BindingContext = new ThirdStepViewModel();
		}

        private void Button_Clicked(object sender, System.EventArgs e)
        {
        }
    }
}