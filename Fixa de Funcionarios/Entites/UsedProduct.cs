using System;
using System.Globalization;


namespace Fixa_de_Funcionarios.Entites
{
    class UsedProduct :Product
    {

        public DateTime ManufactureDate;

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }


        public override string PriceTag()
        {
            return Name + " $ " + Price + " Manufacuture date : " + ManufactureDate.ToString("dd/MM/yyyy");

        }
    }

}
