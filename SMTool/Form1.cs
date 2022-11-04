using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization; //this might be needed because I'll use .xml if I won't use a more complex database -- Going with xml.
using Stream = Tweetinvi.Stream;
using System.Text.RegularExpressions;
using Tweetinvi.Logic;
using System.Windows.Forms.DataVisualization.Charting;

namespace SMTool
{
    public partial class SMTool : Form
    {
        List<SearchedTweet> searchedTweetList;
        UsersToSave userToSave;
        public SMTool()
        {
            InitializeComponent();
        }

        private void SMTool_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.TweetSayisi = 18000;
            TwitterFunctions.Connect();

            userToSave = new UsersToSave();

            if (File.Exists("XmlFiles/users.xml")) //Program xml'i silmeden kapanır ve xml'in dosyada kalma durumu olursa
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UsersToSave));
                StreamReader reader = new StreamReader("XmlFiles/users.xml");
                userToSave = (UsersToSave)serializer.Deserialize(reader);
                reader.Close();

                foreach (var user in userToSave.userList)
                {
                    foreach (var tweet in user.Tweets)
                    {
                        string newText = Regex.Replace(tweet.Text, @"\n", " ");
                        dataGrid_Details.Rows.Add(tweet.UserName, tweet.TweetFrom, tweet.TweetType, tweet.Date, tweet.Place, newText, tweet.TweetRTCount, tweet.TweetFavCount, tweet.InteractionCount, tweet.Url);
                    }
                }
            }
            else
            {
                TwitterFunctions.WriteXML(userToSave, "XmlFiles/users.xml");
            }
        }

        public void btn_IntGraph_Click(object sender, EventArgs e)
        {
            Interaction_Graph intGraph = new Interaction_Graph();
            intGraph.ShowDialog();
        }

        //Arama butonu
        private async void btn_accSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_userName.Text))
            {
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userName = textBox_userName.Text;
            int interactionCount_total = 0; //ekleme
            int interactionCount = 0; //ekleme
            btn_accSearch.Enabled = false;
            label_status.Visible = true;
            label_status.Text = "Receiving data...";

            TweetUser tweetUser = new TweetUser(userName);
            tweetUser.GetInformations();
            userToSave.userList.Add(tweetUser);
            TwitterFunctions.WriteXML(userToSave, "XmlFiles/users.xml");

            dataGrid_Details.Rows.Clear();
            foreach (var tweet in tweetUser.Tweets) 
            {
                string yeniText = Regex.Replace(tweet.Text, @"\n", " ");
                if (checkBox_Date.Checked) //ekleme
                {
                    if (tweet.Date >= dateTime_begin.Value && tweet.Date <= dateTime_end.Value)
                    {
                        if (tweet.TweetType == "Retweet") //if-else ekleme
                        {
                            interactionCount_total += tweet.TweetFavCount;
                            interactionCount = tweet.TweetFavCount;
                        }
                        else
                        {
                            interactionCount_total += tweet.TweetRTCount + tweet.TweetFavCount;
                            interactionCount = tweet.TweetRTCount + tweet.TweetFavCount;
                        }
                        tweet.InteractionCount = interactionCount;
                        dataGrid_Details.Rows.Add(tweet.UserName, tweet.TweetFrom, tweet.TweetType, tweet.Date, tweet.Place, yeniText, tweet.TweetRTCount, tweet.TweetFavCount, tweet.InteractionCount, tweet.Url);
                    }
                }
                else
                {
                    if (tweet.TweetType == "Retweet") //if-else ekleme
                    {
                        interactionCount_total += tweet.TweetFavCount;
                        interactionCount = tweet.TweetFavCount;
                    }
                    else
                    {
                        interactionCount_total += tweet.TweetRTCount + tweet.TweetFavCount;
                        interactionCount = tweet.TweetRTCount + tweet.TweetFavCount;
                    }

                    tweet.InteractionCount = interactionCount;
                    dataGrid_Details.Rows.Add(tweet.UserName, tweet.TweetFrom, tweet.TweetType, tweet.Date, tweet.Place, yeniText, tweet.TweetRTCount, tweet.TweetFavCount, tweet.InteractionCount, tweet.Url);
                }
            }
            
            label_status.Text = "Data claimed successfully. " + dataGrid_Details.Rows.Count + " tweet found." + "\nInteraction count: " + interactionCount_total + " (Fav - RT)";
            btn_accSearch.Enabled = true;
        }

        //Gelişmiş(hashtag) arama butonu
        private void btn_advSearch_Click(object sender, EventArgs e)
        {
            string toSearch = textBox_advSearch.Text;
            searchedTweetList = TwitterFunctions.SearchTweets(toSearch);
            var list = searchedTweetList.Select(items => items.Text);
            int interactionCount = 0; //ekleme
            int interactionCount_total = 0; //ekleme
            btn_accSearch.Enabled = false;
            label_status.Visible = true;
            label_status.Text = "Veriler Alınıyor...";
            //listBox5.Items.Clear();
            //listBox5.Items.AddRange(list.ToArray());

            dataGrid_Details.Rows.Clear();
            foreach (var tweet in searchedTweetList)
            {
                string yeniText = Regex.Replace(tweet.Text, @"\n", " ");

                if (tweet.TweetType == "Retweet") //if-else ekleme
                {
                    interactionCount_total += tweet.TweetFavCount;
                    interactionCount = tweet.TweetFavCount;
                }
                else
                {
                    interactionCount_total += tweet.TweetRTCount + tweet.TweetFavCount;
                    interactionCount = tweet.TweetRTCount + tweet.TweetFavCount;
                }
                tweet.InteractionCount = interactionCount;
                dataGrid_Details.Rows.Add(tweet.UserName, tweet.TweetFrom, tweet.TweetType, tweet.Date, tweet.Place, yeniText, tweet.TweetRTCount, tweet.TweetFavCount, tweet.InteractionCount, tweet.Url);
            }
            label_status.Text = "Data claimed successfully. " + dataGrid_Details.Rows.Count + " tweet found." + "\nInteraction count: " + interactionCount_total + " (Fav - RT)";
            btn_accSearch.Enabled = true;
            TwitterFunctions.WriteXML(searchedTweetList, "XmlFiles/tweets.xml");
        }

        private void SMTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("XmlFiles/users.xml"))
            File.Delete("XmlFiles/users.xml");
        }

        //URL referansı ekledim.
        private void dataGrid_Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = dataGrid_Details.Rows[e.RowIndex].Cells[9].Value.ToString();
            ProcessStartInfo psinfo = new ProcessStartInfo(url);
            Process.Start(psinfo);
        }
    }
}
