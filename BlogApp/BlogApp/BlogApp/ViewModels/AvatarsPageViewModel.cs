using Prism.Mvvm;
using System.Collections.Generic;
using System.Linq;
using BlogApp.Model;

namespace BlogApp.ViewModels
{
    public class AvatarsPageViewModel : BindableBase
    {
        private List<Avatar> _avatars;

        public List<Avatar> Avatars
        {
            get { return _avatars; }
            set
            {
                _avatars = value;
                SetProperty(ref _avatars, value);
            }
        }

        public AvatarsPageViewModel()
        {
            InitialAvatars();
            ChangeAvatars();
        }

        private void InitialAvatars()
        {
            Avatars = new List<Avatar>
            {
                new Avatar
                {
                    Initial = "KS"
                },
                new Avatar
                {
                    Initial = "JK"
                },
                new Avatar
                {
                    Initial = "AS"
                },
                new Avatar
                {
                    Initial = "WS"
                },
                new Avatar
                {
                    Initial = "JM"
                }
            };
        }

        private void ChangeAvatars()
        {
            var maxPassengers = 2;
            if (Avatars.Count > maxPassengers)
            {
                var summary = new[] {new Avatar {Initial = $"+{Avatars.Count - 2}"}};
                Avatars = Avatars.Take(2).Concat(summary).ToList();
            }
        }
    }
}