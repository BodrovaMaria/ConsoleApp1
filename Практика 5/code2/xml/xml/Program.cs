using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Data;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //// #1
            // Создаем файл для сохранения данных
           // FileStream fs = new FileStream("SerializedDate.XML", FileMode.Create);

            // Создаем объект XmlSerializer для выполнения сериализации
            //XmlSerializer xs = new XmlSerializer(typeof(DateTime));
            //// Используем объек  XmlSerializer для сериализации данных в файл
            //xs.Serialize(fs, System.DateTime.Now);
            //// Закрываем файл
            //fs.Close();

            ////#2
            // Открываем файл для чтения данных
            //FileStream fs = new FileStream("SerializedDate.XML", FileMode.Open);
            //// Создаем объект XmlSerializer для выполнения десериализации 
            //XmlSerializer xs = new XmlSerializer(typeof(DateTime));
            //// Используем объект XmlSerializer для десериализации данных из файла
            //DateTime previousTime = (DateTime)xs.Deserialize(fs);
            //// Закрываем файл
            //fs.Close();
            //// Отображаем десериализованное время 
            //Console.WriteLine("Day: " + previousTime.DayOfWeek + ", Time: " + previousTime.TimeOfDay.ToString());

            //#3
            FileStream fs = new FileStream("SerializedShoppingCartItem.XML", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(ShoppingCartItem));
            xs.Serialize(fs, new ShoppingCartItem());
            fs.Close();

        }
            //#4

        //private static void SerializeDataSet(string filename)
        //{
        //    XmlSerializer ser = new XmlSerializer(typeof(DataSet));

        //    // Создаем DataSet; добавляем таблицу, столбец и десять строк.
        //    DataSet ds = new DataSet("myDataSet");
        //    DataTable t = new DataTable("tablel");
        //    DataColumn с = new DataColumn("thing");
        //    t.Columns.Add(c);
        //    ds.Tables.Add(t);
        //    DataRow r;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        r = t.NewRowO; r[0] = "Thing " + i; t.Rows.Add(r);
        //    }
        //    TextWriter writer = new StreamWriter(filename); ser.Serialize(writer, ds); writer.Close();


        //}
    }
}
