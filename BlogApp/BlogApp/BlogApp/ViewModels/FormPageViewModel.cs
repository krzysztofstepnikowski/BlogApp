using Prism.Mvvm;
using Prism.Commands;

namespace BlogApp.ViewModels
{
    public class FormPageViewModel : BindableBase
    {
        private string _firstname;
        private string _lastname;
        private DelegateCommand _continueCommand;

        public DelegateCommand ContinueCommand
        {
            get { return _continueCommand; }

            set
            {
                _continueCommand = value;
                SetProperty(ref _continueCommand, value);
            }
        }

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                SetProperty(ref _firstname, value);
                ContinueCommand.RaiseCanExecuteChanged();
            }
        }

        public string Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                SetProperty(ref _lastname, value);
                ContinueCommand.RaiseCanExecuteChanged();
            }
        }

        public FormPageViewModel()
        {
            ContinueCommand = new DelegateCommand(() => { }, CanContinue);
        }

        private bool Validate()
        {
            return !string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Lastname);
        }

        private bool CanContinue()
        {
            return Validate();
        }
    }
}