using System;
using System.Windows;

namespace ListboxDemo
{
    public class AutoWireViewModel
    {
        public static bool GetIsAutoBindViewModel(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsAutoBindViewModelProperty);
        }

        public static void SetIsAutoBindViewModel(DependencyObject obj, bool value)
        {
            obj.SetValue(IsAutoBindViewModelProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsAutoBindViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAutoBindViewModelProperty =
            DependencyProperty.RegisterAttached("IsAutoBindViewModel", typeof(bool), typeof(AutoWireViewModel), new PropertyMetadata(false, OnPropertyChanged));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var view = d as IView;
            if (view != null)
            {
                SetDataContext(view);
            }
        }

        private static void SetDataContext(IView view)
        {
            var fullname = view.GetType()
                .FullName;

            // Get view model full name
            var viewModelFullname = fullname.Replace(".Views.", ".ViewModels.");
            viewModelFullname = $"{viewModelFullname}ViewModel";

            var ViewModel = Activator.CreateInstance(Type.GetType(viewModelFullname));
            view.DataContext = ViewModel;
        }
    }

    public interface IView
    {
        object DataContext { get; set; }
    }
}
