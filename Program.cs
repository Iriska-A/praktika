using System;

namespace magazin
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Mag magg = new Mag("Введите имя", "Введите фамилию", "Введите Email", "Придумайте пароль", "Зарегистрироваться");

            Console.WriteLine(magg.ReturnSurnameMag());


            Console.WriteLine(magg.ReturnNameMag());
            Console.WriteLine(magg.ReturnPasswordMag());
            Console.WriteLine(magg.ReturnEmailMag());
            Console.WriteLine(magg.ReturnInputMag());


            Console.ReadLine();



        }
    }
}

