// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

List<string> carTypes = new List<string> { "camry", "nissan", "engen", "corolla", "prado", "cardillac", "Benz", "Ford" };
//carTypes.Add("corolla");
//carTypes.Add("prado");
//carTypes.Add("cardillac");
//carTypes.Add("Benz");
//carTypes.Add("Ford");

var carModel = carTypes.Where(toyota => toyota.Contains ("c")).ToList();
var car = carTypes.Count();

Console.WriteLine($"this car models are of toyota {carModel}");

FoodInventory akara = new FoodInventory("akara", 50);
FoodInventory pap = new FoodInventory("pap", 20);
Console.WriteLine(akara.Quantity);
public class FoodInventory
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    // this is a constructor that saves variable.
    public FoodInventory(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
    public void IncreaseQuantity(int amount)

    {
        Quantity += amount;
    }
    public void DecreaseQuantity(int amount)
    {
        if (Quantity >= amount)
        {
            Quantity -= amount;
        }

    }
}

