using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace _OptionalFieldAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [Serializable]
    class ShoppingCartltem : IDeserializationCallback
    {
        public int productld;
        public decimal price;
        public int quantity;
        [NonSerialized]
        public decimal total;
        [OptionalField]
        public bool taxable;
    }

}
