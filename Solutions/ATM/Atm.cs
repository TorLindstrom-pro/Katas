namespace Solutions.ATM;

public class Atm
{
	public static int solve(int n) {
		if (n < 10 || n % 10 > 0) {
			return -1;
		}
      
		List<int> notes = [500, 200, 100, 50, 20, 10];
		
		return notes.Aggregate(new Tuple<int, int>(n, 0), (accumulated, note) =>
		{
			var (quotient, remainder) = int.DivRem(accumulated.Item1, note);
			return new Tuple<int, int>(remainder, accumulated.Item2 + quotient);
		}).Item2;
	} 
}