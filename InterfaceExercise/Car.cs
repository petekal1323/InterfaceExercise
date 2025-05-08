using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{

    public Car()
    {
    }

    public double EngineSize { get; set; } = 4.6;
    public string Model { get; set; } = "Ford";
    public string Make { get; set; } = "Mustang";
    public int SeatCount { get; set; } = 4;
    public string CompanyName { get; set; } = "Ford";
    public string Motto { get; set; } = "Built Ford Tough"; 
    public bool HasChangedGears { get; set; }

    public void Drive()
    {
        Console.WriteLine($"The {GetType().Name} now driving forward");
    }

    public void Reverse()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"The {GetType().Name} now reversing");  
            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine($"The {GetType().Name} cannot reverse until the gear is changed");
        }
        
    }
    
    public void Park()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"The {GetType().Name} now in park");  
            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine($"The {GetType().Name} can't park until the gear is changed");
        }
    }

    public void ChangeGear(bool isChanged)
    {
        HasChangedGears = isChanged;
     }
    
}