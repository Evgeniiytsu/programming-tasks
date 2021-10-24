using System;

namespace task_5_golden_section
{
    class Program
    {

        static void Main(string[] args)
        {
            const double FI = 1.618;
            const double E = 0.000001;

            const double A = -2;
            const double B = 2;

            double a = A;
            double b = B;

            while (b - a > E) {
                double c = a + (b - a) / FI;
                double x = a + b - c;

                double fa = f(a); // не используется, но требуется посчитать
                double fb = f(b); // не используется, но требуется посчитать
                double fc = f(c);
                double fx = f(x);

                Console.WriteLine("a: " + a.ToString() + ", b: " + b.ToString() + ", x: " + x.ToString() + ", f(x)" + fx);

                if (c > x) {
                    if (fx < fc) {
                        // a = a;
                        b = c;
                    } else {
                        a = x;
                        // b = b;
                    }
                } else {
                    if (c < fc) {
                        a = c;
                        // b = b;
                    } else {
                        // a = a;
                        b = x;
                    }
                }
            }
        }

        static double f (double x) {
            const double A = 1;
            const double B = -1;
            return A * Math.Pow(x, 2) + B * x;
        }
    }
}
