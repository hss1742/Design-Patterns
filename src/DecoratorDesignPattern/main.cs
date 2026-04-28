// farmhouse + double cheese

using src.DecoratorDesignPattern;

var pizza1 = new DoubleCheese(new FarmHouse());
System.Console.WriteLine(pizza1.Cost());


// veg + double cheese + mushroom

var pizza2 = new Mushroom(new DoubleCheese(new VegPizza()));
System.Console.WriteLine(pizza2.Cost());