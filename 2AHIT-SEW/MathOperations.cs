using System;

public class MathOperations
{
	static long Fakultät(long n)
	{
		if(n < 0) throw new InvalidArgumentException("Zahl muss >=0 sein!")

		long a = 1;

        checked
        {
			if (n == 0) return a;
			for (int i = 1; i <= n; i++)
			{
				a *= i;
			}
		}
		
		return a;
	}

	static long Fakultät2(long n)
    {
        checked
        {
			if (n == 1)
			{
				return 1;
			}
			else
			{
				return Fakultät2(n - 1) * n;
			}
		}
    }
}
