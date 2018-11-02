using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinTechFriday.Common
{
    public class BindableObjectBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected bool ChangePropertyValue<T>(ref T field,
                                              T value,
                                              [CallerMemberName] string propertyName = "",
                                              Action onChanged = null)
        {
            if (!Equals(field, value))
            {
                field = value;
                onChanged?.Invoke();
                RaisePropertyChanged(propertyName);
                return true;
            }

            return false;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
