using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    class Song : Interfaces.ISong
    {
        private string name;
        private string author;
        private string singer;
        private string thumbnail;
        private string link;
        public List<Song> SongsList = new List<Song>();
        public Song() { }
        public Song(string name, string author, string singer, string thumbnail, string link)
        {
            this.Name = name;
            this.Author = author;
            this.Singer = singer;
            this.Thumbnail = thumbnail;
            this.Link = link;
        }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Singer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Thumbnail { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Link { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
