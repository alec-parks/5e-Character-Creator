using System;

namespace CharacterBuilder.Models
{
	public class DiceRoller:IDice
	{

		readonly static Random DiceRoll = new Random();

		public int Roll (int sides)
		{
			return DiceRoll.Next (1, sides + 1);
		}

		public int Roll(int dice, int sides)
		{
			int retValue = 0;
			for (int i = 0; i < dice; i++)
			{
				retValue += DiceRoll.Next (1, sides + 1);
			}
			return retValue;
		}

	}
}

