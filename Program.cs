using System;
class Program
{
    static void Main()
    {
        int j = 1;
		while(j <= 10){
			for(int i = 1; i <= 10; i++){
				Console.WriteLine($"{j} x {i} = {j * i}");
			}
			Console.WriteLine("\n");
			j+= 1;
		}
    }
}