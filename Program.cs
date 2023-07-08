using LearningOOP;

class Program
{
    static void Main(string[] args)
    {
        //Car myCar = new Car("Toyota", "Camry", 2022);

        //myCar.DisplayDetails();
        //myCar.StartEngine();
        //myCar.StopEngine();
        //Dog myDog = new Dog("moti");
        //myDog.Sound();

        //Vector2D v1 = new Vector2D(3, 5);
        //Vector2D v2 = new Vector2D(1, 2);

        //Vector2D sum = v1 + v2;
        //Console.WriteLine($"Vector addition: ({sum.X}, {sum.Y})");

        //Vector2D difference = v1 - v2;
        //Console.WriteLine($"Vector subtraction: ({difference.X}, {difference.Y})");
        Calculator calculator = new Calculator();

        var sum1 = calculator.Add(2, 3);
        Console.WriteLine("Sum 1: " + sum1);

        var sum2 = calculator.Add(2.5, 3.7);
        Console.WriteLine("Sum 2: " + sum2);

        var sum3 = calculator.Add(2, 3, 4);
        Console.WriteLine("Sum 3: " + sum3);


    }
}