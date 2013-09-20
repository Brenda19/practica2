using System;

namespace practica2
{
	public class cronometro
	{
		public cronometro()
		{
			for(int j=0; j<24; j++){
				for(int k=0; k<60; k++){
					for(int l=0; l<60; l++){
						
						Console.Clear();
						Console.WriteLine(j+":"+k+":"+l);
						System.Threading.Thread.Sleep (1000);
						
						
						
					}
			}
			
		}
		}
	}
}
