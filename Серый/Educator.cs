namespace Серый
{
    public class Educator
    {
        public string FIO { get; set; }

        public Educator(string fIO)
        {
            FIO = fIO;
        }
        public Educator() { }
        //input
        public static Educator Input()
        {
            Console.Write("\nВведите ФИО преподавателя: ");
            var FIO = Console.ReadLine();
            return new Educator(FIO);
        }
    }
}
