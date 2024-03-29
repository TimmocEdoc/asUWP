﻿using System;
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
    public sealed partial class AddSongs : Page
    {
        public AddSongs()
        {
            this.InitializeComponent();
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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string author = Author.Text;
            string singer = Singer.Text;
            string thumbnail = Thumbnail.Text;
            string link = Link.Text;
            if (name.Length != 0)
            {
                if (author.Length != 0)
                {
                    if (singer.Length != 0)
                    {
                        if (thumbnail.Length != 0)
                        {
                            if (link.Length != 0)
                            {
                                Models.Song song = new Models.Song();
                                song.SongsList.Add(song);
                                this.Frame.Navigate(typeof(Pages.SongList));
                            }
                        }
                    }
                }
            }
        }
    }
}
