using System;

class Programm {
    
    // Создаем класс Number
    class Number {
        // Создаем приватную переменную int и сразу зададим ей значение 0
        private int n = 0;
        
        // Создаем bool переменную, которая может вернуть только False или True в языке c#
        public bool SetNumber(int number)
        {
            n = ++n == number ? number : 0;
            // Функция SetNumber возвращает bool значение, а мы пытаемся вернуть число int, чтобы преобразовать int в bool
            // используется Convert.ToBoolean(переменная)
            return Convert.ToBoolean(n);
        }
        
        // Создаем функции, которая возвращает ожидаемое число
        public int ExpectedNumber() {
            return n + 1;
        }
        
    }
    
  static void Main() {
      
    Number number = new Number();
    
   // В нашем случае while всегда будет равно true, тем самым у нас код внутри while будет выполняться почти бесконечно (Завимит от памяти компа)
    while (true)
    {
        Console.WriteLine($"Ожидается число {number.ExpectedNumber()}");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number.SetNumber(n));
    }
    
  }
}
