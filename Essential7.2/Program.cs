using System.ComponentModel.Design;
using System.Transactions;

namespace Essential7._2;

struct Train
{
    private string destination; 
    private int trainNumber;
    private TimeOnly departureTime;

    public string Destination
    {
        get { return destination; }
        set { destination = value; }
    }

    public int TrainNumber
    {
        get { return trainNumber; }
        set { trainNumber = value; }
    }
    public TimeOnly DepartureTime
    {
        get { return departureTime; }
        set { departureTime = value; }
    }
    

}

class Program
{
    static void Main()
    {
        Train[] trains = new Train[8];
        
        trains[0] = new Train { TrainNumber = 1, Destination = "Manchester", DepartureTime = new TimeOnly(14, 30) };
        trains[1] = new Train { TrainNumber = 2, Destination = "Lodz", DepartureTime = new TimeOnly(15, 30) };
        trains[2] = new Train { TrainNumber = 3, Destination = "Cracov", DepartureTime = new TimeOnly(09, 30) };
        trains[3] = new Train { TrainNumber = 4, Destination = "Cracov", DepartureTime = new TimeOnly(06, 40) };
        trains[4] = new Train { TrainNumber = 5, Destination = "Warsaw", DepartureTime = new TimeOnly(10, 00) };
        trains[5] = new Train { TrainNumber = 6, Destination = "Gdynia", DepartureTime = new TimeOnly(16, 10) };
        trains[6] = new Train { TrainNumber = 7, Destination = "Berlin", DepartureTime = new TimeOnly(12, 30) };
        trains[7] = new Train { TrainNumber = 8, Destination = "Kyiv", DepartureTime = new TimeOnly(09, 30) };
        
        Console.WriteLine("Enter the train number: ");
        if (int.TryParse(Console.ReadLine(), out int inputTrainNumber))
        {
            bool found = false; 
            
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber == inputTrainNumber)
                {
                    Console.WriteLine($"Train Number: {trains[i].TrainNumber}");
                    Console.WriteLine($"Destination: {trains[i].Destination}");
                    Console.WriteLine($"Departure Time: {trains[i].DepartureTime}");
                    found = true;
                    break; 
                }
            }
            
            if (!found)
            {
                Console.WriteLine("Train with this number was not found.");
            }
        }
        else
        {
            Console.WriteLine("You entered an invalid train number.");
        }
    }
}
