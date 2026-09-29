using System;
using System.Data.Common;
using System.Net.Sockets;

namespace GameInheritanDemo
{
    public class Character
    {
        private string characterID;
        private string name;
        private int basepower;
        private string addres;

        public Character()
        {
            Console.WriteLine("----> Konstruktor default Character <----");

        }

        //public Character(string id, string name, int basePower, string addres);
       //{
           // Console.WriteLine("----> Konstruktor default Character <----")
          // this. characterID = id;
           // this. name = name;
           // this. basePower = basePower;
           // this. addres = address;
       // }

        public void DisplayBaseData()
        {
            
            Console.WriteLine("CHARACTER ID   = " + characterID);
            Console.WriteLine("NAME           = " + name);
            Console.WriteLine("BASE POWER     = " + basepower);
            Console.WriteLine("ADDRESS        = " + addres);
        }

        public int GetBasepower()
        {
            return basepower;
        }
    }