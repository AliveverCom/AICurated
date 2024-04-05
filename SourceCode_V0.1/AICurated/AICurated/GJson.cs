using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Schema;

namespace Alivever.Com.WinBrowserCrawler
{
    /// <summary>
    /// all json releated static functions.
    /// </summary>
    public class GJson
    {
        public static void Write2File<T>(string _fullFilePath, IEnumerable<T> _objList) where T : class
        {
            //string dirpath = Path.Combine(this.GetStorageRootDir(), "debug");

            string directoryPath = Path.GetDirectoryName(_fullFilePath);

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            List<string> rstList = PrepareForSaving(_fullFilePath, _objList);

            File.WriteAllLines(_fullFilePath, rstList, Encoding.UTF8);

        }//Save2File(string _fullFilePath)

        public static void Append2File<T>(string _fullFilePath, IEnumerable<T> _objList) where T : class
        {
            string directoryPath = Path.GetDirectoryName(_fullFilePath);
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            //string dirpath = Path.Combine(this.GetStorageRootDir(), "debug");

            List<string> rstList = PrepareForSaving(_fullFilePath, _objList);

            File.AppendAllLines(_fullFilePath, rstList, Encoding.UTF8);

        }//Save2File(string _fullFilePath)

        public static void Append2File<T>(string _fullFilePath, T _objList) where T : class
        {
            //string dirpath = Path.Combine(this.GetStorageRootDir(), "debug");

            string rst = ToJson( _objList);

            string[] rstlist = { rst};

            File.AppendAllLines(_fullFilePath, rstlist, Encoding.UTF8);

        }//Save2File(string _fullFilePath)

        public static void Write2File<T>(string _fullFilePath, T _objList ,bool WriteIndented = false ) where T : class
        {
            //string dirpath = Path.Combine(this.GetStorageRootDir(), "debug");

            string rst = ToJson(_objList);

            //string[] rstlist = { rst };

            File.WriteAllText(_fullFilePath, rst, Encoding.UTF8);

        }//Save2File(string _fullFilePath)

        private static List<string> PrepareForSaving<T>(string _fullFilePath, IEnumerable<T> _objList) where T : class
        {

            //string filename = Path.Combine(dirpath, PageTasks_Active_FilePrefix + CLogFile.GetTimeStr_FileName() + ".json");
            List<string> rstList = new List<string>();

            foreach (T crrTask in _objList)
                rstList.Add(ToJson(crrTask));
            return rstList;
        }

        /// <summary>
        /// Load From a File , in wich each row is a json that can be desirilized into an object. 
        /// </summary>
        public static List<T> LoadListFromFile<T>(string _fullFilePath) where T : class
        {
            if (!File.Exists(_fullFilePath))
                throw new Exception("File doesn't exist. path= " + _fullFilePath);

            List<T> rstList = new List<T>();

            string[] lines = File.ReadAllLines(_fullFilePath);

            //using (StreamReader sr = new StreamReader(_fullFilePath))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //foreach(string line in lines) 
            Parallel.ForEach(lines, new ParallelOptions {  MaxDegreeOfParallelism = 4 }, line=>
            { 
                if (line.Length < 2)
                        return;

                T crrObj = FromJson<T>(line);

                lock(rstList)
                    rstList.Add(crrObj);
               
            });

            return rstList;

        }//LoadFromFile

        /// <summary>
        /// load a object from a json file. Note! this method will one load json in the first line.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_fullFilePath"></param>
        /// <returns></returns>
        public static T LoadFromFile<T>(string _fullFilePath) where T: class
        {
            if (!File.Exists(_fullFilePath))
                throw new Exception("File doesn't exist. path= " + _fullFilePath);

            //List<T> rstList = new List<T>();

            string allText = File.ReadAllText(_fullFilePath,Encoding.UTF8);


            T rst = FromJson<T>(allText);
            return rst;

        }//LoadObjFromFile<T>(string _fullFilePath)


        public static string ToJson(object _obj)
        {
            string json = JsonSerializer.Serialize(_obj, new JsonSerializerOptions { IncludeFields = true, WriteIndented = true });
            return json;
        }

        public static T? FromJson<T>(string _jsonStr)
        {
            T? myObject = JsonSerializer.Deserialize<T>(_jsonStr, new JsonSerializerOptions { IncludeFields = true });

            return myObject;
        }

    }//class GJson
}
