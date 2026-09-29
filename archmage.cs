using System;

namespace GameIhertitanceDemo
{
    public class ArchMage : Mage
    {
        public int ancientKnowLedge;

        public ArchMage()
        {
            Console.WriteLine("----> Konstruktor default ArchMage <----");
        }

        public ArchMage(int ancientKnowLedge, int spellPower, string id, string name, int basePower, string address)
        {
            Console.WriteLine("----> konstruktor berparameter ArchMage <----");
            this.ancientKnowLedge = ancientKnowLedge;
        }

        public void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("ANCIENT KNOWLEDGE = " + ancientKnowLedge);
            Console.WriteLine("GRAND TOTAL POWER  = " + (GetBasePower() + spellPower + ancientKnowledge));

            Console.WriteLine("======================");
        }
    }
}