using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic30._09._2024
{
    /*
     Задание 1. Программа «Статистика»
    -
    Подсчитать, сколько раз каждое слово встречается в 
    данном тексте. Результат записать в коллекцию Dictionary<TKey, TValue>.
    
    Вывести статистику по тексту в виде таблицы (рисунок 1).

    Вот дом, Который построил Джек. А это пшеница, 
    Которая в темном чулане хранится В доме, Который построил
    Джек. А это веселая птица-синица, Которая часто ворует пшеницу,
    Которая в темном чулане хранится В доме, Который построил Джек
     */
    /*                    Слово:      Кол-во:
        1.              Вот         1
        2.              дом         1*/
    internal class Jack
    {
        Dictionary<string, int> wordsJack;
        SortedDictionary<string, int> wordsJack2;
        public void Add(string text)
        {
            string[] words = text.Split("., ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            wordsJack = new Dictionary<string, int>();
            wordsJack2 = new SortedDictionary<string, int>();
            foreach (string word in words)
            {
                if (wordsJack.ContainsKey(word))
                {
                    wordsJack[word]++;
                    wordsJack2[word]++;
                }
                else
                    {
                    //wordsJack[word] = 1;
                    wordsJack.Add(word, 1);
                    wordsJack2.Add(word, 1);
                }

            }
            /*try
            {
                wordsJack.Add(word, 1);
            }
            catch
            {
                wordsJack[word]++;
            }*/
        }

        public string ShowDict()
        {
            string map = string.Empty;
            int i = 1;
            foreach (var word in wordsJack2)
            {
               map += i++ + $".\t{word.Key}:\t{word.Value}\n";
            }
            return map;
        }
    }
}

