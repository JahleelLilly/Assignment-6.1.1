namespace Assignment_6._1._1
{
    class House
    {
        public int HouseNumber { get; set; }
        public string Address { get; set; }
        public string HouseType { get; set; }
        public House NextHouse { get; set; }

        public House(int houseNumber, string address, string houseType)
        {
            HouseNumber = houseNumber;
            Address = address;
            HouseType = houseType;
        }
    }

    class Program
    {
        static void Main()
        {
            var house1 = new House(1, "123 Sesame St", "Craftsman");
            var house2 = new House(2, "456 Elm St", "Contemporary");

            house1.NextHouse = house2;

            var houseDictionary = new Dictionary<int, House>
        {
            { house1.HouseNumber, house1 },
            { house2.HouseNumber, house2 }
            
        };

            Console.Write("Enter house number to search: ");
            if (int.TryParse(Console.ReadLine(), out int searchNumber))
            {
                if (houseDictionary.TryGetValue(searchNumber, out var foundHouse))
                {
                    Console.WriteLine($"House {foundHouse.HouseNumber}: {foundHouse.Address} ({foundHouse.HouseType})");
                }
                else
                {
                    Console.WriteLine("House not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid house number.");
            }
        }
    }
}