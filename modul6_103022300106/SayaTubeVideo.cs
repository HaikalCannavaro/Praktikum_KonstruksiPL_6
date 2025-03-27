using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300106
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Judul video tidak boleh kosong atau lebih dari 100 karakter!");
            }

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = playCount;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
            {
                throw new ArgumentOutOfRangeException("Jumlah play count harus di antara 0 dan 10 juta.");
            }
            playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video\t: " + id);
            Console.WriteLine("Judul Video\t: " + title);
            Console.WriteLine("Play Count\t: " + playCount);
        }

        public int GetPlayCount(){ return playCount; }
        public string GetTitle() { return title; }
    }
}
