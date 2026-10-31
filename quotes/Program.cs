class Program{ // основной файл приложения (кейсы и обработка)
    static void Main(string[] args){
        QuoteManager manager = new QuoteManager(); 
        bool isRunning = true;

        manager.AddQuote("Моя манера мыслить не принесла мне несчастий. Их причиной стали мысли других @ Маркиз Де Сад");
        manager.AddQuote("Ничто так не воодушевляет, как первое безнаказанное преступление @ Маркиз Де Сад");

        while (isRunning){
            Console.WriteLine("МЕНЮ ЦИТАТНИКА");
            Console.WriteLine("1 Показать все цитаты");
            Console.WriteLine("2 Добавить цитату");
            Console.WriteLine("3 Удалить цитату");
            Console.WriteLine("4 Выйти");
            Console.Write("Выберите действие: ");
            

            string choice = Console.ReadLine();

            switch (choice){
                case "1":
                    manager.ShowAllQuotes();
                    break;

                case "2":
                    Console.WriteLine("Введите цитату в формате: Текст цитаты @ Автор");
                    Console.Write("Ввод: ");
                    string input = Console.ReadLine();

                    if (manager.AddQuote(input)){
                        Console.WriteLine("Цитата добавлена");
                    }
                    else{
                        Console.WriteLine("Неверный формат ввода");
                    }
                    break;

                case "3":
                    manager.ShowAllQuotes();
                    Console.Write("Введите номер цитаты для удаления: ");

                    if (int.TryParse(Console.ReadLine(), out int index)){
                        if (manager.DeleteQuote(index)){
                            Console.WriteLine("Цитата добавлена");
                        }
                        else{
                            Console.WriteLine("Неверный номер цитаты");
                        }
                    }
                    else{
                        Console.WriteLine("Введите корректное число");
                    }
                    break;

                case "4":
                    isRunning = false;
                    Console.WriteLine("Программа завершена");
                    break;

                default:
                    Console.WriteLine("Такого нет в меню");
                    break;
            }
        }
    }
}