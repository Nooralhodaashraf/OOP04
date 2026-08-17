namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1  

            #region a)  What is Abstraction in Object-Oriented Programming?
            //a) Abstraction is a fundamental concept in Object-Oriented Programming (OOP) that focuses on simplifying complex systems by modeling classes based on the essential properties and behaviors of real-world entities. It allows developers to hide unnecessary implementation details and expose only the relevant features of an object, making it easier to understand and work with.
            #endregion

            #region b)  Why is abstraction considered one of the four pillars of OOP?
            //abstraction is considered one of the 4 pillars of OOP because it hides unnecessary implementation details and exposes only the essential features of an object.
            #endregion

            #endregion

            #region Q2
            #region a)  What is the difference between an Abstract Class and an Interface?
            //the difference between an Abstract Class and an Interface is 
            //abstract:
            //class can have abstract and cocrete methods
            //can have feilds 
            //can use any access modifier 
            //class can inhert 1 abstract class
            //provides base functionality and commen behavior
            //interface:
            //only abstract methods untill C# 0.8 (defult and ststic methods)
            //connot have feilds only const
            //access modifier is public by defult for members 
            //class can implements multible interfaces 
            //connot have a constructor 
            //define a contract 
            #endregion

            #region b)  When would you choose an Interface instead of an Abstract Class?
            //you would choose an interface instead of an abstract class when you want to define a contract that multiple classes can implement, regardless of their position in the class hierarchy. Interfaces are ideal for defining capabilities that can be shared across unrelated classes, promoting flexibility and decoupling in your code design.

            #endregion

            #endregion





            #endregion


        }
    }
}
