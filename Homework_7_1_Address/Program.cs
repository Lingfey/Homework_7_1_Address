////Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте программу в которой создайте класс «Адрес». 
//В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
//Для каждого поля, создать свойство с двумя методами доступа. Также в классе
//необходимо создать метод для отображения информации про адрес.
//В методе Main() создайте экземпляр класса «Адрес», присвойте всем полям значение через свойства доступа,
//а также на экземпляр класса вызовите метод, который выводит информацию про адрес.
//using System;

namespace Homework_7_1_Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address userAddress = new Address();
            userAddress.Country = "Ukraine";
            userAddress.City = "Kyiv";
            userAddress.Street = "Peremohy prosp.";
            userAddress.Bldg = "8b";
            userAddress.Apt = "1098";
            userAddress.Zip = "08932";

            userAddress.getAddress();
        }
    }
}