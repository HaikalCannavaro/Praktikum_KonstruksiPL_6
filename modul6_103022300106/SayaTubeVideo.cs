using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null, "Judul video tidak boleh null.");
            Debug.Assert(title.Length <= 200, "Judul video tidak boleh lebih dari 200 karakter.");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 25000000, "Penambahan play count tidak boleh lebih dari 25.000.000");
            Debug.Assert(count >= 0, "Play count tidak boleh negatif");
            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Playcount melebihi batas.");
            }
           
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
