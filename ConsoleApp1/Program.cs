
using ConsoleApp1.Models;
using ConsoleApp1.Services;

#region Pizza

PizzaService pizzaService = new PizzaService();
//pizzaService.CreatePizza("Solda", 22.20d);

//Pizza pizza2 = pizzaService.GetById(1);

//Console.WriteLine(pizza2.Name);

//pizzaService.Remove(1);

//List<Pizza> pizzas = pizzaService.GetAll();
//foreach (Pizza pizza in pizzas) Console.WriteLine(pizza.Name);

//foreach (var pizza in pizzaService.GetAll())
//    Console.WriteLine($"{pizza.Id}. {pizza.Name} {pizza.Price}");

//Size size = pizzaService.GetSizeById(2);
//Console.WriteLine(size.Name);

#endregion


#region Size

SizeService sizeService = new SizeService();

//sizeService.CreatSize("23", 2);

//List<Size> size = sizeService.GetAll();
//Console.WriteLine(size);

//foreach (Size sizeItem in size) 
//    Console.WriteLine($"{sizeItem.Id}. {sizeItem.Name} {sizeItem.PizzaId}");

//Size size = sizeService.GetById(1);
//Console.WriteLine(size.Name);

//sizeService.Remove(1);

#endregion

