namespace Серый
{
    public class Session
    {
        public Educator educator = new Educator();
        public Group group = new Group();
        public Auditorium auditorium = new Auditorium();
        public Subject subject = new Subject();
        public DateTime date { get; set; }
        public Session(Educator educator, Group group, Auditorium auditorium, Subject subject, DateTime date)
        {
            this.educator = educator;
            this.group = group;
            this.auditorium = auditorium;
            this.subject = subject;
            this.date = date;
        }

        public void Output ()
        {
            Console.WriteLine($"| {educator.FIO,-30} | {auditorium.Hull,-6} | {auditorium.Number,-15} | {auditorium.Seats,-15} | {subject.Title,-20} | {date.ToString("dd.MM.yyyy"),-13} | {Group.Students.Count(),-20} |");
        }
        public static Session Input()
        {
            Educator educator = new Educator();
            Group group = new Group();
            Auditorium auditorium = new Auditorium();
            Subject subject = new Subject();
            educator = Educator.Input();
            group = Group.Input();
            auditorium = Auditorium.Input();
            if (Group.Students.Count()>auditorium.Seats)
            {
                throw new Exception("Недостаточно мест в аудитории, в группе больше студентов, чем в аудитории");
            }
            subject = Subject.Input();
            Console.WriteLine("Введите дату экзамена: ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            return new Session(educator, group, auditorium, subject, dateTime);
        }
    }
}
