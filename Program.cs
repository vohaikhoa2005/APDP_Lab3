namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student(99,"John", "Doe", new DateTime(2000, 12, 31));

            Console.WriteLine("Student 1: ");
            Console.WriteLine("ID: " + student1.StudentID);
            Console.WriteLine("Name: " + student1.FirstName + " " + student1.LastName);
            Console.WriteLine("DOB: " + (student1.DateOfBirth.HasValue ? student1.DateOfBirth.Value.ToShortDateString() : "N/A"));
            Console.WriteLine("Enrollment Date: " + student1.EnrollmentDate.ToShortDateString());
            Console.WriteLine("-------------------");
            Console.WriteLine("Student 2: ");
            Console.WriteLine("ID: " + student2.StudentID);
            Console.WriteLine("Name: " + student2.FirstName + " " + student2.LastName);
            Console.WriteLine("DOB: " + (student2.DateOfBirth.HasValue ? student2.DateOfBirth.Value.ToShortDateString() : "N/A"));
            Console.WriteLine("Enrollment Date: " + student2.EnrollmentDate.ToShortDateString());
            Console.WriteLine("-------------------");   
            Console.WriteLine("Total Students: " + Student.TotalStudent);
        }
    }

}
