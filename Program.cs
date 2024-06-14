namespace Object_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Here we define students with constructor
            Student student1 = new Student("K", "Programming", 2.8);
            Student student2 = new Student("L", "Art", 3.6);
            Student student3 = new Student("A", "Philosophy", 3.1);


            //Here we check if each student has honors, calling the object method
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.WriteLine(student3.HasHonors());

            Console.ReadLine();
        }
    }
}
