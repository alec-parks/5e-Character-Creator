
using System.Collections.Generic;

namespace CharacterBuilder.Models
{
	public class AttributeScores
	{
		private Dictionary<AttributeType,AttributeScore> _attritubteStats = new Dictionary<AttributeType,AttributeScore>();
		public AttributeScores()
		{
			_attritubteStats.Add (AttributeType.Strength, new AttributeScore ());
			_attritubteStats.Add (AttributeType.Dexterity, new AttributeScore ());
			_attritubteStats.Add (AttributeType.Constitution, new AttributeScore ());
			_attritubteStats.Add (AttributeType.Intelligence, new AttributeScore ());
			_attritubteStats.Add (AttributeType.Wisdom, new AttributeScore ());
			_attritubteStats.Add (AttributeType.Charisma, new AttributeScore ());
		}

		public AttributeScore Strength{
			get{ return _attritubteStats [AttributeType.Strength]; }
		}
		public AttributeScore Dexterity{
			get{ return _attritubteStats [AttributeType.Dexterity]; }
		}
		public AttributeScore Constituition{
			get{ return _attritubteStats [AttributeType.Constitution]; }
		}
		public AttributeScore Intelligence{
			get{ return _attritubteStats [AttributeType.Intelligence]; }
		}
		public AttributeScore Wisdom{
			get{ return _attritubteStats [AttributeType.Wisdom]; }
		}
		public AttributeScore Charisma{
			get{ return _attritubteStats [AttributeType.Charisma]; }
		}
	}
}

