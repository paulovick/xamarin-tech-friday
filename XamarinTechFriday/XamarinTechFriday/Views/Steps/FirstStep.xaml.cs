using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTechFriday.ViewModels;

namespace XamarinTechFriday.Views.Steps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstStep : ContentPage
	{
		public FirstStep()
		{
			InitializeComponent ();

            this.BindingContext = new FirstStepViewModel();
		}
	}
}