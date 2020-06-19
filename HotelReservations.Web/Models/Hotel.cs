using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservations.Web.Models
{
	public class Hotel
	{
		public int Size { get; set; }

		public int Days { get; set; }

		public int[,] Bookings { get; set; }

		public Hotel(int size, int days)
		{
			Size = size;
			Days = days;

			Bookings = new int[size, days];

			for (int i = 0; i < Size; i++)
				for (int j = 0; j < Days; j++)
					Bookings[i, j] = 0;
		}
	}
}