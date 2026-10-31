class Quote{ //класс представляющий конкретную цитату
public string Text { get; set; }
public string Author { get; set; }

public Quote(string text, string author){
    Text = text;
    Author = author;
}

//переопределение метода для удобного вывода цитаты в консоль
public override string ToString(){
    return $"\"{Text}\" - {Author}";
}
}