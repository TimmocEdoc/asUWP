using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UI.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        private int _choosedGender = 2;
        public Register()
        {
            this.InitializeComponent();
        }

        public bool ValidatePassword(string password, string confirmPassword)
        {
            if (confirmPassword == password)
            {
                return true;
            }
            return false;
        }
        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                return false;
            }
            return true;
        }
        private void Gender_Choose(object sender, RoutedEventArgs e)
        {
            var chooseRadioButton = (RadioButton)sender;
            if (chooseRadioButton == null)
            {
                return;
            }
            switch (chooseRadioButton.Tag)
            {
                case "Male":
                    _choosedGender = 1;
                    break;
                case "Female":
                    _choosedGender = 0;
                    break;
                case "Other":
                    _choosedGender = 2;
                    break;
            }
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            String firstname = Firstname.Text;
            String lastname = Lastname.Text;
            String password = Password.Text;
            String email = Email.Text;
            String address = Address.Text;
            String avatar = Avatar.Text;
            String phone = Phone.Text;
            String birthday = Birthday.Date.ToString("yyyy/MM/dd");
            int gender = _choosedGender;
            if (ValidateEmail(email))
            {
                if(ValidatePassword(password, ConfirmPassword.Text))
                {
                    if(firstname.Length != 0)
                    {
                        if(lastname.Length != 0)
                        {
                            if(address.Length != 0)
                            {
                                if(avatar.Length != 0)
                                {
                                    if(phone.Length != 0)
                                    {
                                        Models.User user = new Models.User(firstname, lastname, email, password, address, phone, avatar, birthday, gender);
                                        user.UserList.Add(user);
                                        this.Frame.Navigate(typeof(Pages.Login));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            // you can also add items in code behind
            NavView.MenuItems.Add(new NavigationViewItemSeparator());
            NavView.MenuItems.Add(new NavigationViewItem()
            { Content = "My content", Icon = new SymbolIcon(Symbol.Folder), Tag = "content" });

            // set the initial SelectedItem 
            foreach (NavigationViewItemBase item in NavView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "home")
                {
                    NavView.SelectedItem = item;
                    break;
                }
            }
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
            NavView_Navigate(item as NavigationViewItem);
        }
        private void NavView_Navigate(NavigationViewItem item)
        {
            switch (item.Tag)
            {
                case "register":
                    this.Frame.Navigate(typeof(Pages.Register));
                    break;

                case "login":
                    this.Frame.Navigate(typeof(Pages.Login));
                    break;

                case "list":
                    this.Frame.Navigate(typeof(Pages.SongList));
                    break;

                case "addsong":
                    this.Frame.Navigate(typeof(Pages.AddSongs));
                    break;
            }
        }
    }
}
