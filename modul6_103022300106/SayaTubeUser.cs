using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300106
{
    class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            Debug.Assert(username != null, "Username tidak boleh null");
            Debug.Assert(username.Length <= 100, "Username tidak boleh lebih dari 100 karakter");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null, "Video tidak boleh null");
            Debug.Assert(video.GetPlayCount() < int.MaxValue, "Playcount tidak boleh melebihi batas integer");
            uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach(var video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video ke-" + (i + 1) + ": " + uploadedVideos[i].GetTitle());
            }
        }

        public string GetUsername()
        {
            return username;
        }
    }
}
