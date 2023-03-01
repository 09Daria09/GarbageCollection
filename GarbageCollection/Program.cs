using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Program
    {
        class Piece: IDisposable 
        {
            public string PieceTitle { get; set; }
            public string AuthorsName { get; set; }
            public string Genre { get; set; }
            public int YearOfRelease { get; set; }
            public Piece(string pieceTitle, string authorsName, string genre, int yearOfRelease)
            {
                PieceTitle = pieceTitle;
                AuthorsName = authorsName;
                Genre = genre;
                YearOfRelease = yearOfRelease;
            }
            public Piece()
            {
                PieceTitle = null;
                AuthorsName = null;
                Genre = null;
                YearOfRelease = 0;
            }
            public override string ToString()
            {
                return $"Название пьесы: {PieceTitle}\nАвтор: {AuthorsName}\nЖанр: {Genre}\nГод выпуска: {YearOfRelease}";
            }
            ~Piece()
            {
                Console.WriteLine("Пьеса '{0}' уничтожена", PieceTitle);
                Console.Beep();
            }
            public void Dispose()
            {
                Console.WriteLine("Освобождение ресурсов объекта!");
            }
        }
        enum Type
        {
            Grocery, Hardware, Cloth, Shoes
        }
        class Shop
        {
            public string NameOfShop { get; set; }
            public string Address { get; set; }
            public Type Type { get; set; }
            public Shop()
            {
                NameOfShop = null;
                Address = null;
                Type = 0;
            }
            public Shop(string nameOfShop, string address, Type type)
            {
                NameOfShop = nameOfShop;
                Address = address;
                Type = type;
            }
            public override string ToString()
            {
                return $"Название магазина: {NameOfShop}\nАдресс: {Address}\nТип магазина: {Type}";
            }
            ~Shop()
            {
                Console.WriteLine("Магазин '{0}' уничтожена", NameOfShop);
                Console.Beep();
            }
            public void Dispose()
            {
                Console.WriteLine("Освобождение ресурсов объекта!");
            }
        }

        static void Main(string[] args)
        {
            //1
            Piece piece1 = new Piece("Королева ветров", "Джулл Франц", "Комедия", 2005);
            Console.WriteLine(piece1.ToString());
            piece1.Dispose();
            //2
            Shop shop = new Shop("Amazon", "Короткова 13/2", Type.Hardware);
            Console.WriteLine(shop.ToString());
            shop.Dispose();
        }
    }
}
