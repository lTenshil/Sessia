namespace Серый
{
    class Program
    {
        static void Main(string[] args)
        {
            Session[] sessions = new Session[4];
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Выберите действие: 1 - сформировать расписание сессии, 2 - вывести расписание сессии, 0 - выход, 4 - очистка консоли");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.NumPad1:
                            for (int i = 0; i < 4; i++)
                            {
                                sessions[i] = Session.Input();
                            }
                            break;
                        case ConsoleKey.NumPad2:
                            if (sessions.Count() > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("| ФИО преподавателя              | Корпус | Номер аудитории | Количество мест | Предмет              | Дата экзамена | Количество студентов |");
                                foreach (Session session in sessions)
                                {
                                    session.Output();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Список группы: ");
                                foreach (var item in Group.Students)
                                {
                                    item.Print();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Расписание сессии пустое");
                            }
                            break;

                        case ConsoleKey.NumPad0:
                            flag = false;
                            break;

                        case ConsoleKey.NumPad4:
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nОшибка. " + e.Message);
                }
            }
        }
    }
}