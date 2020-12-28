using Entities;
using System;
using System.Collections.Generic;

namespace Set02 {
    class Program {
        static void Main(string[] args) {
            HashSet<User> setA = new HashSet<User>();
            HashSet<User> setB = new HashSet<User>();
            HashSet<User> setC = new HashSet<User>();
            try {
                Console.Write("How many students for course A: ");
                int qtdStudents = int.Parse(Console.ReadLine());
                for (int i = 1; i <= qtdStudents; i++) {
                    Console.Write("Enter the code of the " + i + "# student: ");
                    int codeStudent = int.Parse(Console.ReadLine());
                    setA.Add(new User(codeStudent));
                }

                Console.Write("\nHow many students for course B: ");
                qtdStudents = int.Parse(Console.ReadLine());
                for (int i = 1; i <= qtdStudents; i++) {
                    Console.Write("Enter the code of the " + i + "# student: ");
                    int codeStudent = int.Parse(Console.ReadLine());
                    setB.Add(new User(codeStudent));
                }

                Console.Write("\nHow many students for course A: ");
                qtdStudents = int.Parse(Console.ReadLine());
                for (int i = 1; i <= qtdStudents; i++) {
                    Console.Write("Enter the code of the " + i + "# student: ");
                    int codeStudent = int.Parse(Console.ReadLine());
                    setC.Add(new User(codeStudent));
                }

                HashSet<User> users = new HashSet<User>();
                users.UnionWith(setA);
                users.UnionWith(setB);
                users.UnionWith(setC);

                Console.Write("\n\nTotal users: " + users.Count);
            }
            catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
