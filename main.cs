using System;

class Program {
  static void Main (string[] args) {
    int n;

    do {
        Console.Write("Enter a non-negative number: ");
        if (!int.TryParse(Console.ReadLine(), out n) || n < 0) {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
            continue;
        }

        if (n == 0) {
            Console.WriteLine("Exiting the program.");
            return;
        }

        for (int i = 1; i <= n; i++) {
            Console.WriteLine(new string('*', i * 2 - 1).PadLeft(n + i));
        }

    } while (true);
  }
}