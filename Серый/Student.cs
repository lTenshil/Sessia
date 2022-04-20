namespace Серый
{
    public class Student
    {
        public string FIO { get; set; }
        public string Speciality { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public void Print ()
        {
            Console.WriteLine($"Студент: {FIO}, Специальность: {Speciality}, Факультет: {Faculty}, Курс: {Course}");
        }

        public Student(string fIO, string speciality, string faculty, int course)
        {
            FIO = fIO;
            Speciality = speciality;
            Faculty = faculty;
            Course = course;
        }
    }
}
