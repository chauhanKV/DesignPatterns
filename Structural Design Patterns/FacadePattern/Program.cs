using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            show();
        }

        public static void show()
        {
            var twitterAPI = new TwitterAPI();
            var tweets = twitterAPI.getRecentTweets();
            foreach (Tweet tweet in tweets)
                Console.WriteLine(tweet.Message);

            twitterAPI.composeTweet("New Message");
            twitterAPI.likeTweet(true);
            Console.ReadLine();

        }
    }
}
