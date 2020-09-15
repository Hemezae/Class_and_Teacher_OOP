namespace Homework_9_14_2020
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person myPerson1 = new Person();
            myPerson1.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();
        }
    }
}
