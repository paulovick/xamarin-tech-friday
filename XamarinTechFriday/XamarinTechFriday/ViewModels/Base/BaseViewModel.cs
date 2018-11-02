
using XamarinTechFriday.Common;

namespace XamarinTechFriday.ViewModels.Base
{
    public abstract class BaseViewModel : BindableObjectBase
    {
        private string title;
        public string Title { get => this.title; set => this.ChangePropertyValue(ref this.title, value); }
    }
}
