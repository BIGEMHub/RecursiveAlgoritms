using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveCalisma
{
    class Program
    {
        #region Recursive1
        //static int product(int x, int y)
        //{
        //    if (y == 0)
        //        return 0;
        //    else
        //        return (x + product(x, y - 1));
        //}

        //public static void Main()
        //{
        //    int x = 10, y = 3;

        //    Console.Write(product(x, y));
        //}
        #endregion

        #region Recursive2
        //static int product(int x, int y)
        //{
        //    if (y == 0)
        //        return 0;
        //    else
        //        return (x + product(x, y - 1));
        //}
        //public static void Main()
        //{
        //    int x = 3, y = 150;
        //    if (x < y)
        //        Console.Write(product(y, x));
        //    else
        //        Console.Write(product(x, y));
        //}
        #endregion

        #region Recursive3
        //static void printFun(int test)
        //{
        //    if (test < 1)
        //        return;
        //    else
        //    {
        //        Console.Write(test + " ");

        //        // statement 2
        //        printFun(test - 1);

        //        Console.Write(test + " ");
        //        return;
        //    }
        //}

        //// Driver Code
        //public static void Main(String[] args)
        //{
        //    int test = 3;
        //    printFun(test);
        //}
        #endregion

        #region Recursive4 Fib
        //static int fib(int n)
        //{
        //    if (n == 0)
        //        return 0;
        //    if (n == 1 || n == 2)
        //        return 1;
        //    else
        //        return (fib(n - 1) + fib(n - 2));
        //}
        //static public void Main()
        //{
        //    int n = 10;
        //    Console.Write("Fibonacci series of 10 numbers is: ");
        //    for (int i = 0; i < n; i++) Console.Write(fib(i) + " ");
        //    Console.Read();
        //}
        #endregion

        #region Recursive5 Fac
        //static int f(int n)
        //{
        //    if (n == 0 || n == 1)
        //        return 1;
        //    else
        //        return n * f(n - 1);
        //}
        //static void Main()
        //{
        //    int n = 5;
        //    Console.WriteLine("factorial of " + n + " is: " + f(n));
        //}
        #endregion

        #region Recursive6 
        //static int fun1(int x, int y)
        //{
        //    Console.WriteLine(x +" " + y);
        //    if (x == 0)
        //        return y;
        //    else
        //        return fun1(x - 1, x + y);
        //}
        //static void Main()
        //{
        //    int sonuc = fun1(5, 2);
        //    Console.WriteLine(sonuc);
        //}
        #endregion

        #region Recursive 7
        //static int fun1(int n)
        //{
        //    if (n == 1)
        //        return 0;
        //    else
        //        return 1 + fun1(n / 2);
        //}
        //static void fun2(int n)
        //{
        //    if (n == 0)
        //        return;

        //    fun2(n / 2);
        //    Console.Write(n % 2);
        //}
        //static void Main()
        //{
        //    //int sonuc = fun1(5);
        //    fun2(21);
        //    //Console.WriteLine(sonuc);
        //}
        #endregion

        #region Recursive 8
        //static void fun(int x)
        //{
        //    if (x > 0)
        //    {
        //        fun(--x);
        //        Console.Write(x + " ");
        //        fun(--x);
        //    }
        //}

        //static public void Main()
        //{
        //    int a = 4;
        //    fun(a); // output: 0 1 2 0 3 0 1
        //}

        /*          fun(4);
                   /
                fun(3), print(3), fun(2)(prints 0 1)
               /
           fun(2), print(2), fun(1)(prints 0)
           /
        fun(1), print(1), fun(0)(does nothing)
        /
        fun(0), print(0), fun(-1) (does nothing)*/
        #endregion

        #region Recursive Dizideki maksimum sayıyı döndüren algoritma
        //static int fun(int[] a, int n)
        //{
        //    int x;
        //    if (n == 1)
        //        return a[0];
        //    else
        //        x = fun(a, n - 1);
        //    if (x > a[n - 1])
        //        return x;
        //    else
        //        return a[n - 1];
        //}

        //static public void Main()
        //{
        //    int[] arr = { 12, 10, 30, 50, 100 };
        //    Console.Write(" " + fun(arr, 5) + " ");
        //    Console.Read();
        //}
        #endregion

        #region Recursive 10
        //static int fun(int i)
        //{
        //    if (i % 2 == 1) return (i++);
        //    else return fun(fun(i - 1));
        //}

        //// Driver code    
        //static public void Main()
        //{
        //    Console.WriteLine(fun(200));
        //}
        #endregion

        #region Recursive 11
        //static int fun(int a, int b)
        //{
        //    if (b == 0)
        //        return 0;
        //    if (b % 2 == 0)
        //        return fun(a + a, b / 2);

        //    return fun(a + a, b / 2) + a;
        //}

        //static public void Main()
        //{
        //    Console.Write(fun(4, 3));
        //}
        #endregion

        #region Recursive 12
        //static int fun(int a, int b)
        //{
        //    if (b == 0)
        //        return 1;
        //    if (b % 2 == 0)
        //        return fun(a * a, b / 2);

        //    return fun(a * a, b / 2) * a;
        //}


        //static public void Main()
        //{
        //    Console.WriteLine(fun(4, 3));
        //    Console.Read();
        //}
        #endregion

        #region İçiçe recursive
        //static int fun(int n)
        //{
        //    if (n > 100)
        //        return n - 10;
        //    return fun(fun(n + 11));
        //}

        //// Driver code    
        //static public void Main()
        //{
        //    Console.WriteLine(fun(99)); //output 91
        //}
        #endregion

        #region içiçiçiçe recursive
        //static int fun(int count)
        //{
        //    Console.Write(count + "\n");
        //    if (count < 3)
        //    {
        //        fun(fun(fun(++count)));
        //    }
        //    return count;
        //}

        //static public void Main()
        //{
        //    fun(1); //1233333
        //}
        /*main() işlevi fun(1)'i çağırır. 
         * fun(1) "1" yazdırır ve fun(fun(fun(2))) öğesini çağırır. 
         * fun(2) "2" yazdırır ve fun(fun(fun(3))) öğesini çağırır. 
         * Böylece işlev çağrısı dizisi fun(fun(fun(fun(fun(3)))) olur).
         * fun(3) "3"ü yazdırır ve 3 değerini döndürür 
         * (sayımın artırılmadığını ve sayı 3 için koşul doğru değilmiş gibi daha fazla işlev çağrılmadığını unutmayın). 
         * Böylece işlev çağrısı dizisi fun(fun(fun(fun(3)))) olarak azalır. 
         * fun(3) tekrar "3" yazdırır ve 3'ü döndürür. 
         * Böylece işlev çağrısı tekrar fun(fun(fun(3)))'e indirgenir ve bu da yine "3" yazdırır ve fun(fun(3))'e indirger. 
         * Bu devam ediyor ve ekrana 5 kez “3” yazdırıyoruz.*/
        #endregion

        #region Recursive 13
        //static int fp = 15;
        //static int fun(int n)
        //{
        //    int t, f;

        //    if (n <= 2)
        //    {
        //        fp = 1;
        //        return 1;
        //    }
        //    t = fun(n - 1);
        //    f = t + fp;
        //    fp = t;
        //    return f;
        //}

        //static public void Main()
        //{ Console.Write(fun(5)); }


        /*                    (1) fun(5, fp)
                              /           \
                         (2) fun(4, fp)   (8) t = 3, f = 5, *fp = 3
                         /          \
                   (3) fun(3, fp)    (7) t = 2, f = 3, *fp = 2
                  /            \
              (4) fun(2, fp)   (6) t = 1, f = 2, *fp = 1
             /   
      (5) *fp = 1   
         */
        #endregion

        #region Recursive 14
        //static void fun(int n)
        //{
        //    if (n > 0)
        //    {
        //        fun(n - 1);
        //        Console.Write(n + " ");
        //        fun(n - 1);
        //    }
        //}

        //static public void Main() { fun(4); }

        /*         fun(4)
                   /
                fun(3), print(4), fun(3) [fun(3) prints 1 2 1 3 1 2 1]
               /
           fun(2), print(3), fun(2) [fun(2) prints 1 2 1]
           /
       fun(1), print(2), fun(1) [fun(1) prints 1]
       /
    fun(0), print(1), fun(0) [fun(0) does nothing]
         */
        #endregion

    }
}
