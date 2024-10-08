using NUnit.Framework;

namespace Solutions.ATM;

public class AtmTests
{
	[TestCase(1, ExpectedResult = -1)]
	[TestCase(0, ExpectedResult = -1)]
	[TestCase(5, ExpectedResult = -1)]
	public int Solve_LessThan10_ReturnsNegativeOne(int amount)
	{
		return Atm.solve(amount);
	}
	
	[TestCase(10, ExpectedResult = 1)]
	[TestCase(20, ExpectedResult = 1)]
	[TestCase(500, ExpectedResult = 1)]
	public int Solve_MathingANote_ReturnsOne(int amount)
	{
		return Atm.solve(amount);
	}
	
	[TestCase(30, ExpectedResult = 2)]
	[TestCase(260, ExpectedResult = 3)]
	[TestCase(1620, ExpectedResult = 5)]
	public int Solve_AmountIsCombinationOfNotes_ReturnsMinimumNumberOfNotes(int amount)
	{
		return Atm.solve(amount);
	}
}