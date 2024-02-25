using System;
using System.Collections.Generic;

class ParkingLot
{
    private bool[] parkingSpaces;

    public ParkingLot(int numberOfSpaces)
    {
        if (numberOfSpaces <= 0)
        {
            throw new ArgumentException("The number of parking spaces must be greater than 0.");
        }

        parkingSpaces = new bool[numberOfSpaces]; 
    }

    public int ParkCar()
    {
        for (int i = 0; i < parkingSpaces.Length; i++)
        {
            if (!parkingSpaces[i])
            {
                parkingSpaces[i] = true;  
                return i; 
            }
        }

        return -1; 
    }

    public bool LeaveParking(int parkingSpaceNumber)
    {
        if (parkingSpaceNumber < 0 || parkingSpaceNumber >= parkingSpaces.Length || !parkingSpaces[parkingSpaceNumber])
        {
            return false; 
        }

        parkingSpaces[parkingSpaceNumber] = false; 
        return true;
    }
}

class Program
{
    static void Main()
    {
        
        int numberOfParkingSpaces = 10;
        ParkingLot parkingLot = new ParkingLot(numberOfParkingSpaces);

        int parkingSpaceNumber1 = parkingLot.ParkCar();
        if (parkingSpaceNumber1 != -1)
        {
            Console.WriteLine($"Car parked at space {parkingSpaceNumber1}");
        }
        else
        {
            Console.WriteLine("No available parking spaces.");
        }

        int parkingSpaceNumber2 = parkingLot.ParkCar();
        if (parkingSpaceNumber2 != -1)
        {
            Console.WriteLine($"Car parked at space {parkingSpaceNumber2}");
        }
        else
        {
            Console.WriteLine("No available parking spaces.");
        }

        bool leftParking1 = parkingLot.LeaveParking(parkingSpaceNumber1);
        Console.WriteLine(leftParking1 ? $"Car left from space {parkingSpaceNumber1}" : $"Space {parkingSpaceNumber1} is already empty");

        bool leftParking2 = parkingLot.LeaveParking(parkingSpaceNumber2);
        Console.WriteLine(leftParking2 ? $"Car left from space {parkingSpaceNumber2}" : $"Space {parkingSpaceNumber2} is already empty");
    }
}
