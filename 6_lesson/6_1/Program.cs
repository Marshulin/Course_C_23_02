
void Triangle (int A, int B, int C)
	
	{
	    if (A < B + C & B < A + C & C < A + B)
	    Console.WriteLine("yes");
	
	    else
	    Console.WriteLine("no");
	
	
	}
	
	
	int N1 =int.Parse(Console.ReadLine()!);
	int N2 =int.Parse(Console.ReadLine()!);
	int N3 =int.Parse(Console.ReadLine()!);
	
	
	Triangle(N1, N2, N3);