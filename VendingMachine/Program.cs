using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendingObj = new VendingCls();

            char selectedProd = vendingObj.DisplayItemSelections();

            while (!vendingObj.checkTotal(selectedProd))
            {
                Console.WriteLine("Please enter valid coin (5p, 10p, 20p, 50p, £1, £2)");
                vendingObj.DepositeCoin(Convert.ToString(Console.ReadLine().ToLower()));
            }

            vendingObj.DisplayItemsPrice(selectedProd);

            Console.ReadLine();
        }
    }
}
