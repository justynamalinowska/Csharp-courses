using System;

namespace classes_students
{
    class program
    {
        static void Main(string[] args)
        {
            students student1 = new students("Justyna", "Malinowska", 4);
            students student2 = new students("Mateusz", "Malinowski", 3);

            Console.WriteLine(student1.Honor());
            Console.WriteLine(student2.Honor());

        }

    }
}
