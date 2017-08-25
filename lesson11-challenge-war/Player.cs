using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson11_challenge_war
{
	public class Player
	{
		public string Name { get; set; }
		public List<Card> Hand { get; set; }

		public Player(string name)
		{
			Name = name;
			Hand = new List<Card>();
		}
	}
}