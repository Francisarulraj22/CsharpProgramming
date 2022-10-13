using System;

namespace Question7;
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Customer Id:");
            int customerId=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Name of the customer:");
            string name=Console.ReadLine();
            System.Console.WriteLine("Unit used:");
            int unit=int.Parse(Console.ReadLine());
            
            if(unit<100)
            {
                System.Console.WriteLine($"Customer IDNO:{customerId}");
                System.Console.WriteLine($"Customer Name:{name}");
                System.Console.WriteLine($"unit Consumed:{unit}");
                System.Console.WriteLine("Minimum amount Charged:Rs.100.00");
            }
            else if(unit<200)
            {
                System.Console.WriteLine($"Customer IDNO:{customerId}");
                System.Console.WriteLine($"Customer Name:{name}");
                System.Console.WriteLine($"unit Consumed:{unit}");
                double totalAmount=unit*1.20;
                System.Console.WriteLine("Amount Charges @Rs.1.20:"+totalAmount);
                if (totalAmount>400)
                {   double surcharge=totalAmount*0.15;
                    System.Console.WriteLine("Surcharge Amount:"+surcharge);
                    System.Console.WriteLine("Net Amount Paid By the Customer :"+(totalAmount+surcharge));
                }
                else
                System.Console.WriteLine("Net Amount Paid By the Customer :"+totalAmount);

            }
            else if(unit>=200&&unit<400)
            {
                System.Console.WriteLine($"Customer IDNO:{customerId}");
                System.Console.WriteLine($"Customer Name:{name}");
                System.Console.WriteLine($"unit Consumed:{unit}");
                double totalAmount=unit*1.50;
                System.Console.WriteLine("Amount Charges @Rs.1.50:"+totalAmount);
                if (totalAmount>400.00)
                {   double surcharge=totalAmount*0.15;
                    System.Console.WriteLine("Surcharge Amount:"+surcharge);
                    System.Console.WriteLine("Net Amount Paid By the Customer :"+(totalAmount+surcharge));
                }
                else
                System.Console.WriteLine("Net Amount Paid By the Customer :"+totalAmount);

            }
            else if(unit>=400&&unit<600)
            {
                System.Console.WriteLine($"Customer IDNO:{customerId}");
                System.Console.WriteLine($"Customer Name:{name}");
                System.Console.WriteLine($"unit Consumed:{unit}");
                double totalAmount=unit*1.80;
                System.Console.WriteLine("Amount Charges @Rs.1.80:"+totalAmount);
                if (totalAmount>400)
                {   double surcharge=totalAmount*0.15;
                    System.Console.WriteLine("Surcharge Amount:"+surcharge);
                    System.Console.WriteLine("Net Amount Paid By the Customer :"+(totalAmount+surcharge));
                }
                else
                System.Console.WriteLine("Net Amount Paid By the Customer :"+totalAmount);

            }
            else if(unit>=600)
            {
                System.Console.WriteLine($"Customer IDNO:{customerId}");
                System.Console.WriteLine($"Customer Name:{name}");
                System.Console.WriteLine($"unit Consumed:{unit}");
                double totalAmount=unit*2.00;
                System.Console.WriteLine("Amount Charges @Rs.2.00:"+totalAmount);
                if (totalAmount>400)
                {   double surcharge=totalAmount*0.15;
                    System.Console.WriteLine("Surcharge Amount:"+surcharge);
                    System.Console.WriteLine("Net Amount Paid By the Customer :"+(totalAmount+surcharge));
                }
                else
                System.Console.WriteLine("Net Amount Paid By the Customer :"+totalAmount);

            }
            
        }
    }


