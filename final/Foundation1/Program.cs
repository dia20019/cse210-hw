using System;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Earth To God";
        video1._length = "375";
        video1._author = "John Rich";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Victor Rams";
        video1Comment1._commentText = "Needed to hear this today.";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "David Nyonga";
        video1Comment2._commentText = "Would have rather a reaggeae song";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Ceron Pesta";
        video1Comment3._commentText = "The piano is strong on this one";

        Video video2 = new Video();
        video2._title = "Ghost";
        video2._length = "321";
        video2._author = "Tom McDonald";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Rodrigo Wronsky";
        video2Comment1._commentText = "motivation!!!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Hansma Neenas";
        video2Comment2._commentText = "Dedicated it to my lady";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Ruben PM";
        video2Comment3._commentText = "Still lonely tough";

        Video video3 = new Video();
        video3._title = "Family First";
        video3._length = "401";
        video3._author = "Demun Jones";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Raphael Velazquez";
        video3Comment1._commentText = "he's spot on";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Yahairo Rojas";
        video3Comment2._commentText = "My motto";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Sean Void";
        video3Comment3._commentText = "Liked his last album the best";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Isaac AT";
        video3Comment4._commentText = "Trained to this beat today";

        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
        video3._commentList.Add(video3Comment4);

        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}