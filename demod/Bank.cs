using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.demod
{
    public delegate void Mydel();
    class Bank
    {

        public event Mydel Less;
        public event Mydel Zero;
        double balance;
        public Bank(double balance)
        {
            this.balance = balance;
        }
        public void Credit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine(balance);
        }
        public void Debit(double amount)
        {
            if (amount > balance)
            {
                Less();
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine(balance);
                if (balance == 0)
                {
                    Zero();
                }
                
            }
        }
    }
    public static class Message
    {
        public static void LessMessage()
        {
            Console.WriteLine("insufficient balance ");
        }
        public static void ZeroMessage()
        {
            Console.WriteLine("zero balance");
        }
    }
    public class Test11
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank(5000);
            b1.Less += new Mydel(Message.LessMessage);
            b1.Zero += new Mydel(Message.ZeroMessage);
            b1.Credit(4000);
            b1.Debit(6000);
            b1.Debit(3000);
        }

        
    }
}
