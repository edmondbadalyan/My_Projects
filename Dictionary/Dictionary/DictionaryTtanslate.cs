using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{


    internal class DictionaryTranslator
    {
        private Dictionary<string, string> englishtoRussian = new Dictionary<string, string>();
        private Dictionary<string, string> russiantoEnglish = new Dictionary<string, string>();

        public DictionaryTranslator()
        {

            AddTranslate("cat", "кошка");
            AddTranslate("dog", "собака");
            AddTranslate("house", "дом");
            AddTranslate("car", "машина");
            AddTranslate("book", "книга");
            AddTranslate("apple", "яблоко");

        }

        public void AddTranslate(string target, string source)
        {
            englishtoRussian.Add(target, source);
            russiantoEnglish.Add(source, target);
        }

        public string Translate(string source, bool isRussianToEnglish)
        {
            if (isRussianToEnglish)
            {
                if (russiantoEnglish.ContainsKey(source))
                {
                    return russiantoEnglish[source];
                }
            }
            else
            {
                if (englishtoRussian.ContainsKey(source))
                {
                    return englishtoRussian[source];
                }
            }

            return "Translation not found.";
        }
    }
}

