using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProjectForRegularExpressions
{
    /*
        ---Regular Expression In C#---
         Regular Expression bir patterndir. Ki bu pattern input text ile eşleştirilebilecek bir patterndir. 
         .Net frameworku 'regular expresssion engine' sağlar ki bu regular  expression engine bu tarz eşleşmelere imkan tanır.
         Patternler (Regular Expression) bir veya bir den fazla karakter literalleri sabitleri değişmezleri, operatorleri, yapılar constructları içerir.
         
         Regular Expressionları Tanımlamak İçin Var Olan Yapılar, Constructlar: 
               Characterlerin, operatorlerin ve constructların (yapıların) çeşitli categorileri vardır. Bu kategorilerdeki operatorler, constructlar, karakterler sana 'Regular Expression' tanımlamana imkan sağlar.
         Aşağıda regular expression tanılaman  için var olan operator, constructor, character kategorileri listelendi:
          1--> Character Escapes
          2--> Character Classes 
          3--> Anchors
          4--> Grouping  Constructs 
          5--> Quantifiers  
          6--> Backreference Constructs  
          7--> Alternation Constructs 
          8--> Substitutions 
          9--> Miscellaneous Consructs
        --Regex Class--
        .Net frameworkunun REgualr Expresiion lar ile kullanılabilecek methodlarını fonksiyonlarını çeşitli class memberlarını içeren claass dır. Regex classı .netin bir classıdır. 
        Bu classın içerisinde Regular Expresiionlar ile kullanableceğimiz built-in methodlar bulunmaktadır.
        
        Regex Class regular expressionları temsil etmek için kullanılır.  REgex Class yaygın olarak kullanılan aşağıdaki methodları içerir: 

        *public bool IsMatch(string input) -->  Belirlenen input stringin belirlenen regular expression ile eşleşip eşleşmediini gösterir.
        *public bool IsMatch(string input, int startat) --> Belirlenen input stringin belirlenen regular expression ile eşleşip eşleşmediini gösterir.  Input stringin ikinci parametre ile belirlenen indexden sonraki karakterleri baz alınır.
        *public static bool IsMatch(string input, string pattern) -->  Belirlenen input string ile belirlenen regular  expressionın eşleşip eşleşmediğini belirler.
        *public MatchCollection Matches(string input) -->  Belirlenen input stringin belirlenen regular expressionda bulunduğu yerleri search eder. 
        *public string Replace(string input, string replacement) --> Belirlenen input stringinde, regular expression patterni ile eşleşen bütün stringleri parametredeki replacement stringi ile replace eder.
        *public string[] Split(string input) --> input stringi split eder. input stringi altstringin arraylerine split eder belirli bir pozisyonda. Ki bu pozisyon Regex constructorda belirlenen  regular expression patterni tarafından tanımlanır.  
     */
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Regular Expressions In C#..");

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("#####FirstExample#####");
                Console.WriteLine("");
                Console.WriteLine("");

            #region first example that it matches words which starts with 'S'
                string str = "A Thousand Splendid Suns";
                Console.WriteLine("Matching words that start with 'S': ");
                //@ ile başlaması regular expression olduğunu gösterir.
                //ShowMatch(str, @"\bS\S*");
                ShowMatchWithMyRegexObject(str, @"\bS\S*");
            #endregion  first example

            Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("#####SecondExample#####");
                Console.WriteLine("");
                Console.WriteLine("");

            #region second example that it matches words which starts with 'm' and ends with 'e'
                //aynı methodu m ile başlayıp e ile biten kelimeleri eşlemesi için kullanıcaz. Bu değişikliği regexi kullanarak yapıcaz. 
                str = "make maze and manage to measure it";
                Console.WriteLine("Matching words start with 'm' and ends with 'e':");
                //ShowMatch(str, @"\bm\S*e\b");
                ShowMatchWithMyRegexObject(str, @"\bm\S*e\b");
            #endregion second example

            Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("#####ThirdExample#####");
                Console.WriteLine("");
                Console.WriteLine("");

            #region third example that it replaces extra white spaces
                string input = "Hello   World   ";
                //boşluğun yerini tutan Regular Expression patterni
                string pattern = "\\s+";
                string replacement = "+";

                Regex rgx = new Regex(pattern);
                //convert all spaces to the plus.
                string result = rgx.Replace(input, replacement);

                Console.WriteLine("Original String: {0}", input);
                Console.WriteLine("Replacement String: {0}", result);
            #endregion third example


            Console.ReadKey();
        }

        private static void ShowMatch(string text, string expr)
        {
            Console.WriteLine("The Expression (Regular Expression): " + expr);
            //eşleşen stringlerin var olduğu bir collection var elimizde.
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        private static void ShowMatchWithMyRegexObject(string text, string expr)
        {
            Regex rgx = new Regex(expr);
            MatchCollection mc = rgx.Matches(text);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        } 
    }
}
