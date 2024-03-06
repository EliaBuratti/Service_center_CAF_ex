namespace Service_center_CAF
{
    internal class Naspi
    {
        private string name;
        private double salary;
        private double monthOccupation;
        public Naspi(string name, double salary, double monthOccupation)
        {
            this.name = name;
            this.salary = salary;
            this.monthOccupation = monthOccupation;
        }

        public string check()
        {
            string response;
            double percentage;

            if (monthOccupation >= 24)
            {
                percentage = 70;
                response = name + ". You have right to have 70% of yours monthsalary. It's equal to: ";
            }
            else if (monthOccupation >= 12)
            {
                percentage = 40;
                response = name + ". You have right to have 40% of yours monthsalary. It's equal to: ";

            }
            else
            {
                percentage = 0;
                response = name + ". You don't have right requirements";
            }

            double calc = ((salary * percentage) / 100);

            return response + ((calc > 1200 ? 1200 : calc) == 0 ? "" : calc);
        }

    }
}
