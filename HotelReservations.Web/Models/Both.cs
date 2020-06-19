using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservations.Web.Models
{
	public class Both
	{
		public Hotel Hotel { get; set; }

		public Reservation Reservation { get; set; }

		public Both(int size, int days)
		{
			Hotel = new Hotel(size, days)
			{
				Size = 5,
				Days = 15
			};
			Reservation = new Reservation();
		}
	}
}