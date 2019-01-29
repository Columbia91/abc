using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            StatusCodes code = StatusCodes.NotFound;
            int statusInt = (int)StatusCodes.InternalServerError;

            Enum.TryParse("Ok", out StatusCodes statusCode);

            Shop shop = new Shop
            {
                Name = null,
                Coordinates = null
            };

            ChangeValue(shop);
            Console.WriteLine(shop.Name);

            int number = 1;
            ChangeValue(number);
            Console.WriteLine(number);

            Console.ReadLine();
        }

        static void ChangeValue(Shop shop)
        {
            shop.Name += "aaaaaaaaaaaaaaaaaaaaaaaaa";
        }
        static void ChangeValue(int number)
        {
            number += 6;
        }
    }
}
