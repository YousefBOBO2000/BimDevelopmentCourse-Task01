using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Variables
            //Console.WriteLine("What's the Room Width");
            //Double Width = Double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("What's the Room Height");
            //Double Height = Double.Parse(Console.ReadLine());
            //Console.WriteLine("What's the Room Length");
            //double Length = double.Parse(Console.ReadLine());
            //#endregion
            //#region STR.
            //Console.WriteLine("What's the Beam Length");
            //double BeamLength = double.Parse(Console.ReadLine());
            //Console.WriteLine("What's the Beam Weight Per meter");
            //double Weight = double.Parse(Console.ReadLine());
            //Console.WriteLine(BeamLength * Weight);
            //#endregion
            #region DataTypes OF Arch.
            bool availability = true;
            if (availability == true)
            {
                Console.WriteLine("available For disabled People");
            }
            else
            {
                Console.WriteLine("no available");
            } 
            #endregion
          

                Console.WriteLine("The cost Per Unit Area:");
                double CostPerUnitArea =double.Parse(Console.ReadLine());
            Console.WriteLine(  " TotalArea = ");
            double TotalArea = double.Parse(Console.ReadLine());
            double AreaCost = TotalArea*CostPerUnitArea;
            Console.WriteLine(AreaCost);

        }
    }
}
