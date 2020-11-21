using System;

namespace CalCulatorDegree
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int i = 1;
            do
            {
                Console.WriteLine("Что вы хотите перевести (Цельсия в Фаренгейт) - 1, (Фаренгейт в Цельсия) - 0, (Кельвин в Цельсия) - 2?");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 0:
                        Console.Write("Введите температуру по шкале Цельсия:\t");
                        double inputCelsius = double.Parse(Console.ReadLine());
                        double outputVaulue1 = MethodCelsiusToFahrenheit(inputCelsius);
                        Console.WriteLine("{0}°С перевод в Фаренгейт: {1}°K", inputCelsius, outputVaulue1);
                        break;
                    case 1:
                        Console.Write("Введите температуру по шкале Фаренгейта:\t");
                        double inputFahrenheit = double.Parse(Console.ReadLine());
                        double outputVaulue2 = MethodFahrenheitToCelsius(inputFahrenheit);
                        Console.WriteLine("{0}°С перевод в Цельсия: {1}°K", inputFahrenheit, outputVaulue2);
                        break;
                    case 2:
                        Console.Write("Введите темературу по шкале Кельвина:\t");
                        double inputKelvin = double.Parse(Console.ReadLine());
                        double outputValue = MethodKelvinToCelsius(inputKelvin);
                        Console.WriteLine("{0}°С перевод в Кельвин: {1}°K", inputKelvin, outputValue);
                        break;
                }
                Console.WriteLine("Хотите поробовать еще раз? да - 1, нет - 0");
                i = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            while (i != 0);
            Console.WriteLine("Программа закончена");
            Console.ReadKey();


        }

        static double MethodKelvinToCelsius(double kelvin)
        {
            double convertedCelsius = 0;

            convertedCelsius = kelvin - 273.15f;

            return convertedCelsius;
        }

        static double MethodCelsiusToFahrenheit(double Celsius)
        {
            double convertedCelsius = 0;
            convertedCelsius = Celsius * 1.8 + 32;
            return convertedCelsius;



        }
        static double MethodFahrenheitToCelsius(double Fahrenheit)
        {
            double convertedFahrenheit = 0;
            convertedFahrenheit = (Fahrenheit - 32) / 1.8;
            return convertedFahrenheit;



        }
    }
}
