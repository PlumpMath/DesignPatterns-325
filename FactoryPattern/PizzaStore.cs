
using System;
using System.Collections;

namespace FactoryPattern
{
   public abstract class PizzaStore
   {
      public Pizza OrderPizza(string type)
      {
         var pizza = CreatePizza(type);

         pizza.Prepare();
         pizza.Bake();
         pizza.Cut();
         pizza.Box();

         return pizza;
      }

      protected abstract Pizza CreatePizza(string type);
   }

   public class NyPizzaStore : PizzaStore
   {
      protected override Pizza CreatePizza(string type)
      {
         if (type.Equals("cheese"))
            return new NyStyleCheesePizza();
         if (type.Equals("veggie"))
            return new NyStyleVeggiePizza();
         if (type.Equals("clam"))
            return new NyStyleClamPizza();
         if (type.Equals("pepperoni"))
            return new NyStylePepperoniPizza();
         return null;
      }
   }
   public class ChicagoPizzaStore : PizzaStore
   {
      protected override Pizza CreatePizza ( string type )
      {
         if (type.Equals("cheese"))
            return new ChicagoStyleCheesePizza();
         if (type.Equals("veggie"))
            return new ChicagoStyleVeggiePizza();
         if (type.Equals("clam"))
            return new ChicagoStyleClamPizza();
         if (type.Equals("pepperoni"))
            return new ChicagoStylePepperoniPizza();
         return null;
      }
   }

   public class ChicagoStylePepperoniPizza : Pizza
   {
   }

   public class ChicagoStyleClamPizza : Pizza
   {
   }

   public class ChicagoStyleVeggiePizza : Pizza
   {
   }

   public class ChicagoStyleCheesePizza : Pizza
   {
      public ChicagoStyleCheesePizza()
      {
         Name = "Chicago Style Deep Dish Cheese Pizza";
         Dough = " Extra Thick Crust Dough";
         Sauce = "Plum Tomato Sauce";

         Toppings.Add("Shredded Mozzarella Cheese");
      }

      public override void Cut()
      {
         Console.WriteLine("Cutting the pizza into square slices");
      }
   }
   public class NyStyleCheesePizza : Pizza
   {
      public NyStyleCheesePizza()
      {
         Name = "NY Style Sauce and Cheese Pizza";
         Dough = " Thin Crust Dough";
         Sauce = "Marinara Sauce";

         Toppings.Add("Grated Reggiano Cheese");

      }
   }

   public class NyStylePepperoniPizza : Pizza
   {
   }

   public class NyStyleClamPizza : Pizza
   {
   }

   public class NyStyleVeggiePizza : Pizza
   {
   }

   public abstract class Pizza
   {
       public string Name;
       public string Dough;
       public string Sauce;

      public ArrayList Toppings = new ArrayList();

      public void Prepare()
      {
         Console.WriteLine("Preparing " + Name);
         Console.WriteLine("Tossing dough...");
         Console.WriteLine("Adding sauce...");
         Console.WriteLine("Adding toppings: ");
         foreach (var topping in Toppings)
         {
            Console.WriteLine("   " + topping);
         }
      }

      public void Bake()
      {
         Console.WriteLine("Bake for 25 minutes at 350");
      }

      public virtual void Cut()
      {
         Console.WriteLine("Cutting the pizza into diagonal slices");
      }

      public void Box()
      {
         Console.WriteLine("Place pizza in official PizzaStore box");
      }

      public string GetName()
      {
         return Name;
      }
   }

   public class PizzaTestDrive
   {
      public static void Main(string[] args)
      {
         PizzaStore nyStore=new NyPizzaStore();
         PizzaStore chicagoPizzaStore=new ChicagoPizzaStore();

         Pizza pizza = nyStore.OrderPizza("cheese");
         Console.WriteLine("Ethan ordered a " + pizza.GetName() +"\n");

         pizza = chicagoPizzaStore.OrderPizza("cheese");
         Console.WriteLine("Joel ordered a " + pizza.GetName()+ "\n");

         Console.ReadLine();
      }
   }
}
