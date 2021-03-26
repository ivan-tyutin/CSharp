using System;

namespace _33._1_homework_index
{
    class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }


    }



    class SoccerTeam
    {
        private Player[] players;

        public SoccerTeam()
        {
            players = new Player[11];
        }

        Player this[int index]
        {
            get 
            {
                if (index >= 0 && index < players.Length)
                {
                    return players[index];
                }  
                return null;
            }
            set 
            {
                if (index < players.Length && index >= 0)
                {
                    players[index] = value;
                }
                
            }
        }


    }


    class Word
    {
        public string Source { get; }
        public string Target { get; set; }
        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }

    class Dictionary
    {
        Word[] words;
        public Dictionary()
        {
            words = new Word[]
            {
                new Word("red", "красный"),
                new Word("blue", "синий"),
                new Word("green", "зеленый")
            };
        }

       public string this[string word]
        {
            get
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Source == word.ToLower()) return words[i].Target;
                    if (words[i].Target == word.ToLower()) return words[i].Source;
                }
                return null;
            }

            set
            {
                foreach (Word x in words)
                {
                    if (x.Source == word) 
                    {
                        x.Target = value;
                        break;        
                    }
                }
            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dict = new Dictionary();

            Console.WriteLine($"Red: {dict["Red"]}, Blue: {dict["blue"]}, Green: {dict["Green"]}");

            Console.WriteLine($"Красный: {dict["красный"]}, Синий: {dict["Синий"]}, Зеленый: {dict["зеленый"]}");

        }
    }
}
