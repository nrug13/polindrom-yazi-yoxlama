﻿// C# program to find if a
// sentence is palindrome
using System;

public class GFG
{

	
	static bool polindrom(String exp)
	{
		int x = 0;
		int h = exp.Length - 1;

		
		exp = exp.ToLower();

		
		while (x <= h)
		{

			char yoxla11 = exp[x];
			char yoxla2 = exp[h];

			
			if (!(yoxla11 >= 'a' &&
				yoxla11 <= 'z'))
				x++;

			
			else if (!(yoxla2 >= 'a' &&
					yoxla2 <= 'z'))
				h--;

			
			else if (yoxla11 == yoxla2)
			{
				x++;
				h--;
			}

			else
				return false;
		}
		return true;
	}

	
	public static void Main()
	{
		String str = Console.ReadLine();
		if (polindrom(str))
			Console.Write("palindrome");
		else
			Console.Write("yox");
	}
}


