using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace App1
{
    public class ViewModel : ViewModelBase
    {
        
        protected ObservableCollection<User> _Users;
        public ObservableCollection<User> Users
        {
            get
            {
                if (this._Users == null)
                {
                    this._Users = new ObservableCollection<User>() {
                        new User(0, "Jack", UserRole.Administrator),
                        new User(1, "Ron", UserRole.User),
                        new User(2, "John", UserRole.User),
                        new User(3, "Antoni", UserRole.User),
                        new User(4, "Paul", UserRole.Moderator),
                    };

                }

                return this._Users;
            }
        }


        protected UserRole _SelectedRole;
        public UserRole SelectedRole
        {
            get { return this._SelectedRole; }
            set { this.SetProperty(ref this._SelectedRole, value, "SelectedRole"); }
        }

    }
}
