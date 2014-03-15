using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
   public abstract class Beverage
   {
      protected string description = "Unknown beverage";
      

      public virtual string getDescription ()
      {
         return description;
      }

      public abstract double cost ();

   }

   public abstract class CondimentDecorator : Beverage
   {
     //public abstract string getDescription ();
   }


   public class Esprresso : Beverage
   {
      public Esprresso ()
      {
         description = "Espresso";
      }

      public override double cost ()
      {
         return 1.99;
      }
   }

   public class HouseBlend : Beverage
   {
      public HouseBlend ()
      {
         description = "House Blend Coffee";
      }

      public override double cost ()
      {
         return .89;
      }
   }

   public class Mocha : CondimentDecorator
   {
      Beverage beverage;

      public Mocha ( Beverage beverage )
      {
         this.beverage = beverage;
      }

      public override string getDescription ()
      {
         return beverage.getDescription() + ", Mocha";
      }

      public override double cost ()
      {
         return .20 + beverage.cost();
      }
   }

   public class Soy : CondimentDecorator
   {
      Beverage beverage;

      public Soy ( Beverage beverage )
      {
         this.beverage = beverage;
      }

      public override string getDescription ()
      {
         return beverage.getDescription() + ", Soy";
      }

      public override double cost ()
      {
         return .20 + beverage.cost();
      }
   }

   public class Whip : CondimentDecorator
   {
      Beverage beverage;

      public  Whip ( Beverage beverage )
      {
         this.beverage = beverage;
      }

      public override string getDescription ()
      {
         return beverage.getDescription() + ", Whip";
      }

      public override double cost ()
      {
         return .20 + beverage.cost();
      }
   }

}
