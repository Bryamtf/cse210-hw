using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // VIDEO 1
        Video videoConferenceGeneral = new Video("Conference General October 2025", "Church Of JesusChrist", 3000);
        videoConferenceGeneral.AddComment(new Comment("Bryam Terrones", "It's a beautiful video!"));
        videoConferenceGeneral.AddComment(new Comment("Daniel Terrones", "It's an excellent video!"));
        videoConferenceGeneral.AddComment(new Comment("Carlos Terrones", "Very good!"));
        videos.Add(videoConferenceGeneral);

        // VIDEO 2
        Video videoLoFi = new Video("Lo-Fi Beats to Relax/Study", "ChilledCow", 7200);
        videoLoFi.AddComment(new Comment("Lucía Gómez", "I love visual production."));
        videoLoFi.AddComment(new Comment("Pedro Ramos", "The music is very relaxing."));
        videoLoFi.AddComment(new Comment("Ana Torres", "I'll use it to study, thank you."));
        videos.Add(videoLoFi);

        // VIDEO 3
        Video videoReceta = new Video("How to make Lomo Saltado", "Peruvian Kitchen", 900);
        videoReceta.AddComment(new Comment("Jorge Castillo", "What a great recipe, I'm going to try it!"));
        videoReceta.AddComment(new Comment("María López", "It looks delicious, thanks for sharing."));
        videoReceta.AddComment(new Comment("Luis Fernández", "I love the way you explain it."));
        videos.Add(videoReceta);

        // Iterate and display all videos with their comments
        Console.WriteLine("\n--- VIDEO LIST ---");
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}