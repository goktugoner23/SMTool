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
    public class TwitterFunctions
    {
        //Twitter Developer Credentials - Enter your consumer key here
        const string CONSUMER_KEY = "";       
        const string CONSUMER_SECRET = "";
        const string USER_ACCESS_TOKEN = "";
        const string USER_ACCESS_SECRET = "";

        /*private const string FOLDER_XML = @"XmlFiles";
        private const string FILE_USERS = FOLDER_XML + @"/users.xml";*/

        public static void Connect()
        {
            Auth.SetUserCredentials(CONSUMER_KEY, CONSUMER_SECRET, USER_ACCESS_TOKEN, USER_ACCESS_SECRET);
        }
        public static List<TweetUser> UsersToSave { get; set; }

        //XML yazma
        public static void WriteXML<T>(T objectToSave, string savePath)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            System.IO.FileStream file = System.IO.File.Create(savePath);
            writer.Serialize(file, objectToSave);
            file.Close();
        }
        public static List<SearchedTweet> SearchTweets(string toSearch) //TWITTER SEARCH OPERATORLAR BURADA ÇALIŞIYOR EKLEMEYE GEREK YOK
        {
            if (string.IsNullOrWhiteSpace(toSearch))
            {
                List<SearchedTweet> sonuc = new List<SearchedTweet>();
                return sonuc;
            }
            else
            {
                //SMTool f1 = new SMTool();
                var searchParameter = new SearchTweetsParameters(toSearch)
                {
                    MaximumNumberOfResults = Properties.Settings.Default.TweetSayisi,                    
                };      

                var matchingTweets = Search.SearchTweets(searchParameter);
                List<SearchedTweet> sonuc = new List<SearchedTweet>();

                matchingTweets.ToList().ForEach(userTweet =>
                {
                    SearchedTweet twt = new SearchedTweet();
                    twt.UserName = userTweet.CreatedBy.ScreenName;
                    twt.Date = userTweet.CreatedAt;
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
                    twt.TweetRTCount = userTweet.RetweetCount;
                    twt.TweetFavCount = userTweet.FavoriteCount;
                    sonuc.Add(twt);
                });
                //var person = matchingTweets.Select(matchingTweets1 => matchingTweets1.CreatedBy.ScreenName).ToList();
                // return person;

                return sonuc;
            }
        }
    }


}
