using System;

namespace nested_repetition {
    class program {
        static void Main(string[] args) {
            descend(5);
            ascend(5);
        }

        static public void descend(int start_with) {
            for (int i = 0; i < start_with; i++) {
                for (int n = i; n < start_with; n++) {
                    Console.Write("x");
                }
                Console.WriteLine("");
            }
        }

        static public void ascend(int lines) {
            for (int i = 0; i < lines; i++) {
                for (int n = i + 1; n > 0; n--) {
                    Console.Write("x");
                }
                Console.WriteLine("");
            }
        }
    }
}
