using CharacterBuilder.Models;

namespace CharacterBuilder.Models.Tests
{
	public class FakeDice:IDice
	{

		public int Roll (int sides)
		{
			return 10;
		}

		public int Roll (int dice,int sides)
		{
			return 10 * dice;
		}

	}
}

