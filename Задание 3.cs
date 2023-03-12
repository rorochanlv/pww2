using System;

public class CaesarCipher
{
    //символы русского алфавита
    const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

    // создаем приватную переменную с параметрами текст и ключ
    private string CodeEncode(string text, int k)
    {
        //добавляем в алфавит маленькие буквы
        string fullAlfabet = alfabet + alfabet.ToLower();
        
        // Узнаем длину получившегося алфавита после вместе с маленькими и большими буквами
        int letterQty = fullAlfabet.Length;

        // Создаем строку, в которой будет хранится наша Зашифрованная строка
        string retVal = "";
       
        for (int i = 0; i < text.Length; i++)
        {
            // получаем один символ из нашей строки 
            char c = text[i];
            // Сейчас мы находим позицию нашей буквы, которая хранится в c 
            int index = fullAlfabet.IndexOf(c);
            // Если в нашей строки есть число, то его нет в алфавите, значит нам надо вернуть его без изменений
            if (index < 0)
            {
                // если символ не найден, то добавляем его в неизменном виде
                // ToString позволяет конвертировать char в строку  
                retVal += c.ToString();
            }
            else
            {
               int codeIndex = (letterQty + index + k) % letterQty;
                retVal += fullAlfabet[codeIndex];
            }
            
        }

        return retVal;
    }

    //шифрование текста
    public string Encrypt(string plainMessage, int key) 
    {
        return CodeEncode(plainMessage, key);
    }

    //дешифрование текста
    public string Decrypt(string encryptedMessage, int key)
    {
        return CodeEncode(encryptedMessage, -key);
    }

}

class Program
{
    static void Main(string[] args)
    {
        var cipher = new CaesarCipher();
        
        Console.Write("Введите текст на русском: ");
        var message = Console.ReadLine();
        
        Console.Write("Введите ключ: ");
        var secretKey = Convert.ToInt32(Console.ReadLine());
        
        var encryptedText = cipher.Encrypt(message, secretKey);
        Console.WriteLine($"Зашифрованное сообщение: {encryptedText}");
        Console.WriteLine($"Расшифрованное сообщение: {cipher.Decrypt(encryptedText, secretKey)}");
        Console.ReadLine();
    }
}