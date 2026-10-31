class QuoteManager{ //класс для управления цитатами
    private List<Quote> quotes = new List<Quote>();

    //метод добавления цитаты с парсингом формата "...@author"
    public bool AddQuote(string rawInput){
        if (!rawInput.Contains("@")){
            return false;
        }

        //разделяем строку по символу '@'
        string[] parts = rawInput.Split(new char[] { '@' }, 2);

        //очищаем от лишних пробелов и кавычек
        string text = parts[0].Trim().Trim('"');
        string author = parts[1].Trim();

        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(author)){
            return false;
        }

        quotes.Add(new Quote(text, author));
        return true;
    }


    public void ShowAllQuotes(){
        if (quotes.Count == 0){
            Console.WriteLine("Список пуст");
            return;
        }

        Console.WriteLine("Все цитаты");
        for (int i = 0; i < quotes.Count; i++){
            //индекс для возможности последующего удаления
            Console.WriteLine($"{i + 1}. {quotes[i]}");
        }
    }

    //метод удаления цитаты по индексу (начиная с 1)
    public bool DeleteQuote(int index){
        int actualIndex = index - 1;

        if (actualIndex >= 0 && actualIndex < quotes.Count){
            quotes.RemoveAt(actualIndex);
            return true;
        }
        return false;
    }
}