using MySql.Data.MySqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace fantasysports
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

            //mysql tables string erzeugen
            string createTableQuery = string.Format(@"CREATE TABLE IF NOT EXISTS `{0}` (
            `id` int(5) unsigned NOT NULL AUTO_INCREMENT,
            `Wettbewerb` VARCHAR(50) NOT NULL,
            `home` VARCHAR(50) NOT NULL,
            `away` VARCHAR(50) NOT NULL,
            `win` VARCHAR(50) NOT NULL,
            `draw` VARCHAR(50) NOT NULL,
            `loose` VARCHAR(50) NOT NULL,
            `Datum` VARCHAR(50) NOT NULL,
            `Spieltag` VARCHAR(50) NOT NULL,
            PRIMARY KEY (`id`),
            KEY `Spielerid` (`Datum`)) 
            ENGINE = MyISAM AUTO_INCREMENT = 1 DEFAULT CHARSET = utf8;", "bet356");

            //mysql connection erzeugen
            MySqlConnection connection = new MySqlConnection("server=buqhvbltjab1w9h2bks9-mysql.services.clever-cloud.com;Port=20444;database=buqhvbltjab1w9h2bks9;uid=uxayl6sbtpqdhepa;password=QZPnMNX6OIJrkYTkes3F");
            connection.Open();

            //mysql DB erzeugen
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(createTableQuery, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        List<string> db2list2(string tabelle, string spalte)
        {
            MySqlConnection connection = new MySqlConnection("server=buqhvbltjab1w9h2bks9-mysql.services.clever-cloud.com;Port=20444;database=buqhvbltjab1w9h2bks9;uid=uxayl6sbtpqdhepa;password=QZPnMNX6OIJrkYTkes3F");
            List<string> dblist2 = new List<string>();
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command = connection.CreateCommand();
            command.CommandText = "SELECT "+spalte+ " FROM "+tabelle;
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    row = Reader.GetValue(i).ToString();
                    dblist2.Add(row);
                }
            }
            connection.Close();
            return dblist2;
        }


        private void button1_Click(object sender, EventArgs e)
        {


            //Firefox öffnen
            IWebDriver driver = new FirefoxDriver();

            //URL öffnen
            driver.Url = textBox1.Text;

            //10 sec warten
            System.Threading.Thread.Sleep(10000);

            //javaScript einbinden
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            //Tabelle in Webelement speichern
            IWebElement Partie = (IWebElement)js.ExecuteScript("return document.querySelector('.sgl-MarketFixtureDetailsLabelExpand3')");
            IWebElement win = (IWebElement)js.ExecuteScript("return document.querySelector('div.sgl-MarketOddsExpand:nth-child(2)')");
            IWebElement unentschieden = (IWebElement)js.ExecuteScript("return document.querySelector('div.sgl-MarketOddsExpand:nth-child(3)')");
            IWebElement loose = (IWebElement)js.ExecuteScript("return document.querySelector('div.sgl-MarketOddsExpand:nth-child(4)')");


            //          IWebElement test = (IWebElement)js.ExecuteScript("return document.querySelector('.sl-MarketCouponFixtureLabelBase')");



            //Webelement in String speichern
            string Partie_str = Partie.Text;
            string win_str = win.Text;
            string unentschieden_str = unentschieden.Text;
            string loose_str = loose.Text;
   //         string test2 = test.Text;

            //String vereinzeln und in array speichern
            string[] Partie_ar = Partie_str.Split(new string[] { "\n", " v "}, StringSplitOptions.None);
            for (int i=0; i<Partie_ar.Length;i++)
            {
                Partie_ar[i]=Partie_ar[i].Replace("\r", "");
            }
            string[] win_ar = win_str.Split(new Char[] { '\n' });
            string[] unentschieden_ar = unentschieden_str.Split(new Char[] { '\n' });
            string[] loose_ar = loose_str.Split(new Char[] { '\n' });

            //liste erzeugen
            List<string> Partie_list = new List<string>();
            List<string> win_list = new List<string>();
            List<string> unentschieden_list = new List<string>();
            List<string> loose_list = new List<string>();

            //liste für DB auslesenen Referenz
            string a = "Team365";
            string b = "Referenz";
            List<string> Teams = new List<string>();
            Teams = db2list2(b, a);
            Teams = Teams.Distinct().ToList();


            string temp = "";
            int counter = 0;

            //Listen erzeugen
            for (int i = 0; i < Partie_ar.Length; i++)
            {
                for (int j=0; j<Teams.Count(); j++)
                {
                    if(Partie_ar[i].ToString()==Teams[j].ToString())
                    {
                        Partie_list.Add(Partie_ar[i]);
                    }
                }               
            }


            for (int i = 0; i < win_ar.Length; i++)
            {
                win_ar[i]=win_ar[i].Trim();
                if (win_ar[i]!="1")
                {
                    win_list.Add(win_ar[i]);
                }
            }

            for (int i = 0; i < unentschieden_ar.Length; i++)
            {
                unentschieden_ar[i] = unentschieden_ar[i].Trim();
                if(unentschieden_ar[i]!="X" && unentschieden_ar[i]!="x")
                {
                    unentschieden_list.Add(unentschieden_ar[i]);

                }                
            }

            //qwwqwqw
            for (int i = 0; i < loose_ar.Length; i++)
            {
                loose_ar[i] = loose_ar[i].Trim();
                if(loose_ar[i]!="2")
                {
                    loose_list.Add(loose_ar[i]);
                }
            }
           


            string[,] final = new string[loose_list.Count(), 5];
            counter = 0;
            for ( int i =0; i< win_list.Count();i++)
            {
                for ( int j=0; j<5;j++)
                {
                    if(j==0)
                    {
                        final[i, j] = Partie_list[counter];
                        counter = counter + 1;
                    }
                    if(j==1)
                    {
                        final[i,j] = Partie_list[counter];
                        counter = counter + 1;

                    }
                    if(j==2)
                    {
                        final[i, j] = win_list[i];
                    }
                    if(j==3)
                    {
                        final[i, j] = unentschieden_list[i];
                    }
                    if(j==4)
                    {
                        final[i, j] = loose_list[i];
                    }
                    
                }
            }
          

                //mysql connection erzeugen
                MySqlConnection connection = new MySqlConnection("server=buqhvbltjab1w9h2bks9-mysql.services.clever-cloud.com;port = 20444;database=buqhvbltjab1w9h2bks9;uid=uxayl6sbtpqdhepa;password=QZPnMNX6OIJrkYTkes3F");
                connection.Open();

                //letzte db id auslesen
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM bet356";
                MySqlDataReader Reader;
                string lastid = "";
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string row = "";
                    //Komplette dB auslesen
                    //for (int i = 0; i < Reader.FieldCount; i++)

                    //letzte id auslesen
                    for (int i = 0; i < 1; i++)
                        row += Reader.GetValue(i).ToString();

                    lastid = row;
                }
                connection.Close();
                //daten in db
                connection.Open();
                int h;
                if (lastid.Length == 0)
                {
                    h = 1;
                }
                else
                    h = Int32.Parse(lastid) + 1;

                int k = 0;
                string st2;
                string st3;
                string datum = System.DateTime.Now.ToShortDateString();

                for (int i = 0; i < final.Length / 5; i++)
                {
                    command.CommandText = "INSERT INTO bet356(id, Wettbewerb, home, away, win, draw, loose, Datum, Spieltag) VALUES(@id, @Wettbewerb, @home, @away, @win, @draw, @loose, @Datum, @Spieltag)";
                    command.Prepare();
                    command.Parameters.AddWithValue("@id", h + i);
                    command.Parameters.AddWithValue("@Wettbewerb", Wettbewerb_combo.Text);
                    //final[i, 0] = final[i, 0].Trim();
                    final[i, 0] = final[i, 0].Trim();
                    command.Parameters.AddWithValue("@home", final[i, 0]);
                    final[i, 1] = final[i, 1].Trim();
                    command.Parameters.AddWithValue("@away", final[i,1]);
                    final[i, 2] = final[i, 2].Trim();
                    command.Parameters.AddWithValue("@win", final[i, 2]);
                    final[i, 3] = final[i, 3].Trim();
                    command.Parameters.AddWithValue("@draw", final[i, 3]);
                    final[i, 4] = final[i, 4].Trim();
                    command.Parameters.AddWithValue("@loose", final[i,4]);
                    command.Parameters.AddWithValue("@Datum", datum);
                    command.Parameters.AddWithValue("@Spieltag", Spieltag_Combo.Text);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
                finish_lbl.Text = "Database upload finished!";
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Wettbewerb_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //mysql connection erzeugen
            MySqlConnection connection = new MySqlConnection("server=buqhvbltjab1w9h2bks9-mysql.services.clever-cloud.com;port = 20444;database=buqhvbltjab1w9h2bks9;uid=uxayl6sbtpqdhepa;password=QZPnMNX6OIJrkYTkes3F");
            connection.Open();
            List<string> deb2 = new List<string>();
            //letzte db id auslesen
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT home FROM bet356";
            MySqlDataReader Reader;
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    row += Reader.GetValue(i).ToString();
                    deb2.Add(row);
                }
            }
            connection.Close();

            //mysql connection erzeugen

            connection.Open();
            //letzte db id auslesen
            command.CommandText = "SELECT away FROM bet356";
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    row += Reader.GetValue(i).ToString();
                    deb2.Add(row);
                }
            }
            connection.Close();

            deb2 = deb2.Distinct().ToList();

            using (StreamWriter writer = new StreamWriter(@"C:\FantasySports\Referenztabelle\eee.csv"))
            {
                for (int i = 0; i < deb2.Count(); i++)
                {
                    writer.WriteLine(deb2[i]);
                }
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
