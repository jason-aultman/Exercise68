using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise68
{
    public static class FileHandler
    {
        public static Dictionary<string, string> getDictionary(Dictionary<string, string> dictionaryList, string path)
        {
            
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string srStream = sr.ReadLine();
                    if (srStream != null)
                    {
                        var srStreamOne =srStream.Split(',',2,StringSplitOptions.None);
                        dictionaryList.Add(srStreamOne[0], srStreamOne[1]);
                    }
                }
            }

            return dictionaryList;
        }
    }
}