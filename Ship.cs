using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirate
{
	internal class Ship 
	{
		private string captian;
		private string crew;
		private List<Pirate> pirate;
		private static Random random = new Random();

		public Ship(string captian, string crew, List<Pirate> pirate)
		{
			this.Captian = captian;
			this.Crew = crew;
			this.Pirate = pirate;
		}

		public string Captian { get => captian; set => captian = value; }
		public string Crew { get => crew; set => crew = value; }
		internal List<Pirate> Pirate { get => pirate; set => pirate = value; }




		public string fillship()
		{
			int crew = 0;
			int captian = 0;
			int board=random.Next(114);
			for (int i = 0; i < board; i++)
			{
				if (captian == 0)
				{
					captian++;
				}
				else if (captian == 1) 
				{
					crew++;
				}
			}
			return $"On the ship There is a {captian} captian and he has {crew} crew member";
		}



	}
}
