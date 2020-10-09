using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace _Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            //string data = "This must be stored in a file.";

            //// Создаем файл, в который будут сохраняться данные
            //FileStream fs = new FileStream("SerializedString.Data", FileMode.Create);

            //// Создаем объект BinaryFormatter для выполнения сериадизации
            //BinaryFormatter bf = new BinaryFormatter();
            //// Используем объект BinaryFormatter для сериализации данных в файл
            //bf.Serialize(fs, data);
            //// Закрываем файл 
            //fs.Close();

            //#2
           //  С#
            //Создаем файл, в который будут сохраняться данные
            //FileStream fs = new FileStream("SerializedDate.Data", FileMode.Create);
            //// Создаем объект BinaryFormatter для выполнения сериализации 
            //SoapFormatter bf = new SoapFormatter();
            //// Используем объект BinaryFormatter для сериализации данных в файл 
            //var obj= new ShoppingCartItem(1,100,10);
            //bf.Serialize(fs,obj );
            //// Закрываем файл 
            //fs.Close();

            //#3
            //// С#
            // Открываем файл, из которого будут считываться данные
            //FileStream fs = new FileStream("SerializedString.Data", FileMode.Open);

            //// Создаем объект BinaryFormatter для выполнения десериализации
            //BinaryFormatter bf = new BinaryFormatter();
            //// Создаем объект для хранения десериализованных данных
            //string data = "";
            //// Используем объект BinaryFormatter для десериализации данных из файла
            //data = (string)bf.Deserialize(fs);
            //// Закрываем файл
            //fs.Close();
            //// Отображаем десериализованную строку 
            //Console.WriteLine(data);

            //#4
            // Открываем файл, из которого будут считываться данные
            FileStream fs = new FileStream("SerializedDate.Data", FileMode.Open);

            // Создаем объект BinaryFormatter для выполнения десериализации
            SoapFormatter bf = new SoapFormatter();
            // Создаем объект для хранения десериализованных данных
            ShoppingCartItem obj = (ShoppingCartItem)bf.Deserialize(fs);
            // Закрываем файл 
            fs.Close();
            //// Отображаем десериализованное время 
            // Console.WriteLine("Day: " + previousTime.DayOfWeek + ", Time: " + previousTime.TimeOfDay.ToString());
            // Console.WriteLine("Day: " + DateTime.Now.DayOfWeek + ", Time: " + DateTime.Now.TimeOfDay.ToString());



        }
    }
}
