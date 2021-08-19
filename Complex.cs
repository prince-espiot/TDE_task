/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/18/2021
 * Time: 10:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAR_IQ
{
	/// <summary>
	/// Description of Complex.
	/// this class will define the list parameters for IQ inputs
	/// </summary>
	/// 
	
	
	public class Complex
	{
		public double _inter = 0;
		public double _quad =0 ;
		public double prap =0 ;
		const double ten = 10.0d;
		public Complex(string Inter, string Quad)
		{
			_inter = Convert.ToDouble(Inter);
			_quad =Convert.ToDouble(Quad);
			
		}
		static double ParCalculation (List<Complex> inputIQ)
		{

		 	List <Complex>input= new List<Complex>();
		 	//foreach (Complex value in inputIQ)
		 		 
		 	//input.Add(new Complex (Convert.ToDouble_inter,Convert.ToDouble_quad));
		 	summing();
		 	
		 	double power = ten*Math.Log(ten*(sum));
		 		return power;
		}
		
		
		 		
		
	}
}
