// See https://aka.ms/new-console-template for more information

/*Hello world lesson*/
// Console.WriteLine("Hello, World!");

/*Type conversion*/
// int i = 1;
// byte b = (byte) i;
// Console.WriteLine(b);

/*try and Catch block to prevent the crash due to overflow*/
// try
// {
//     var number = "1234";
//     byte j = Convert.ToByte(number);
//     Console.WriteLine(j);
// }
// catch(Exception)
// {
//     Console.WriteLine("The number could not be converted to a byte ");
// }

//Non-primitive types

Person person = new Person();
//why should it be above the declaration?
 var person2 = new Person();
 person2.Name = "Emy";
 person2.Introduce();

 Console.WriteLine(Calculator.Add(1,4));

 public class Person
 {
     public string? Name;

     public void Introduce()
     {
         Console.WriteLine("Hi, my name is " + Name);
     }
 }

 public class Calculator
 {
     public static int Add(int a, int b)
     {
         return a + b;
     }
 }

/*static classes are accessed from outside the scope of the class;
it doesn't have to be repeated in the memory so I don't have to create multiple objects of it*/

namespace BeginnerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

