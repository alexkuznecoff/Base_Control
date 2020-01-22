using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Control
{
    public struct City
    {
        public string Name { get; set; }
        public int Populated { get; set; }
        public int Area { get; set; }
    }
    class Program
    {
     
        static void Main(string[] args)
        {
            string str = "Kharkiv = 1431000,350; Kiev = 2804000,839; Las Vegas = 603400,352";
            string[] result = str.Split(';');
            City[] citys = new City[result.Length];

            for (int i = 0; i < result.Length; i++)
            {
                citys[i].Name = result[i].Split('=')[0];
                citys[i].Populated = int.Parse(result[i].Split('=',',')[1]);
                citys[i].Area = int.Parse(result[i].Split(',')[1]);
            }
            Console.WriteLine(TheMostPpulatedCity(citys));
            Console.WriteLine(LongestName(citys));
            PrintDesity(citys);
            Console.ReadKey();
        }

        public static void PrintDesity(City[] citys)  
        {
            Console.WriteLine("\nDensity :");
            Console.WriteLine();       
            for (int i = 0; i < citys.Length; i++)
            {
                double density = citys[i].Populated / citys[i].Area;
                Console.WriteLine($" {citys[i].Name} -  {density}");
            }
        }

        public static string TheMostPpulatedCity(City[] citys)
        {
            City mostPopCity = new City();

            foreach (var city in citys)
            {
                if (city.Populated > mostPopCity.Populated)  
                {
                    mostPopCity.Name = city.Name;
                    mostPopCity.Populated = city.Populated; 
                    mostPopCity.Area = city.Area;
                }

            }
            return $"The mos populated city: {mostPopCity.Name} = {mostPopCity.Populated} , area =({mostPopCity.Area})";
        }
        public static string LongestName(City[] citys)
        {
            City longestName = new City();
            longestName.Name ="";

            foreach(var city in citys)
            {
                if(city.Name.Length > longestName.Name.Length)
                {
                    longestName.Name = city.Name;
                    longestName.Populated = city.Populated;
                    longestName.Area = city.Area;
                }
            }
            return $"\nLongest name : {longestName.Name} ({longestName.Name.Length}) litters ";
        }
    }
}
