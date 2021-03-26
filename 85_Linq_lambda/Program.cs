using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _85_Linq_lambda
{

    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
                throw new ArgumentNullException();

            foreach(var item in source)
            {
                action(item);
            }
        }
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            DisplayLargestFileWithLinq(@"D:\Code\work_C++");
            //DisplayLargesFilesWithoutLinq(@"D:\Code\work_C++");
            Console.ReadLine();
        }

        private static void DisplayLargestFileWithLinq(string pathToDir)
        {
            new DirectoryInfo(pathToDir)
                .GetFiles()
                .OrderByDescending(file => file.Length)
                .Take(5)
                .ForEach(file => Console.WriteLine($"{file.Name} : {file.Length}"));         
        }





        private static long KeySelector(FileInfo file)
        {
            return file.Length;
        }

        private static void DisplayLargesFilesWithoutLinq(string pathToDir)
        {
            var dirInfo = new DirectoryInfo(pathToDir);
            FileInfo[] files = dirInfo.GetFiles();
            Array.Sort(files, delegate (FileInfo file1, FileInfo file2)
            {
                return (int)(file2.Length - file1.Length);
            });

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} Lenghth {file.Length}");
            }
        }
         
       


    }
}
