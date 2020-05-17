using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class TwitterClient
    {
        public List<Tweet> getRecentTweets(string accessToken)
        {
            List<Tweet> tweets = new List<Tweet>();
            tweets.Add(new Tweet("We are young!"));
            tweets.Add(new Tweet("What a game!"));
            tweets.Add(new Tweet("Amazing restaurant.."));
            tweets.Add(new Tweet("Corona strikes!"));

            return tweets;
        }

        public void composeTweet(string message, string accessToken)
        {
            Console.WriteLine("Composing message.." + message);
        }

        public void likeTweet(bool isLiked, string accessToken)
        {
            Console.WriteLine("Liking Tweet " + isLiked);
        }



    }
}
