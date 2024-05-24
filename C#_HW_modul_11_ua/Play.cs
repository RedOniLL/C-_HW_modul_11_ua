using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_11_ua
{
    public class Play : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Genre: {Genre}, Year: {Year}");
        }

        ~Play()
        {
            Console.WriteLine("Destructor called for Play");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose called for Play");
            GC.SuppressFinalize(this);
        }
    }
}
