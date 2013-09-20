using System;

namespace practica2
{
	
	public class reloj
	{
		public reloj()
		{
			int h = DateTime.Now.Hour;
			int m = DateTime.Now.Minute;
			int s = DateTime.Now.Second;
			
			
			for(int x=h; x<24; x++){
				for(int w=m; w<60; x++){
					for(int z=s; z<60; z++){
						
						Console.Clear();
						Console.WriteLine(x+":"+w+":"+z);
						System.Threading.Thread.Sleep (1000);
						
					}
			}
		}
		}
	}
}
