using modul6_103022300106;
using System;

class program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Haikal Cannavaro");

        string[] films =
        {
            "Harry Potter", "Narnia", "Infinity War", "Spiderman", "Joker", "Endgame", "Interstellar", "Parasite", "Batman", "Silence"
        };

        for (int i = 0; i < films.Length; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo("Review Film " + films[i] + " oleh " + user.GetUsername());
            video.IncreasePlayCount(1000 * (i + 1));

            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine("Total Playcount: " + user.GetTotalVideoPlayCount());
       
    }
}