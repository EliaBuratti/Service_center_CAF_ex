namespace Service_center_CAF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option \n1: Reddito di Cittadinanza.\n2: Pensione quota 100.\n3: Calcolo tassazione.\n4: Calcolo naspi.\n5: Esci.");
            // insert here a request and execute choice
            int choice;

            choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string name;
                    Console.WriteLine("your name: ");
                    name = Console.ReadLine();

                    int age;
                    Console.WriteLine("your age: ");
                    age = Convert.ToInt16(Console.ReadLine());

                    double isee;
                    Console.WriteLine("your isee: ");
                    isee = Convert.ToInt16(Console.ReadLine());

                    double realEstateProperty;
                    Console.WriteLine("your real Estate Property: ");
                    realEstateProperty = Convert.ToInt32(Console.ReadLine());

                    RedditoCittadinanza rcUser = new(name, age, isee, realEstateProperty);
                    Console.WriteLine(rcUser.checkRedditoCittadinanza());

                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    double monthOccupation;
                    Console.WriteLine("How many month did you work?");
                    monthOccupation = Convert.ToDouble(Console.ReadLine());

                    double salary;
                    Console.WriteLine("how much do you earn for month?");
                    salary = Convert.ToDouble(Console.ReadLine());

                    Naspi calcNaspi = new("Elia", salary, monthOccupation);
                    Console.WriteLine(calcNaspi.check());

                    break;

                case 5:
                    Console.WriteLine("Exit.");
                    break;

                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
