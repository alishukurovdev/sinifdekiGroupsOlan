using ConsoleApp3.Model;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("ali","shukur","7kabaak"); 

            Group group=new Group();

            group.AddStudent(std);

            Student student = group["7kabaak"];
            if(student==null)
            {
                throw new Exception("Student not found");
            }else
            {
                Console.WriteLine(student.Name + " " + student.Surname);
            }
            Book bk = new Book("fizuli", "shukurov");
            Library lb= new Library();
            lb.AddBook(bk);
            Console.WriteLine(lb[1].Name);
        }
    }
}