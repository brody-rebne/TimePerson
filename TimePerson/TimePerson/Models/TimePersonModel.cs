using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace TimePerson.Models
{
    public class TimePersonModel
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public TimePersonModel(string[] properties)
        {
            Year = Convert.ToInt32(properties[0]);
            Honor = properties[1];
            Name = properties[2];
            Country = properties[3];
            BirthYear = Convert.ToInt32(properties[4]);
            DeathYear = Convert.ToInt32(properties[5]);
            Title = properties[6];
            Category = properties[7];
            Context = properties[8];
        }

        public static List<TimePersonModel> GetPersons(int begYear, int endYear)
        {
            // create a list of Time persons (instantiate a new list)
            // get the path of your timeperson.csv file
            string filename = "personOfTheYear.csv";
            string folderpath = Environment.CurrentDirectory;
            string filepath = $"{folderpath}/{filename}";

            string[] csvData = File.ReadAllLines(filepath);
            string[,] parsedData = new string[csvData.Length, 8];

            for(int i=0;i<csvData.Length;i++)
            {
                string[] lineArray = csvData[i].Split(",");
                for(int j = 0; j < parsedData.GetLength(1); j++)
                {
                    parsedData[i, j] = lineArray[j];
                }
            }

            var query =
                from lines in csvData
                where Convert.ToInt32(lines.Split(",")[4]) >= begYear &&
                      Convert.ToInt32(lines.Split(",")[5]) <= endYear
                select lines;

            // once you get the file path, 
            // read all the lines and save it into an array of strings
            // traverse through the strings for each line item
            // remember CSV is delimited by commas. 

            // use LINQ to filter out with the years that you brought in against your list of persons

            //return your list of persons



            return personsList;
        }
    }
}