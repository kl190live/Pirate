using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirate
{
	internal abstract class Pirate
	{
		private int pirete;
		private int rum;
		private int lives;
		private int died;
		private int live;
		private static Random RND = new Random();

		public Pirate(int pirete, int rum, int lives)
		{
			this.Pirete = pirete;
			this.Rum = rum;
			this.Lives = lives;
		}

		public int Pirete { get => pirete; set => pirete = value; }
		public int Rum { get => rum; set => rum = value; }
		public int Lives { get => lives; set => lives = value; }

		public virtual string drinkSumRum()
		{
			rum = 0;
			rum++;
			return $"intoxicated the pirate by one";
		}

		public virtual string howsItGoingMate() 
		{
			for (int i = 0; i < rum; i++)
			{
				if (rum < 4)
				{
					drinkSumRum();
					Console.WriteLine("Pour me anudder");
				}
				else
				{
					Console.WriteLine("Arghh I'ma Pirate. How d'ya d'ink its going?(The pirate passes out and slep it off)");
					rum = 0;
				}
			}
			return howsItGoingMate();
		}

		public virtual string die()
		{
			int lives=RND.Next(1,2);
			if (lives==1)
			{
				return "He is dead";
				died++;
			}
			else
			{
				return "He is alive";
				live++;
			}
		}

	}
}
