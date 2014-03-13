using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
   public class StarBuzzCoffee
   {
      public static void Main(string[] args)
      {
         Beverage beverage=new Esprresso();
         Console.WriteLine(beverage.getDescription() + "$" +beverage.cost());

         Beverage beverage2 = new HouseBlend();
         beverage2=new Mocha(beverage2);
         beverage2=new Mocha(beverage2);
         beverage2=new Whip(beverage2);

         Console.WriteLine(beverage2.getDescription() +"$"+ beverage2.cost());

         Console.ReadLine();
      }
   }
}
