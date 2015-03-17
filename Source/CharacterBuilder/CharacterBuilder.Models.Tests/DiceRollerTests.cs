using CharacterBuilder.Models;
using Xunit;

namespace CharacterBuilder.Models.Tests
{
	public class DiceRollerTests
	{
		[Fact]
		public void ShouldReturnRandom()
		{
			var sut = new DiceRoller ();
			for (int i = 0; i <= 10000; i++)
			{
				Assert.InRange (sut.Roll (20), 1, 20);
			}
		}

		[Theory]
		[InlineData(1,20)]
		[InlineData(2,8)]
		[InlineData(4,6)]
		public void ShouldAllowMultipleDice(int dice, int sides)
		{
			var sut = new DiceRoller ();

			Assert.InRange (sut.Roll (dice, sides), dice, dice * sides);

		}
	}
}

