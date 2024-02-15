using System;
using System.Collections.Generic;

namespace YouTubeTrackVids
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>
            {
                new Video("Journey To Heaven", "JohnBunyan", 800),
                new Video("Make Money Online", "Mils Wise Sylva", 640),
                new Video("The Passion of the Christ", "Elie Smith", 1500),
                new Video("Help you Build Growth Mindset", "Emilus Sylvain", 740)
            
            };

            videos[0].AddComment("Nice lesson", "I enjoyed watching it, much love!");
            videos[0].AddComment("that was amazing", "Very helpful, very accurate.");
            videos[0].AddComment("thanks for the video", "Love the content, bring new for us!");
            videos[0].AddComment("gud stuff", "yayyy, thanks!");
            videos[0].AddComment("una gatita", " que le gusto, el manbo");
            videos[0].AddComment("Baseball tomorrow", "H****t, ");
            videos[0].AddComment("my Homie", "Dang it is dope!, ");

            videos[1].AddComment("good stuff", "dude, cool.");
            videos[1].AddComment("Ainsi soit it", "I hear you!");
            videos[1].AddComment("wow", "save it to my pc.");
            videos[1].AddComment("ayay", "cool  teacher.");
            


            videos[2].AddComment("amazing", "course is amazing, lots of info.");
            videos[2].AddComment("the guy", "keep up the good works, thank you!");
            videos[2].AddComment("roger", "bring some more like this please.");
            videos[2].AddComment("master", "You the man.");
            videos[2].AddComment("Mils", "so you've made my day.");

            videos[3].AddComment("gold course", "five stars.");
            videos[3].AddComment("sssss", "nice, hmm");
            videos[3].AddComment("save it", "more, please ");
            videos[3].AddComment("Wow", "Thanks bro, I appreciate you ");
            videos[3].AddComment("incredible", "You are the best, ");
            videos[3].AddComment("Love you", "Proud of you, ");

            foreach (Video video in videos)
            {

                video.DisplayInfo();
            }
        }
    }
}
