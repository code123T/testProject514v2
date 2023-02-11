using System;

namespace EmekHaggi
{
    class Program
    {
        static void Main(string[] args)
        {
            string DisabilityStatus;
            double NumberOfChildren;
            string MarriageStatus;
            double ChildCompensation = 0;
            double TotalSalary = 0;
            double FamilyAssitance = 0;
            bool IsContinue = true;
            double FixSalary = 0;
            double WageTaxPercentage = 0;
            double WageTaxAmount = 0;
            double Tax;

            do
            {
                Console.Write("Emek haqqinizi daxil edin: ");
                TotalSalary = Convert.ToInt32(Console.ReadLine());
                Console.Write("Aile veziyyetinizi daxil edin (e/E: evli, b/B: subay, d/Du: dul) :  ");
                MarriageStatus = Console.ReadLine().ToLower();

                if (MarriageStatus == "evli" || MarriageStatus == "dul")
                {
                    if (MarriageStatus == "evli")
                    {
                        FamilyAssitance += 50;
                        TotalSalary = TotalSalary + FamilyAssitance;

                    }

                    Console.Write("Usaqlarinizin sayini daxil edin: ");
                    NumberOfChildren = Convert.ToInt32(Console.ReadLine());
                    if (NumberOfChildren == 1)
                    {
                        ChildCompensation += 30;
                        TotalSalary = TotalSalary + ChildCompensation;
                    }
                    else if (NumberOfChildren == 2)
                    {
                        ChildCompensation = 30 + 25;
                        TotalSalary = TotalSalary + ChildCompensation;
                    }
                    else if (NumberOfChildren == 3)
                    {
                        ChildCompensation = 30 + 25 + 20;
                        TotalSalary = TotalSalary + ChildCompensation;
                    }
                    else
                    {
                        ChildCompensation = 30 + 25 + 20 + ((NumberOfChildren - 3) * 15);
                        TotalSalary = TotalSalary + ChildCompensation;

                    }
                }

                Console.Write("Elilsiniz? (e/E: beli, h/N: yox):  ");
                DisabilityStatus = Console.ReadLine();
                if (DisabilityStatus == "beli")
                {
                    if (TotalSalary <= 1000)
                    {

                        WageTaxPercentage = 15/ 2;
                        WageTaxAmount = (TotalSalary / 100) * WageTaxPercentage;
                        FixSalary = TotalSalary - WageTaxAmount;
                        Console.WriteLine("Sizin vergi dereceniz: " + WageTaxPercentage);

                    }
                    else if (TotalSalary > 1000 || TotalSalary <= 2000)
                    {
                        WageTaxPercentage = 20/2;
                        WageTaxAmount = (TotalSalary / 100) * WageTaxPercentage;
                        FixSalary = TotalSalary - WageTaxAmount;
                        Console.WriteLine("Sizin vergi dereceniz: " + WageTaxPercentage);
                    }
                    else if (TotalSalary > 2000 || TotalSalary <= 3000)
                    {
                        WageTaxPercentage = 25 / 2;
                        WageTaxAmount = (TotalSalary / 100) * WageTaxPercentage;
                        FixSalary = TotalSalary - WageTaxAmount;
                        Console.WriteLine("Sizin vergi dereceniz: " + WageTaxPercentage);
                    }
                    else if (TotalSalary > 3000)
                    {
                        WageTaxPercentage = 30/2;
                        WageTaxAmount = (TotalSalary / 100) * WageTaxPercentage;
                        FixSalary = TotalSalary - WageTaxAmount;
                        Console.WriteLine("Sizin vergi dereceniz: " + WageTaxPercentage);
                    }

                }
                else
                {
                    if (TotalSalary <= 1000)
                    {

                        WageTaxPercentage = 15;
                        WageTaxAmount = (TotalSalary / 100) * 15;
                        FixSalary = TotalSalary - WageTaxAmount;
                        Console.WriteLine("Sizin vergi dereceniz: " + WageTaxPercentage);

                    }
                    else if (TotalSalary > 1000 || TotalSalary <= 2000)
                    {
                        WageTaxPercentage = 20;
                        WageTaxAmount = (TotalSalary / 100) * 20;
                        FixSalary = TotalSalary - WageTaxAmount;
                        Console.WriteLine("Sizin vergi dereceniz: " + WageTaxPercentage);
                    }
                    else if (TotalSalary > 2000 || TotalSalary <= 3000)
                    {
                        WageTaxPercentage = 25;
                        WageTaxAmount = (TotalSalary / 100) * 25;
                        FixSalary = TotalSalary - WageTaxAmount;
                        Console.WriteLine("Sizin vergi dereceniz: " + WageTaxPercentage);
                    }
                    else if (TotalSalary > 3000)
                    {
                        WageTaxPercentage = 30;
                        WageTaxAmount = (TotalSalary / 100) * 30;
                        FixSalary = TotalSalary - WageTaxAmount;
                        Console.WriteLine("Sizin vergi dereceniz: " + WageTaxPercentage);
                    }
                }
                

              
               
                Console.WriteLine("Sizin fix geliriniz: "+ FixSalary);
                Console.WriteLine("Sizin gelir vergisinin meblegi: "+ WageTaxAmount);
                Console.WriteLine("Sizin umumi maasiniz:" +TotalSalary);
                Console.WriteLine("Sizin Aile desteyiniz: " +FamilyAssitance);
                Console.WriteLine("Usaq Pulunuz:"+ChildCompensation);

                int[] MonetaryUnit = { 200, 100, 50, 20, 10, 5, 1 };
                //int TwoHundredMonetaryUnit = 0;
                //int OneHundredMonetaryUnit = 0;
                //int FiftyMonetaryUnit = 0;
                //int TwentyMonetaryUnit = 0;
                //int TenMonetaryUnit = 0;
                //int FiveMonetaryUnit = 0;
                //int OneMonetaryUnit = 0;
                int UnitsCount = 0;

                for (int i = 0; i < MonetaryUnit.Length; i++)
                {

                    UnitsCount=Convert.ToInt32(Math.Floor(FixSalary/MonetaryUnit[i]));
                    if (UnitsCount !=0)
                    {
                        Console.WriteLine($"{UnitsCount} eded {MonetaryUnit[i]} AZN VERILDI");
                    }
                    FixSalary = FixSalary - (UnitsCount * MonetaryUnit[i]);

                    //TwoHundredMonetaryUnit = FixSalary / MonetaryUnit[0];
                    //int result1 = FixSalary - TwoHundredMonetaryUnit * MonetaryUnit[0];
                    //OneHundredMonetaryUnit = result1 / MonetaryUnit[1];
                    //int result2 = result1 - OneHundredMonetaryUnit * MonetaryUnit[1];
                    //FiftyMonetaryUnit = result2/ MonetaryUnit[2];
                    //int result3 = result2 - FiftyMonetaryUnit * MonetaryUnit[2];
                    //TwentyMonetaryUnit = result3 / MonetaryUnit[3];
                    //int result4 = result3 - TwentyMonetaryUnit * MonetaryUnit[3];


                }


                //Console.WriteLine("Sizin fix geliriniz: " + FixSalary);
                //Console.WriteLine("Sizin gelir vergisinin meblegi: " + WageTaxAmount);
                //Console.WriteLine("Sizin umumi maasiniz:" + TotalSalary);
                //Console.WriteLine("Sizin Aile desteyiniz: " + FamilyAssitance);
                //Console.WriteLine("Usaq Pulunuz:" + ChildCompensation);




            } while (IsContinue);
           
        }   
    }
}
