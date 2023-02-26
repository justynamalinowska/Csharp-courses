using System;

namespace classes_movies
{
	public class movies
	{
		public string title;
		private string rate; //private for setters and getters!!!
		public static int movieCount = 0;

		//constructor
		public movies(string atitle, string arate)
		{
			title = atitle;
			Rate = arate;
			movieCount++;
		}

		private string Rate //Capital letter
		{
			set
			{
				if (value=="PG" || value=="G")
				{
					rate = value;
				}
				else
				{
					rate = "NR";
				}
			}
			get { return rate; }
		}
	}
}

