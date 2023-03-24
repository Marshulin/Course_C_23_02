
string ConvertBin(int num)
	{
	    string result = "";
	    while (num > 0)
	    {
	        result = num % 2 + result;
	        num = num / 2;
	    }
	    return result;
	}
	int n = int.Parse (Console.ReadLine()!);
	string ResultEnd = ConvertBin(n);
	Console.WriteLine(ResultEnd);
