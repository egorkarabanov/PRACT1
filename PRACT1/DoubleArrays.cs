using System;

namespace PRACT1 {
    public class DoubleArrays {
        public bool error = false;
        private int x_length = 5;
        private int y_length = 5;
        private int[,] a;

        public int X_length {
            get { return x_length; }
            set { x_length = value; }
        }

        public int Y_length {
            get { return y_length; }
            set { y_length = value; }
        }

        public int this[int i, int j] {
            get {
                if (0 <= i && i < x_length && 0 <= j && j < y_length) {
                    return a[i, j];
                } else {
                    error = true;
                    return 0;
                }
            }
            set {
                if (0 <= i && i < x_length && 0 <= j && j < y_length && value >= -10 && value <= 10) {
                    a[i, j] = value;
                } else {
                    error = true;
                }
            }
        }

        public DoubleArrays(int a_length, int b_length) {
            x_length = a_length;
            y_length = b_length;
            a = new int[x_length, y_length];
            var rand = new Random();
            for (int i = 0; i < x_length; i++) {
                for (int j = 0; j < y_length; j++) {
                    a[i, j] = rand.Next(-10, 10);
                }
            }
        }

        public (int[], int[]) diagonali() {
            int d_length = Math.Min(x_length, y_length);
            int[] res1 = new int[d_length];
            int[] res2 = new int[d_length];
            for (int i = 0; i < x_length; i++) {
                res1[i] = a[i, i];
                res2[i] = a[i, x_length - i - 1];
            }

            return (res1, res2);
        }
    }
}