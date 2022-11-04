using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTool
{
    public class UsersToSave
    {
        public List<TweetUser> userList { get; set; }
        //public List<string> SearchedTweets { get; set; }


        public UsersToSave()
        {
            userList = new List<TweetUser>();
        }


        /* public void SearchByWord(string word)
         {
             //SearchedTweets = userList.Where(item => item.Tweets.Contains(word)).ToList();

             //var something = userList.Where(item => item.Tweets.Contains(word));
             SearchedTweets = userList.Select(something1 => something1.Tweets.ToString()).ToList();

         }*/
    }
}
