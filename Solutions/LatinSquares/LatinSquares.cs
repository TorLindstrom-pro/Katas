namespace Solutions.LatinSquares;

public class LatinSquare
{
	public static int[][] MakeLatinSquare(int n)
	{
		if (n < 1)
		{
			throw new ArgumentException("n must be at least 1");
		}
		
		int[][] latinSquare = new int[n][];
		for (int i = 0; i < n; i++)
		{
			latinSquare[i] = new int[n];
			for (int j = 0; j < n; j++)
			{
				latinSquare[i][j] = (j + 1 + i) % n + 1;
			}
		}

		return latinSquare;
	}
}