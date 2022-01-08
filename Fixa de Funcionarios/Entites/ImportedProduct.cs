using System;
using System.Collections.Generic;
using System.Globalization;


namespace Fixa_de_Funcionarios.Entites
{
    class ImportedProduct : Product
    {
        public double CustomsFree;
        public ImportedProduct()
        {

        }
        public ImportedProduct(string name, double price,double customsFree) 
            : base(name,price)
        {
            CustomsFree = customsFree;
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + $" Customs free: $  { CustomsFree.ToString("F2",CultureInfo.InvariantCulture)}";

        }


    }
        
    
}
