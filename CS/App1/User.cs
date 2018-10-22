using DevExpress.Mvvm;

namespace App1
{
    public class User : BindableBase
    {
        public User() { }

        public User(int id, string name, UserRole role)
        {
            Name = name;
            ID = id;
            Role = role;
        }


        protected int _ID;
        public int ID
        {
            get { return this._ID; }
            set { this.SetProperty(ref this._ID, value, "ID"); }
        }

        protected string _Name;
        public string Name
        {
            get { return this._Name; }
            set { this.SetProperty(ref this._Name, value, "Name"); }
        }


        protected UserRole _Role;
        public UserRole Role
        {
            get { return this._Role; }
            set { this.SetProperty(ref this._Role, value, "Role"); }
        }
    }
}
