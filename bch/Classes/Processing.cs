using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace bch.Classes
{
    public static class Processing
    {
        //Shortcut paths to Desktop as well as the folder all the data will be saved to.
        public static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string DataPath = DesktopPath+"\\bchData";


        //Delete a file.
        public static void DeleteObject(string path)
        {
            System.IO.File.Delete(path);
        }

        //Save an object as a json object to a text file.
        public static void SaveObject(object obj, string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            Directory.CreateDirectory(path);
            System.IO.File.WriteAllText(path, json);
        }

        //returns an object from a json object saved in a file, and converts it to a given type.
        public static T getObject<T>(string path)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(System.IO.File.ReadAllText(path));
        }

        //returns all objects, and converts it to a given type.
        public static List<T> getObjects<T>(string path)
        {
            List<T> ret = new List<T>();
            foreach (var file in Directory.GetFiles(path))
            {
                ret.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<T>(System.IO.File.ReadAllText(file)));
            }
            return ret;
        }

        //Generate a random unique ID code, with a given length.
        private static Random random = new Random();
        public static string GenerateID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}