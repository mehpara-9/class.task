namespace Class.task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello, World!");

            Group group1 = new Group("BP215","Gunorta");
            Student student1 = new Student("Mehpara", "Kicibeyova", "female", 20, "546874312456578",12);


            group1.AddStudent(student1,"yaya");

            
        
        }

    }
}
