namespace OperatorsExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Arithmetical Operators
            decimal a = 10M;
            decimal b = 3M;
            decimal c = a + b; // output: 13
            decimal d = a - b; // output: 7
            decimal e = a * b; // output: 30
            decimal f = a / b; // output: 3.333333333333333
            decimal g = a % b; // output: 1
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);
            System.Console.WriteLine(e);
            System.Console.WriteLine(f);
            System.Console.WriteLine(g);
            
            // Assignment Operators
            a += 20M;
            System.Console.WriteLine(a); // output: 30
            a -= 20M;
            System.Console.WriteLine(a); // output: 10
            a *= 3M;
            System.Console.WriteLine(a); // output: 30
            a /= 3M;
            System.Console.WriteLine(a); // output: 10
            a %= 3M;
            System.Console.WriteLine(a); // output: 1
            
            // Increment / Decrement Operators
            a = 10M;
            System.Console.WriteLine();
            System.Console.WriteLine(++a); // output: 11
            System.Console.WriteLine(--a); // output: 11
            System.Console.WriteLine(a); // output: 12
            System.Console.WriteLine(--a); // output: 11
            System.Console.WriteLine(a--); // output: 11
            System.Console.WriteLine(a); // output: 10
            
            // Comparison Operators
            System.Console.WriteLine();
            bool b1 = a == 10;
            System.Console.WriteLine(b1); // output: true
            bool b2 = a != 10;
            System.Console.WriteLine(b2); // output: false
            bool b3 = a < 10;
            System.Console.WriteLine(b3); // output: false
            bool b4 = a > 10;
            System.Console.WriteLine(b4); // output: false
            bool b5 = a <= 10;
            System.Console.WriteLine(b5); // output: true
            bool b6 = a >= 10;
            System.Console.WriteLine(b6); // output: true
            
            // Logical Operators
            System.Console.WriteLine();
            bool b7 = a == 10 & b == 10;
            System.Console.WriteLine(b7); // output: false
            bool b8 = a == 10 && b == 10;
            System.Console.WriteLine(b8); // output: false
            bool b9 = a == 10 |  b == 10;
            System.Console.WriteLine(b9); // output: true
            bool b10 = a == 10 || b == 10;
            System.Console.WriteLine(b10); // output: true
            bool b11 = !(a == 10);
            System.Console.WriteLine(b11); // output: false
            bool b12 = a == 10 ^ b == 10;
            System.Console.WriteLine(b12); // output: true
            
            // Concatenation Operator
            string name = "Scott";
            int age = 20;
            string message = "Hey" + name + ", your age is "  + age;
            System.Console.WriteLine(message);
            
            // Ternary Operator
            string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
            System.Console.WriteLine(title);
            
            // Precedence Operator
            double z = 10 + 4 * 30 / 10;
            System.Console.WriteLine(z); // output: 22
            
            System.Console.ReadKey();
        }
    }
}