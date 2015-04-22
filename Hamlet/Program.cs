using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Hamlet
{

    class Program
    {
        static Dictionary<string, int> dictionOfWords;  // Contains a dictionary of all the words

        static void Main(string[] args)
        {
            dictionOfWords = new Dictionary<string, int>();

            string s = "";

            s = ExtractTextFromWebPage("http://shakespeare.mit.edu/hamlet/full.html");

#if DEBUG
            Console.WriteLine("JUST TO VERIFY STRING LOOKS GOOD");
            Console.WriteLine(s);
            Console.ReadLine();
#endif

            // Split the words in the string provided and populate a dictionary with
            // number of occurences of each word
            var words = s.Split((new char[] { ' ', ',', '.', ':', '\t', '?', ';', '!' ,'-','\r','\n'}), StringSplitOptions.RemoveEmptyEntries);
            int totalWords = PopulateWordCounts(words);

            //Display result             
            DisplayTopResults(20, totalWords);

            Console.ReadLine();
        }

        /// <summary>
        /// Canned functionality to turn a HTML web page returned into a Text document        
        /// </summary>
        /// <param name="uRL">URL of web page to get content from</param>
        /// <returns></returns>
        private static string ExtractTextFromWebPage(string uRL)
        {
            HtmlToText convert = new HtmlToText();
            string s = convert.Convert(new System.Net.WebClient().DownloadString(uRL));
            return s;
        }

        /// <summary>
        /// Displays the Top x words and there occurence count
        /// and other interesting stats
        /// </summary>
        /// <param name="topResults"></param>
        private static void DisplayTopResults(int topResults, int totalWords)
        {
            // Use query to take top topResults number of used words 
            var queryWordsToGetTopResult = (from words1 in dictionOfWords
                                            orderby words1.Value descending
                                            select words1).Take(topResults);

            //Display results and count

            Console.WriteLine("\nMOST USED WORDS\n");
            foreach (var item in queryWordsToGetTopResult)
            {
                Console.WriteLine("Word {0} occurence {1}", item.Key, item.Value);
            }

            Console.WriteLine("*******************************************");
            Console.WriteLine("\nOther Interesting stats.");
            Console.WriteLine("NO. OF UNIQUE WORDS:{0}", dictionOfWords.Count);

            var qry2 = (from words1 in dictionOfWords
                        where words1.Value == 1
                        select words1).Count();

            Console.WriteLine("NO. OF WORDS USED ONLY ONCE:{0}", qry2);
            Console.WriteLine("NO. OF WORDS IN THE DOCUMENT:{0}", totalWords);

            var wordswithchar = (from words1 in dictionOfWords
                                 where words1.Key.Contains("'")
                                 select words1).Count();

            Console.WriteLine("\n Words with ' character: {0}", wordswithchar);


            Console.WriteLine("*******************************************");
            var longestwords = (from words1 in dictionOfWords
                                orderby words1.Key.Length descending
                                select words1).Take(topResults);

            Console.WriteLine("\nLONGEST WORDS\n");
            foreach (var item in longestwords)
            {
                Console.WriteLine("Word {0} length {1}", item.Key, item.Key.Length) ;
            }      
        }

        /// <summary>
        /// Populate dictionary of words and occurences
        /// </summary>
        /// <param name="words"></param>
        private static int PopulateWordCounts(string[] words)
        {
            int counter = 0;

            // Iterate over the words in an string array
            // Words are added in lower case to ensure that we don't get multiple words for different cases and trimmed
            // to ensure no extra whitespace causes additional values.
            string trimmedWord = "";
            foreach (var word in words)
            {
                trimmedWord = word.ToLower().Trim();

                counter++;
                // If the word is present increment the value which is hold the occurence count
                if (dictionOfWords.ContainsKey(trimmedWord))
                {
                    dictionOfWords[trimmedWord]++;
                }
                else
                {
                    // The word didnt yet exist in dictionary so add it with a count of 1.
                    dictionOfWords.Add(trimmedWord, 1);
                }
            }
            return counter;
        }
        //public static List<string> ignoreList;

        //static void PopulateIgnoreList()
        //{
        //    ignoreList = new List<string>()
           // Add Items

        //}


    }
}
