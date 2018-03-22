using System.Windows.Input;
using BlogApp.ViewModels.Base;
using Prism.Commands;
using Prism.Navigation;

namespace BlogApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand FormCommand { get; }
        public ICommand AvatarsCommand { get; }
        public ICommand ExpandAndCollapseCommand { get; }

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            FormCommand = new DelegateCommand(OnFormCommand);
            AvatarsCommand = new DelegateCommand(OnAvatarsCommand);
            ExpandAndCollapseCommand = new DelegateCommand(OnExpandAndCollapseCommand);
        }

        private void OnExpandAndCollapseCommand()
        {
            NavigationService.NavigateAsync("ExpandAndCollapsePage");
        }

        private void OnAvatarsCommand()
        {
            NavigationService.NavigateAsync("AvatarsPage");
        }

        private void OnFormCommand()
        {
            NavigationService.NavigateAsync("FormPage");
        }
    }
}