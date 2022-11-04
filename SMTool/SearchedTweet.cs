using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace SMTool
{
    public class SearchedTweet
    {
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Url { get; set; }
        public string TweetType { get; set; }
        public string TweetFrom { get; set; }
        public int TweetFavCount { get; set; } //ekleme
        public int TweetRTCount { get; set; } //ekleme
        public int InteractionCount { get; set; } //ekleme
        public int tweetid { get; set; }

        public SearchedTweet()
        {
        }

        public SearchedTweet(string userName, string text, DateTime date, string location, string url, string tweetType, string tweetFrom, int rtcount, int favcount, int intcount, int id)
        {
            UserName = userName;
            Text = text;
            Date = date;
            Place = location;
            Url = url;
            TweetType = tweetType;
            TweetFrom = tweetFrom;
            TweetRTCount = rtcount; //ekleme
            TweetFavCount = favcount; //ekleme
            InteractionCount = intcount; //ekleme
            tweetid = id;
        }
    }
}
