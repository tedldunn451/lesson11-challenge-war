﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace lesson11_challenge_war
{
	public class Deck
	{
		private List<Card> _deck;
		private Random _random;
		private StringBuilder _sb;

		public Deck()
		{
			_deck = new List<Card>();
			_random = new Random();
			_sb = new StringBuilder();

			string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
			string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

			foreach (var suit in suits)
			{
				foreach (var rank in ranks)
				{
					Card card = new Card() { Rank = rank, Suit = suit };
					_deck.Add(card);
				}
			}
		}

		public string Deal(Player player1, Player player2)
		{
			while (_deck.Count > 0)
			{
				dealCard(player1);
				dealCard(player2);
			}

			return _sb.ToString();
		}

		private void dealCard(Player player)
		{
			Card card = _deck.ElementAt(_random.Next(0, _deck.Count));
			player.Hand.Add(card);
			_deck.Remove(card);

			_sb.Append("<br />");
			_sb.Append(player.Name);
			_sb.Append(" is dealt the ");
			_sb.Append(card.Rank);
			_sb.Append(" of ");
			_sb.Append(card.Suit);
		}
	}
}