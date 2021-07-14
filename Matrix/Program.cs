using System;

namespace Indexer
{
    //    Требуется: 
    //Создать класс Article, содержащий следующие закрытые поля:
    //• название товара;
    //• название магазина, в котором продается товар;
    //• стоимость товара в гривнах.
    //Создать класс Store, содержащий закрытый массив элементов типа Article.
    //Обеспечить следующие возможности:
    //• вывод информации о товаре по номеру с помощью индекса;
    //• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров
    //нет, выдать соответствующее сообщение;
    //Написать программу, вывода на экран информацию о товаре.
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            store[0] = new Article("Телефон", "Розетка", 5000);

            store[1] = new Article("Ноутбук", "Розетка", 20000);

            store[2] = new Article("Планшет", "Розетка", 10000);

            store[3] = new Article("Наушники", "Розетка", 1000);

            store[4] = new Article("Видеокарта", "Розетка", 6000);

            Console.WriteLine("Номер индекса товара: ");

            int index = Convert.ToInt32(Console.ReadLine());

            store[index].Show();

            Console.WriteLine("Название товара: ");

            string productName = Console.ReadLine();

            var result = store[productName];

            if (!result.Equals(null))
            {
                result.Show();
            }



        }
    }
}
