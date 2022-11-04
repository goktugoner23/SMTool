using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
using Stream = Tweetinvi.Stream;

namespace SMTool
{
    [System.Serializable]
    public class TweetUser
    {
        //private const string FOLDER_XML = @"XmlFiles";
        //private const string FILE_USERS = FOLDER_XML + @"/users.xml";


        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                SetUser();
            }
        }
        public List<string> Followers { get; set; }
        public List<string> Followings { get; set; }
        public List<SearchedTweet> Tweets { get; set; }


        private IUser user;


        public TweetUser()
        {
            Followers = new List<string>();
            Followings = new List<string>();
            Tweets = new List<SearchedTweet>();
        }

        public TweetUser(string name)
        {
            Name = name;
            Followers = new List<string>();
            Followings = new List<string>();
            Tweets = new List<SearchedTweet>();
            SetUser();
        }

        private void SetUser()
        {
            user = User.GetUserFromScreenName(Name);
        }

        public async void GetFollowings()
        {
            var userFollowings = user.GetFriends(1000000);
            Followings = userFollowings.Select(userFollowing => userFollowing.ScreenName).ToList();
        }

        public async void GetFollowers()
        {
            var userFollowers = user.GetFollowers(1000000);
            Followers = userFollowers.Select(userFollower => userFollower.ScreenName).ToList();
        }

        public async void GetTweets()
        {
            var userTweets = user.GetUserTimeline(Properties.Settings.Default.TweetSayisi);
            Tweets.Clear();
            if (userTweets != null)
            {
                userTweets.ToList().ForEach(userTweet =>
                {
                    
                    SearchedTweet twt = new SearchedTweet();
                    twt.UserName = userTweet.CreatedBy.ScreenName;
                    twt.Date = userTweet.CreatedAt; //buraya date kontrolü eklenmeli
                    twt.TweetRTCount = userTweet.RetweetCount; //ekleme
                    twt.TweetFavCount = userTweet.FavoriteCount; //ekleme

                    if (userTweet.Place != null)
                    {
                        twt.Place = userTweet.Place.FullName;
                    }

                    if (userTweet.IsRetweet == true)
                    {
                        twt.TweetType = "Retweet";
                        twt.TweetFrom = userTweet.RetweetedTweet.CreatedBy.ScreenName;
                        twt.Text = userTweet.RetweetedTweet.Text;
                    }
                    else if (userTweet.InReplyToScreenName != null)
                    {
                        twt.TweetType = "Mention";
                        twt.TweetFrom = userTweet.InReplyToScreenName;
                        twt.Text = userTweet.Text;
                    }
                    else
                    {
                        twt.TweetType = "Tweet";
                        twt.TweetFrom = userTweet.CreatedBy.ScreenName;
                        twt.Text = userTweet.Text;
                    }

                    twt.Url = userTweet.Url;
                    Tweets.Add(twt);
                });
            } //tek seferde 200 çekiyor, hepsini çekmek için iteration eklenmeli
        }

        public async void GetInformations()
        {
            GetFollowings();
            GetFollowers();
            GetTweets();
        }

    }
}
