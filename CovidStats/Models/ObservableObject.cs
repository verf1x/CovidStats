using System.ComponentModel;
using System;

namespace CovidStats.Models
{
    internal abstract class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] String prop = "") 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        protected virtual Boolean Set<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] String? propName = null)
        {
            if (Equals(field, value)) return false;
            field = value;

#pragma warning disable CS8604 // Possible null reference argument.
            OnPropertyChanged(propName);
#pragma warning restore CS8604 // Possible null reference argument.

            return true;
        }
    }
}
