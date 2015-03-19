using CharacterBuilder.Models;
using Xunit;

namespace CharacterBuilder.Models.Tests
{
	public class AttributeTests
	{
		[Theory]
		[InlineData(8,-1)]
		[InlineData(7,-2)]
		[InlineData(9,-1)]
		[InlineData(10,0)]
		[InlineData(11,0)]
		[InlineData(12,1)]
		public void ShouldComputeModifier(int score, int result)
		{
			var sut = new AttributeScore();

			sut.Score = score;

			Assert.Equal (result, sut.Modifier);
		}
	}
}

