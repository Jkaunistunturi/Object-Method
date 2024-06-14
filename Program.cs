namespace Object_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Here we define students with constructor
            Student student1 = new Student("Ken", "Programming", 2.8, "A");
            Student student2 = new Student("Lisa", "Art", 3.6, "B");
            Student student3 = new Student("Ted", "Philosophy", 3.1, "A");
            Student student4 = new Student("Ann", "Psychology", 3.5, "P");


            //Here we check if each student has honors, calling the object method
            Console.WriteLine(student1.Letter);
            Console.WriteLine(student2.Letter);
            Console.WriteLine(student3.Letter);
            Console.WriteLine(student4.Letter); //this student does not have any of the defined letter, so the letter is set to "No letter"

            Console.ReadLine();
        }
    }
}
