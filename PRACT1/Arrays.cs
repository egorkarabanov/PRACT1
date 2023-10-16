using System;

namespace PRACT1 {
    public class Arrays {
        public bool error = false;
        private int[] a;

        private int length = 5;

        public int Length {
            get {
                return length;
            }
        }

        public int this[int i] {
            get {
                if (0 <= i && i < length) {
                    return a[i];
                } else {
                    error = true;
                    return 0;
                }
            }
            set {
                if (0 <= i && i < length && value >= -100 && value <= 100) {
                    a[i] = value;
                } else {
                    error = true;
                }
            }
        }

        public Arrays() {
            a = new int[length];
        }

        public Arrays(int[] mas) {
            a = mas;
        }

        public Arrays(int size) {
            length = size;
            a = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++) {
                a[i] = rand.Next(-20, 10);
            }
        }

        public void changeNegativeToZero() {
            for (int i = 0; i < length; i++) {
                if (a[i] < 0) {
                    a[i] = 0;
                }
            }
        }
    }
}