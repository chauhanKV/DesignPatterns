using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class TwitterAPI
    {
        public string getAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.requestToken("appKey", "secret");
            var accessToken = oauth.getAccessToken(requestToken);
            return accessToken;
        }

        public List<Tweet> getRecentTweets()
        {
            var twitterClient = new TwitterClient();
            List<Tweet> tweets = twitterClient.getRecentTweets(getAccessToken());
            Console.WriteLine("Getting recent tweets");

            return tweets;
        }


        public void composeTweet(string message)
        {
            var twitterClient = new TwitterClient();
            twitterClient.composeTweet(message, getAccessToken());
        }

        public void likeTweet(bool isLiked)
        {
            var twitterClient = new TwitterClient();
            twitterClient.likeTweet(isLiked, getAccessToken());
        }
    }
}
