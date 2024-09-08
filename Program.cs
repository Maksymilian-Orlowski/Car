namespace Car;


class Program { 

    static void Main(string[] args)
    {

        Console.ReadKey();
    }

    public class Car
    {
        String model;
        int year;
        String manufacturer;
        int numberOfDoors;
        String color;

        public Car(String model, int year, String manufacturer, int numberOfDoors, String color)
        {
            this.model = model;
            this.year = year;
            this.manufacturer = manufacturer;
            this.numberOfDoors = numberOfDoors;
            this.color = color;
            

        }

        Car Lambo = new Car("Aventador", 2021, "Lamborghini", 2, "Blue");
        Car Porsche = new Car("911 Carrera", 2021, "Porsche", 2, "Red");

    }

}