class Automobile {
    public string AutomobilePrint () {
        return "AutomobilePrint";
    }
}

class Car : Automobile {
    public string CarPrint () {
        return "CarPrint";
    }
}

static class Program {
    static void Main () {
        int a = 2;
        long b = a; //Upcast
        Console.WriteLine(b);

        long c = 3;
        int d = (int) c; //Downcast
        Console.WriteLine(d);

        //Class Upcast and Downcast
        Car car = new();
        Automobile automobile = car;
        Console.WriteLine (automobile.AutomobilePrint());
        //Console.WriteLine (automobile.CarPrint ());
        Console.WriteLine (car.CarPrint());

        Automobile automobile2 = new();
        Car car2 = (Car) automobile2;
        Console.WriteLine (automobile.AutomobilePrint());
        Console.WriteLine (car2.CarPrint ());
    }
}
