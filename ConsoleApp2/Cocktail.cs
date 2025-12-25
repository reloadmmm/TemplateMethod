using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cocktail : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Смешиваем ингридиенты в стакане");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Добавляем молоко и сливки и трубочку");
        }
    }
}
