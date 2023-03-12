using System;

class HelloWorld {
    
    // Создаем класс QuadEquation
    class QuadEquation {
        private double a, b, c;
        private double d, firstRoots, secondRoots;
        
        // Высчитываем дискриминант b^2 - 4 * a * c
        private double subtractDiscriminant () {
            return (b * b) - 4 * a * c;
        }
        
        // конструктор класса, в котором мы присваеваем переменные a, b и c наши значения
        public QuadEquation (double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
            firstRoots = 0;
            secondRoots = 0;
        }
        
       public void CalculateRoots () {
            d = subtractDiscriminant();

            // if это условие, которое позволяет выполнять разный код в зависимости от определнных условий, у нас это если d == 0
            // то мы считаем только первый корень
            if (d == 0)
            {
                firstRoots = ( (b * -1) + Math.Sqrt(d) / 2 * a);
            }
            // else if это еще одно условие, если предыдущее окажется ложью, в нем мы смотрим, если d > 1, значит корня 2
            else if (d > 1)
            {
                firstRoots = ( ((b * -1) + Math.Sqrt(d)) / (2 * a));
                secondRoots = ( ((b * -1) - Math.Sqrt(d)) / (2 * a));
            }
            // else сработает, если ни if или else if не сработали, то есть это грубо говоря значение по умолчанию
            else {
                Console.WriteLine("Корней нет");
            }
            
        }
        
        // все функции ниже необходимы для того, чтобы получить какую-либо переменную из класса
        public double GetA () {
            return a;
        }
        
        public double SetA () {
            return a;
        }
        
        public double GetB () {
            return b;
        }
        
        public double SetB () {
            return b;
        }
        
        public double GetC () {
            return c;
        }
        
        public double SetC () {
            return c;
        }
        
        public double GetD () {
            return d;
        }
        
        public double GetFirstRoots () {
            return firstRoots;
        }
        
        public double GetSecondRoots () {
            return secondRoots;
        }
        
    }
    
  static void Main() {
    
    QuadEquation quad = new QuadEquation(3, 13, 0);
    quad.CalculateRoots();
    Console.WriteLine(quad.GetFirstRoots());
    Console.WriteLine(quad.GetSecondRoots());
  }
}
