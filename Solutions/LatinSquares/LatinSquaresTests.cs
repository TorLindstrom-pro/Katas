using NUnit.Framework;

namespace Solutions.LatinSquares;

public class LatinSquaresTests
{
	[Test]
	public void MakeLatinSquare_RowShouldNotContainDuplicates()
	{
		int[][] square = LatinSquare.MakeLatinSquare(4);
		Assert.That(square[0], Is.Unique);
	}
	
	[Test]
	public void MakeLatinSquare_ColumnsShouldNotContainDuplicates()
	{
		int[][] square = LatinSquare.MakeLatinSquare(4);
		var column = square.Select(r => r[0]);
		Assert.That(column, Is.Unique);
	}
	
	[Test]
	public void MakeLatinSquare_AllNumbersAreWithinTheGivenRange()
	{
		int[][] square = LatinSquare.MakeLatinSquare(4);
		int[] flattenedSquare = square.SelectMany(innerArray => innerArray).ToArray();
		Assert.That(flattenedSquare, Is.All.InRange(1,4));
	}
	
	[Theory]
	public void MakeLatinSquare_NonPositiveSize_ThrowsException([System.ComponentModel.DataAnnotations.Range(-1,0)] int size)
	{
		Assert.Throws<ArgumentException>(() => LatinSquare.MakeLatinSquare(size));
	}
}