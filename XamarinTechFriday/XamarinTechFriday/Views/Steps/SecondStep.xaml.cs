
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTechFriday.ViewModels;

namespace XamarinTechFriday.Views.Steps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondStep : ContentPage
	{
		public SecondStep ()
		{
			InitializeComponent ();

            this.BindingContext = new SecondStepViewModel();
		}
	}
}