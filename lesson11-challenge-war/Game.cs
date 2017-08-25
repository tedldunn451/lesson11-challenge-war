using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson11_challenge_war
{
	public class Game
	{
		private Player _player1;
		private Player _player2;

		public Game()
		{
			_player1 = new Player("Player1");
			_player2 = new Player("Player2");
		}

		public string Play()
		{
			Deck deck = new Deck();

			string result = "<h3>Dealing cards ...</h3>";
			result += deck.Deal(_player1, _player2);
			result += "<h3>Begin battle ...</h3>";

			int round = 1;

			while (_player1.Hand.Count != 0 && _player2.Hand.Count != 0)
			{
				Battle battle = new Battle();
				result += battle.PerformBattle(_player1, _player2);

				round++;

				if (round > 20)
					break;
			}

			result += determineGameWinner();
			return result ;
		}

		private string determineGameWinner()
		{
			string winner = "";

			if (_player1.Hand.Count > _player2.Hand.Count)
				winner += "<br />Player1 wins!";
			else
				winner += "<br />Player2 wins!";

			winner += "<br />Player1: " + _player1.Hand.Count + "<br /> Player2: " + _player2.Hand.Count;

			return winner;
		}
	}
}