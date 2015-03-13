using Assisticant.Fields;
using System;

namespace CharacterBuilder.Models
{
	public class Attribute
	{
		private Observable<int> _score = new Observable<int>(8);

		public int Score 
		{
			get { return _score.Value;}
			set { _score.Value = value;}
		}

		public int Modifier 
		{
			get { return GetModifier(_score); }
		}

		private int GetModifier(int sc)
		{
			return (int) Math.Floor((sc - 10) / 2.0);
		}

	}
}

