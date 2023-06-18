using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Provider_BusinessApplication_inC_Sharp_full_version.DL
{
    class TextList
    {
        private static List<string> texts = new List<string>();
        public static List<string> getTexts()
        {
            return texts;
        }
        public static void Add_text(string text,string role)
        {
            texts.Add(role+": "+text);
        }
        public static void Erase_texts()
        {
            foreach(string temp_text in texts)
            {
            texts.Remove(temp_text);
            }
        }
    }
}
