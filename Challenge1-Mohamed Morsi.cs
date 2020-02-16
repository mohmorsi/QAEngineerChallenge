using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    static int Main(String[] args){
        if (args.Length == 0){
            Console.WriteLine("Error: Expected a valid file argument");
            return 1;
        }

    try{
            using (StreamReader reader = new StreamReader(args[0]))
            {
                string line;
                var dictionary = new Dictionary<int, int>();
                while ((line = reader.ReadLine()) != null)
                {
                    int key = int.Parse(line);
                    if (dictionary.ContainsKey(key))
                    {
                        dictionary[key]++;
                    }
                    else
                    {
                        dictionary.Add(key, 1);
                    }
                }
                
                var minimum = dictionary.Aggregate((l, r) => l.Value < r.Value ? l : r);

            
                Console.WriteLine($"Number: {minimum.Key}, Repeated: {minimum.Value}");
            }

        }

    catch (Exception e){
            Console.WriteLine(e.Message);
        }
        return 0;
    }
}
