using Assisticant.Fields;

namespace CharacterBuilder.Models
{
	public class Attributes
	{
		private Observable<int> _str = new Observable<int>(8);
		private Observable<int> _dex = new Observable<int>(8);
		private Observable<int> _con = new Observable<int>(8);
		private Observable<int> _int = new Observable<int>(8);
		private Observable<int> _wis = new Observable<int>(8);
		private Observable<int> _cha = new Observable<int>(8);

		public int Strength
		{
			get { return _str.Value; }
			set { _str.Value = value; }
		}
		public int Dexterity
		{
			get { return _dex.Value; }
			set { _dex.Value = value; }
		}
		public int Constitution
		{
			get { return _con.Value; }
			set { _con.Value = value; }
		}
		public int Intelligence
		{
			get { return _int.Value; }
			set { _int.Value = value; }
		}
		public int Wisdom
		{
			get { return _wis.Value; }
			set { _wis.Value = value; }
		}
		public int Charisma
		{
			get { return _cha.Value; }
			set { _cha.Value = value; }
		}

	}
}

