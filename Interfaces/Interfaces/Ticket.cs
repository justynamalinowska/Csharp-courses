using System;
namespace Interfaces
{

	//we want compare objects "ticket"
	public class Ticket : IEquatable<Ticket>
	{
		public int DurationInHours { get; set; }

		public Ticket(int durationinhours)
		{
            DurationInHours = durationinhours;
		}

		public bool Equals(Ticket other)
		{
			return this.DurationInHours == other.DurationInHours;
		}
	}
}

