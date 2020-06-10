using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




static class Globalvariables
{
    // global strings
    // sql string
    public static string SqlString = "server = buqhvbltjab1w9h2bks9 - mysql.services.clever - cloud.com; port = 20444;database=buqhvbltjab1w9h2bks9;uid=uxayl6sbtpqdhepa;password=QZPnMNX6OIJrkYTkes3F";

    // global int
    // counter 
    public static int counter;

}


public class MultipleArray
{
    public list2array(List<string> liste, int spalten)
    {
        string[,] array = new string[liste.Count() / spalten, spalten];
        int k = 0;
        for (int i = 0; i < liste.Count() / spalten; i++)
        {
            for (int j = 0; j < spalten; j++)
            {
                array[i, j] = liste[k];
                k++;
            }
        }
        return array;
    }

    public db2array(string tabelle)
    {
        MySqlConnection connection = new MySqlConnection("server=buqhvbltjab1w9h2bks9-mysql.services.clever-cloud.com;port = 20444;database=buqhvbltjab1w9h2bks9;uid=uxayl6sbtpqdhepa;password=QZPnMNX6OIJrkYTkes3F");
        List<string> dblist = new List<string>();
        MySqlCommand command = connection.CreateCommand();
        MySqlDataReader Reader;
        command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM " + tabelle;
        connection.Open();
        Reader = command.ExecuteReader();
        while (Reader.Read())
        {
            string row = "";
            for (int i = 0; i < Reader.FieldCount; i++)
            {
                row = Reader.GetValue(i).ToString();
                dblist5.Add(row);
            }
        }
        connection.Close();

        return list2array(dblist);
    }


}




