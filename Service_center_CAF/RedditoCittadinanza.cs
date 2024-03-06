namespace Service_center_CAF
{
    internal class RedditoCittadinanza
    {
        private string name;
        private int age;
        private double isee;
        private double realEstateProperty;

        //constructor
        public RedditoCittadinanza(string name, int age, double isee, double realEstateProperty)
        {
            this.name = name;
            this.age = age;
            this.isee = isee;
            this.realEstateProperty = realEstateProperty;
        }

        public string checkRedditoCittadinanza()
        {
            if ((age >= 26 && age <= 67) && (isee < 9360) && (realEstateProperty < 30000))
            {

                string resultMessage = "Congrats " + name + "! You have right requirement to do this answer!";
                return resultMessage;
            }

            return "Sorry " + name + ". You don't have right requirement to do this answer!";
        }

    }
}
