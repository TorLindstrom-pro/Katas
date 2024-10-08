namespace Solutions.ATM;

public class Atm
{
	public static int solve(int n) {
		if (n < 10 || n % 10 > 0) {
			return -1;
		}
      
		List<int> notes = [500, 200, 100, 50, 20, 10];

		var result = 0;
		while (n > 0)
		{
			n -= notes.First(note => note <= n);
			result++;
		}

		return result;
	} 
}