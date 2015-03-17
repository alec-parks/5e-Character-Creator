
namespace CharacterBuilder.Models
{
	public interface IDice
	{
		int Roll(int sides);
		int Roll(int dice, int sides);
	}
}

