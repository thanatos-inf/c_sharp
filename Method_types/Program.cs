// Вид 1. Методы, которые ничего не возвращают и не принимают. 
void Method1()
{
    Console.WriteLine("Какой-то текст");
}
//Method1(); //вызов метода




// Вид 2. Методы которые что-то принимают, но ничего не возвращают. 
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения.");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкремент, уменьшение на единицу - декремент. 
    }
}
//Method2_1(msg: "Текст", count: 4);  
//Method2_1(count: 4, msg: "Новый текст"); //именованные аргументы не обязательно указывать по порядку.



//Вид 3. Методы, которые что-то возвращают, но ничего не принимают. 

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);


// Вид 4. Методы, которые что-то принимают и что-то возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

//string res = Method4(10, "Привет ");
//Console.WriteLine(res);

string Method4_1(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4_1(10, "Привет ");
Console.WriteLine(res);
