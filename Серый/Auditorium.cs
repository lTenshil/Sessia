namespace Серый
{
    public class Auditorium
    {
        public int Number { get; set; }
        public int Seats { get; set; }
        public char Hull { get; set; }
        public Auditorium(int number, int seats, char hull)
        {
            Number = number;
            Seats = seats;
            Hull = hull;
        }
        public Auditorium() { }
        public static Auditorium Input ()
        {
            Console.Write("Введите корпус аудитории: ");
            var Hull = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите номер аудитории: ");
            var Number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество мест в аудитории: ");
            var Seats = Convert.ToInt32(Console.ReadLine());
            return new Auditorium(Number, Seats, Hull);
        }
    }
}
