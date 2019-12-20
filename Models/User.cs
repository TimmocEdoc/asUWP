using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    class User : Interfaces.IUser
    {
        private string firstname;
        private string lastname;
        private string email;
        private string password;
        private string address;
        private string phone;
        private string avatar;
        private string birthday;
        private int gender;
        public List<User> UserList = new List<User>();
        public User() { }
        public User(string firstname, string lastname, string email, string password, string address, string phone, string avatar, string birthday, int gender)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.Address = address;
            this.Avatar = avatar;
            this.Birthday = birthday;
            this.Gender = gender;
        }

        public string Firstname { get => firstname; set => firstname = Firstname; }
        public string Lastname { get => lastname; set => lastname = Lastname; }
        public string Password { get => password; set => password = Password; }
        public string Email { get => email; set => email = Email; }
        public string Address { get => address; set => address = Address; }
        public string Avatar { get => avatar; set => avatar = Avatar; }
        public string Phone { get => phone; set => phone = Phone; }
        public int Gender { get => gender; set => gender = Gender; }
        public string Birthday { get => birthday; set => birthday = Birthday; }
    }
}
