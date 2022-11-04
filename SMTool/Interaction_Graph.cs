using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography;

namespace SMTool
{
    public partial class Interaction_Graph : Form
    {
        UsersToSave userToSave;
        public Interaction_Graph()
        {
            InitializeComponent();
        }
        string[] range = new string[14];
        int[] interaction_months = new int[12];
        public List<string> dates { get; set; }
        public void Interaction_Graph_Load(object sender, EventArgs e) //Bar Chart
        {
            Interaction_Chart.Series.Clear();
            Interaction_Chart.Titles.Add("Etkileşim Grafiği (Bar)");
            Series S1 = new Series();
            S1.LegendText = "Etkileşim";

            if (File.Exists("XmlFiles/users.xml")) //Xml dosyasından tarihler ve etkileşim sayısını alıp chart a ekleme
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UsersToSave));
                StreamReader reader = new StreamReader("XmlFiles/users.xml");
                userToSave = (UsersToSave)serializer.Deserialize(reader);
                reader.Close();
                foreach (var user in userToSave.userList)
                {
                    foreach (var tweet in user.Tweets)
                    {
                        //aylara göre etkileşim sayısını grafiğe ekliyorum.
                        if (tweet.Date.Year == 2020)
                        {
                            switch (tweet.Date.Month)
                            {
                                case 1:
                                    interaction_months[0] += 1;
                                    break;
                                case 2:
                                    interaction_months[1] += 1;
                                    break;
                                case 3:
                                    interaction_months[2] += 1;
                                    break;
                                case 4:
                                    interaction_months[3] += 1;
                                    break;
                                case 5:
                                    interaction_months[4] += 1;
                                    break;
                                case 6:
                                    interaction_months[5] += 1;
                                    break;
                                case 7:
                                    interaction_months[6] += 1;
                                    break;
                                case 8:
                                    interaction_months[7] += 1;
                                    break;
                                case 9:
                                    interaction_months[8] += 1;
                                    break;
                                case 10:
                                    interaction_months[9] += 1;
                                    break;
                                case 11:
                                    interaction_months[10] += 1;
                                    break;
                                case 12:
                                    interaction_months[11] += 1;
                                    break;
                                default:
                                    Array.Clear(interaction_months, 0, interaction_months.Length);
                                    break;
                            }
                        }

                        if (tweet.Date.Month == 8 && tweet.Date.Year == 2020) //yıllık grafik için combobox eklenebilir.
                        {
                            //i++;
                            //range[8] = "Ağustos";
                        }
                    }
                }
                //S1.Points.AddXY(15, i);
                Interaction_Chart.Series.Add(S1);
            }
            else
            {
                TwitterFunctions.WriteXML(userToSave, "XmlFiles/users.xml");
                Interaction_Chart.Series.Add(S1);//tweet çekmeden kontrol için
            }


            Interaction_Chart.ChartAreas[0].AxisX.Minimum = 7;
            Interaction_Chart.ChartAreas[0].AxisX.Maximum = 20;
            Interaction_Chart.ChartAreas[0].AxisY.Minimum = 0;
            Interaction_Chart.ChartAreas[0].AxisY.Maximum = interaction_months.Max() + 10;
            Interaction_Chart.ChartAreas[0].AxisY.Interval = 5;
            //ay şeklinde eklemek daha mantıklı gibi
            range[0] = "";
            range[1] = "Ocak";
            range[2] = "Şubat";
            range[3] = "Mart";
            range[4] = "Nisan";
            range[5] = "Mayıs";
            range[6] = "Haziran";
            range[7] = "Temmuz";
            range[8] = "Ağustos";
            range[9] = "Eylül";
            range[10] = "Ekim";
            range[11] = "Kasım";
            range[12] = "Aralık";
            range[13] = "";

            for (int i = 0; i < 12; i++) 
            {
                S1.Points.AddXY(i+8, interaction_months[i]); //x ekseni minimum 7 old. range'ler 8 den başlıyor.
            }
            //Bu nokta değiştirme olaylarını customize eventine de yazabilirim. - yazamadım değerleri atamıyor.


            //PIE CHART
            chart_pie.Titles.Add("Etkileşim Grafiği (Pasta)");
            for (int i = 0; i < 12; i++) 
            {
                if (interaction_months[i] != 0) //etkileşim 0 ise göstermemeli, i=0 dan başladığı için month numarasına 1 ekliyorum.
                {
                    chart_pie.Series[0].Points.AddXY(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i+1), interaction_months[i]);
                }
            }
        }


        private void Interaction_Chart_Customize(object sender, EventArgs e)
        {
            int count = 0;
            foreach (CustomLabel lbl in Interaction_Chart.ChartAreas[0].AxisX.CustomLabels)
            {
                lbl.Text = range[count];
                count++;
            }
        }
    }
}
