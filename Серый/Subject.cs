namespace Серый
{
    public class Subject
    {
        public string Title { get; set; }

        public Subject(string title)
        {
            Title = title;
        }
        public Subject() { }
        public static Subject Input ()
        {
            Console.Write("Введите название предмета");
            var Title = Console.ReadLine();
            return new Subject(Title);
        }
    }
}
