using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentLibrary
{
    /// <summary>
    /// Класс, представляющий квартиру.
    /// </summary>
    public class Apartment
    {
        public int Number { get; set; }          // Номер квартиры
        public string Owner { get; set; }         // Владелец квартиры
        public List<Room> Rooms { get; private set; } // Список комнат

        public Apartment(int number, string owner)
        {
            Number = number;
            Owner = owner;
            Rooms = new List<Room>();
        }

        /// <summary>
        /// Метод для добавления комнаты в квартиру.
        /// </summary>
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        /// <summary>
        /// Метод для показа информации о квартире.
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Apartment Number: {Number}, Owner: {Owner}");
        }

        /// <summary>
        /// Метод для показа информации о всех комнатах в квартире.
        /// </summary>
        public void ShowAll()
        {
            Console.WriteLine($"Rooms in Apartment {Number}:");
            foreach (var room in Rooms)
            {
                room.Show();
            }
        }
    }

    /// <summary>
    /// Класс, представляющий комнату.
    /// </summary>
    public class Room
    {
        public string Name { get; set; }        // Назначение комнаты
        public double Area { get; set; }        // Площадь комнаты

        public Room(string name, double area)
        {
            Name = name;
            Area = area;
        }

        /// <summary>
        /// Метод для показа информации о комнате.
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Room Name: {Name}, Area: {Area} sq.m.");
        }
    }
}
