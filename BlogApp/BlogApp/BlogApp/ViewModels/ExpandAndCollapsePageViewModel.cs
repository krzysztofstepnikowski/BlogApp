using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Xamarin.Forms;

namespace BlogApp.ViewModels
{
    public class ExpandAndCollapsePageViewModel : BindableBase
    {
        private bool _isExpand;

        public bool IsExpand
        {
            get { return _isExpand; }
            set
            {
                _isExpand = value;
                SetProperty(ref _isExpand, value);
            }
        }

        public ICommand ExpandCommand { get; }

        public ExpandAndCollapsePageViewModel()
        {
            ExpandCommand = new DelegateCommand<VisualElement>(obj => Expand(obj as StackLayout));
        }

        private void Expand(StackLayout obj)
        {
            var height = 200;
            IsExpand = !IsExpand;
            obj.Children[0].HeightRequest = IsExpand ? height : 0;
        }
    }
}