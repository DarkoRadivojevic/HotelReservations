namespace HotelReservations.Logic
{
	public class HotelLogic
	{
		//broj soba
		public int size;

		public int days;

		public int[,] bookings;

		public HotelLogic()
		{
			size = 2;

			days = 15;

			bookings = new int[size, days];

			for (int i = 0; i < size; i++)
				for (int j = 0; j < days; j++)
					bookings[i, j] = 0;
		}

		public HotelLogic(int size, int days)
		{
			this.size = size;

			this.days = days;

			bookings = new int[size, days];

			for (int i = 0; i < size; i++)
				for (int j = 0; j < days; j++)
					bookings[i, j] = 0;
		}

		public bool addReservation(int start, int end)
		{
			int room = testRoomAvailability(start, end);

			if (room < 0)
				return false;

			for (int i = start; i <= end; i++)
				bookings[room, i] = 1;

			return true;
		}

		public int testRoomAvailability(int start, int end)
		{
			if (start < 0 || end < 0 || start >= days || end >= days || start > end)
				return -1;

			bool flag = false;

			int i;

			for (i = 0; i < size; i++)
			{
				if (bookings[i, start] == 1)
					continue;

				flag = true;

				for (int j = start; j <= end; j++)
				{
					if (bookings[i, j] == 1)
					{
						flag = false;
						break;
					}
				}
				if (flag)
					break;
				else
					flag = false;
			}

			if (flag)
				return i;
			else
				return -1;
		}
	}
}