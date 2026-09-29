namespace GameInheritanceDemo
{
    public class warrior : character
    {
        public int bonus;

        public warrior()
        {
            Console.WriteLine("----> Knstruktor default warrior <----");
        }

        public warrior(int bonus, string id, string name, int basePower, string address)
            : base(id, name, basePower, address)
        {
            Console.WriteLine("----> Konstruktor berparameter warrior <----");
            this.bonus = bonus;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("BONUS              =" + bonus);
            Console.WriteLine("TOTAL POWER        =" + (GetBasePower() + bonus));
            Console.WriteLine("===========================");
        }
    }
}