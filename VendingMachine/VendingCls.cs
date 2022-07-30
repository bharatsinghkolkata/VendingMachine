using System;

namespace VendingMachine
{   
    class VendingCls
    {
        const double COST_OF_COLA = 1;
        const double COST_OF_Crisps = 0.5;
        const double COST_OF_Chocolate = 0.65;
        public double RunningTotal { get; set; }

        public VendingCls()
        {
            RunningTotal = 0;
        }

        public void DepositeCoin(string money)
        {
            // the only valid enties are 5p, 10p, 20p, 50p, £1.00, £2.00

            switch (money)
            {
                case ("5p"):
                    RunningTotal += 0.05;
                    Console.WriteLine("");
                    Console.WriteLine("**************************");
                    Console.WriteLine("Your current Amount is {0:C}", RunningTotal);
                    break;

                case ("10p"):
                    RunningTotal += 0.10;
                    Console.WriteLine("");
                    Console.WriteLine("**************************");
                    Console.WriteLine("Your current Amount is {0:C}", RunningTotal);
                    break;

                case ("20p"):
                    RunningTotal += 0.20;
                    Console.WriteLine("");
                    Console.WriteLine("**************************");
                    Console.WriteLine("Your current Amount is {0:C}", RunningTotal);
                    break;

                case ("50p"):
                    RunningTotal += 0.50;
                    Console.WriteLine("");
                    Console.WriteLine("**************************");
                    Console.WriteLine("Your current Amount is {0:C}", RunningTotal);
                    break;

                case ("£1"):
                    RunningTotal += 1;
                    Console.WriteLine("Your current Amount is {0:C}", RunningTotal);
                    break;

                case ("£2"):
                    RunningTotal += 2;
                    Console.WriteLine("Your current Amount is {0:C}", RunningTotal);
                    break;

                default:
                    Console.WriteLine("Invalid Coins");
                    break;
            }
        }

        public bool checkTotal(char selectedProd)
        {
            double CostOfProd = 0;
            switch (selectedProd)
            {
                case ('A'):
                    CostOfProd = COST_OF_COLA;
                    break;

                case ('B'):
                    CostOfProd = COST_OF_Crisps;
                    break;

                case ('C'):
                    CostOfProd = COST_OF_Chocolate;
                    break;

                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }

            if (RunningTotal >= CostOfProd)
                return true;
            else
                return false;
        }
        public void DisplayItemsPrice(char optionSelected)
        {
            MakeItemsSelection(optionSelected);
        }

        public char DisplayItemSelections()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("* A - Cola for £1.00*");
            Console.WriteLine("* B - Crisps for 50p");
            Console.WriteLine("* C - Chocolate for 65p");
            Console.WriteLine("***********************");
            Console.WriteLine();
            Console.WriteLine("Please make your selection");
            char optionSelected = char.ToUpper(Console.ReadLine()[0]);
            optionSelected = MakeItemsSelection(optionSelected);
            return optionSelected;
        }

        private char MakeItemsSelection(char Selection)
        {
            bool selectionOk = false;
            while (!selectionOk)
            {
                switch (Selection)
                {
                    case 'A':
                        Console.WriteLine("Thanks you for choosing A Cola");
                        selectionOk = true;
                        ReturnChange(COST_OF_COLA);
                        break;
                    case 'B':
                        Console.WriteLine("Thanks you for choosing B Crisps");
                        selectionOk = true;
                        ReturnChange(COST_OF_Crisps);
                        break;
                    case 'C':
                        Console.WriteLine("Thanks you for choosing C Chocolate");
                        selectionOk = true;
                        ReturnChange(COST_OF_Chocolate);
                        break;

                    default:
                        Console.WriteLine("Invalid Selection. Please re-enter your selection");
                        Selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selectionOk = false;
                        break;
                }
            }
            return Selection;
        }

        private void ReturnChange(double COST_OF_PRODUCT)
        {
            if (RunningTotal >= COST_OF_PRODUCT)
                Console.WriteLine("Your change is {0:C}", (RunningTotal - COST_OF_PRODUCT));
        }
    }
}
