using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace _Serialize
{
    [Serializable]
    
    class ShoppingCartItem  :IDeserializationCallback 
    {
        [SoapAttribute]
        public int productld;

        [SoapElement]
        public int Name { get; set; }

        [SoapAttribute]
        public decimal price;
        [SoapAttribute]
        public int quantity;
        //#2
        [NonSerialized]
        [SoapIgnore] 
        public decimal total;

        public ShoppingCartItem(int _productID, decimal _price, int _quantity)
        {
            productld = _productID;
            price = _price;
            quantity = _quantity;
            total = price * quantity;
        }

       

        #region IDeserializationCallback Members

        public void OnDeserialization(object sender)
        {
            total = price * quantity;
        }

        #endregion
    }

}
