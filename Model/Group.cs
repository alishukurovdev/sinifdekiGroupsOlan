using System;

namespace ConsoleApp3.Model
{
    public class Group
    {
        Student[] students = new Student[0];
        public void AddStudent( Student  student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1]=student;
        }
        public Student this[string indexer]
        {
            get
            {
                foreach (var student in students)
                {
                    if (student.FinCode == indexer.ToUpper())
                    {
                        return student; 
                    }
                }
                return null; 
            }
            //  set => students[indexer] = value;
        }
    }
}