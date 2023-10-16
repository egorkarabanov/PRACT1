using System;

namespace PRACT1 {
    public class Tabul {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        public double F1(double x) {
            return Math.Sin(x + 3) / (Math.Pow(x, 5) * (1 / Math.Tan(2 * Math.Pow(x, 3))));
        }

        public double F2(double x) {
            return (Math.Abs(x) + 2) / (Math.Pow(Math.Cos(Math.Pow(x, 3) + 2 * x + 1), 2));
        }

        public double F3(double x) {
            return (Math.Pow(Math.Sin(x + 5), 2)) / (Math.Pow(Math.Abs(x) + 2, 1.0 / 3.0) - 1);
        }

        public void Calc(double xn = 1.7, double xk = 4.9, double h = 0.5, double a = 3) {
            double x = xn, y;
            int i = 0;
            while (x <= xk) {
                if (x < 0) {
                    y = F1(x);
                }
                else if((x>=0) && (x< a)) {
                    y = F2(x);
                }
                else {
                    y = F3(x);
                }

                xy[i, 0] = i;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }

            n = i;
        }
    }
}