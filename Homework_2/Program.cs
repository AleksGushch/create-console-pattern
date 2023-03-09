using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName="Иванов Иван Иванович";
            int age = 33;
            string email = "qwerty@mail.ru";
            float programmingPoints = 4.6f;
            float mathematicsPoints = 4.7f;
            float physicsPoints = 4.5f;
            float totalPoints;
            float middlePoints;
            string pattern = ("Задание 1.\n" +
                "Ф.И.О: {0} " +
                "\nВозвраст: {1} " +
                "\nE-mail: {2} " +
                "\nБаллы по программированию: {3} " +
                "\nБаллы по математике: {4} " +
                "\nБаллы по физике: {5}");
            Console.WriteLine(pattern,
                                fullName,
                                age,
                                email,
                                programmingPoints,
                                mathematicsPoints,
                                physicsPoints);
            totalPoints=programmingPoints+mathematicsPoints+physicsPoints;
            middlePoints = totalPoints / 3;
            Console.WriteLine($"Задание 2. \nСумма баллов: {totalPoints} \nСредний балл: {middlePoints}");
            Console.ReadKey();

        }
    }
}
