using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Demo
{
    
//Assignment:
//Create a class Bank, assign default account bal using constructor
//Add debit method with parameter debit amt, debit the amount from main bal,

//If bal == 0  -> raise an event bal is zero
//If debit amt > bal   -> raise an event -> inefficient bal

//Credit method with parameter credit amount
//Add amt to bal - > display the updated ac balance

    class BankAssignment
    {
        public delegate void Mydel();
        public class Student
        {
            public event Mydel Fail;
            public event Mydel Distinction;
            public void AcceptMark(int Marks)
            {
                if (Marks < 40)
                {
                    Fail();
                }
                else if (Marks >= 75)
                {
                    Distinction();
                }
                Console.WriteLine($"Your score is {Marks}");
            }
        }
        class Program
        {
            static void Failmsg()
            {
                Console.WriteLine("you are fail!!!!!");
            }
            static void DistinctionMsg()
            {
                Console.WriteLine("Congratulation ! you are pass with Distinction");
            }
            static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.Fail += new Mydel(Failmsg);
                s1.Distinction += new Mydel(DistinctionMsg);
                s1.AcceptMark(34);
            }
        }






        public delegate void Mydel1();
        class Bank
        {


            public event Mydel1 InsufficientBal;
            public event Mydel1 ZeroBal;
            int balance;
            public Bank()
            {
                balance = 900000;
            }
            public void credit(int i)
            {
                balance = balance + i;
            }
            public void debit(int i)
            {
                if (balance < i)
                {
                    InsufficientBal();
                }
                if (balance >= i)
                {
                    balance -= i;
                    if (balance == 0)
                    {
                        ZeroBal();
                    }
                }
            }

        }
        class Atm1
        {
            static void InsufficientBalMsg()
            {
                Console.WriteLine("your balance is low!!!!!");
            }
            static void ZeroBalMsg()
            {
                Console.WriteLine("Your Balance is zero");
            }
            static void Main(string[] args)
            {
                Bank b = new Bank();
                b.InsufficientBal += new Mydel1(InsufficientBalMsg);
                b.ZeroBal += new Mydel1(ZeroBalMsg);
                b.credit(60000);
            }
        }
    }
}
