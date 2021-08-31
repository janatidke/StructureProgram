using System;

namespace StructureProgram
{
    class Program
    {
        public struct Student
        {
            public string Name;
            public string Course_name;
            public int stud_id;
            public int reg_id;

        }
        static void Main(string[] args)
        {
            Student s1;
            s1.Name = "jana";
            s1.Course_name = "Csharp";
            s1.stud_id = 56;
            s1.reg_id = 67667;

            Console.WriteLine("Student Details are:");
            Console.WriteLine("\nName{0},\nCourse_name{1},\nstu_id{2},\nreg_id{3}", s1.Name, s1.Course_name, s1.stud_id, s1.reg_id);
        }
    }
}
