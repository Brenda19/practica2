using System;

namespace practica2
{
	
	public class menu
	{
		public static void Main(string[] args)
		{
			cronometro c;
			reloj r;
			
			
			Console.WriteLine("**Menu**");
			Console.WriteLine("1.-Reloj");
			Console.WriteLine("2.-Cronometro");
			int op = int.Parse(Console.ReadLine());
			
			
			switch (op){
					
					
				case 1: 
					r =new reloj();
					r.GetHashCode();
			break;
					
			
		       case 2:
			c = new cronometro();
			c.GetHashCode();
			
			break;
			default:Console.WriteLine("no valido");
				break;
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
