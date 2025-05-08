using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public Truck()
    {
        
    }
    
    public double EngineSize { get; set; } = 6;
    public string Model { get; set; } = "Ford";
    public string Make { get; set; } = "F150";
    public int SeatCount { get; set; } = 4;
    public string CompanyName { get; set; } = "Ford";
    public string Motto { get; set; } = "Built Ford Tough"; 
    public bool HasChangedGears { get; set; }
    public bool HasFourWheelDrive { get; set; }

    
    public void Drive()
    {
        if (HasFourWheelDrive == true)
        {
            Console.WriteLine($"The {GetType().Name} now driving forward in 4 wheel drive");
        }
        else
        {
            Console.WriteLine($"The {GetType().Name} now driving forward");
        }
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