/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/18/2021
 * Time: 08:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
	
namespace PAR_IQ
{
	class Program
	{
		
		static List<Complex> inputIQ = new List<Complex>();
		
		public static void Main(string[] args)
		{
			
			// TODO: Implement Functionality Here
			//List<Complex> inputIQ = new List<Complex>();
			Console.WriteLine("Please enter an inter");
			string inter = Console.ReadLine();
			
			Console.WriteLine("Please enter an Q");
			string quad = Console.ReadLine();
			
			inputIQ.Add(new Complex (inter, quad));
			
			
			// ParCalculation(inputIQ);

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static double summing (double inter, double quad)
		{
			double sum;
			inter *= inter;
		 	quad *= quad;
		 	
		 	return sum = inter + quad;
		}
		
		
	}
	
}